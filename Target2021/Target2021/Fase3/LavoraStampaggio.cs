using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021
{
    public partial class LavoraStampaggio : Form
    {
        public String stringa = Properties.Resources.StringaConnessione;
        public string IDCommessa;
        public int macchina;

        public LavoraStampaggio(string id, int mac)
        {
            InitializeComponent();
            IDCommessa = id;
            macchina = mac;
        }

        private void LavoraStampaggio_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.MacchineStampo'. È possibile spostarla o rimuoverla se necessario.
            this.macchineStampoTableAdapter.Fill(this.target2021DataSet.MacchineStampo);
            this.stampiTableAdapter.Fill(this.target2021DataSet.Stampi);
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            commesseBindingSource.Filter = "IDCommessa = '" + IDCommessa + "'";
            ControllaDate();
            schedMachTextBox.Text = macchina.ToString();
        }

        private void ControllaDate()
        {
            int risultato;
            string filtro = "IDCommessa = '" + IDCommessa + "'";
            try
            {
                risultato = (int)target2021DataSet.Commesse.Select(filtro)[0]["AttG1"];
            }
            catch
            {
                Disabilita(1);
            }
            try
            {
                risultato = (int)target2021DataSet.Commesse.Select(filtro)[0]["AttG2"];
            }
            catch
            {
               Disabilita(2);
            }
        }

        private void Disabilita(int gruppo)
        {
            if (gruppo==2)
            {
                button4.Text = "APRI";
                attG2TextBox.Enabled = false;
                oISG2DateTimePicker.Enabled = false;
                oFSG2DateTimePicker.Enabled = false;
                dateTimePicker3.Enabled = false;
                dateTimePicker4.Enabled = false;
            }
        }

        private void iDStampoTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AggiornaPosizione(iDStampoTextBox.Text);
            }
            catch
            {

            }
        }

        private void AggiornaPosizione(string stampo)
        {
            string stringaconnessione, sql, corsia, campata;
            int posizione;
            SqlCommand comando;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            connessione.Open();
            sql = "SELECT Corsia FROM Stampi WHERE codice ='" + stampo + "'";
            comando = new SqlCommand(sql, connessione);
            corsia = comando.ExecuteScalar().ToString();
            sql = "SELECT Campata FROM Stampi WHERE codice ='" + stampo + "'";
            comando = new SqlCommand(sql, connessione);
            campata = comando.ExecuteScalar().ToString();
            sql = "SELECT Posizione FROM Stampi WHERE codice ='" + stampo + "'";
            comando = new SqlCommand(sql, connessione);
            posizione = Convert.ToInt32(comando.ExecuteScalar());
            connessione.Close();
            textBox1.Text = corsia;
            textBox2.Text = campata;
            textBox3.Text = posizione.ToString ();
        }

        private void iDCommessaTextBox_TextChanged(object sender, EventArgs e)
        {
            string immagine = fotoTextBox.Text;
            try
            {
                pictureBox1.Image = new Bitmap(immagine);
            }
            catch
            {
                pictureBox1.Image = Properties.Resources.question_mark;
            }
        }

        private void attG1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void attG2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Salva();
        }

        private void Salva()
        {
            this.Validate();
            this.commesseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Salva();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "APRI")
            {
                Abilita(2);
                button4.Text = "SALVA";
                oISG2DateTimePicker.Value = DateTime.Now;
            }
            else
                Salva();
        }

        private void Abilita(int gruppo)
        {
            if (gruppo==2)
            {
                attG2TextBox.Enabled = true;
                oISG2DateTimePicker.Enabled = true;
                oFSG2DateTimePicker.Enabled = true;
                dateTimePicker3.Enabled = true;
                dateTimePicker4.Enabled = true;
            }

        }

        private void schedMachTextBox_TextChanged(object sender, EventArgs e)
        {
            DataRow[] riga;
            string NomeMacchina;   
            try
            {
                riga = target2021DataSet.Tables["MacchineStampo"].Select("IdStampa=" + schedMachTextBox.Text);
                NomeMacchina = riga[0]["Descrizione"].ToString();
            }
            catch { NomeMacchina = "Non trovata!"; }
            label4.Text = NomeMacchina;
        }
    }
}
