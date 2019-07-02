using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Anagrafiche
{
    public partial class AnaOrdiniEsclusi : Form
    {
        public AnaOrdiniEsclusi()
        {
            InitializeComponent();
        }


        private void AnaOrdiniEsclusi_Load(object sender, EventArgs e)
        {
            string anno="";
            comboBox1.Text = DateTime.Now.Year.ToString();
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.dettaglio_ordini_multiriga'. È possibile spostarla o rimuoverla se necessario.
            this.dettaglio_ordini_multirigaTableAdapter.Fill(this.target2021DataSet.dettaglio_ordini_multiriga);
            anno = comboBox1.Text+"0000";
            dettaglio_ordini_multirigaBindingSource.Filter = "peso = 2 AND data_ordine > '" + anno + "'";
            try
            {
                dettaglio_ordini_multirigaDataGridView.Sort(dettaglio_ordini_multirigaDataGridView.Columns["dataGridViewTextBoxColumn2"], ListSortDirection.Descending);
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dettaglio_ordini_multirigaDataGridView.SelectedRows)
            {
                int Posizione = row.Index;
                int NumOrd = Convert.ToInt32(dettaglio_ordini_multirigaDataGridView.Rows[Posizione].Cells[1].Value);
                int DataOrd = Convert.ToInt32(dettaglio_ordini_multirigaDataGridView.Rows[Posizione].Cells[0].Value);
                ImpostaPesoCliente(NumOrd, DataOrd, 0);  // usa il campo peso per settare stato ordine (0=da importare, 1=importato, 2=scontato)
                AggiornaStatoTemporaneo(NumOrd, DataOrd, 0);  // Aggiorno anche la tabella locale
                MessageBox.Show("Ri-incluso l'ordine " + NumOrd + " del " + DataOrd);
            }
        }

        private void AggiornaStatoTemporaneo(int n, int data, int stato)
        {
            string stringaconnessione, sql;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "UPDATE dettaglio_ordini_multiriga SET peso = " + stato + " WHERE data_ordine = " + data + " AND numero_ordine=" + n;
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            try
            {
                comando.ExecuteNonQuery();
            }
            catch
            {
            }
            connessione.Close();
        }

        private void ImpostaPesoCliente(int n, int data, int stato)
        {
            string stringaconnessione, sql = "", note;
            stringaconnessione = Properties.Resources.ConnessioneAccess;
            OleDbConnection connessione = new OleDbConnection(stringaconnessione);
            sql = "UPDATE dettaglio_ordini_multiriga SET peso=" + stato + " WHERE numero_ordine=" + n + " AND data_ordine = " + data;
            OleDbCommand comando = new OleDbCommand(sql, connessione);
            connessione.Open();
            try
            {
                note = comando.ExecuteScalar().ToString();
            }
            catch
            {
                note = null;
            }
            connessione.Close();
            //MessageBox.Show("Bingo!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string anno = comboBox1.Text+"0000";
            dettaglio_ordini_multirigaBindingSource.Filter = "peso = 2 AND data_ordine > " + anno + "";
        }
    }
}
