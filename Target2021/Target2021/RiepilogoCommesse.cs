using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021
{
    public partial class RiepilogoCommesse : Form
    {
        string stringa_connessione = Properties.Resources.StringaConnessione;
        public RiepilogoCommesse()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RiepilogoCommesse_Load(object sender, EventArgs e)
        {
            Calcolo();
        }

        private void Calcolo()
        {
            string query_of1,query_of2,query_of3,query_s1,query_s2,query_s3,query_t1,query_t2,query_t3;
            query_of1 = "Select Count(IDcommessa) From Commesse WHERE TipoCommessa = 1 AND Stato=0";
            query_of2 = "Select Count(IDcommessa) From Commesse WHERE TipoCommessa = 1 AND Stato=1";
            query_of3 = "Select Count(IDcommessa) From Commesse WHERE TipoCommessa = 1 AND Stato=2";
            query_s1 = "Select Count(IDcommessa) From Commesse WHERE TipoCommessa = 2 AND Stato=0";
            query_s2 = "Select Count(IDcommessa) From Commesse WHERE TipoCommessa = 2 AND Stato=1";
            query_s3 = "Select Count(IDcommessa) From Commesse WHERE TipoCommessa = 2 AND Stato=2";
            query_t1 = "Select Count(IDcommessa) From Commesse WHERE TipoCommessa = 3 AND Stato=0";
            query_t2 = "Select Count(IDcommessa) From Commesse WHERE TipoCommessa = 3 AND Stato=1";
            query_t3 = "Select Count(IDcommessa) From Commesse WHERE TipoCommessa = 3 AND Stato=2";
            SqlConnection connessione = new SqlConnection(stringa_connessione);
            SqlCommand comando = new SqlCommand(query_of1, connessione);
            SqlCommand comando1 = new SqlCommand(query_of2, connessione);
            SqlCommand comando2 = new SqlCommand(query_of3, connessione);
            SqlCommand comando3 = new SqlCommand(query_s1, connessione);
            SqlCommand comando4 = new SqlCommand(query_s2, connessione);
            SqlCommand comando5 = new SqlCommand(query_s3, connessione);
            SqlCommand comando6 = new SqlCommand(query_t1, connessione);
            SqlCommand comando7 = new SqlCommand(query_t2, connessione);
            SqlCommand comando8 = new SqlCommand(query_t3, connessione);
            connessione.Open();
            button1.Text = Convert.ToString(comando.ExecuteScalar());
            button2.Text = Convert.ToString(comando1.ExecuteScalar());
            button3.Text = Convert.ToString(comando2.ExecuteScalar());
            button4.Text = Convert.ToString(comando3.ExecuteScalar());
            button5.Text = Convert.ToString(comando4.ExecuteScalar());
            button6.Text = Convert.ToString(comando5.ExecuteScalar());
            button7.Text = Convert.ToString(comando6.ExecuteScalar());
            button8.Text = Convert.ToString(comando7.ExecuteScalar());
            button9.Text = Convert.ToString(comando8.ExecuteScalar());
            connessione.Close();


        }
    }
}
