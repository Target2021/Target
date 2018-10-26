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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Target2021.Fase1;
using Target2021.Fornitori;

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
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.GiacenzeMagazzini'. È possibile spostarla o rimuoverla se necessario.
            this.giacenzeMagazziniTableAdapter.Fill(this.target2021DataSet.GiacenzeMagazzini);
            inserimento_iniziale();
            verifica_commesse();
            SoloInOrdine();
        }

        public void inserimento_iniziale()
        {
            string query = "Select IDMateriaPrima,SUM(NrLastreRichieste) as LastreRichieste FROM Commesse WHERE TipoCommessa=1 AND Stato=0 GROUP BY IDMateriaPrima";
            SqlConnection connessione = new SqlConnection(stringa_connessione);
            SqlCommand comando = new SqlCommand(query, connessione);
            connessione.Open();
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.SelectCommand = comando;
            SDA.Fill(dataTable);
            dataTable.Columns.Add("Disponibilità Lastre", typeof(Int32));
            dataTable.Columns.Add("Descrizione materia prima", typeof(String));
            dataTable.Columns.Add("Codice fornitore", typeof(String));
            dataTable.Columns.Add("Descrizione fornitore", typeof(String));
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
            int Pezzi = 0, PezziOrdinati = 0, nriga = 0, nrighe;
            nrighe=dataGridView1.RowCount;
            for (nriga=0;nriga<nrighe;nriga++)
            {
                riga = dataGridView1.Rows[nriga];
                string query1 = "Select GiacenzaDisponibili From GiacenzeMagazzini Where idPrime='" + Convert.ToString(riga.Cells[0].Value) + "'";
                string query2 = "Select descrizione From Prime Where codice='" + Convert.ToString(riga.Cells[0].Value) + "'";
                string query3 = "Select codice_fornitore From Prime Where codice='" + Convert.ToString(riga.Cells[0].Value) + "'";                
                SqlCommand comando1 = new SqlCommand(query1, conn);
                SqlCommand comando2 = new SqlCommand(query2, conn);
                SqlCommand comando3 = new SqlCommand(query3, conn);
                conn.Open();
                int giacenza = Convert.ToInt32(comando1.ExecuteScalar());
                string descrizione = comando2.ExecuteScalar().ToString();
                string cod_for= comando3.ExecuteScalar().ToString();
                string query4 = "Select ragione_sociale From Fornitori Where codice='" + cod_for + "'";
                SqlCommand comando4 = new SqlCommand(query4, conn);
                string des_for = comando4.ExecuteScalar().ToString();
                dataTable.Rows[nriga]["Disponibilità Lastre"]=giacenza;
                dataTable.Rows[nriga]["Descrizione materia prima"] = descrizione;
                dataTable.Rows[nriga]["Codice fornitore"] = cod_for;
                dataTable.Rows[nriga]["Descrizione fornitore"] = des_for;
                PezziOrdinati = Convert.ToInt32(riga.Cells[1].Value);
                if (giacenza < PezziOrdinati)
                {
                    richTextBox1.Text = richTextBox1.Text + "PROPOSTA DI ORDINE A FORNITORE";
                    richTextBox1.Text = richTextBox1.Text + "\r" + "Ordinare materia prima codice: " + Convert.ToString(riga.Cells[0].Value)+" - "+ Convert.ToString(riga.Cells[3].Value);
                    richTextBox1.Text = richTextBox1.Text + "\r" + "Fornitore: " + Convert.ToString(riga.Cells[4].Value) + " - " + Convert.ToString(riga.Cells[5].Value);
                    richTextBox1.Text = richTextBox1.Text + "\r" + "Quantità da ordinare: " + (PezziOrdinati-giacenza).ToString();
                    richTextBox1.Text = richTextBox1.Text + "\r\r";
                }
                conn.Close();
            }
            source.DataSource = dataTable;
            dataGridView1.DataSource = source;
        }

        public void SoloInOrdine()
        {

            //giacenzeMagazziniBindingSource.Filter = "idPrime = '" + textBox1.Text + "'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataTable.Columns.Remove("Disponibilità Lastre");
            dataTable.Columns.Remove("Descrizione materia prima");
            dataTable.Columns.Remove("Codice fornitore");
            dataTable.Columns.Remove("Descrizione fornitore");
            dataTable.Clear();
            richTextBox1.Text = "";
            inserimento_iniziale();
            verifica_commesse();
        }

        private void Selezi(object sender, DataGridViewCellEventArgs e)
        {
            string CodiceLastra="",DescrizioneLastra="";

            if (e.RowIndex > -1 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                CodiceLastra = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                DescrizioneLastra = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            ImpegnaMatPrima Impegna = new ImpegnaMatPrima(CodiceLastra,DescrizioneLastra);
            Impegna.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            NuovoOrdineForn NOF = new NuovoOrdineForn();
            NOF.Show();
        }
    }
}
