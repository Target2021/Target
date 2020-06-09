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

namespace Target2021.Fase4
{
    public partial class NewCheckTaglio : Form
    {
        public NewCheckTaglio()
        {
            InitializeComponent();
        }

        private void commesseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commesseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void NewCheckTaglio_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            commesseBindingSource.Filter = "TipoCommessa = 3 AND (Stato = 0 OR Stato = 1)";
            commesseDataGridView.Sort(dataGridViewTextBoxColumn50, ListSortDirection.Descending);
            CompilaColonnaPezziStampati();
        }

        private void commesseDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void CompilaColonnaPezziStampati()
        {
            int NrCommessa, PezziStampati;
            DateTime DataCommessa;

            foreach (DataGridViewRow row in commesseDataGridView.Rows)
            {
                NrCommessa = (int)row.Cells["NrCommessa"].Value;
                DataCommessa = (DateTime)row.Cells["DataCommessa"].Value;
                //MessageBox.Show("Commessa numero " + NrCommessa.ToString() + " del " + DataCommessa.ToShortDateString());

                PezziStampati = RecuperaPezziStampati(NrCommessa, DataCommessa);

                row.Cells["PezziGiaStampati"].Value = PezziStampati;
            }
            commesseDataGridView.EndEdit();
            commesseDataGridView.Update();
            commesseDataGridView.Refresh();
        }

        private int RecuperaPezziStampati(int NrCommessa, DateTime DataCommessa)
        {
            int NrPezziStampati = 0;
            string stringaconnessione, sql;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT NrPezziCorretti FROM Commesse WHERE NrCommessa = " + NrCommessa + " AND TipoCommessa=2 AND DataCommessa='"+DataCommessa.ToShortDateString()+"'";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            try
            {
                NrPezziStampati = Convert.ToInt32(comando.ExecuteScalar());
            }
            catch
            {
                return 0;
            }
            connessione.Close();
            return NrPezziStampati;
        }
    }
}
