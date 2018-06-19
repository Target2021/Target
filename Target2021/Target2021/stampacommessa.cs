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
    public partial class stampacommessa : Form
    {
        public stampacommessa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int NrPezzi = 0, NrCommessa=0;          
            string cliente, articolo, stringa_connessione;
            stringa_connessione = Properties.Resources.StringaConnessione;
            SqlConnection conn = new SqlConnection(stringa_connessione);
            string queryCliente = "Select IDCliente From Commesse Where NrCommessa=" + NrCommessa;
            SqlCommand comando = new SqlCommand(queryCliente, conn);
            conn.Open();
            cliente = comando.ExecuteScalar().ToString();
            textBox2.Text = cliente;
            string queryArticolo = "Select CodArticolo From Commesse Where NrCommessa=" + NrCommessa;
            SqlCommand comandoArticolo = new SqlCommand(queryCliente, conn);
            articolo = comando.ExecuteScalar().ToString();
            textBox3.Text = articolo;
            conn.Close();

        }
    }
}
