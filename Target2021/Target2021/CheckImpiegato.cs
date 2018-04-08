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

        public void inserimento_iniziale()
        {
            string query = "Select CodCommessa,DataCommessa,IDCliente,DataConsegna,NRPezziDaLavorare,CodArticolo,IDMateriaPrima,IDFornitore FROM Commesse WHERE TipoCommessa=1 AND (Stato=0 OR Stato=1)";
            SqlConnection connessione = new SqlConnection(stringa_connessione);
            SqlCommand comando = new SqlCommand(query, connessione);
            connessione.Open();
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.SelectCommand = comando;
            SDA.Fill(dataTable);
            dataTable.Columns.Add("Disponibilità Lastre", typeof(Int32));
            dataTable.Columns.Add("Disponibilità Pezzi", typeof(Int32));
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
            int Pezzi = 0, PezziLiberi = 0, nriga = 0, nrighe;
            nrighe=dataGridView1.RowCount;
            for (nriga=0;nriga<nrighe;nriga++)
            {
                riga = dataGridView1.Rows[nriga];
                string query = "Select PercentualeLastra From DettArticoli Where codice_articolo='" + Convert.ToString(riga.Cells[5].Value) + "' AND lavorazione=1";
                SqlCommand comando = new SqlCommand(query, conn);
                string query1 = "Select GiacenzaDisponibili From GiacenzeMagazzini Where idPrime='" + Convert.ToString(riga.Cells[6].Value) + "'";
                SqlCommand comando1 = new SqlCommand(query1, conn);
                conn.Open();
                int percentuale = Convert.ToInt32(comando.ExecuteScalar());
                int giacenza = Convert.ToInt32(comando1.ExecuteScalar());
                try
                {
                    double n = 100 / percentuale;
                    int npezzi = (int) Math.Floor(n);
                    Pezzi = giacenza * npezzi;
                }
                catch (DivideByZeroException e)
                {
                    MessageBox.Show(e.Message);
                }
                dataTable.Rows[nriga]["Disponibilità Lastre"]=giacenza;
                dataTable.Rows[nriga]["Disponibilità Pezzi"] = Pezzi;
                PezziLiberi = Convert.ToInt32(riga.Cells[4].Value);
                if (Pezzi < PezziLiberi)
                {
                    richTextBox1.Text = richTextBox1.Text + "PROPOSTA DI ORDINE A FORNITORE";
                    richTextBox1.Text = richTextBox1.Text + "\r" + "Ordinare materia prima codice: " + Convert.ToString(riga.Cells[6].Value);
                    richTextBox1.Text = richTextBox1.Text + "\r" + "Fornitore: " + riga.Cells[7].Value;
                    richTextBox1.Text = richTextBox1.Text + "\r" + "Quantità da ordinare: " + (Pezzi - PezziLiberi).ToString();
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
            dataTable.Columns.Remove("Disponibilità Lastre");
            dataTable.Columns.Remove("Disponibilità Pezzi");
            dataTable.Clear();
            richTextBox1.Text = "";
            inserimento_iniziale();
            verifica_commesse();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
