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
        int PezziArrivat;

        public ArrivoMerce()
        {
            InitializeComponent();
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
                    textBox1.Text = "";
                    AggiornaOrdineFornitoreTestata();
                    AggiornaMagazzini(e.RowIndex);
                    AggiornaMovimenti(e.RowIndex);
                    EliminaRigaImpegnateOrdinato();
                    AggiornaCommesseCollegate();
                }

                this.ordFornDettTableAdapter.Fill(this.target2021DataSet.OrdFornDett);
                ordFornDettBindingSource.Filter = "Stato<>2 AND idOFTestata = " + NrOrdine.ToString();
                ordFornDettDataGridView.DataSource = ordFornDettBindingSource;
                ordFornDettDataGridView.Update();
                ordFornDettDataGridView.Refresh();
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
            PezziArrivat = CD.PezziArrivati;
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
            string query = "SELECT count(idOFdett) FROM OrdFornDett WHERE idOFTestata="+NrOrdine.ToString()+" AND STATO != '2'";
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

        private void SeNonEsisteCrea(string Cod)
        {
            DataRow[] RigaTrovata;
            RigaTrovata = target2021DataSet.Tables["GiacenzeMagazzini"].Select("idPrime = '"+Cod+"'");

            if (RigaTrovata.Length != 0)
            {
                //MessageBox.Show("L'articolo "+Cod+" esiste nelle giacenze");
            }
            else
            {
                //MessageBox.Show("L'articolo "+Cod+" va creato nelle giacenze!");
                Target2021DataSet.GiacenzeMagazziniRow riga = target2021DataSet.GiacenzeMagazzini.NewGiacenzeMagazziniRow();
                riga.idMagazzino = 1;
                riga.idPrime = Cod;
                riga.GiacenzaComplessiva = 0;
                riga.GiacenzaDisponibili = 0;
                riga.GiacenzaImpegnati = 0;
                riga.DataUltimoMovimento = DateTime.Today;
                riga.GiacenzaOrdinati = 0;
                riga.GiacImpegnSuOrd = 0;
                target2021DataSet.GiacenzeMagazzini.Rows.Add(riga);
                giacenzeMagazziniTableAdapter.Update(target2021DataSet.GiacenzeMagazzini);
            }
        }

        private void ordFornTestDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AggiornaMagazzini(int nriga)
        {
            SeNonEsisteCrea(CodArt);
            int ordinate, arrivate, impegnate;
            int gc, gd, gi, go, gso;

            ordinate = Convert.ToInt32(ordFornDettDataGridView.Rows[nriga].Cells[3].Value);
            arrivate = PezziArrivat;
            impegnate = Convert.ToInt32(ordFornDettDataGridView.Rows[nriga].Cells[12].Value);

            //DataRow[] RigaGiacenza;
            Target2021DataSet.GiacenzeMagazziniRow[] RigaGiacenza;
            RigaGiacenza =(Target2021DataSet.GiacenzeMagazziniRow[]) target2021DataSet.Tables["GiacenzeMagazzini"].Select("idPrime = '" + CodArt + "'");
            gc = RigaGiacenza[0].GiacenzaComplessiva;
            gd = RigaGiacenza[0].GiacenzaDisponibili;
            gi = RigaGiacenza[0].GiacenzaImpegnati;
            go = RigaGiacenza[0].GiacenzaOrdinati;
            gso = RigaGiacenza[0].GiacImpegnSuOrd;

            gc = gc + arrivate;
            gd = gd + (arrivate - impegnate);
            gi = gi + impegnate;
            go = go - ordinate;
            gso = gso - impegnate;

            RigaGiacenza[0].GiacenzaComplessiva = gc;
            RigaGiacenza[0].GiacenzaDisponibili = gd;
            RigaGiacenza[0].GiacenzaImpegnati = gi;
            RigaGiacenza[0].GiacenzaOrdinati = go;
            RigaGiacenza[0].GiacImpegnSuOrd = gso;
            RigaGiacenza[0].DataUltimoMovimento = DateTime.Today;

            this.Validate();
            this.giacenzeMagazziniBindingSource.EndEdit();
            giacenzeMagazziniTableAdapter.Update(target2021DataSet.GiacenzeMagazzini);
            textBox1.Text = textBox1.Text + "Giacenze di magazzino aggiornate correttamente!\r\n";
        }

        private void AggiornaMovimenti(int nriga)
        {
            int arrivate, NrO;
            DateTime adesso;
            arrivate = PezziArrivat;
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

        private void AggiornaCommesseCollegate()
        {
            SqlConnection connessione = new SqlConnection(Properties.Resources.StringaConnessione);
            SqlConnection connessione1 = new SqlConnection(Properties.Resources.StringaConnessione);
            SqlDataReader dati;
            int IdCommessa, NrLastreNecessarie, NrLastreOrdinate, NrLastreAssegnate, Stato, ImpegnoTotale;
            bool Parziale;
            connessione.Open();
            string query = "SELECT Commesse.IDCommessa,CodCommessa,TipoCommessa,NrLastreRichieste,NrPezziOrdinati,QtaImpegnata,Stato,ImpegnataMatPrima,EvasoParziale FROM Commesse INNER JOIN ImpegnateOrdinato ON Commesse.IDCommessa = ImpegnateOrdinato.IdCommessa WHERE TipoCommessa = 1 AND IdOrdFornDett = " + IdDettaglio.ToString();
            SqlCommand comando = new SqlCommand(query, connessione);
            dati = comando.ExecuteReader();
            while (dati.Read())
                {
                IdCommessa = Convert.ToInt32(dati.GetValue(0));
                NrLastreNecessarie = Convert.ToInt32(dati.GetValue(3));
                NrLastreOrdinate = Convert.ToInt32(dati.GetValue(4));
                NrLastreAssegnate = Convert.ToInt32(dati.GetValue(5));
                Stato = Convert.ToInt32(dati.GetValue(6));
                ImpegnoTotale = Convert.ToInt32(dati.GetValue(7));
                Parziale = Convert.ToBoolean(dati.GetValue(8));

                ImpegnoTotale = ImpegnoTotale + NrLastreAssegnate;
                if (ImpegnoTotale >= NrLastreNecessarie)
                    {
                        Stato = 2;
                        Parziale = false;
                    }
                connessione1.Open();
                string query2 = "UPDATE Commesse SET ImpegnataMatPrima = " + ImpegnoTotale.ToString() + " , Stato = " + Stato.ToString() + " , EvasoParziale = '" + Parziale.ToString() + "' WHERE IDCommessa = " + IdCommessa.ToString();
                SqlCommand comando2 = new SqlCommand(query2, connessione1);
                try
                    {
                        comando2.ExecuteNonQuery();
                    }
                catch (Exception e)
                    { }
                textBox1.Text = textBox1.Text + "Aggiornata commessa nr. " + IdCommessa.ToString() + " !\r\n";
                connessione1.Close();
                }
            dati.Close();
            connessione.Close();         
        }
    }
}
