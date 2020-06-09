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
    public partial class LavoraTaglio_cs : Form
    {
        public string IDCommessa, codice;

        public LavoraTaglio_cs(string ID)
        {
            InitializeComponent();
            IDCommessa = ID;
        }

        private void LavoraTaglio_cs_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.GiacenzeMagazzini'. È possibile spostarla o rimuoverla se necessario.
            this.giacenzeMagazziniTableAdapter.Fill(this.target2021DataSet.GiacenzeMagazzini);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.MovimentiMagazzino'. È possibile spostarla o rimuoverla se necessario.
            this.movimentiMagazzinoTableAdapter.Fill(this.target2021DataSet.MovimentiMagazzino);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Dime'. È possibile spostarla o rimuoverla se necessario.
            this.dimeTableAdapter.Fill(this.target2021DataSet.Dime);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.MacchineTaglio'. È possibile spostarla o rimuoverla se necessario.
            this.macchineTaglioTableAdapter.Fill(this.target2021DataSet.MacchineTaglio);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.clienti'. È possibile spostarla o rimuoverla se necessario.
            this.clientiTableAdapter.Fill(this.target2021DataSet.clienti);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            commesseBindingSource.Filter = "CodCommessa = '" + IDCommessa + "'";
        }

        private void commesseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commesseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Scanna scanner = new Scanna();
            scanner.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nrPezziScartatiTextBox_TextChanged(object sender, EventArgs e)
        {
            calcolapezzi();
        }

        private void calcolapezzi()
        {
            int pztagliati, pzscartati, pzcorretti;
            if (textBox1.Text == "") textBox1.Text = "0";
            if (nrPezziScartatiTextBox.Text == "") nrPezziScartatiTextBox.Text = "0";
            if (nrPezziCorrettiTextBox.Text == "") nrPezziCorrettiTextBox.Text = "0";
            pzcorretti = Convert.ToInt32(nrPezziCorrettiTextBox.Text);
            pzscartati = Convert.ToInt32(nrPezziScartatiTextBox.Text);
            pztagliati = pzcorretti + pzscartati;
            textBox1.Text = pztagliati.ToString();
        }

        private void iDClienteTextBox_TextChanged(object sender, EventArgs e)
        {
            DataRow[] riga;
            string NomeCliente, filtro;
            try
            {
                filtro = "codice='" + iDClienteTextBox.Text.Replace(" ", string.Empty) + "'";
                riga = target2021DataSet.Tables["clienti"].Select(filtro);
                NomeCliente = riga[0]["ragione_sociale"].ToString();
            }
            catch { NomeCliente = "Non trovato!"; }
            label2.Text = NomeCliente;
        }

        private void iDMachTaglioTextBox_TextChanged(object sender, EventArgs e)
        {
            int IdMachT = 0;
            string DescrMachT;
            try
            {
                IdMachT = Convert.ToInt32(iDMachTaglioTextBox.Text);
            }
            catch
            {

            }
            DataRow[] riga;
            try
            {
                riga = target2021DataSet.Tables["MacchineTaglio"].Select("IDTaglio=" + IdMachT.ToString());
                DescrMachT = riga[0]["Descrizione"].ToString();
            }
            catch { DescrMachT = "Non trovata!"; }
            label5.Text = DescrMachT;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Salva();
        }

        private void Salva()
        {
            //this.Validate();
            //this.commesseBindingSource.EndEdit();
            //this.commesseTableAdapter.Update(target2021DataSet.Commesse);
            ////tableAdapterManager.UpdateAll(this.target2021DataSet);
            int IDCommessa, NrPezziCorretti, NrPezziScartati, SecondiCicloTaglio, MinutiAttrezzaggio;
            try
            {
                NrPezziCorretti = Convert.ToInt32(nrPezziCorrettiTextBox.Text);
            }
            catch
            {
                NrPezziCorretti = 0;
            }

            try
            {
                NrPezziScartati = Convert.ToInt32(nrPezziScartatiTextBox.Text);
            }
            catch
            {
                NrPezziScartati = 0;
            }

            try
            {
                SecondiCicloTaglio = Convert.ToInt32(secondiCicloTaglioTextBox.Text);
            }
            catch
            {
                SecondiCicloTaglio = 0;
            }

            try
            {
                MinutiAttrezzaggio = Convert.ToInt32(minutiAttrezzaggioTextBox.Text);
            }
            catch
            {
                MinutiAttrezzaggio = 0;
            }

            IDCommessa = Convert.ToInt32(iDCommessaTextBox.Text);

            DataRow riga;
            DataTable Commesse;
            Commesse = target2021DataSet.Tables["Commesse"];

            riga = Commesse.Rows.Find(IDCommessa);

            riga.BeginEdit();
            riga["NrPezziCorretti"] = NrPezziCorretti;
            riga["NrPezziScartati"] = NrPezziScartati;
            riga["SecondiCicloTaglio"] = SecondiCicloTaglio;
            riga["MinutiAttrezzaggio"] = MinutiAttrezzaggio;
            riga["Stato"] = statoTextBox.Text;
            riga.EndEdit();

            commesseTableAdapter.Update(target2021DataSet);

        }

        private void codCommessaTextBox_TextChanged(object sender, EventArgs e)
        {
            string immagine = fotoTextBox.Text;
            try
            {
                pictureBox1.Image = new Bitmap(immagine);
            }
            catch
            {
                pictureBox1.Image = Properties.Resources.question_mark;
            }
        }

        private void iDDimaTextBox_TextChanged(object sender, EventArgs e)
        {
            string CodDima = iDDimaTextBox.Text;
            string DescDima = RecuperaDescDima(CodDima);
            label4.Text = DescDima;
            try
            {
                AggiornaPosizione(CodDima);
            }
            catch
            { }
        }

        private void AggiornaPosizione(string dima)
        {
            string stringaconnessione, sql, corsia, campata;
            int posizione;
            SqlCommand comando;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            connessione.Open();
            sql = "SELECT Corsia FROM Dime WHERE codice ='" + dima + "'";
            comando = new SqlCommand(sql, connessione);
            corsia = comando.ExecuteScalar().ToString();
            sql = "SELECT Campata FROM Dime WHERE codice ='" + dima + "'";
            comando = new SqlCommand(sql, connessione);
            campata = comando.ExecuteScalar().ToString();
            sql = "SELECT Posizione FROM Dime WHERE codice ='" + dima + "'";
            comando = new SqlCommand(sql, connessione);
            posizione = Convert.ToInt32(comando.ExecuteScalar());
            connessione.Close();
            textBox2.Text = corsia;
            textBox3.Text = campata;
            textBox4.Text = posizione.ToString();
        }

        private string RecuperaDescDima(string Cod)
        {
            DataRow[] riga;
            string Desc;
            try
            {
                riga = target2021DataSet.Tables["Dime"].Select("codice='" + Cod + "'");
                Desc = riga[0]["descrizione"].ToString();
            }
            catch { Desc = "Non trovata!"; }
            return Desc;
        }

        private void nrPezziCorrettiTextBox_TextChanged(object sender, EventArgs e)
        {
            calcolapezzi();
            int qta;
            qta = Convert.ToInt32(nrPezziCorrettiTextBox.Text);
            if (qta > 0) statoTextBox.Text = "1";
            if (qta > 0) evasoParzialeCheckBox.Checked = true;
        }

        private void nrPezziCorrettiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nrPezziScartatiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void minutiAttrezzaggioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int prosegui = 0, errore = 0;  // 0 = No, 1 = Si
            prosegui = MessaggioAvviso();
            if (prosegui == 1)
            {
                errore=CaricaFiniti();                 // OK
                if (errore==0)
                {
                    ScaricaSemilavorati();          // OK
                    VariaGiacenzaFiniti();          // OK
                    VariaGiacenzaSemilavorati();    // OK
                    ChiudiFase();                   // OK
                    MessageBox.Show("Commessa chiusa!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Errore nell'anagrafica articolo! Sistemare manualmente i dati di commessa!");
                    this.Close();
                }
            }
        }

        private int MessaggioAvviso()
        {
            int DaLavorare = 0, Corretti = 0;
            try
            {
                DaLavorare = Convert.ToInt32(nrPezziDaLavorareTextBox.Text);
                Corretti = Convert.ToInt32(nrPezziCorrettiTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Errore nr. pezzi corretti!");
                return 0;
            }
            if (Corretti >= DaLavorare)
                return 1;
            else
            {
                DialogResult dialogResult = MessageBox.Show("Il numero dei pezzi prodotti è inferiore rispetto a quelli da produrre. Procedo comunque ?", "PROCEDO?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    return 1;
                }
                else if (dialogResult == DialogResult.No)
                {
                    return 0;
                }
            }
            return 0;
        }

        private int CaricaFiniti()
        {
            string tipo;
            char c;
            int i, lunghezza, err=0;
            tipo = codArtiDopoTaglioTextBox.Text;
            lunghezza = tipo.Length;
            for (i=0;i<lunghezza;i++)
            {
                c = tipo[i];
                if (c=='.')
                {
                    codice = tipo[i + 1].ToString() + tipo[i + 2].ToString();
                    break;
                }
            }
            if (codice=="08")
            {
                CaricoMagazzino(codice);
            }
            if (codice=="09")
            {
                CaricoMagazzino(codice);
            }
            if (codice!="08" && codice!="09")
            {
                MessageBox.Show("Anomalia, non è né un codice 08 né un codice 09");
                err = 1;
            }
            return err;
        }

        private void CaricoMagazzino(string codmag)
        {
            string CodArt, CodCom, NrCom;
            int qta = Convert.ToInt32(nrPezziCorrettiTextBox.Text);

            Target2021DataSet.MovimentiMagazzinoRow riga = target2021DataSet.MovimentiMagazzino.NewMovimentiMagazzinoRow();

            CodArt = codArtiDopoTaglioTextBox.Text;
            CodCom = codCommessaTextBox.Text;
            NrCom = nrCommessaTextBox.Text;

            if (codmag == "08")
            {
                riga.idMagazzino = 4;
                riga.idSemilavorati = CodArt;
            }      
            if (codmag == "09")
            {
                riga.idMagazzino = 5;
                riga.idArticoli = CodArt;
            }

            riga.CarScar = "C";
            riga.Quantita = qta;
            riga.Barcode = CodCom;
            riga.NrOrdine = NrCom;
            riga.DataOraMovimento = dataTermineDateTimePicker.Value;
            riga.Causale = CodCom;

            target2021DataSet.MovimentiMagazzino.Rows.Add(riga);
            movimentiMagazzinoTableAdapter.Update(target2021DataSet.MovimentiMagazzino);
        }

        private void ScaricaSemilavorati()
        {
            string CodArt, CodCom, NrCom;
            int qta = Convert.ToInt32(textBox1.Text);

            Target2021DataSet.MovimentiMagazzinoRow riga = target2021DataSet.MovimentiMagazzino.NewMovimentiMagazzinoRow();

            CodArt = codArtiDopoStampoTextBox.Text;
            CodCom = codCommessaTextBox.Text;
            NrCom = nrCommessaTextBox.Text;
            riga.idMagazzino = 4;
            riga.idSemilavorati = CodArt;
            riga.CarScar = "S";
            riga.Quantita = qta;
            riga.Barcode = CodCom;
            riga.NrOrdine = NrCom;
            riga.DataOraMovimento = dataTermineDateTimePicker.Value;
            riga.Causale = CodCom;

            target2021DataSet.MovimentiMagazzino.Rows.Add(riga);
            movimentiMagazzinoTableAdapter.Update(target2021DataSet.MovimentiMagazzino);
        }

        private void VariaGiacenzaFiniti()
        {
            string CodArt = codArtiDopoTaglioTextBox.Text;
            int gc, gd;
            int qta = Convert.ToInt32(nrPezziCorrettiTextBox.Text);

            // codice contiene gia o 08 o 09
            DataRow[] RigaTrovata=null;
            if (codice=="08")
            {
                RigaTrovata = target2021DataSet.Tables["GiacenzeMagazzini"].Select("idSemilavorati = '" + CodArt + "'");
            }
            if (codice == "09")
            {
                RigaTrovata = target2021DataSet.Tables["GiacenzeMagazzini"].Select("idArticoli = '" + CodArt + "'");
            }

            if (RigaTrovata.Length != 0)
            {
                // L'articolo esiste nelle giacenze. Aggorna la giacenza
                gc = Convert.ToInt32(RigaTrovata[0]["GiacenzaComplessiva"]);
                gd = Convert.ToInt32(RigaTrovata[0]["GiacenzaDisponibili"]);
                gc = gc + qta;
                gd = gd + qta;
                RigaTrovata[0].BeginEdit();
                RigaTrovata[0]["GiacenzaComplessiva"] = gc;
                RigaTrovata[0]["GiacenzaDisponibili"] = gd;
                RigaTrovata[0].EndEdit();
                giacenzeMagazziniTableAdapter.Update(target2021DataSet.GiacenzeMagazzini);
            }
            else
            {
                // L'articolo va creato nelle giacenze
                Target2021DataSet.GiacenzeMagazziniRow riga = target2021DataSet.GiacenzeMagazzini.NewGiacenzeMagazziniRow();

                if (codice == "08")
                {
                    riga.idMagazzino = 4;
                    riga.idSemilavorati = CodArt;
                }
                else
                {
                    riga.idMagazzino = 5;
                    riga.idArticoli = CodArt;
                }
                riga.GiacenzaComplessiva = qta;
                riga.GiacenzaDisponibili = qta;
                riga.GiacenzaImpegnati = 0;
                riga.DataUltimoMovimento = DateTime.Today;
                riga.GiacenzaOrdinati = 0;
                riga.GiacImpegnSuOrd = 0;
                target2021DataSet.GiacenzeMagazzini.Rows.Add(riga);
                giacenzeMagazziniTableAdapter.Update(target2021DataSet.GiacenzeMagazzini);
            }
        }

        private void VariaGiacenzaSemilavorati()
        {
            string CodArt = codArtiDopoStampoTextBox.Text;
            int gc, gd;
            //int qta = Convert.ToInt32(nrPezziCorrettiTextBox.Text);
            int qta = Convert.ToInt32(textBox1.Text);

            // codice contiene gia o 08 o 09
            DataRow[] RigaTrovata = null;

            RigaTrovata = target2021DataSet.Tables["GiacenzeMagazzini"].Select("idSemilavorati = '" + CodArt + "'");

            if (RigaTrovata.Length != 0)
            {
                // L'articolo esiste nelle giacenze. Aggorna la giacenza
                gc = Convert.ToInt32(RigaTrovata[0]["GiacenzaComplessiva"]);
                gd = Convert.ToInt32(RigaTrovata[0]["GiacenzaDisponibili"]);
                gc = gc - qta;
                gd = gd - qta;
                RigaTrovata[0].BeginEdit();
                RigaTrovata[0]["GiacenzaComplessiva"] = gc;
                RigaTrovata[0]["GiacenzaDisponibili"] = gd;
                RigaTrovata[0].EndEdit();
                giacenzeMagazziniTableAdapter.Update(target2021DataSet.GiacenzeMagazzini);
            }
            else
            {
                MessageBox.Show("C'è qualcosa che non va, non risulta presente a magazzino il semilavorato in ingresso dalla fase di stampaggio, il che dovrebbe essere impossibile");
            }
        }

        private void AggiornaGiacenzaSemilavorato(object sender, EventArgs e)
        {
            string CodSemilavorato;
            CodSemilavorato = codArtiDopoStampoTextBox.Text;
            if (CodSemilavorato.Length>8)
            {
                int pezzi = 0;
                pezzi = RecuperaSemilavoratiDisponibili(CodSemilavorato);
                textBox5.Text = pezzi.ToString();
            }
            else
            {
                textBox5.Text = "Errore recupero giacenza";
            }

        }

        private int RecuperaSemilavoratiDisponibili(string Cod)
        {
            int risultato;
            string filtro = "idSemilavorati = '" + Cod + "'";
            risultato = (int)target2021DataSet.GiacenzeMagazzini.Compute("MAX(GiacenzaDisponibili)", filtro);
            return risultato;
        }

        private void ChiudiFase()
        {
            statoTextBox.Text = "2";
            Salva();
        }
    }
}
