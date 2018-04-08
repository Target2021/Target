using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Target2021.Anagrafiche
{
    public partial class CheckAssemblaggio : Form
    {
        string stringa_connessione = Properties.Resources.StringaConnessione;
        DataTable dataTable = new DataTable();
        DataTable datatable1 = new DataTable();
        string query = "Select CodCommessa,DataCommessa,IDCliente,DataConsegna,NRPezziDaLavorare,CodArticolo,IDMateriaPrima,IDFornitore FROM Commesse WHERE TipoCommessa=4 AND (Stato=0 OR Stato=1)";
        string query1 = "Select CodCommessa,DataCommessa,IDCliente,DataConsegna,NRPezziDaLavorare,CodArticolo,IDMateriaPrima,IDFornitore FROM Commesse WHERE TipoCommessa=4 AND Stato=2";
        public CheckAssemblaggio()
        {
            InitializeComponent();
        }

        private void CheckAssemblaggio_Load(object sender, EventArgs e)
        {

            inizializzazione_tabella();
            popolazione_datagridview();

        }


        public void inizializzazione_tabella()
        {
          
            SqlConnection connessione = new SqlConnection(stringa_connessione);
            SqlCommand comando = new SqlCommand(query, connessione);
            SqlCommand comando1 = new SqlCommand(query1, connessione);
            connessione.Open();
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.SelectCommand = comando;
            SqlDataAdapter SDA1 = new SqlDataAdapter();
            SDA1.SelectCommand = comando1;
            SDA.Fill(dataTable);
            dataTable.Columns.Add("Stato", typeof(Image));
            SDA1.Fill(datatable1);
            BindingSource source = new BindingSource();
            source.DataSource = dataTable;
            dataGridView1.DataSource = source;
            BindingSource source1 = new BindingSource();
            source1.DataSource = datatable1;
            dataGridView2.DataSource = source1;
            SDA.Update(dataTable);
            SDA1.Update(datatable1);
            connessione.Close();
        }

        public void popolazione_datagridview()
        {
            DataGridViewRow riga;
            int  nriga = 0, nrighe;
            nrighe = dataGridView1.RowCount;
            for (nriga = 0; nriga < nrighe; nriga++)
            {
                riga = dataGridView1.Rows[nriga];
                DateTime dataconsegna = Convert.ToDateTime(riga.Cells[3].Value);
                DateTime adesso = DateTime.Now;
                int totalDays = Convert.ToInt32((adesso.Date - dataconsegna.Date).TotalDays);
                if (totalDays >= 1)
                {
                    dataTable.Rows[nriga]["Stato"] = Properties.Resources.arrabiato;
                }
                if (totalDays == 0)
                {
                    dataTable.Rows[nriga]["Stato"] = Properties.Resources.preoccupato;
                }
                if (totalDays <= -1)
                {
                    dataTable.Rows[nriga]["Stato"] = Properties.Resources.felice;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataTable.Columns.Remove("Stato");
            dataTable.Clear();
            datatable1.Clear();
            inizializzazione_tabella();
            popolazione_datagridview();
        }
    }
}
