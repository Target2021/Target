using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Fornitori
{
    public partial class ArrivoMerce : Form
    {
        int IdDettaglio, NrOrdine, Riga;
        double PesoTot, PrezzoTot;
        string CodArt;

        public ArrivoMerce()
        {
            InitializeComponent();
        }

        private void ordFornTestBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordFornTestBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void ArrivoMerce_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.GiacenzeMagazzini'. È possibile spostarla o rimuoverla se necessario.
            this.giacenzeMagazziniTableAdapter.Fill(this.target2021DataSet.GiacenzeMagazzini);
            this.ordFornTestTableAdapter.Fill(this.target2021DataSet.OrdFornTest);
            filtra();
        }

        private void filtra()
        {
            ordFornTestBindingSource.Filter = "StatoOrdine = 0 OR StatoOrdine = 1";
        }

        private void selezionata(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                NrOrdine = Convert.ToInt32(ordFornTestDataGridView.Rows[e.RowIndex].Cells[11].Value);
                Riga = e.RowIndex;
                dettaglio();
            }
            catch { }
        }

        private void dettaglio()
        {
            this.ordFornDettTableAdapter.Fill(this.target2021DataSet.OrdFornDett);
            ordFornDettBindingSource.Filter = "Stato=0 AND idOFTestata = " + NrOrdine.ToString();
        }

        private void SelezionataRigaOrdine(object sender, DataGridViewCellEventArgs e)
        {
            int risultato = 0;
            try
            {
                IdDettaglio = Convert.ToInt32(ordFornDettDataGridView.Rows[e.RowIndex].Cells[11].Value);
                CodArt = ordFornDettDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                giacenzeMagazziniBindingSource.Filter = "idPrime = '" + CodArt + "'";
                risultato = AggiornaOrdineFornitoreDettaglio();
                if (risultato == 2)
                {
                    AggiornaOrdineFornitoreTestata();
                    AggiornaMagazzini(e.RowIndex);
                    AggiornaMovimenti(e.RowIndex);
                    EliminaRigaImpegnateOrdinato();
                }
            }
            catch { }
        }

        private int AggiornaOrdineFornitoreDettaglio()
        {
            int ris;
            ChiudiDettaglio CD = new ChiudiDettaglio(IdDettaglio,5);  // 5 = chiusura
            CD.ShowDialog();
            ris = CD.risultato;
            PesoTot = CD.Peso;
            PrezzoTot = CD.Prezzo;
            return ris;
        }

        private void AggiornaOrdineFornitoreTestata()
        {
            int ris = 9;
            //      c) OrdFornTest
            //          c1) Incremento tutti gli importi?
            //          c2) Imposto lo stato = 1 se altre righe e 2 se unica riga?
            SqlConnection connessione = new SqlConnection(Properties.Resources.StringaConnessione);
            connessione.Open();
            string query = "SELECT count(idOFdett) FROM OrdFornDett WHERE idOFTestata="+IdDettaglio.ToString()+" AND STATO != '2'";
            SqlCommand comando = new SqlCommand(query, connessione);
            ris = Convert.ToInt32 (comando.ExecuteScalar());
            connessione.Close();
            if (ris == 0)
            {
                textBox1 .Text = textBox1 .Text +"Questa era l'ultima riga dell'ordine aperta. Chiudo l'ordine a Fornitore.\r\n";
                connessione.Open();
                query = "UPDATE OrdFornTest SET StatoOrdine=2 WHERE idOFTestata=" + NrOrdine.ToString();
                comando = new SqlCommand(query, connessione);
                comando.ExecuteNonQuery();
                connessione.Close();
            }
            else
            {
                textBox1.Text = textBox1.Text + "Questa non era l'ultima riga dell'ordine aperta.\r\n";
                connessione.Open();
                query = "UPDATE OrdFornTest SET StatoOrdine=1 WHERE idOFTestata=" + NrOrdine.ToString();
                comando = new SqlCommand(query, connessione);
                comando.ExecuteNonQuery();
                connessione.Close();
            }
        }

        private void ordFornDettDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EliminaRigaImpegnateOrdinato()
        {
            //      d) ImpegnateOrdinato -> Io non lo toccherei (o si?) -> si
        }

        private void AggiornaMagazzini(int nriga)
        {
            int ordinate, arrivate, impegnate;
            int gc, gd, gi, go, gso;

            this.ordFornDettTableAdapter.Fill(this.target2021DataSet.OrdFornDett);
            ordFornDettBindingSource.Filter = "Stato=2 AND idOFTestata = " + NrOrdine.ToString();
            ordFornDettDataGridView.DataSource = ordFornDettBindingSource;
            //ordFornDettTableAdapter.Fill(target2021DataSet.OrdFornDett);
            ordFornDettDataGridView.Update();
            ordFornDettDataGridView.Refresh();

            ordinate = Convert.ToInt32(ordFornDettDataGridView.Rows[nriga].Cells[3].Value);
            arrivate = Convert.ToInt32(ordFornDettDataGridView.Rows[nriga].Cells[8].Value);
            impegnate = Convert.ToInt32(ordFornDettDataGridView.Rows[nriga].Cells[12].Value);
            gc = Convert.ToInt32(giacenzeMagazziniDataGridView.Rows[nriga].Cells[7].Value);
            gd = Convert.ToInt32(giacenzeMagazziniDataGridView.Rows[nriga].Cells[8].Value);
            gi = Convert.ToInt32(giacenzeMagazziniDataGridView.Rows[nriga].Cells[9].Value);
            go = Convert.ToInt32(giacenzeMagazziniDataGridView.Rows[nriga].Cells[14].Value);
            gso = Convert.ToInt32(giacenzeMagazziniDataGridView.Rows[nriga].Cells[15].Value);

            gc = gc + arrivate;
            gd = gd + (arrivate - impegnate);
            gi = gi + impegnate;
            go = go - ordinate;
            gso = gso - impegnate;

            giacenzeMagazziniDataGridView.Rows[nriga].Cells[7].Value=gc;
            giacenzeMagazziniDataGridView.Rows[nriga].Cells[8].Value=gd;
            giacenzeMagazziniDataGridView.Rows[nriga].Cells[9].Value=gi;
            giacenzeMagazziniDataGridView.Rows[nriga].Cells[14].Value=go;
            giacenzeMagazziniDataGridView.Rows[nriga].Cells[15].Value=gso;

            this.Validate();
            this.giacenzeMagazziniBindingSource.EndEdit();
            giacenzeMagazziniTableAdapter.Update(target2021DataSet.GiacenzeMagazzini);
            //this.tableAdapterManager.UpdateAll(this.target2021DataSet);
            textBox1.Text = textBox1.Text + "Giacenze di magazzino aggiornate correttamente!\r\n";
        }

        private void AggiornaMovimenti(int nriga)
        {
            int arrivate, NrO;
            DateTime adesso;
            arrivate = Convert.ToInt32(ordFornDettDataGridView.Rows[nriga].Cells[8].Value);
            adesso = DateTime.Now;
            NrO = Convert.ToInt32(ordFornTestDataGridView.Rows[Riga].Cells[2].Value);

            SqlConnection connessione = new SqlConnection(Properties.Resources.StringaConnessione);
            connessione.Open();
            string query = "INSERT INTO MovimentiMagazzino(idMagazzino, idPrime, CarScar, Quantita, NrOrdine, DataOraMovimento, PesoMateriaPrima, PrezzoComplessivoMateriaPrima) VALUES (1, '" + CodArt + "', 'C', "+arrivate.ToString()+", '"+NrO.ToString()+"', '"+adesso.ToString()+"', "+PesoTot.ToString(CultureInfo.InvariantCulture) +", "+PrezzoTot.ToString(CultureInfo.InvariantCulture) +")";
            SqlCommand comando = new SqlCommand(query, connessione);
            comando.ExecuteNonQuery();
            connessione.Close();
            textBox1.Text = textBox1.Text + "Movimento di magazzino inserito correttamente!\r\n";
        }
    }
}
