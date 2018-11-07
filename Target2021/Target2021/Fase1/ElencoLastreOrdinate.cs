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

namespace Target2021.Fase1
{
    public partial class ElencoLastreOrdinate : Form
    {
        private string Cod;
        private int IdCommessa, NumCommessa;
        public int NrLastreImpegnate { get; set; }

        public ElencoLastreOrdinate(string Codice, int IdC, int NumC)
        {
            InitializeComponent();
            Cod = Codice;
            IdCommessa = IdC;
            NumCommessa = NumC;
        }

        private void ElencoLastreOrdinate_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.OrdFornDett'. È possibile spostarla o rimuoverla se necessario.
            this.ordFornDettTableAdapter.Fill(this.target2021DataSet.OrdFornDett);
            textBox1.Text = Cod;
            textBox3.Text = IdCommessa.ToString();
            textBox4.Text = NumCommessa.ToString();
            Filtra();
            AggiornaQuantitaAssegnata();
        }

        private void ordFornDettBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordFornDettBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }

        private void Filtra()
        {
            ordFornDettBindingSource.Filter = "idCodiceArt = '" + Cod + "' AND Stato<>3"; // prima anche AND(QtaImpegnata < QuantitaRich)
        }

        private void AggiornaQuantitaAssegnata()
        {
            int IdOrdineAFornitoreDettaglio, IdCommessa, QtaImpegnata;
            string CodArt;

            foreach (DataGridViewRow row in ordFornDettDataGridView.Rows)
            {
                IdOrdineAFornitoreDettaglio = Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn12"].Value);
                IdCommessa = Convert.ToInt32(textBox3.Text);

                SqlConnection conn = new SqlConnection(Properties.Resources.StringaConnessione);
                string query1 = "Select QtaImpegnata From ImpegnateOrdinato Where IdOrdFornDett='" + Convert.ToString(IdOrdineAFornitoreDettaglio) + "' AND IdCommessa = '" + IdCommessa .ToString()+"'";
                SqlCommand comando1 = new SqlCommand(query1, conn);
                conn.Open();
                try
                {
                    var risultato = comando1.ExecuteScalar();
                    if (risultato==null)
                    {
                        CodArt = textBox1.Text;
                        query1 = "INSERT INTO ImpegnateOrdinato (IdOrdFornDett, CodArt, QtaImpegnata, IdCommessa) VALUES (" + IdOrdineAFornitoreDettaglio.ToString() + ",'" + CodArt + "',0," + IdCommessa.ToString() + ")";
                        comando1 = new SqlCommand(query1, conn);
                        comando1.ExecuteNonQuery();
                    }
                    QtaImpegnata = Convert.ToInt32(risultato);
                    row.Cells["QuantitaAssegnata"].Value = QtaImpegnata.ToString();
                }
                catch
                {
                }
                conn.Close();
            }
            ordFornDettDataGridView.Refresh();
        }

        private void Cambio(object sender, DataGridViewCellEventArgs e)
        {
            int totale = 0;
            int assegnate, ordinata, impegnata, disponibile;

            foreach (DataGridViewRow row in ordFornDettDataGridView.Rows)
            {
                assegnate= Convert.ToInt32(row.Cells["QuantitaAssegnata"].Value);
                ordinata = Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn4"].Value);
                impegnata = Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn13"].Value);
                disponibile = ordinata - impegnata;
                if (assegnate > ordinata)           // prima > disponibile
                {
                    MessageBox.Show("Non è disponibile questa quantità");
                    row.Cells["QuantitaAssegnata"].Value = 0;
                    assegnate = 0;
                }
                totale += assegnate;
            }

            textBox2.Text = totale.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AggiornaImpegnateSuOrdinato();
            AggiornaOrdiniFornitori();
            AggiornaGiacenze();
            MessageBox.Show("Aggiornamento effettuato correttamente!");
            this.Close();
        }

        private void AggiornaImpegnateSuOrdinato()
        {   // Aggiorna tabella ImpegnateOrdinato
            int IdOrdineAFornitoreDettaglio, IdCommessa, QtaImpegnata;
            SqlConnection conn = new SqlConnection(Properties.Resources.StringaConnessione);
            string CodArt;
            conn.Open();
            foreach (DataGridViewRow row in ordFornDettDataGridView.Rows)
            {
                QtaImpegnata = Convert.ToInt32(row.Cells["QuantitaAssegnata"].Value);
                IdOrdineAFornitoreDettaglio = Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn12"].Value);
                IdCommessa = Convert.ToInt32(textBox3.Text);
                string query1 = "UPDATE ImpegnateOrdinato SET QtaImpegnata = "+ QtaImpegnata.ToString()+" Where IdOrdFornDett='" + Convert.ToString(IdOrdineAFornitoreDettaglio) + "' AND IdCommessa = '" + IdCommessa.ToString() + "'";
                SqlCommand comando1 = new SqlCommand(query1, conn);    
                try
                {
                    comando1.ExecuteScalar();
                }
                catch
                {
                }
            }
            conn.Close();
            ordFornDettDataGridView.Refresh();
        }

        private void AggiornaOrdiniFornitori()
        {   // Aggiorna tabella OrdFornDett
            int IdOrdineAFornitoreDettaglio, QtaImpegnata;
            SqlConnection conn = new SqlConnection(Properties.Resources.StringaConnessione);
            conn.Open();
            foreach (DataGridViewRow row in ordFornDettDataGridView.Rows)
            {
                QtaImpegnata = Convert.ToInt32(row.Cells["QuantitaAssegnata"].Value);
                IdOrdineAFornitoreDettaglio = Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn12"].Value);
                string query1 = "UPDATE OrdFornDett SET QtaImpegnata = " + QtaImpegnata.ToString() + " Where idOFDett='" + Convert.ToString(IdOrdineAFornitoreDettaglio) + "'";
                SqlCommand comando1 = new SqlCommand(query1, conn);
                try
                {
                    comando1.ExecuteScalar();
                }
                catch
                {
                }
            }
            conn.Close();
            ordFornDettDataGridView.Refresh();
        }

        private void AggiornaGiacenze()
        {
            // Aggiorna tabella GiacenzeMagazzini
            // Questo aggiornamento lo faccio fare al form padre
            NrLastreImpegnate = Convert.ToInt32(textBox2.Text);
        }

        private void ordFornDettDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
