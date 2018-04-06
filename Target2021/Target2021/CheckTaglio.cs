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
    public partial class CheckTaglio : Form
    {
        
        public CheckTaglio()
        {
            InitializeComponent();
        }

        private void CheckTaglio_Load(object sender, EventArgs e)
        {
            String stringa = Properties.Resources.StringaConnessione;
            string query = "Select CodCommessa,DataCommessa,IDCliente,DescrArticolo,IDMachTaglio, IDDima,CodArtiDopoTaglio, SecondiCicloTaglio,Stato from Commesse where TipoCommessa=3 AND Stato IN (3,2,1)";
            SqlConnection con = new SqlConnection(stringa);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            BindingSource source = new BindingSource();
            source.DataSource = dataTable;
            dataGridView1.DataSource = source;
            sda.Update(dataTable);
            con.Close();
        }
        private void colore()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int stato = Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value);
                if (stato == 1)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                if (stato == 2)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                if (stato == 3)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            colore();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String stringa = Properties.Resources.StringaConnessione;
            string query = "Select CodCommessa,DataCommessa,IDCliente,DescrArticolo,IDMachTaglio, IDDima,CodArtiDopoTaglio, SecondiCicloTaglio,Stato from Commesse where TipoCommessa IN (3,2) AND Stato IN (3,2,1) ";
            SqlConnection con = new SqlConnection(stringa);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            BindingSource source = new BindingSource();
            source.DataSource = dataTable;
            dataGridView1.DataSource = source;
            sda.Update(dataTable);
            con.Close();
        }
    }
}
