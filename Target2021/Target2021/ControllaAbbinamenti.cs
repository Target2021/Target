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
    public partial class ControllaAbbinamenti : Form
    {
        public ControllaAbbinamenti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopolaOrdiniAperti();
        }

        private void PopolaOrdiniAperti()
        {
            SqlConnection Connessione = new SqlConnection(Properties.Resources.StringaConnessione);
            string query = "SELECT CodCommessa, DataCommessa, TipoCommessa, CodArticolo, NrLastreRichieste, Stato FROM Commesse WHERE Stato = 0 AND TipoCommessa=1";
            SqlCommand Commesse = new SqlCommand(query, Connessione);
            Connessione.Open();
            SqlDataReader risultato = Commesse.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(risultato);
            dataGridView1.DataSource = dt;
            Connessione.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string articolo;
            int abbinamento;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                articolo = row.Cells["CodArticolo"].Value.ToString();
                abbinamento = RecuperaAbbinamento(articolo);
                dataGridView2.Rows.Add(articolo, abbinamento.ToString());
            }
        }

        private int RecuperaAbbinamento(string CodArt)
        {
            DataRow[] RigaTrovata;
            int Abbinamento;
            RigaTrovata = target2021DataSet.Tables["DettArticoli"].Select("codice_articolo = '" + CodArt + "'");
            Abbinamento = Convert.ToInt32(RigaTrovata[0]["AbbinamentoStampo"]);
            return Abbinamento;
        }
    }
}
