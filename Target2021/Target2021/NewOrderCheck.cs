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

namespace Target2021
{
    public partial class NewOrderCheck : Form
    {
        private int NumOrd, NumTest;

        public NewOrderCheck()
        {
            InitializeComponent();
        }

        private void NewOrderCheck_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);

        }

        private void button1_Click(object sender, EventArgs e)
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
                label4.Text = "Ci sono " + neworder.ToString() + " nuovi ordini!";
                button2.Enabled = true;
            }
                
        }

        private int RecuperaUltimoOrdine()
        {
            string stringaconnessione, sql;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "select NrUltimoOrdineLetto from Configurazione";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            int NrUltOrd = Convert.ToInt32(comando.ExecuteScalar());
            connessione.Close();
            return NrUltOrd;
        }

        private int RecuperaUltimoTestata()
        {
            string stringaconnessione, sql;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT MAX(numero_ordine) FROM testata_ordini_multiriga WHERE data_ordine>20180000";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            int NrUltOrd = Convert.ToInt32(comando.ExecuteScalar());
            connessione.Close();
            return NrUltOrd;
        }

        private int RecuperaUltimoDettaglio()
        {
            string stringaconnessione, sql;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT MAX(numero_ordine) FROM dettaglio_ordini_multiriga WHERE data_ordine>20180000";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            int NrUltOrd = Convert.ToInt32(comando.ExecuteScalar());
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

        private void button2_Click(object sender, EventArgs e)
        {
            int i, IDOrdine, UltimoID, NumFasi, progressivo, NrPezzi, NrLastreRichieste;
            DateTime DataOrdine = DateTime.Now, DataConsegna=DateTime.Now;
            string CodiceArticolo, IDCliente, OrdineCliente, DescrArticolo, IdFornitore, IDMatPrima,PT1,PT2;
            SqlDataReader fasi;
            BindingSource SorgenteDati = new BindingSource();

            do { 
                IDOrdine = RecuperaUltimoOrdine();
                UltimoID = RecuperaUltimoTestata();
                IDOrdine++;
                CodiceArticolo = CodiceArt(IDOrdine);
                textBox4.Text = textBox4.Text + "Ordine numero: " + IDOrdine + "\r\n";
                textBox4.Text = textBox4.Text + "Articolo: " + CodiceArticolo+ "\r\n";
                NumFasi = NumeroFasi(CodiceArticolo);
                textBox4.Text = textBox4.Text + "Questo articolo ha: " + NumFasi.ToString() + " fasi di lavorazione. \r\n";
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
                    textBox4.Text = textBox4.Text + "NrCommessa: " + com.NrCommessa  + "\r\n";
                    textBox4.Text = textBox4.Text + "Data Commessa: " + com.DataCommessa + "\r\n";
                    textBox4.Text = textBox4.Text + "Tipo Commessa: " + com.TipoCommessa + "\r\n";
                    IDCliente = RecuperaIDCliente(IDOrdine);
                    com.IDCliente = IDCliente;
                    OrdineCliente = RecuperaOrdineCliente(IDOrdine);
                    com.OrdCliente = OrdineCliente;
                    DataConsegna = RecuperaDataConsegna(IDOrdine);
                    com.DataConsegna = DataConsegna;
                    NrPezzi = RecuperaNrPezzi(IDOrdine);
                    com.NrPezziDaLavorare=NrPezzi;
                    com.CodArticolo = CodiceArticolo;
                    DescrArticolo = RecuperaDescrizioneArticolo(IDOrdine);
                    com.DescrArticolo = DescrArticolo;
                    IdFornitore = RecuperaIdFornitore(CodiceArticolo, i);
                    com.IDFornitore = IdFornitore;
                    IDMatPrima = RecuperaIDMatPri(CodiceArticolo, i);
                    com.IDMateriaPrima = IDMatPrima;
                    NrLastreRichieste = RecuperaNrLasRic(CodiceArticolo, i, IDOrdine);
                    com.NrLastreRichieste = NrLastreRichieste;
                    PT1 = RecuperaProgTaglio(CodiceArticolo, i, 1);
                    com.ProgrTaglio1 = PT1;
                    PT2 = RecuperaProgTaglio(CodiceArticolo, i, 2);
                    com.ProgrTaglio2 = PT2;
                    InserisciCommessa(com);
                }
                AggiornaUltimoOrdine(IDOrdine, DataOrdine);
            } while (IDOrdine + 1 < IDOrdine+1);  //UltimoID
            commesseDataGridView.Update();
        }

        private string CodiceArt(int numord)
        {
            string stringaconnessione, sql, CodArticolo;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT codice_articolo FROM dettaglio_ordini_multiriga WHERE numero_ordine="+numord.ToString()+" AND data_ordine>20180000";
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
            sql = "SELECT descrizione_articolo FROM dettaglio_ordini_multiriga WHERE numero_ordine=" + numord.ToString() + " AND data_ordine>20180000";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            DesArticolo = comando.ExecuteScalar().ToString();
            connessione.Close();
            return DesArticolo;
        }

        private int NumeroFasi(string codart)
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
            sql = "SELECT data_ordine FROM dettaglio_ordini_multiriga WHERE numero_ordine=" + numord.ToString() + " AND data_ordine>20180000";
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
            sql = "SELECT codice_cliente FROM testata_ordini_multiriga WHERE numero_ordine=" + numord.ToString() + " AND data_ordine>20180000";
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
            sql = "SELECT numero_ordine_cliente FROM testata_ordini_multiriga WHERE numero_ordine=" + numord.ToString() + " AND data_ordine>20180000";
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
            sql = "SELECT data_consegna FROM dettaglio_ordini_multiriga WHERE numero_ordine=" + numord.ToString() + " AND data_ordine>20180000";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            dtc = DateTime.ParseExact(comando.ExecuteScalar().ToString(), "yyyyMMdd", null);
            connessione.Close();
            return dtc;
        }

        private int RecuperaNrPezzi(int numord)
        {
            string stringaconnessione, sql;
            int NumeroPezzi;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT numero_pezzi FROM dettaglio_ordini_multiriga WHERE numero_ordine=" + numord.ToString() + " AND data_ordine>20180000";
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
            sql = "SELECT codice_fornitore FROM DettArticoli WHERE codice_articolo ='" + codart.ToString() + "' AND progressivo=" + i;
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            idf = comando.ExecuteScalar().ToString();
            connessione.Close();
            return idf;
        }

        private string RecuperaIDMatPri(string codart, int i)
        {
            string stringaconnessione, sql;
            string idmp;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT codicePrimaStampoDima FROM DettArticoli WHERE codice_articolo ='" + codart.ToString() + "' AND progressivo=" + i;
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            idmp = comando.ExecuteScalar().ToString();
            connessione.Close();
            return idmp;
        }

        private int RecuperaNrLasRic(string codart, int i, int NrOrd)
        {
            int NrPezziRichiesti, Lastre=0;
            NrPezziRichiesti = RecuperaNrPezzi(NrOrd);
            string stringa_connessione;
            stringa_connessione = Properties.Resources.StringaConnessione;
            SqlConnection conn = new SqlConnection(stringa_connessione);
            string query = "Select PercentualeLastra From DettArticoli Where codice_articolo='" + codart + "' AND lavorazione=1";
            SqlCommand comando = new SqlCommand(query, conn);
            conn.Open();
            int percentuale = Convert.ToInt32(comando.ExecuteScalar());
            try
            {
                double n = 100 / percentuale;
                Lastre = (int)Math.Floor(NrPezziRichiesti / n);
            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show(e.Message);
            }
            conn.Close();
            return Lastre;
        }

        private string RecuperaProgTaglio(string codart, int i, int lato)
        {
            string stringaconnessione, sql="", progt;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            if (lato == 1) sql = "SELECT ProgrTaglio1 FROM DettArticoli WHERE codice_articolo=" + codart + " AND lavorazione=3";
            if (lato == 2) sql = "SELECT ProgrTaglio2 FROM DettArticoli WHERE codice_articolo=" + codart + " AND lavorazione=3";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            progt = comando.ExecuteScalar().ToString();
            connessione.Close();
            return progt;
        }

        private void commesseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commesseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void InserisciCommessa(Commessa com)
        {
            string stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            string sql = "INSERT INTO Commesse (CodCommessa, NrCommessa, DataCommessa, TipoCommessa, IDCliente, OrdCliente, DataConsegna, NrPezziDaLavorare, CodArticolo, DescrArticolo, IDFornitore,IDMateriaPrima, NrLastreRichieste, NrPezziOrdinati, NrOrdine, Stato, ProgrTaglio1, ProgrTaglio2) VALUES (@cod,@nr,@data,@tipo,@idc,@oc,@dtc,@npdl,@codart,@desart,@idf,@idmp,@NrLastreRichieste,@npo,@no,@stato,@prt1,@prt2)";
            SqlCommand comando = new SqlCommand(sql, connessione);
            comando.Parameters.AddWithValue("@cod", com.CodCommessa);
            comando.Parameters.AddWithValue("@nr", com.NrCommessa);
            comando.Parameters.AddWithValue("@data", com.DataCommessa);
            comando.Parameters.AddWithValue("@tipo", com.TipoCommessa);
            comando.Parameters.AddWithValue("@idc", com.IDCliente);
            comando.Parameters.AddWithValue("@oc", com.OrdCliente);
            comando.Parameters.AddWithValue("@dtc", com.DataConsegna);
            comando.Parameters.AddWithValue("@npdl", com.NrPezziDaLavorare);
            comando.Parameters.AddWithValue("@codart", com.CodArticolo);
            comando.Parameters.AddWithValue("@desart", com.DescrArticolo);
            comando.Parameters.AddWithValue("@idf", com.IDFornitore);
            comando.Parameters.AddWithValue("@idmp", com.IDMateriaPrima);
            comando.Parameters.AddWithValue("@NrLastreRichieste", com.NrLastreRichieste);
            comando.Parameters.AddWithValue("@npo", 0);
            comando.Parameters.AddWithValue("@no", 'N');
            comando.Parameters.AddWithValue("@stato", 0);
            comando.Parameters.AddWithValue("@prt1", com.ProgrTaglio1);
            comando.Parameters.AddWithValue("@prt2", com.ProgrTaglio2);
            connessione.Open();
            comando.ExecuteNonQuery();
            connessione.Close();
        }

    }
}
