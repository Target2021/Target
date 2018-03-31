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
    public partial class CheckImpiegato : Form
    {
        string stringa_connessione = Properties.Resources.StringaConnessione;
        DataTable dataTable = new DataTable();

        public CheckImpiegato()
        {
            InitializeComponent();
        }

        private void commesseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commesseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void CheckImpiegato_Load(object sender, EventArgs e)
        {
            inserimento_iniziale();
            verifica_commesse();
        }

        
        private void commesseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void commesseDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }

        public void inserimento_iniziale()
        {
            string query = "Select CodCommessa,DataCommessa,IDCliente,DataConsegna,NRPezziDaLavorare,CodArticolo,DescrArticolo,IDMateriaPrima,IDFornitore FROM Commesse WHERE TipoCommessa=1 AND (Stato=0 OR Stato=1)";
            SqlConnection connessione = new SqlConnection(stringa_connessione);
            SqlCommand comando = new SqlCommand(query, connessione);
            connessione.Open();
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.SelectCommand = comando;
            SDA.Fill(dataTable);
            dataTable.Columns.Add("Disponibilità", typeof(Int32));
            BindingSource source = new BindingSource();
            source.DataSource = dataTable;
            dataGridView1.DataSource = source;
            SDA.Update(dataTable);
            connessione.Close();
        }

        public void verifica_commesse()
        {
            SqlConnection conn = new SqlConnection(stringa_connessione);
            BindingSource source = new BindingSource();
            DataGridViewRow riga;
            int PezziMagazzino = 0, PezziOrdinati = 0, nriga = 0, nrighe;
            nrighe=dataGridView1.RowCount;
            for (nriga=0;nriga<nrighe;nriga++)
            //foreach (DataGridViewRow riga in dataGridView1.Rows)
            {
                riga = dataGridView1.Rows[nriga];
                string query = "Select lavorazione From DettArticoli Where codice_articolo_bc='" + Convert.ToString(riga.Cells[7].Value) + "'";
                SqlCommand comando = new SqlCommand(query, conn);
                string query1 = "Select Giacenza From GiacenzeMagazzini Where idPrime='" + Convert.ToString(riga.Cells[7].Value) + "'";
                SqlCommand comando1 = new SqlCommand(query1, conn);
                conn.Open();
                int divisione_pezzo = Convert.ToInt32(comando.ExecuteScalar());
                int giacenza = Convert.ToInt32(comando1.ExecuteScalar());
                try
                {
                    PezziMagazzino = giacenza / divisione_pezzo;
                }
                catch (DivideByZeroException e)
                {
                    MessageBox.Show(e.Message);
                }
                dataTable.Rows[nriga]["Disponibilità"]=PezziMagazzino;
                PezziOrdinati = Convert.ToInt32(riga.Cells[4].Value);
                if (PezziMagazzino < PezziOrdinati)
                {
                    richTextBox1.Text = richTextBox1.Text + "PROPOSTA DI ORDINE A FORNITORE";
                    richTextBox1.Text = richTextBox1.Text + "\r" + "Ordinare materia prima codice: " + Convert.ToString(riga.Cells[7].Value);
                    richTextBox1.Text = richTextBox1.Text + "\r" + "Fornitore: " + riga.Cells[8].Value;
                    richTextBox1.Text = richTextBox1.Text + "\r" + "Quantità da ordinare: " + (PezziOrdinati - PezziMagazzino).ToString();
                    richTextBox1.Text = richTextBox1.Text + "\r";
                }
                conn.Close();
            }
            source.DataSource = dataTable;
            dataGridView1.DataSource = source;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //verifica_commesse();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inserimento_iniziale();
            verifica_commesse();
        }
    }
}
