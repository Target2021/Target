using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Target2021
{
    public partial class CheckPianificazione : Form
    {
        public CheckPianificazione()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CheckPianificazione_Load(object sender, EventArgs e)
        {
            carica();
        }

        private void carica()
        {
            String stringa = Properties.Resources.StringaConnessione;
            string idcommessa;
            DataTable dataTable = new DataTable();
            string query = "SELECT CodCommessa,DataCommessa,IDCliente,DataConsegna,NrPezziDaLavorare,DescrArticolo,IDMateriaPrima, NrLastreRichieste FROM Commesse WHERE TipoCommessa=2 AND (Stato=0 OR Stato=1) AND CodCommessa LIKE 'S%'";
            SqlConnection con = new SqlConnection(stringa);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(dataTable);
            BindingSource source = new BindingSource();
            source.DataSource = dataTable;
            dataGridView1.DataSource = source;
            sda.Update(dataTable);
            dataTable.Columns.Add("Scadenza", typeof(Image));
            con.Close();
        }

        private void SelezionaRiga(object sender, DataGridViewCellEventArgs e)
        {
            int riga;
            String CodCom;
            riga = e.RowIndex;
            CodCom = dataGridView1.Rows[riga].Cells[0].Value.ToString();
            Pianificazione pianificazione = new Pianificazione(CodCom);
            pianificazione.Show();
        }
    }
}
