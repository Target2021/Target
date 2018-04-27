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

namespace Target2021
{
    public partial class LavoraStampaggio : Form
    {
        public String stringa = Properties.Resources.StringaConnessione;
        public string IDCommessa;
        public LavoraStampaggio(string id)
        {
            InitializeComponent();
            IDCommessa = id;
            CheckEvasoParziale();
        }

        private void commesseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }
        private void CheckEvasoParziale()
        {
            string query="SELECT EvasoParziale FROM Commesse WHERE CodCommessa='"+codCommessaTextBox.Text+"'";
            SqlConnection con = new SqlConnection(stringa);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            bool evaso = Convert.ToBoolean(cmd.ExecuteScalar());
            if (!evaso) MessageBox.Show("Prodotto evaso parzialmente precedentemente!");
        }
        private void CheckGiacenza(int id)
        {
            string query = "SELECT GiacenzaDisponibili FROM GiacenzeMagazzini WHERE idPrime=(SELECT IDMateriaPrima FROM Commesse WHERE IDCommessa='" + id + "')";
            string query2="SELECT NrPezziDaLavorare FROM Commesse WHERE IDCommessa='"+id+"'";
            SqlConnection con = new SqlConnection(stringa);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int Giacenza = Convert.ToInt32(cmd.ExecuteScalar());
            cmd = new SqlCommand(query2,con);
            int quantita = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            int diff = Giacenza - quantita;
            if(diff<=0)
            {
                MessageBox.Show("Giacenza insufficiente,impossibile caricare la commessa");
                cCToolStripTextBox.Text = "";
            }
        }
        private void LavoraStampaggio_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Stampi'. È possibile spostarla o rimuoverla se necessario.
            this.stampiTableAdapter.Fill(this.target2021DataSet.Stampi);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.AnaMagazzini'. È possibile spostarla o rimuoverla se necessario.
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            cCToolStripTextBox.Text = IDCommessa;
            SqlConnection connessione = new SqlConnection(stringa);
            string sql = "SELECT descrizione FROM Stampi WHERE codice=(SELECT IDStampo FROM Commesse WHERE IDCommessa='"+IDCommessa+"')";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            string descrizione = comando.ExecuteScalar().ToString();
            connessione.Close();
            label10.Text = descrizione;
            int i =0;
           // RecuperoDati();
            RecuperoDate("SELECT DataCommessa FROM Commesse WHERE IDCommessa='" + IDCommessa + "'",i);
            ImpostaDateTime();
        }

        private void ImpostaDateTime()
        {
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dateTimePicker5.Format = DateTimePickerFormat.Custom;
            dateTimePicker5.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dateTimePicker6.Format = DateTimePickerFormat.Custom;
            dateTimePicker6.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dateTimePicker7.Format = DateTimePickerFormat.Custom;
            dateTimePicker7.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dateTimePicker8.Format = DateTimePickerFormat.Custom;
            dateTimePicker8.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dateTimePicker9.Format = DateTimePickerFormat.Custom;
            dateTimePicker9.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dateTimePicker10.Format = DateTimePickerFormat.Custom;
            dateTimePicker10.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dateTimePicker11.Format = DateTimePickerFormat.Custom;
            dateTimePicker11.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dateTimePicker12.Format = DateTimePickerFormat.Custom;
            dateTimePicker12.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dateTimePicker13.Format = DateTimePickerFormat.Custom;
            dateTimePicker13.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        }
        private void RecuperoDati()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT * FROM Commesse WHERE IDCommessa='"+cCToolStripTextBox.Text+"' AND CodCommessa LIKE 'S%'", stringa);
            DataSet ds = new DataSet();
            da.Fill(ds, "Commesse");
            txt1.DataBindings.Clear();
            txt1.DataBindings.Add("text", ds, "Commesse.IDCommessa");
            codCommessaTextBox.DataBindings.Clear();
            codCommessaTextBox.DataBindings.Add("text", ds, "Commesse.CodCommessa");
            nrCommessaTextBox.DataBindings.Clear();
            nrCommessaTextBox.DataBindings.Add("text", ds, "Commesse.NRCommessa");
            iDClienteTextBox.DataBindings.Clear();
            iDClienteTextBox.DataBindings.Add("text", ds, "Commesse.IDCliente");
            nrPezziDaLavorareTextBox.DataBindings.Clear();
            nrPezziDaLavorareTextBox.DataBindings.Add("text", ds, "Commesse.NRPezziDaLavorare");
            codArticoloTextBox.DataBindings.Clear();
            codArticoloTextBox.DataBindings.Add("text", ds, "Commesse.CodArticolo");
            descrArticoloTextBox.DataBindings.Clear();
            descrArticoloTextBox.DataBindings.Add("text", ds, "Commesse.DescrArticolo");
            nrPezziOrdinatiTextBox.DataBindings.Clear();
            nrPezziOrdinatiTextBox.DataBindings.Add("text", ds, "Commesse.NRPezziOrdinati");
            iDStampoTextBox.DataBindings.Clear();
            iDStampoTextBox.DataBindings.Add("text", ds, "Commesse.IDStampo");
            codArtiDopoStampoTextBox.DataBindings.Clear();
            codArtiDopoStampoTextBox.DataBindings.Add("text", ds, "Commesse.CodArtiDopoStampo");
            nrPezziCorrettiTextBox.DataBindings.Clear();
            nrPezziCorrettiTextBox.DataBindings.Add("text", ds, "Commesse.NRPezziCorretti");
            nrPezziScartatiTextBox.DataBindings.Clear();
            nrPezziScartatiTextBox.DataBindings.Add("text", ds, "Commesse.NRPezziScartati");
           
        }
        public void RecuperoDate(string query,int i)
        {
            for (i = 0; i < 3; i++)
            {
                if(i==0)
                {
                    SqlConnection con = new SqlConnection(stringa);
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    string dateTime = cmd.ExecuteScalar().ToString();
                    DateTime dt = Convert.ToDateTime(dateTime);
                    dateTimePicker1.Value = dt;
                    con.Close();
                }
                if(i==1)
                {
                    query = "SELECT DataConsegna FROM Commesse WHERE IDCommessa='" + IDCommessa + "'";
                    SqlConnection con = new SqlConnection(stringa);
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    string dateTime = cmd.ExecuteScalar().ToString();
                    DateTime dt = Convert.ToDateTime(dateTime);
                    dateTimePicker2.Value = dt;
                    con.Close();
                }
                //if(i==2)
                //{
                //    query = "SELECT DataTermine FROM Commesse WHERE CODCommessa='" + IDCommessa + "'";
                //    SqlConnection con = new SqlConnection(stringa);
                //    SqlCommand cmd = new SqlCommand(query, con);
                //    con.Open();
                //    string dateTime = cmd.ExecuteScalar().ToString();
                //    DateTime dt = Convert.ToDateTime(dateTime);
                //    dateTimePicker3.Value = dt;
                //    con.Close();
                //}
            }
        }
        private void commesseDataGridView_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
          
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void commesseBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            string query = " UPDATE Commesse SET  CodCommessa='"+codCommessaTextBox.Text+"', NrCommessa='"+nrCommessaTextBox.Text+"',IDCliente='"+iDClienteTextBox.Text+"',NrPezziDaLavorare='"+nrPezziDaLavorareTextBox.Text+"',CodArticolo='"+codArticoloTextBox.Text+"',DescrArticolo='"+descrArticoloTextBox.Text+"', IDStampo='"+ iDStampoTextBox.Text+"',CodArtiDopoStampo='"+codArtiDopoStampoTextBox.Text+"',NrPezziCorretti='"+nrPezziCorrettiTextBox.Text+"',NrPezziScartati='"+nrPezziScartatiTextBox.Text+"', DataCommessa='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',DataConsegna='" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "',DataTermine='" + dateTimePicker3.Value.ToString("yyyy-MM-dd") + "' WHERE IDCommessa='"+IDCommessa+"'";
            SqlConnection con = new SqlConnection(stringa);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               RecuperoDati();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           DialogResult dialogResult= MessageBox.Show("Sicuro di voler apportare le seguenti modifiche?","Modifiche",MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                if(evaso.Checked)
                {
                    string query = " UPDATE Commesse SET  CodCommessa='" + Convert.ToString(codCommessaTextBox.Text) + "', NrCommessa='" + Convert.ToString(nrCommessaTextBox.Text) + "',IDCliente='" + Convert.ToString(iDClienteTextBox.Text) + "',NrPezziDaLavorare=" + Convert.ToInt32(nrPezziDaLavorareTextBox.Text) + ",CodArticolo='" + Convert.ToString(codArticoloTextBox.Text) + "',DescrArticolo='" + Convert.ToString(descrArticoloTextBox.Text) + "', IDStampo='" + Convert.ToString(iDStampoTextBox.Text) + "',CodArtiDopoStampo='" + Convert.ToString(codArtiDopoStampoTextBox.Text) + "',NrPezziCorretti = NrPezziCorretti + " + Convert.ToInt32(nrPezziCorrettiTextBox.Text) + ",NrPezziScartati= NrPezziScartati +" + Convert.ToInt32(nrPezziScartatiTextBox.Text) + ", DataCommessa='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',DataConsegna='" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "',DataTermine='" + dateTimePicker3.Value.ToString("yyyy-MM-dd") + "',Stato='" + 2 + "',EvasoParziale= 1 WHERE IDCommessa='" + IDCommessa + "'";
                    SqlConnection con = new SqlConnection(stringa);
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    AggiornaGiacenze();
                    MessageBox.Show("Operazione completata con successo");
                    this.Close();
                }
                else { 
                    string query = " UPDATE Commesse SET  CodCommessa='" + Convert.ToString(codCommessaTextBox.Text) + "', NrCommessa='" + Convert.ToString(nrCommessaTextBox.Text) + "',IDCliente='" + Convert.ToString(iDClienteTextBox.Text) + "',NrPezziDaLavorare=" + Convert.ToInt32(nrPezziDaLavorareTextBox.Text) + ",CodArticolo='" + Convert.ToString(codArticoloTextBox.Text) + "',DescrArticolo='" + Convert.ToString(descrArticoloTextBox.Text) + "', IDStampo='" + Convert.ToString(iDStampoTextBox.Text) + "',CodArtiDopoStampo='" + Convert.ToString(codArtiDopoStampoTextBox.Text) + "',NrPezziCorretti = NrPezziCorretti + " + Convert.ToInt32(nrPezziCorrettiTextBox.Text) + ",NrPezziScartati= NrPezziScartati +" + Convert.ToInt32(nrPezziScartatiTextBox.Text) + ", DataCommessa='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',DataConsegna='" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "',DataTermine='" + dateTimePicker3.Value.ToString("yyyy-MM-dd") + "',Stato='" + 3 + "',EvasoParziale=0 WHERE IDCommessa='" + IDCommessa + "'";
                    SqlConnection con = new SqlConnection(stringa);
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    AggiornaGiacenze();
                    MessageBox.Show("Operazione completata con successo");
                    this.Close();
                }

            }
        }
        private void cCToolStripTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                try
                {
                    CheckGiacenza(Int32.Parse(cCToolStripTextBox.Text));
                }
                catch
                {
                    MessageBox.Show("Controllare ID commessa");
                }
            }
        }
        private void cCToolStripTextBox_Leave(object sender, EventArgs e)
        {
            try {
                CheckGiacenza(Int32.Parse(cCToolStripTextBox.Text));
            } 
            catch
            {
                MessageBox.Show("Controllare ID commessa");
            }
        }
        private void AggiornaLavorazione(object sender, EventArgs e)
        {
            string CodLav,sql, NomeLavorazione;
            CodLav = iDStampoTextBox.Text;
            SqlConnection connessione = new SqlConnection(stringa);
            sql = "SELECT descrizione FROM Fasi WHERE codice=" + CodLav;
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            NomeLavorazione = comando.ExecuteScalar().ToString();
            connessione.Close();
            label10.Text = NomeLavorazione;
        }
        private void iDStampoTextBox_Click(object sender, EventArgs e)
        {
            CambiaStampo(sender,e);
        }
        private void CambiaStampo(object sender, EventArgs e)
        {
            SelezAna.SelStampi selezionastampo = new SelezAna.SelStampi(iDStampoTextBox.Text);
            selezionastampo.FormClosed += new FormClosedEventHandler(ChiudiStampo);
            selezionastampo.Show();
        }
        private void ChiudiStampo(object sender, FormClosedEventArgs e)
        {
            SelezAna.SelStampi sf = (SelezAna.SelStampi)sender;
            string idStampo = sf.CodFase;
            iDStampoTextBox.Text = idStampo;
            SqlConnection connessione = new SqlConnection(stringa);
            string sql = "SELECT descrizione FROM Stampi WHERE codice='" + idStampo+"'";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            string descrizione = comando.ExecuteScalar().ToString();
            connessione.Close();
            label10.Text = descrizione;
        }
        private void AggiornaGiacenze()
        {
            string IDPrime = "";
            int giacimp = 0,idMovimento=0,idMagazzino=0;
            string querysel = "SELECT IDMateriaPrima FROM Commesse WHERE IDCommessa='" + txt1.Text + "'"; // Recupero l'ID conservato nella commessa
            string queryselImpegnati = "SELECT GiacenzaImpegnati FROM GiacenzeMagazzini WHERE idPrime='" + IDPrime + "'";
            string queryupdImpegnati = " UPDATE GiacenzeMagazzini SET GiacenzaImpegnati= GiacenzaImpegnati-"+Convert.ToInt32(LastreEffettive.Text)+"";
            string queryupdComplessiva = " UPDATE GiacenzeMagazzini SET GiacenzaComplessiva= GiacenzaComplessiva-" + Convert.ToInt32(LastreEffettive.Text) + "";
            string queryupdDisponibili = " UPDATE GiacenzeMagazzini SET GiacenzaDisponibili= GiacenzaComplessiva- GiacenzaImpegnati";
            string queryidmovimento = "SELECT MAX(idMovimento) FROM MovimentiMagazzino"; //Recupero l'ultimo id movimento e lo incremento di 1
            SqlConnection con = new SqlConnection(stringa);
            SqlCommand cmd = new SqlCommand(querysel, con);
            con.Open();
            IDPrime = Convert.ToString(cmd.ExecuteScalar());
            IDPrime.Replace(" ", string.Empty);
            cmd.CommandText = queryselImpegnati;
            giacimp=Convert.ToInt32(cmd.ExecuteScalar());
            cmd.CommandText = queryupdImpegnati;
            cmd.ExecuteNonQuery();
            cmd.CommandText = queryupdComplessiva;
            cmd.ExecuteNonQuery();
            cmd.CommandText = queryupdDisponibili;
            cmd.ExecuteNonQuery();
            cmd.CommandText = queryidmovimento;
            idMovimento=Convert.ToInt32(cmd.ExecuteScalar())+1;
            cmd.CommandText = "SELECT idMagazzino FROM GiacenzeMagazzini WHERE idPrime='" + Convert.ToString(IDPrime) + "'";
            idMagazzino =Convert.ToInt16(cmd.ExecuteScalar());
            string queryinsMovimento = "INSERT INTO MovimentiMagazzino (idMovimento,idMagazzino,idPrime,idStampi,CarScar,Quantita,NrOrdine,DataOraMovimento,PesoMateriaPrima,PrezzoComplessivoMateriaPrima) VALUES ('" + idMovimento + "','" + idMagazzino + "','" + IDPrime + "','"+Convert.ToString(iDStampoTextBox.Text)+"','S','" + Convert.ToInt32(LastreEffettive.Text) + "','" + null + "','" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss.fff", CultureInfo.InvariantCulture) + "','" + 0 + "','" + 0 + "')";
            cmd.CommandText = queryinsMovimento;
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();
        }
    }
}
