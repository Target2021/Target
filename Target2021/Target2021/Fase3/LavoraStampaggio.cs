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

        public LavoraStampaggio(string id)
        {
            InitializeComponent();
            IDCommessa = id;
        }

        private void LavoraStampaggio_Load(object sender, EventArgs e)
        {
            this.stampiTableAdapter.Fill(this.target2021DataSet.Stampi);
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            commesseBindingSource.Filter = "IDCommessa = '" + IDCommessa + "'";
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
    }
}
