using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021
{
    public partial class LavoraTaglio_cs : Form
    {
        public string IDCommessa;
        public LavoraTaglio_cs(string ID)
        {
            InitializeComponent();
            IDCommessa = ID;
        }

        private void LavoraTaglio_cs_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Dime'. È possibile spostarla o rimuoverla se necessario.
            this.dimeTableAdapter.Fill(this.target2021DataSet.Dime);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.MacchineTaglio'. È possibile spostarla o rimuoverla se necessario.
            this.macchineTaglioTableAdapter.Fill(this.target2021DataSet.MacchineTaglio);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.clienti'. È possibile spostarla o rimuoverla se necessario.
            this.clientiTableAdapter.Fill(this.target2021DataSet.clienti);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            commesseBindingSource.Filter = "CodCommessa = '" + IDCommessa+"'";
        }

        private void commesseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commesseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Scanna scanner = new Scanna();
            scanner.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calcolapezzi();
        }

        private void nrPezziScartatiTextBox_TextChanged(object sender, EventArgs e)
        {
            calcolapezzi();
        }

        private void calcolapezzi()
        {
            int pztagliati, pzscartati, pzcorretti;
            if (textBox1.Text == "") textBox1.Text = "0";
            if (nrPezziScartatiTextBox.Text == "") nrPezziScartatiTextBox.Text = "0";
            pztagliati = Convert.ToInt32(textBox1.Text);
            pzscartati = Convert.ToInt32(nrPezziScartatiTextBox.Text);
            pzcorretti = pztagliati - pzscartati;
            nrPezziCorrettiTextBox.Text = pzcorretti.ToString();
        }

        private void iDClienteTextBox_TextChanged(object sender, EventArgs e)
        {
            DataRow[] riga;
            string NomeCliente, filtro;
            try
            {
                filtro = "codice='" + iDClienteTextBox.Text.Replace(" ", string.Empty) + "'";
                riga = target2021DataSet.Tables["clienti"].Select(filtro);
                NomeCliente = riga[0]["ragione_sociale"].ToString();
            }
            catch { NomeCliente = "Non trovato!"; }
            label2.Text = NomeCliente;
        }

        private void iDMachTaglioTextBox_TextChanged(object sender, EventArgs e)
        {
            int IdMachT = 0;
            string DescrMachT;
            try
            {
                IdMachT = Convert.ToInt32(iDMachTaglioTextBox.Text);
            }
            catch
            {

            }
            DataRow[] riga;
            try
            {
                riga = target2021DataSet.Tables["MacchineTaglio"].Select("IDTaglio=" + IdMachT.ToString());
                DescrMachT = riga[0]["Descrizione"].ToString();
            }
            catch { DescrMachT = "Non trovata!"; }
            label5.Text = DescrMachT;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Salva();
        }

        private void Salva()
        {
            this.Validate();
            this.commesseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }

        private void codCommessaTextBox_TextChanged(object sender, EventArgs e)
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

        private void iDDimaTextBox_TextChanged(object sender, EventArgs e)
        {
            string CodDima = iDDimaTextBox.Text;
            string DescDima = RecuperaDescDima(CodDima);
            label4.Text = DescDima;
            try
            {
                AggiornaPosizione(CodDima);
            }
            catch
            { }
        }

        private void AggiornaPosizione(string dima)
        {
            string stringaconnessione, sql, corsia, campata;
            int posizione;
            SqlCommand comando;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            connessione.Open();
            sql = "SELECT Corsia FROM Dime WHERE codice ='" + dima + "'";
            comando = new SqlCommand(sql, connessione);
            corsia = comando.ExecuteScalar().ToString();
            sql = "SELECT Campata FROM Dime WHERE codice ='" + dima + "'";
            comando = new SqlCommand(sql, connessione);
            campata = comando.ExecuteScalar().ToString();
            sql = "SELECT Posizione FROM Dime WHERE codice ='" + dima + "'";
            comando = new SqlCommand(sql, connessione);
            posizione = Convert.ToInt32(comando.ExecuteScalar());
            connessione.Close();
            textBox2.Text = corsia;
            textBox3.Text = campata;
            textBox4.Text = posizione.ToString();
        }

        private string RecuperaDescDima(string Cod)
        {
            DataRow[] riga;
            string Desc;
            try
            {
                riga = target2021DataSet.Tables["Dime"].Select("codice='" + Cod+"'");
                Desc = riga[0]["descrizione"].ToString();
            }
            catch { Desc = "Non trovata!"; }
            return Desc;
        }

        private void nrPezziCorrettiTextBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void nrPezziCorrettiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nrPezziScartatiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void minutiAttrezzaggioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
