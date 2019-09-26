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
using System.Windows.Forms.Integration;

namespace Target2021
{
    public partial class NewOrderCheck : Form
    {
        private int NumOrd, NumTest, percentuale;
        private string IDPrima;

        public NewOrderCheck()
        {
            InitializeComponent();
        }

        private void NewOrderCheck_Load(object sender, EventArgs e)
        {
            this.ordiniEsclusiTableAdapter.Fill(this.target2021DataSet.OrdiniEsclusi);
            this.ordiniImportatiTableAdapter.Fill(this.target2021DataSet.OrdiniImportati);
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            this.dettaglio_ordini_multirigaTableAdapter.Fill(this.target2021DataSet.dettaglio_ordini_multiriga);
            this.dettArticoliTableAdapter.Fill(this.target2021DataSet.DettArticoli);
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            //carica();
            aggiornaVisualizzazione(comboBox1.Text);
        }

        private void aggiornaVisualizzazione(string anno)
        {
            anno = anno + "0000";
            dettaglio_ordini_multirigaBindingSource.Filter = "peso = 1 ";
            dettaglioordinimultirigaBindingSource.Filter = "peso = 0";
            dettaglioordinimultirigaBindingSource1.Filter = "peso = 2 AND data_ordine > '"+anno+"'";
            try
            {
                dettaglio_ordini_multirigaDataGridView.Sort(dettaglio_ordini_multirigaDataGridView.Columns["dataGridViewTextBoxColumn9"], ListSortDirection.Descending);
                dataGridView5.Sort(dataGridView5.Columns["Numero"], ListSortDirection.Descending);
                dataGridView4.Sort(dataGridView4.Columns["dataGridViewTextBoxColumn99"], ListSortDirection.Descending);
            }
            catch
            { }
        }

        private void carica()
        {
            DataTable tabella, tabellavecchi;
            aggiorna();
            //tabella=CreaTabellaOrdini();
            //tabellavecchi=CreaTabellaOrdiniVecchi();
            //PopolaTabellaOrdini(comboBox1.Text, tabella, tabellavecchi);
        }

        private void CreaTabellaOrdini()  // restituiva il tipo DataTable
        {
            //DataTable dt = new DataTable();
            //dt.Columns.Add(new DataColumn("Seleziona", typeof(bool)));
            //dt.Columns.Add(new DataColumn("Num", typeof(Int32)));
            //dt.Columns.Add(new DataColumn("Data", typeof(DateTime)));
            //dt.Columns.Add(new DataColumn("Articolo", typeof(string)));
            //dt.Columns.Add(new DataColumn("Descrizione", typeof(string)));
            //dataGridView2.DataSource = dt;
            //this.dataGridView2.Columns["Num"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //this.dataGridView2.Sort(this.dataGridView2.Columns["Num"], ListSortDirection.Ascending);
            //return dt;
        }

        private DataTable CreaTabellaOrdiniVecchi()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Seleziona", typeof(bool)));
            dt.Columns.Add(new DataColumn("Num", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Data", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("Articolo", typeof(string)));
            dt.Columns.Add(new DataColumn("Descrizione", typeof(string)));
            return dt;
        }

        private void PopolaTabellaOrdini(string anno, DataTable tabella, DataTable vecchi)
        {
            RiempiDettaglioOrdini(anno, tabella, vecchi);
            RiempiCheckOrdinato(anno, vecchi);
        }

        private void RiempiDettaglioOrdini(string anno, DataTable tabella, DataTable vecchi)
        {
            string data;
            data = anno+"0000";
            DataTable DettaglioOrdini;
            DettaglioOrdini = target2021DataSet.Tables["dettaglio_ordini_multiriga"];

            string selezione = "data_ordine > '"+data+"' AND aliquota_iva = 0" ;
            DataRow[] rows = DettaglioOrdini.Select(selezione);

            foreach(DataRow riga in rows)
            {
                DataRow rig = tabella.NewRow();
                rig["Num"] = riga[1];
                rig["Data"] = DateTime.ParseExact(riga[0].ToString(),"yyyyMMdd",CultureInfo.InvariantCulture);
                rig["Articolo"] = riga[3];
                rig["Descrizione"] = riga[4];
                tabella.Rows.Add(rig);
            }
        }

        private void RiempiCheckOrdinato(string anno, DataTable vecchi)
        {
            //int NumOrdine, i=0, j;
            //int[] rimuovi = new int[2000];
            //dataGridView3.Rows.Clear();
            //dataGridView3.Refresh();
            //foreach (DataGridViewRow riga in dataGridView2.Rows)
            //{
            //    NumOrdine = Convert .ToInt32(riga.Cells[1].Value);
            //    DataTable OrdiniImportati;
            //    OrdiniImportati = target2021DataSet.Tables["OrdiniImportati"];

            //    string selezione = "Anno = " + anno + " AND Numero = " + NumOrdine.ToString();
            //    DataRow[] rows = OrdiniImportati.Select(selezione);

            //    if (rows.Length == 0) ;
            //    //riga.Cells[0].Value = false;
            //    else
            //    {
            //        //riga.Cells[0].Value = true;
            //        DataGridViewRow vecchia = (DataGridViewRow)riga.Clone();
            //        for (Int32 index = 0; index < riga.Cells.Count; index++)
            //        {
            //            vecchia.Cells[index].Value = riga.Cells[index].Value;
            //        }
            //        dataGridView3.Rows.Add(vecchia);
            //        rimuovi[i] = riga.Index;
            //        i++;
            //    }
            //}
            //for (j=0;j<i;j++)  // Si potrebbe sostituire questro codice con ciclo "rimuovi se spuntata"
            //{
            //    dataGridView2.Rows.RemoveAt(rimuovi[j]-j);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aggiorna();
        }

        private void aggiorna()
        {
            int NumDet, neworder=0;
            NumOrd = RecuperaUltimoOrdine();
            textBox1.Text = NumOrd.ToString();
            NumTest = RecuperaUltimoTestata();
            textBox2.Text = NumTest.ToString();
            NumDet = RecuperaUltimoDettaglio();
            textBox3.Text = NumDet.ToString();
            neworder = NumTest - NumOrd;
            label4.Visible = true;
            if (neworder == 0) label4.Text = "Non ci sono nuovi ordini!";
            else
            {
                label4.Text = "Ci sono " + neworder.ToString() + " ordini ancora da importare!";
            }
            this.dettaglio_ordini_multirigaTableAdapter.Fill(this.target2021DataSet.dettaglio_ordini_multiriga);
            dataGridView5.Refresh();
        }

        private int RecuperaUltimoOrdine()
        {
            int NrUltOrd=0;
            string stringaconnessione, sql;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "select COUNT(Id) from OrdiniImportati";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            try
            {
                NrUltOrd = Convert.ToInt32(comando.ExecuteScalar());
            }
            catch
            {
                NrUltOrd = 0;
            }
            connessione.Close();
            return NrUltOrd;
        }

        private int RecuperaUltimoTestata()
        {
            int NrUltOrd = 0;
            string stringaconnessione, sql;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT MAX(numero_ordine) FROM testata_ordini_multiriga WHERE data_ordine>20190000";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            try
            {
                NrUltOrd = Convert.ToInt32(comando.ExecuteScalar());
            }
            catch
            {

            }
            connessione.Close();
            return NrUltOrd;
        }

        private int RecuperaUltimoDettaglio()
        {
            int NrUltOrd = 0;
            string stringaconnessione, sql;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT MAX(numero_ordine) FROM dettaglio_ordini_multiriga WHERE data_ordine>20190000";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            try
            {
                NrUltOrd = Convert.ToInt32(comando.ExecuteScalar());
            }
            catch
            {

            }
            connessione.Close();
            return NrUltOrd;
        }

        private void AggiornaUltimoOrdine(int no, DateTime data)
        {
            string stringaconnessione, sql;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "UPDATE Configurazione SET NrUltimoOrdineLetto = "+no+" , DataUltimoOrdine = '"+data.ToString("d/M/yyyy")+"'";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            comando.ExecuteNonQuery();
            connessione.Close();
        }

        private int Importa(int n, int data)
        {
            int i, IDOrdine, NumFasi, progressivo, NrPezzi, NrLastreRichieste, MachStamp;
            DateTime DataOrdine = DateTime.Now, DataConsegna=DateTime.Now;
            string CodiceArticolo, IDCliente, OrdineCliente, DescrArticolo, IdFornitore, IDMatPrima,PT1,PT2;
            SqlDataReader fasi;
            BindingSource SorgenteDati = new BindingSource();
            IDOrdine = n;
            CodiceArticolo = CodiceArt(IDOrdine);
            textBox4.Text = textBox4.Text + "Ordine numero: " + IDOrdine + "\r\n";
            textBox4.Text = textBox4.Text + "Articolo: " + CodiceArticolo + "\r\n";
            NumFasi = NumeroFasi(CodiceArticolo);
            textBox4.Text = textBox4.Text + "Questo articolo ha: " + NumFasi.ToString() + " fasi di lavorazione. \r\n";
            if (NumFasi == 0)
            {
                MessageBox.Show("Non ho nulla da importare! Questo articolo ha 0 fasi!");
                AggiornaUltimoOrdine(IDOrdine, DataOrdine);
                ImpostaPesoCliente(n, data,1);  // usa il campo peso per settare stato ordine (0=da importare, 1=importato, 2=scontato)
                AggiornaStatoTemporaneo(n, data,1);  // Aggiorno anche la tabella locale
                return 1;
            }   
            else
            {
                fasi = ControllaFasi(CodiceArticolo);
                SorgenteDati.DataSource = fasi;
                dataGridView1.DataSource = SorgenteDati;
                for (i = 1; i <= NumFasi; i++)
                {
                    textBox4.Text = textBox4.Text + "Fase numero: " + i + "\r\n";
                    Commessa com = new Commessa(IDOrdine);
                    progressivo = RecuperaFaseLavorazione(CodiceArticolo, i);
                    if (progressivo == 1)
                    {
                        com.CodCommessa = "OF" + IDOrdine;
                        com.TipoCommessa = 1;
                    }
                    if (progressivo == 2)
                    {
                        com.CodCommessa = "S" + IDOrdine;
                        com.TipoCommessa = 2;
                    }
                    if (progressivo == 3)
                    {
                        com.CodCommessa = "T" + IDOrdine;
                        com.TipoCommessa = 3;
                    }
                    if (progressivo == 4)
                    {
                        com.CodCommessa = "ASS" + IDOrdine;
                        com.TipoCommessa = 4;
                    }
                    com.NrCommessa = IDOrdine;
                    DataOrdine = RecuperaDataOrdine(IDOrdine);
                    com.DataCommessa = DataOrdine;
                    textBox4.Text = textBox4.Text + "CodCommessa: " + com.CodCommessa + "\r\n";
                    textBox4.Text = textBox4.Text + "NrCommessa: " + com.NrCommessa + "\r\n";
                    textBox4.Text = textBox4.Text + "Data Commessa: " + com.DataCommessa + "\r\n";
                    textBox4.Text = textBox4.Text + "Tipo Commessa: " + com.TipoCommessa + "\r\n";
                    IDCliente = RecuperaIDCliente(IDOrdine);
                    com.IDCliente = IDCliente;
                    OrdineCliente = RecuperaOrdineCliente(IDOrdine);
                    com.OrdCliente = OrdineCliente;
                    DataConsegna = RecuperaDataConsegna(IDOrdine);
                    com.DataConsegna = DataConsegna;
                    NrPezzi = RecuperaNrPezzi(IDOrdine);
                    com.NrPezziDaLavorare = NrPezzi;
                    com.CodArticolo = CodiceArticolo;
                    DescrArticolo = RecuperaDescrizioneArticolo(IDOrdine);
                    com.DescrArticolo = DescrArticolo;
                    IdFornitore = RecuperaIdFornitore(CodiceArticolo, i);
                    com.IDFornitore = IdFornitore;
                    IDMatPrima = RecuperaIDMatPri(CodiceArticolo, i);
                    com.IDMateriaPrima = IDMatPrima;
                    if (progressivo == 1) IDPrima = IDMatPrima;
                    NrLastreRichieste = RecuperaNrLasRic(CodiceArticolo, i, IDOrdine);
                    com.NrLastreRichieste = NrLastreRichieste;
                    PT1 = RecuperaProgTaglio(CodiceArticolo, i, 1);
                    com.ProgrTaglio1 = PT1;
                    PT2 = RecuperaProgTaglio(CodiceArticolo, i, 2);
                    com.ProgrTaglio2 = PT2;
                    percentuale = RecuperaPercentualeLastra(CodiceArticolo);
                    com.PercentualeUtilizzoLastra = percentuale;
                    MachStamp = RecuperaMacchinaStampa(CodiceArticolo);
                    com.Mps = MachStamp;
                    com.ProgStampa = RecuperaProgrammaStampaggio(CodiceArticolo);
                    com.PezziOra = RecuperaNumeroPezziStampatiOra(CodiceArticolo);
                    com.Foto = RecuperaFoto(CodiceArticolo);
                    com.CodArtiDopoStampo = RecuperaCodiceArticoloDopoStampo(CodiceArticolo);
                    com.CodArtiDopoTaglio = RecuperaCodiceArticoloDopoTaglio(CodiceArticolo);
                    com.IDMachStampa = RecuperaMacchinaStampaPredefinita(CodiceArticolo);
                    com.Note = RecuperaNote(CodiceArticolo);
                    com.IDMachTaglio = RecuperaMacchinaTaglio(CodiceArticolo);
                    com.IDMinuteria = RecuperaMinuteria(CodiceArticolo, i);
                    com.Qtaminuteria = RecuperaQtaMinuteria(CodiceArticolo, i);
                    InserisciCommessa1(com);
                }
                AggiornaUltimoOrdine(IDOrdine, DataOrdine);
                ImpostaPesoCliente(n, data,1);  // usa il campo peso per settare stato ordine (0=da importare, 1=importato, 2=scontato)
                AggiornaStatoTemporaneo(n, data,1);  // Aggiorno anche la tabella locale
                return 0;
            }
        }

        private void AggiornaStatoTemporaneo(int n, int data, int stato)
        {
            string stringaconnessione, sql;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "UPDATE dettaglio_ordini_multiriga SET peso = "+stato+" WHERE data_ordine = " + data + " AND numero_ordine=" + n;
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
            sql = "UPDATE dettaglio_ordini_multiriga SET peso="+stato+" WHERE numero_ordine=" + n + " AND data_ordine = " + data;
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

        private string RecuperaMinuteria(string Cod, int pos)
        {
            string outp = "";
            DataRow[] riga;
            riga = target2021DataSet.Tables["DettArticoli"].Select("codice_articolo='" + Cod + "' AND lavorazione=4");
            try
            {
                outp = riga[pos-1]["CodiceInput"].ToString();
                return outp;
            }
            catch { return "NN"; }
        }

        private int RecuperaQtaMinuteria(string ca, int pos)
        {
            int numero = 1;
            DataRow[] riga;
            riga = target2021DataSet.Tables["DettArticoli"].Select("codice_articolo='" + ca + "' AND lavorazione=4");
            try
            {
                numero =Convert .ToInt32(riga[pos - 1]["Quantita"]);
                return numero;
            }
            catch { return numero; }
        }

        private int RecuperaPercentualeLastra(string ca)
        {
            int risultato = 0;
            string filtro = "lavorazione = 2 AND codice_articolo = '" + ca + "'";
            try
            {
                risultato = (int)target2021DataSet.DettArticoli.Compute("MAX(PercentualeLastra)", filtro);
            }
            catch
            {
                risultato = 100;
            }
            return risultato;
        }

        private int RecuperaMacchinaTaglio(string ca)
        {
            int risultato = 0;
            string filtro = "codice_articolo = '" + ca + "'";
            try
            {
                risultato = (int)target2021DataSet.DettArticoli.Compute("MAX(MacPredefTaglio)", filtro);
            }
            catch
            {
                risultato = 0;
            }
            return risultato;
        }

        private string RecuperaNote(string ca)
        {
            string stringaconnessione, sql = "", note;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT note FROM articoli_semplici WHERE codice='" + ca + "'";
            SqlCommand comando = new SqlCommand(sql, connessione);
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
            return note;
        }

        private int RecuperaMacchinaStampaPredefinita(string ca)
        {
            int risultato = 0;
            string filtro = "codice_articolo = '" + ca + "'";
            try
            {
                risultato = (int)target2021DataSet.DettArticoli.Compute("MAX(MacPredefStampo)", filtro);
            }
            catch
            {
                risultato = 0;
            }
            return risultato;
        }

        private string RecuperaProgrammaStampaggio(string ca)
        {
            string stringaconnessione, sql = "", progt;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT ProgStampaggio FROM DettArticoli WHERE codice_articolo='" + ca + "' AND lavorazione=2";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            try
            {
                progt = comando.ExecuteScalar().ToString();
            }
            catch
            {
                progt = "Non presente";
            }
            connessione.Close();
            return progt;
        }

        private string RecuperaFoto(string ca)
        {
            string stringaconnessione, sql = "", foto;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT indirizzo_immagine FROM articoli_semplici WHERE codice='" + ca + "'";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            try
            {
                foto = comando.ExecuteScalar().ToString();
            }
            catch
            {
                foto = null;
            }
            connessione.Close();
            return foto;
        }

        private int RecuperaNumeroPezziStampatiOra(string ca)
        {
            int risultato=0;
            string filtro = "codice_articolo = '" + ca + "'";
            try
            {
                risultato = (int)target2021DataSet.DettArticoli.Compute("MAX(PezziOra)", filtro);
            }
            catch
            {
                risultato = 0;
            }
            return risultato;
        }

        private int RecuperaMacchinaStampa(string ca)
        {
            int risultato;
            string filtro = "codice_articolo = '" + ca + "'";
            risultato=(int) target2021DataSet.DettArticoli.Compute("MAX(MacPredefStampo)", filtro);
            return risultato; ;
        }

        private string RecuperaCodiceArticoloDopoStampo(string Cod)
        {
            string outp="";
            DataRow[] riga;
            riga = target2021DataSet.Tables["DettArticoli"].Select("codice_articolo='" + Cod + "' AND lavorazione=2");
            try
            {
                outp = riga[0]["CodiceOutput"].ToString();
                return outp;
            }
            catch { return "NN"; }
        }

        private string RecuperaCodiceArticoloDopoTaglio(string Cod)
        {
            string outp = "";
            DataRow[] riga;
            riga = target2021DataSet.Tables["DettArticoli"].Select("codice_articolo='" + Cod + "' AND lavorazione=3");
            try
            {
                outp = riga[0]["CodiceOutput"].ToString();
                return outp;
            }
            catch { return "NN"; }
        }

        private string CodiceArt(int numord)
        {
            string stringaconnessione, sql, CodArticolo, data;
            stringaconnessione = Properties.Resources.StringaConnessione;
            data = comboBox1.Text;
            data = data + "0000";
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT codice_articolo FROM dettaglio_ordini_multiriga WHERE numero_ordine="+numord.ToString()+" AND data_ordine>"+data;
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            CodArticolo = comando.ExecuteScalar().ToString();
            connessione.Close();
            return CodArticolo;
        }

        private string RecuperaDescrizioneArticolo(int numord)
        {
            string stringaconnessione, sql, DesArticolo;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT descrizione_articolo FROM dettaglio_ordini_multiriga WHERE numero_ordine=" + numord.ToString() + " AND data_ordine>20190000";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            DesArticolo = comando.ExecuteScalar().ToString();
            connessione.Close();
            return DesArticolo;
        }

        private int NumeroFasi(string codart)  // Da rivedere
        {
            string stringaconnessione, sql;
            int NumFasi;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT COUNT(codice_articolo) FROM DettArticoli WHERE codice_articolo ='" + codart.ToString()+"'";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            NumFasi = Convert.ToInt32(comando.ExecuteScalar());
            connessione.Close();
            return NumFasi;
        }

        private SqlDataReader ControllaFasi(string codart)
        {
            SqlDataReader fasilav;

            string stringaconnessione, sql;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT * FROM DettArticoli WHERE codice_articolo ='" + codart.ToString() + "'";
            SqlCommand comando = new SqlCommand(sql, connessione);
            try
            {
                connessione.Open();
                fasilav = comando.ExecuteReader(CommandBehavior.CloseConnection);
                return fasilav;
            }
            catch (Exception ex)
            {
                connessione.Dispose();
                return null;
            }
        }

        private int RecuperaFaseLavorazione(string codart, int i)
        {
            string stringaconnessione, sql;
            int Fase;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT lavorazione FROM DettArticoli WHERE codice_articolo ='" + codart.ToString() + "' AND progressivo="+i;
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            Fase = Convert.ToInt32(comando.ExecuteScalar());
            connessione.Close();
            return Fase;
        }

        private DateTime RecuperaDataOrdine(int numord)
        {
            string stringaconnessione, sql;
            DateTime dto;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT data_ordine FROM dettaglio_ordini_multiriga WHERE numero_ordine=" + numord.ToString() + " AND data_ordine>20190000";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            dto = DateTime.ParseExact(comando.ExecuteScalar().ToString(), "yyyyMMdd", null);
            connessione.Close();
            return dto;
        }

        private string RecuperaIDCliente(int numord)
        {
            string stringaconnessione, sql, idc;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT codice_cliente FROM testata_ordini_multiriga WHERE numero_ordine=" + numord.ToString() + " AND data_ordine>20190000";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            idc = comando.ExecuteScalar().ToString();
            connessione.Close();
            return idc;
        }

        private string RecuperaOrdineCliente(int numord)
        {
            string stringaconnessione, sql, noc;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT numero_ordine_cliente FROM testata_ordini_multiriga WHERE numero_ordine=" + numord.ToString() + " AND data_ordine>20190000";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            noc = comando.ExecuteScalar().ToString();
            connessione.Close();
            return noc;
        }

        private DateTime RecuperaDataConsegna(int numord)
        {
            string stringaconnessione, sql;
            DateTime dtc;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT data_consegna FROM dettaglio_ordini_multiriga WHERE numero_ordine=" + numord.ToString() + " AND data_ordine>20190000";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            try
            {
                dtc = DateTime.ParseExact(comando.ExecuteScalar().ToString(), "yyyyMMdd", null);
            }
            catch
            {
                int year = DateTime.Now.Year;
                dtc = new DateTime(year, 1, 1);
            }
            connessione.Close();
            return dtc;
        }

        private int RecuperaNrPezzi(int numord)
        {
            string stringaconnessione, sql;
            int NumeroPezzi;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT numero_pezzi FROM dettaglio_ordini_multiriga WHERE numero_ordine=" + numord.ToString() + " AND data_ordine>20190000";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            NumeroPezzi = Convert.ToInt32(comando.ExecuteScalar());    
            connessione.Close();
            return NumeroPezzi;
        }

        private string RecuperaIdFornitore(string codart, int i)
        {
            string stringaconnessione, sql;
            string idf;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT codice_fornitore FROM DettArticoli WHERE codice_articolo ='" + codart.ToString() + "' AND lavorazione=" + i;
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            try
            {
                idf = comando.ExecuteScalar().ToString();
            }
            catch
            {
                idf = "";
            }
            connessione.Close();
            return idf;
        }

        private string RecuperaIDMatPri(string codart, int i)
        {
            string stringaconnessione, sql;
            string idmp;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT codicePrimaStampoDima FROM DettArticoli WHERE codice_articolo ='" + codart.ToString() + "' AND lavorazione=" + i;
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            try
            {
                idmp = comando.ExecuteScalar().ToString();
            }
            catch
            {
                idmp = "LAS.00.000";
            }
            connessione.Close();
            return idmp;
        }

        private int RecuperaNrLasRic(string codart, int i, int NrOrd)
        {
            int AbbinamentoStampo = 0, NrPezziAStampo;
            AbbinamentoStampo = RecuperaAbbinamentoStampo(codart);
            string stringa_connessione;
            stringa_connessione = Properties.Resources.StringaConnessione;
            SqlConnection conn = new SqlConnection(stringa_connessione);
            string query = "Select NrPezziAStampo From DettArticoli Where codice_articolo='" + codart + "' AND lavorazione=2";
            SqlCommand comando = new SqlCommand(query, conn);
            conn.Open();
            try
            {
                NrPezziAStampo = Convert.ToInt32(comando.ExecuteScalar());
            }
            catch
            {
                NrPezziAStampo = 1;
            }
            conn.Close();
            if (true) //(AbbinamentoStampo == 0)
            { 
                int NrPezziRichiesti, Lastre = 0;
                NrPezziRichiesti = RecuperaNrPezzi(NrOrd);
                try
                {
                    Lastre = (int)Math.Ceiling((double)(NrPezziRichiesti / NrPezziAStampo));
                }
                catch (DivideByZeroException e)
                {
                    //MessageBox.Show(e.Message);
                }
                return Lastre;
            }
            //else
            //{
            //    int NrPezziRichiesti, Lastre = 0, PercLastra;
            //    double percentuale;
            //    NrPezziRichiesti = RecuperaNrPezzi(NrOrd);
            //    PercLastra = RecuperaPercentualeLastra(codart);
            //    try
            //    {
            //        percentuale = (double)PercLastra / 100;
            //        Lastre = (int)Math.Ceiling(NrPezziRichiesti * percentuale);
            //        Lastre = (int)Math.Ceiling((double)(Lastre / NrPezziAStampo));
            //    }
            //    catch (DivideByZeroException e)
            //    {
            //        MessageBox.Show(e.Message);
            //    }
            //    return Lastre;
            //}
        }

        private int RecuperaAbbinamentoStampo(string codart)
        {
            int AbbStamp = 0;
            string stringaconnessione, sql;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "select MAX(AbbinamentoStampo) from DettARticoli WHERE codice_articolo = '"+codart+"'";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            try
            {
                AbbStamp = Convert.ToInt32(comando.ExecuteScalar());
            }
            catch
            {
                AbbStamp = 0;
            }
            connessione.Close();
            return AbbStamp;
        }

        private string RecuperaProgTaglio(string codart, int i, int lato)
        {
            string stringaconnessione, sql="", progt;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            if (lato == 1) sql = "SELECT ProgrTaglio1 FROM DettArticoli WHERE codice_articolo='" + codart + "' AND lavorazione=3";
            if (lato == 2) sql = "SELECT ProgrTaglio2 FROM DettArticoli WHERE codice_articolo='" + codart + "' AND lavorazione=3";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            try
            {
                progt = comando.ExecuteScalar().ToString();
            }
            catch
            {
                progt = "Non presente";
            }
            connessione.Close();
            return progt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] import = new int[100];
            int[] date = new int[100];
            int i = 0, j,x=0;
            progressBarAdv1.Maximum = dataGridView5.Rows.Count;
            foreach (DataGridViewRow row in dataGridView5.Rows)
            {
                try
                {
                    if ((bool)(row.Cells["Seleziona"].Value) == true)
                    {
                        import[i] =Convert.ToInt32(row.Cells["Numero"].Value);
                        date[i] = Convert.ToInt32(row.Cells["Data"].Value);
                        i++;
                    }
                }
                catch { }
                x++;
                progressBarAdv1.Value = x;
            }
            for (j=0;j<i;j++)
            {
                Importa(import[j], date[j]);
                AggiornaOrdiniImportati(import[j], date[j]);
                MessageBox.Show("Importato ordine nr. " + import[j].ToString());
            }
            carica();
        }

        private void AggiornaOrdiniImportati(int nord, int dataord)
        {
            //MessageBox.Show("L'articolo "+Cod+" va creato nelle giacenze!");
            Target2021DataSet.OrdiniImportatiRow riga = target2021DataSet.OrdiniImportati.NewOrdiniImportatiRow();
            riga.Anno = Convert.ToInt32(comboBox1.Text);
            riga.Importato = true;
            riga.Numero = nord;
            riga.Data = dataord;
            riga.Articolo = CodiceArt(nord);
            riga.Descrizione = RecuperaDescrizioneArticolo(nord);
            target2021DataSet.OrdiniImportati.Rows.Add(riga);
            ordiniImportatiTableAdapter.Update(target2021DataSet.OrdiniImportati);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] esclusi = new int[100];
            int[] data = new int[100];
            int i = 0, j, x = 0;
            progressBarAdv1.Maximum = dataGridView5.Rows.Count;
            foreach (DataGridViewRow row in dataGridView5.Rows)
            {
                try
                {
                    if ((bool)(row.Cells["Seleziona"].Value) == true)
                    {
                        esclusi[i] = Convert.ToInt32(row.Cells["Numero"].Value);
                        data[i] = Convert.ToInt32(row.Cells["Data"].Value);
                        i++;
                    }
                }
                catch { }
                x++;
                progressBarAdv1.Value = x;
            }
            for (j = 0; j < i; j++)
            {
                //AggiornaOrdiniEsclusi(esclusi[j]);
                ImpostaPesoCliente(esclusi[j], data[j], 2);  // usa il campo peso per settare stato ordine (0=da importare, 1=importato, 2=scontato)
                AggiornaStatoTemporaneo(esclusi[j], data[j], 2);  // Aggiorno anche la tabella locale

            }
            MessageBox.Show("Ho escluso gli ordini selezionati");
            carica();
            //this.ordiniEsclusiTableAdapter.Fill(this.target2021DataSet.OrdiniEsclusi);
        }

        private void AggiornaOrdiniEsclusi(int nord)
        {
            //MessageBox.Show("L'articolo "+Cod+" va creato nelle giacenze!");
            Target2021DataSet.OrdiniEsclusiRow riga = target2021DataSet.OrdiniEsclusi.NewOrdiniEsclusiRow();
            riga.Anno = Convert.ToInt32(comboBox1.Text);
            riga.Stato = 2;  // 2 = escluso
            riga.Numero = nord;
            riga.Data = DateTime.Today;  // Data nel quale è stato escluso
            riga.Articolo = CodiceArt(nord);
            riga.Descrizione = RecuperaDescrizioneArticolo(nord);
            target2021DataSet.OrdiniEsclusi.Rows.Add(riga);
            ordiniEsclusiTableAdapter.Update(target2021DataSet.OrdiniEsclusi);
            ImpostaAliquotaIva2(Convert.ToInt32(comboBox1.Text), nord);
        }

        private void ImpostaAliquotaIva2(int anno,int num)
        {
            string data = anno.ToString() + "0000";
            string stringaconnessione, sql, DesArticolo;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "UPDATE dettaglio_ordini_multiriga SET peso=2 WHERE numero_ordine=" + num.ToString() + " AND data_ordine>'"+data+"'";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            comando.ExecuteNonQuery();
            connessione.Close();
        }

        private void commesseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commesseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }

        private void InserisciCommessa1(Commessa com)
        {
            Target2021DataSet.CommesseRow riga = target2021DataSet.Commesse.NewCommesseRow();

            riga.CodCommessa = com.CodCommessa;
            riga.NrCommessa = com.NrCommessa;
            riga.DataCommessa = com.DataCommessa;
            riga.TipoCommessa = com.TipoCommessa;
            riga.IDCliente = com.IDCliente;
            riga.OrdCliente = com.OrdCliente;
            riga.DataConsegna = com.DataConsegna;
            riga.NrPezziDaLavorare = com.NrPezziDaLavorare;
            riga.CodArticolo = com.CodArticolo;
            riga.DescrArticolo = com.DescrArticolo;
            riga.IDFornitore = com.IDFornitore;
            riga.IDStampo = com.IDMateriaPrima;
            riga.IDDima = com.IDMateriaPrima;
            riga.IDMateriaPrima = IDPrima;
            riga.NrLastreRichieste = com.NrLastreRichieste;
            riga.NrPezziOrdinati = 0;
            riga.NrOrdine = "N";
            riga.Stato = 0;
            riga.ImpegnataMatPrima = 0;
            riga.ProgrTaglio1 = com.ProgrTaglio1;
            riga.ProgrTaglio2 = com.ProgrTaglio2;
            riga.PercentualeUtilizzoLastra = com.PercentualeUtilizzoLastra;
            riga.InSupercommessa = 0;
            riga.NrPezziDaLavorare = com.NrPezziDaLavorare;
            riga.IDMachStampa = com.IDMachStampa;
            riga.ProgStampa = com.ProgStampa;
            riga.PezziOra = com.PezziOra;
            riga.Foto = com.Foto;
            riga.CodArtiDopoStampo = com.CodArtiDopoStampo;
            riga.CodArtiDopoTaglio = com.CodArtiDopoTaglio;
            riga.AttG1 = 0;
            riga.AttG2 = 0;
            riga.AttG3 = 0;
            riga.AttG4 = 0;
            riga.AttG5 = 0;
            riga.Note = com.Note;
            riga.IDMachTaglio = com.IDMachTaglio;
            riga.IDMinuteria = com.IDMinuteria;
            riga.Qtaminuteria = com.Qtaminuteria;

            target2021DataSet.Commesse.Rows.Add(riga); 
            commesseTableAdapter.Update(target2021DataSet.Commesse);
        }
    }
}
