using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Anagrafiche
{
    public partial class AnaOrdiniImportati : Form
    {
        public AnaOrdiniImportati()
        {
            InitializeComponent();
        }

        private void ordiniImportatiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordiniImportatiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void AnaOrdiniImportati_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            this.ordiniImportatiTableAdapter.Fill(this.target2021DataSet.OrdiniImportati);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Posizione, NumOrd;
            int DataOrd;
            DateTime DataCommessa;
            DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler eliminare l'importazione  degli ordini selezionati?", "Eliminazione importazione ordine", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in ordiniImportatiDataGridView.SelectedRows)
                {
                    Posizione = row.Index;
                    textBox1.AppendText("Riga: " + Posizione.ToString() + Environment.NewLine);
                    NumOrd = (int)ordiniImportatiDataGridView.Rows[Posizione].Cells[3].Value;
                    DataOrd = (int)ordiniImportatiDataGridView.Rows[Posizione].Cells[4].Value;
                    DataCommessa = DateTime.ParseExact(DataOrd.ToString(), "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None);
                    textBox1.AppendText("Ordine numero: " + row.Index.ToString() + Environment .NewLine);
                    int risultato;
                    string filtro = "NrCommessa = " + NumOrd + " AND DataCommessa = " + DataOrd;
                    try
                    {
                        risultato = (int)target2021DataSet.Commesse.Compute("MAX(Stato)", filtro);
                    }
                    catch
                    {
                        risultato = 0;
                    }
                    if (risultato>0)
                    {
                        MessageBox.Show("Impossibile eliminare l'importazione dell'ordine " + NumOrd.ToString() + "! Non tutte le righe sono in Stato 0!");
                    }
                    else
                    {
                        // Prima elimino le righe della tabella Commesse
                        DataRow[] Riga = target2021DataSet.Commesse.Select("NrCommessa = " + NumOrd.ToString() + " AND DataCommessa = '"+DataCommessa.ToShortDateString()+"'");
                        foreach (DataRow R in Riga)
                        {
                            R.Delete();
                        }
                        commesseTableAdapter.Update(target2021DataSet.Commesse);
                        // Poi elimino la riga dalla tabella OrdiniImportati
                        DataRow[] Riga2 = target2021DataSet.OrdiniImportati.Select("Numero = " + NumOrd.ToString() + "AND Data = " + DataOrd);
                        foreach (DataRow R in Riga2)
                        {
                            R.Delete();
                        }
                        ordiniImportatiTableAdapter.Update(target2021DataSet.OrdiniImportati);
                        // Poi ri-setto il flag in ACCESS
                        int data = DataOrd;
                        ImpostaPesoCliente(NumOrd, data, 0);
                        // Poi ri-setto il flag in tabella dettaglio_ordini_multirig in locale su SQL
                        ImpostaPesoLocale(NumOrd, DataOrd);
                        // DA FARE
                        MessageBox.Show("Importazione ordine "+NumOrd .ToString()+" eliminata con successo!");
                    }
                    
                }              
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void ImpostaPesoLocale(int NumOrd, int DataOrd)
        {
            string stringaconnessione, sql = "";
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "UPDATE dettaglio_ordini_multiriga SET peso = 0  WHERE numero_ordine=" + NumOrd + " AND data_ordine = " + DataOrd;
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            try
            {
                comando.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Errore in Aggiornamento campo 'Peso' in locale");
            }
            connessione.Close();
            //MessageBox.Show("Bingo!");
        }

        private void ImpostaPesoCliente(int n, int data, int stato)
        {
            string stringaconnessione, sql = "";
            stringaconnessione = Properties.Resources.ConnessioneAccess;
            OleDbConnection connessione = new OleDbConnection(stringaconnessione);
            sql = "UPDATE dettaglio_ordini_multiriga SET peso=" + stato + " WHERE numero_ordine=" + n + " AND data_ordine = " + data;
            OleDbCommand comando = new OleDbCommand(sql, connessione);
            connessione.Open();
            try
            {
                comando.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Errore in Access!");
            }
            connessione.Close();
            //MessageBox.Show("Bingo!");
        }

        private void ordiniImportatiDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                this.ordiniImportatiDataGridView.Sort(this.ordiniImportatiDataGridView.Columns["dataGridViewTextBoxColumn3"], ListSortDirection.Descending);
            }
            catch
            {
                this.ordiniImportatiDataGridView.Sort(this.ordiniImportatiDataGridView.Columns["dataGridViewTextBoxColumn3"], ListSortDirection.Descending);
            }
        }
    }
}
