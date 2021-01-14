using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Magazzino
{
    public partial class AllineaDDT : Form
    {
        public AllineaDDT()
        {
            InitializeComponent();
        }

        private void dettaglio_ddtBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dettaglio_ddtBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void AllineaDDT_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.GiacenzeMagazzini'. È possibile spostarla o rimuoverla se necessario.
            this.giacenzeMagazziniTableAdapter.Fill(this.target2021DataSet.GiacenzeMagazzini);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.MovimentiMagazzino'. È possibile spostarla o rimuoverla se necessario.
            this.movimentiMagazzinoTableAdapter.Fill(this.target2021DataSet.MovimentiMagazzino);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.dettaglio_ddt'. È possibile spostarla o rimuoverla se necessario.
            this.dettaglio_ddtTableAdapter.Fill(this.target2021DataSet.dettaglio_ddt);
            int anno;
            anno = DateTime.Now.Year;
            comboBox1.Text = anno.ToString();
            filtra();
        }

        private void filtra()
        {
            dettaglio_ddtBindingSource.Filter = "data_ddt > '" + comboBox1.Text + "0000'";
            dettaglio_ddtDataGridView.Sort(dettaglio_ddtDataGridView.Columns[1], ListSortDirection.Descending);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtra();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int importato = 0, esito = 0, ContaImportati = 0, ContaModificati=0, elaborati=0;
            int DataDDT, NumDDT, ProgrDDT, Qta, ContaAgGiac=0;
            bool Selezionato;
            Double Prezzo;
            string CodArt, Causale;
            // Controlla Le nuove importazioni (per ogni riga)
            foreach (DataGridViewRow riga in dettaglio_ddtDataGridView.Rows)
            {
                try
                {
                    Selezionato = (bool)riga.Cells["Seleziona"].Value;
                }
                catch
                {
                    Selezionato = false;
                }
                if (Selezionato == false) continue;
                else elaborati++;
                // Se importato: data_preventivo_prov = 1 altrimenti = 0
                importato = Convert.ToInt32(riga.Cells["Importato"].Value);
                if (importato == 0)   // Non è già stato importato in precedenza
                {
                    DataDDT = Convert.ToInt32(riga.Cells["DataDDT"].Value);
                    NumDDT = Convert.ToInt32(riga.Cells["NumDDT"].Value);
                    ProgrDDT = Convert.ToInt32(riga.Cells["ProgrDDT"].Value);
                    CodArt = riga.Cells["CodArt"].Value.ToString();
                    if (CodArt == "") continue;
                    Qta = Convert.ToInt32(riga.Cells["Qta"].Value);
                    Prezzo = Convert.ToDouble(riga.Cells["Prezzo"].Value);
                    Causale = "DDT Numero: "+NumDDT.ToString()+" Del " +DataDDT.ToString() + " - Ordine cliente nr: " + riga.Cells["NrOrdine"].Value.ToString();
                    // Crea: A) Moviemento di Scarico in 'MovimentiMagazzino' valorizzando Data, Numero e progressivo DDT
                    esito = InserisciMovimento(DataDDT, NumDDT, ProgrDDT, CodArt, Qta, Prezzo, Causale);
                    //       B) Aggiorna GiacenzeMagazzino (se non esiste lo crea)
                    if (esito == 0)
                    {
                        esito = AggiornaGiacenza(CodArt, Qta);
                        if (esito == 0)
                        {
                            //       C) Aggiorno lo stato 'Importato' a 1 nel MDB e in locale
                            esito = AggiornaImportatoSQL(DataDDT, NumDDT, ProgrDDT);
                            if (esito == 0)
                            {
                                esito = AggiornaImportatoMDB(DataDDT, NumDDT, ProgrDDT);
                                if (esito == 0)
                                {
                                    ContaImportati++;
                                    // colora la riga di verde
                                    // riga.DefaultCellStyle.BackColor = Color.LightGreen;
                                }
                                else
                                {
                                    MessageBox.Show("Aggiornamento dello stato ddt nel MDB: errore");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Aggiornamento dello stato ddt nel SQL: errore");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Aggiornamento tabella giacenze: errore");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aggiornamento movimento di scarico magazzino: errore");
                    }
                }
                else // = 1
                {
                    DataDDT = Convert.ToInt32(riga.Cells["DataDDT"].Value);
                    NumDDT = Convert.ToInt32(riga.Cells["NumDDT"].Value);
                    ProgrDDT = Convert.ToInt32(riga.Cells["ProgrDDT"].Value);
                    CodArt = riga.Cells["CodArt"].Value.ToString();
                    if (CodArt == "") continue;
                    Qta = Convert.ToInt32(riga.Cells["Qta"].Value);
                    esito = AggiornaMovimentoMagazzino(DataDDT, NumDDT, ProgrDDT, Qta);
                    if (esito!=0) ContaModificati++;
                    esito = AggiornaGiacenza(CodArt, esito);
                    if (esito == 0) ContaAgGiac++;
                }
                // if (ContaImportati == 3) break;   // da commentare
            }
            this.dettaglio_ddtTableAdapter.Fill(this.target2021DataSet.dettaglio_ddt);
            dettaglio_ddtDataGridView.Refresh();
            MessageBox.Show("Finito. Elaborate "+elaborati.ToString()+" righe. Importate " + ContaImportati + " righe di DDT. Modificate "+ContaModificati +" righe");
            // Visualizza in un messagebox info su attività di importazione effettuate
            this.dettaglio_ddtTableAdapter.Fill(this.target2021DataSet.dettaglio_ddt);
            filtra();
        }

        private int AggiornaMovimentoMagazzino(int DataDDT, int NumDDT, int ProgrDDT, int Qta)
        {
            int Quantita, IdMovimento, Differenza=0;
            DataRow[] RigaTrovata;
            RigaTrovata = target2021DataSet.Tables["MovimentiMagazzino"].Select("DataDDT = " + DataDDT + " AND NumeroDDT = " + NumDDT + " AND ProgressivoRigaDDT = " + ProgrDDT);

            if (RigaTrovata.Length != 0)
            {
                IdMovimento = Convert.ToInt32(RigaTrovata[0]["idMovimento"]);
                Quantita = Convert.ToInt32(RigaTrovata[0]["Quantita"]);
                if (Quantita == Qta)
                {
                    // Non fai nulla
                    return 0;
                }
                else
                {
                    // Aggiorna
                    Differenza = Qta-Quantita;
                    DataRow riga;
                    DataTable TMovimenti;
                    TMovimenti = target2021DataSet.Tables["MovimentiMagazzino"];
                    riga = TMovimenti.Rows.Find(IdMovimento);
                    riga.BeginEdit();
                    riga["Quantita"] = Qta;
                    riga.EndEdit();
                    giacenzeMagazziniTableAdapter.Update(target2021DataSet.GiacenzeMagazzini);
                    return Differenza;
                }
            }
            else
            {
                //MessageBox.Show("Anomalia! Non trovo un movimento che dovrebbe essere registrato: "+DataDDT+" - " + NumDDT + " - " + ProgrDDT);
                return 0;
            }
        }

        private int AggiornaImportatoMDB(int DataDDT, int NumDDT, int ProgrDDT)
        {
            try
            {
                string stringaconnessione, sql = "";
                stringaconnessione = Properties.Resources.ConnessioneAccessDDT;
                OleDbConnection connessione = new OleDbConnection(stringaconnessione);
                sql = "UPDATE dettaglio_ddt SET data_preventivo_prov = 1 WHERE data_ddt = " + DataDDT + " AND numero_ddt = " + NumDDT + " AND progressivo = " + ProgrDDT;
                OleDbCommand comando = new OleDbCommand(sql, connessione);
                connessione.Open();
                try
                {
                    comando.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Errore ExecuteNonQuery nell'aggiornmento del MDB");
                }
                connessione.Close();
                return 0;
            }
            catch
            {
                return 1;
            }
        }

        private int AggiornaImportatoSQL(int DataDDT, int NumDDT, int ProgrDDT)
        {
            short progr;
            progr = Convert.ToSByte(ProgrDDT);
            try
            {
                dettaglio_ddtTableAdapter.UpdateQuery(DataDDT, NumDDT, progr);
                return 0;
            }
            catch
            {
                return 1;
            }
        }

        private int AggiornaGiacenza(string CodArt, int Qta)
        {
            DataRow[] RigaGiacenza;
            int GComp, GDisp, IdGiacenza;

            try
            {
                RigaGiacenza = target2021DataSet.Tables["GiacenzeMagazzini"].Select("idArticoli = '" + CodArt + "'");
                if (RigaGiacenza.Length != 0)
                {
                    IdGiacenza = Convert.ToInt32(RigaGiacenza[0]["IdGiacenza"]);
                    GComp = Convert.ToInt32(RigaGiacenza[0]["GiacenzaComplessiva"]);
                    GDisp = Convert.ToInt32(RigaGiacenza[0]["GiacenzaDisponibili"]);
                    // Aggiorna
                    DataRow riga;
                    DataTable TGiacenze;
                    TGiacenze = target2021DataSet.Tables["GiacenzeMagazzini"];
                    riga = TGiacenze.Rows.Find(IdGiacenza);
                    riga.BeginEdit();
                    GComp = GComp - Qta;
                    riga["GiacenzaComplessiva"] = GComp;
                    GDisp = GDisp - Qta;
                    riga["GiacenzaDisponibili"] = GDisp;
                    riga["DataUltimoMovimento"] = DateTime.Today;    // Non ancora testata questa riga
                    riga.EndEdit();
                    giacenzeMagazziniTableAdapter.Update(target2021DataSet.GiacenzeMagazzini);
                    // Aggiornata giacenza se articolo già presente
                }
                else
                {
                    MessageBox.Show("L'articolo "+CodArt+" non esiste nelle giacenze. Lo creo.");
                    Target2021DataSet.GiacenzeMagazziniRow riga = target2021DataSet.GiacenzeMagazzini.NewGiacenzeMagazziniRow();
                    riga.idMagazzino = 5;
                    riga.idArticoli = CodArt;
                    riga.GiacenzaComplessiva = -Qta;
                    riga.GiacenzaDisponibili = -Qta;
                    riga.GiacenzaImpegnati = 0;
                    riga.DataUltimoMovimento = DateTime.Today;
                    riga.GiacenzaOrdinati = 0;
                    riga.GiacImpegnSuOrd = 0;
                    target2021DataSet.GiacenzeMagazzini.Rows.Add(riga);
                    giacenzeMagazziniTableAdapter.Update(target2021DataSet.GiacenzeMagazzini);
                }
                return 0;
            }
            catch
            {
                return 1;
            }
        }

        private int InserisciMovimento(int DataDDT, int NumDDT, int ProgrDDT, string CodArt, int Qta, double Prezzo, string Causale)
        {
            try
            {
                Target2021DataSet.MovimentiMagazzinoRow riga = target2021DataSet.MovimentiMagazzino.NewMovimentiMagazzinoRow();
                riga.idMagazzino = 5;
                riga.idArticoli = CodArt;
                riga.CarScar = "S";
                riga.Quantita = Qta;
                riga.DataOraMovimento = DateTime.Now;
                riga.PrezzoComplessivoMateriaPrima = Prezzo*Qta;
                riga.Causale = Causale;
                riga.DataDDT = DataDDT;
                riga.NumeroDDT = NumDDT;
                riga.ProgressivoRigaDDT = ProgrDDT;
                target2021DataSet.MovimentiMagazzino.Rows.Add(riga);
                movimentiMagazzinoTableAdapter.Update(target2021DataSet.MovimentiMagazzino);
                return 0;
            }
            catch
            {
                return 1;
            }
        }

        private void dettaglio_ddtDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int importato = 0;

            foreach (DataGridViewRow riga in dettaglio_ddtDataGridView.Rows)
            {
                importato = Convert.ToInt32(riga.Cells["Importato"].Value);
                if (importato==1)
                    riga.DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }
    }
}
