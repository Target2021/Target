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
    public partial class NewOrderCheck : Form
    {
        private int NumOrd, NumTest;

        public NewOrderCheck()
        {
            InitializeComponent();
        }

        private void NewOrderCheck_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int NumDet, neworder=0;
            NumOrd = RecuperaUltimoOrdine();
            textBox1.Text = NumOrd.ToString();
            NumTest = RecuperaUltimoTestata();
            textBox2.Text = NumTest.ToString();
            NumDet = RecuperaUltimoDettaglio();
            textBox3.Text = NumDet.ToString();
            neworder = NumTest - NumOrd;
            label4.Visible = true;
            if (neworder == 0) label4.Text = "Non ci sono nuovi ordini!";
            else
            {
                label4.Text = "Ci sono " + neworder.ToString() + " nuovi ordini!";
                button2.Enabled = true;
            }
                
        }

        private int RecuperaUltimoOrdine()
        {
            string stringaconnessione, sql;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "select NrUltimoOrdineLetto from Configurazione";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            int NrUltOrd = Convert.ToInt32(comando.ExecuteScalar());
            connessione.Close();
            return NrUltOrd;
        }

        private int RecuperaUltimoTestata()
        {
            string stringaconnessione, sql;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT MAX(numero_ordine) FROM testata_ordini_multiriga WHERE data_ordine>20180000";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            int NrUltOrd = Convert.ToInt32(comando.ExecuteScalar());
            connessione.Close();
            return NrUltOrd;
        }

        private int RecuperaUltimoDettaglio()
        {
            string stringaconnessione, sql;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT MAX(numero_ordine) FROM dettaglio_ordini_multiriga WHERE data_ordine>20180000";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            int NrUltOrd = Convert.ToInt32(comando.ExecuteScalar());
            connessione.Close();
            return NrUltOrd;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i, IDOrdine, UltimoID, NumFasi;
            string CodiceArticolo;
            SqlDataReader fasi;
            BindingSource SorgenteDati = new BindingSource();

            do { 
                IDOrdine = RecuperaUltimoOrdine();
                UltimoID = RecuperaUltimoTestata();
                CodiceArticolo = CodiceArt(IDOrdine);
            } while (IDOrdine + 1 < IDOrdine+1);  //UltimoID
            textBox4.Text = textBox4.Text + "Articolo: " + CodiceArticolo+ "\r\n";
            NumFasi = NumeroFasi(CodiceArticolo);
            textBox4.Text = textBox4.Text + "Questo articolo ha: " + NumFasi.ToString() + " fasi di lavorazione. \r\n";
            fasi = ControllaFasi(CodiceArticolo);
            SorgenteDati.DataSource = fasi;
            dataGridView1.DataSource = SorgenteDati;
        }

        private string CodiceArt(int numord)
        {
            string stringaconnessione, sql, CodArticolo;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT codice_articolo FROM dettaglio_ordini_multiriga WHERE numero_ordine="+numord.ToString()+" AND data_ordine>20180000";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            CodArticolo = comando.ExecuteScalar().ToString();
            connessione.Close();
            return CodArticolo;
        }

        private int NumeroFasi(string codart)
        {
            string stringaconnessione, sql;
            int NumFasi;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT COUNT(codice_articolo) FROM DettArticoli WHERE codice_articolo ='" + codart.ToString()+"'";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            NumFasi = Convert.ToInt32(comando.ExecuteScalar());
            connessione.Close();
            return NumFasi;
        }

        private SqlDataReader ControllaFasi(string codart)
        {
            SqlDataReader fasilav;

            string stringaconnessione, sql;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT * FROM DettArticoli WHERE codice_articolo ='" + codart.ToString() + "'";
            SqlCommand comando = new SqlCommand(sql, connessione);
            try
            {
                connessione.Open();
                fasilav = comando.ExecuteReader(CommandBehavior.CloseConnection);
                return fasilav;
            }
            catch (Exception ex)
            {
                connessione.Dispose();
                return null;
            }
        }

    }
}
