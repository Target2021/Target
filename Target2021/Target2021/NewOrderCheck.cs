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
        public NewOrderCheck()
        {
            InitializeComponent();
        }

        private void NewOrderCheck_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int NumOrd, NumTest, NumDet;
            NumOrd = RecuperaUltimoOrdine();
            textBox1.Text = NumOrd.ToString();
            NumTest = RecuperaUltimoTestata();
            textBox2.Text = NumTest.ToString();
            NumDet = RecuperaUltimoDettaglio();
            textBox3.Text = NumDet.ToString();

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
            sql = "SELECT MAX(numero_ordine) FROM testata_ordini_multiriga WHERE data_ordine>20180000";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            int NrUltOrd = Convert.ToInt32(comando.ExecuteScalar());
            connessione.Close();
            return NrUltOrd;
        }
    }
}
