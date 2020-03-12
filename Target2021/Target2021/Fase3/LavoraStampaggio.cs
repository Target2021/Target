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
using Target2021.Stampe;
using Target2021.Fase2;
using Target2021.Fase3;

namespace Target2021
{
    public partial class LavoraStampaggio : Form
    {
        public String stringa = Properties.Resources.StringaConnessione;
        public string IDCommessa;
        public int macchina;

        public LavoraStampaggio(string id, int mac)
        {
            InitializeComponent();
            IDCommessa = id;
            macchina = mac;
        }

        private void LavoraStampaggio_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.AbbinamentiSuperCommesse'. È possibile spostarla o rimuoverla se necessario.
            this.abbinamentiSuperCommesseTableAdapter.Fill(this.target2021DataSet.AbbinamentiSuperCommesse);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.GiacenzeMagazzini'. È possibile spostarla o rimuoverla se necessario.
            this.giacenzeMagazziniTableAdapter.Fill(this.target2021DataSet.GiacenzeMagazzini);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.DettArticoli'. È possibile spostarla o rimuoverla se necessario.
            this.dettArticoliTableAdapter.Fill(this.target2021DataSet.DettArticoli);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.clienti'. È possibile spostarla o rimuoverla se necessario.
            this.clientiTableAdapter.Fill(this.target2021DataSet.clienti);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.MovimentiMagazzino'. È possibile spostarla o rimuoverla se necessario.
            this.movimentiMagazzinoTableAdapter.Fill(this.target2021DataSet.MovimentiMagazzino);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.MacchineStampo'. È possibile spostarla o rimuoverla se necessario.
            this.macchineStampoTableAdapter.Fill(this.target2021DataSet.MacchineStampo);
            this.stampiTableAdapter.Fill(this.target2021DataSet.Stampi);
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            commesseBindingSource.Filter = "IDCommessa = '" + IDCommessa + "'";
            ControllaDate();
            schedMachTextBox.Text = macchina.ToString();
            ImpostaSchedaLavorazione();
        }

        private void ImpostaSchedaLavorazione()
        {
            string CodArt, Allegato;
            CodArt = codArticoloTextBox.Text;
            DataRow[] riga;
            riga = target2021DataSet.Tables["DettArticoli"].Select("codice_articolo='" + CodArt + "' AND lavorazione=2");
            try
            {
                Allegato  = Convert.ToString(riga[0]["Allegato"]);
                textBox5.Text = Allegato.ToString();
            }
            catch { textBox5.Text = "Scheda non trovata"; }
        }

        private void ControllaDate()
        {
            int risultato;
            string filtro = "IDCommessa = '" + IDCommessa + "'";
            try
            {
                risultato = (int)target2021DataSet.Commesse.Select(filtro)[0]["AttG1"];
            }
            catch
            {
                Disabilita(1);
            }
            try
            {
                risultato = (int)target2021DataSet.Commesse.Select(filtro)[0]["AttG2"];
            }
            catch
            {
               Disabilita(2);
            }
            try
            {
                risultato = (int)target2021DataSet.Commesse.Select(filtro)[0]["AttG3"];
            }
            catch
            {
                Disabilita(3);
            }
            try
            {
                risultato = (int)target2021DataSet.Commesse.Select(filtro)[0]["AttG4"];
            }
            catch
            {
                Disabilita(4);
            }
            try
            {
                risultato = (int)target2021DataSet.Commesse.Select(filtro)[0]["AttG5"];
            }
            catch
            {
                Disabilita(5);
            }
        }

        private void Disabilita(int gruppo)
        {
            if (gruppo==2)
            {
                button4.Text = "APRI";
                attG2TextBox.Enabled = false;
                oISG2DateTimePicker.Enabled = false;
                oFSG2DateTimePicker.Enabled = false;
                dateTimePicker3.Enabled = false;
                dateTimePicker4.Enabled = false;
            }
            if (gruppo == 3)
            {
                button9.Text = "APRI";
                attG3TextBox.Enabled = false;
                oISG3DateTimePicker.Enabled = false;
                oSFG3DateTimePicker.Enabled = false;
                dateTimePicker5.Enabled = false;
                dateTimePicker6.Enabled = false;
            }
            if (gruppo == 4)
            {
                button10.Text = "APRI";
                attG4TextBox.Enabled = false;
                oISG4DateTimePicker.Enabled = false;
                oFSG4DateTimePicker.Enabled = false;
                dateTimePicker7.Enabled = false;
                dateTimePicker8.Enabled = false;
            }
            if (gruppo == 5)
            {
                button11.Text = "APRI";
                attG5TextBox.Enabled = false;
                oISG5DateTimePicker.Enabled = false;
                oFSG5DateTimePicker.Enabled = false;
                dateTimePicker9.Enabled = false;
                dateTimePicker10.Enabled = false;
            }
        }

        private void iDStampoTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AggiornaPosizione(iDStampoTextBox.Text);
            }
            catch
            { }
        }

        private void AggiornaPosizione(string stampo)
        {
            string stringaconnessione, sql, corsia, campata;
            int posizione;
            SqlCommand comando;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            connessione.Open();
            sql = "SELECT Corsia FROM Stampi WHERE codice ='" + stampo + "'";
            comando = new SqlCommand(sql, connessione);
            corsia = comando.ExecuteScalar().ToString();
            sql = "SELECT Campata FROM Stampi WHERE codice ='" + stampo + "'";
            comando = new SqlCommand(sql, connessione);
            campata = comando.ExecuteScalar().ToString();
            sql = "SELECT Posizione FROM Stampi WHERE codice ='" + stampo + "'";
            comando = new SqlCommand(sql, connessione);
            posizione = Convert.ToInt32(comando.ExecuteScalar());
            connessione.Close();
            textBox1.Text = corsia;
            textBox2.Text = campata;
            textBox3.Text = posizione.ToString ();
        }

        private void iDCommessaTextBox_TextChanged(object sender, EventArgs e)
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

        private void attG1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void attG2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Salva();
            SalvaSchedaInAnArticolo();
        }

        private void Salva()
        {
            this.Validate();
            this.commesseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Salva();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "APRI")
            {
                Abilita(2);
                button4.Text = "SALVA";
                oISG2DateTimePicker.Value = DateTime.Now;
            }
            else
                Salva();
        }

        private void Abilita(int gruppo)
        {
            if (gruppo==2)
            {
                attG2TextBox.Enabled = true;
                oISG2DateTimePicker.Enabled = true;
                oFSG2DateTimePicker.Enabled = true;
                dateTimePicker3.Enabled = true;
                dateTimePicker4.Enabled = true;
            }
            if (gruppo == 3)
            {
                attG3TextBox.Enabled = true;
                oISG3DateTimePicker.Enabled = true;
                oSFG3DateTimePicker.Enabled = true;
                dateTimePicker5.Enabled = true;
                dateTimePicker6.Enabled = true;
            }
        }

        private void schedMachTextBox_TextChanged(object sender, EventArgs e)
        {
            DataRow[] riga;
            string NomeMacchina;   
            try
            {
                riga = target2021DataSet.Tables["MacchineStampo"].Select("IdStampa=" + schedMachTextBox.Text);
                NomeMacchina = riga[0]["Descrizione"].ToString();
            }
            catch { NomeMacchina = "Non trovata!"; }
            label4.Text = NomeMacchina;
        }

        private void nrPezziCorrettiTextBox_TextChanged(object sender, EventArgs e)
        {
            int PzDaLavorare=0, PzLavorati=0, PzResidui;
            try
            {
                PzDaLavorare = Convert.ToInt32(nrPezziDaLavorareTextBox.Text);
                PzLavorati = Convert.ToInt32(nrPezziCorrettiTextBox.Text);
            }
            catch
            {}
            PzResidui = PzDaLavorare - PzLavorati;
            nrPezziResiduiTextBox.Text = PzResidui.ToString();
            if (PzLavorati > 0)
            {
                evasoParzialeCheckBox.Checked = true;
                //statoTextBox.Text = "1";
            }             
            else
            {
                evasoParzialeCheckBox.Checked = false;
                //statoTextBox.Text = "0";
            }
            nrPezziCorrettiTextBox.BackColor = Color.White;
        }

        private int RecuperaStatoRiga()
        {
            int ID;
            DataRow[] riga;
            riga = target2021DataSet.Tables["Commesse"].Select("IDCommessa=" + iDCommessaTextBox .Text);
            try
            {
                ID = Convert.ToInt32(riga[0]["Stato"]);
                return ID;
            }
            catch { return -1; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int statoriga, stato = 0;
            statoriga = RecuperaStatoRiga();
            if (statoriga == 2)
            {
                MessageBox.Show("Fase già chiusa!");
                return;
            }
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            int PzDaLavorare = 0, PzLavorati = 0, PzResidui=0;
            stato = Convert.ToInt32(statoTextBox.Text);
            if (stato!=10)
            {
                try
                {
                    PzDaLavorare = Convert.ToInt32(nrPezziDaLavorareTextBox.Text);
                    PzLavorati = Convert.ToInt32(nrPezziCorrettiTextBox.Text);
                }
                catch
                { }
                PzResidui = PzDaLavorare - PzLavorati;
            }

            if (PzResidui > 0 && stato!=10)
            {
                DialogResult dialogResult = MessageBox.Show("Stai chiudendo la fase di stampaggio senza aver stampato tutti i pezzi richiesti! Sei sicuro di voler procedere?", "Sei sicuro?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ChiudiFase();

                }
                else if (dialogResult == DialogResult.No)
                {
                    // non fa nulla
                }
            }
            else
            {
                ChiudiFase();
            }
        }

        private void ChiudiFase()
        {
            int stato = Convert.ToInt32(statoTextBox.Text);
            if (stato!=10)
            {
                RigaStampaStato2();
                RigaOFStato4();
                CaricoMagazzino();
                ScaricoLastre();
            }
            else
            {
                //MessageBox.Show("Chiudere la supercommessa e tutte le commesse sottostanti");
                PezziSottocommesse ps = new PezziSottocommesse(codCommessaTextBox.Text);
                ps.ShowDialog();

                //MessageBox.Show("IDCOMMEESSAA:" +ps.IDCommesse);
                // Chiudi riga (Stato=2) stampaggio tutte sottocommesse
                RigaStampaStato2Sottocommesse(nrCommessaTextBox.Text);
                //MessageBox.Show("RigaStampaStato2Sottocommesse");
                // Chiudi riga SC (Lavorazione=1 OF) Mettere in Stato 4
                RigaOFStato4();
                //MessageBox.Show("RigaOFStato4");
                // Chiudi riga (Lavorazione=1) sottocommesse ImpegnataMateriaPrima=(calcolo) Mettere in Stato 4
                RigaOFStato4Sottocommesse(nrCommessaTextBox.Text);
                //MessageBox.Show("RigaOFStato4Sottocommesse");
                // Carichi semilavorarti a magazzino -> in RigaStampaStato2Sottocommesse
                // Scarico lastre materia prima
                ScaricoLastre();
                //MessageBox.Show("ScaricoLastre");
                // Chiudi riga SC (Stato=2) (TipoCommessa=2) stampaggio supercommessa
                RigaStampaStato2();

                //ps.Close();
                //MessageBox.Show("Fine RigaStampaStato2");
            }
        }

        private void RigaStampaStato2()
        {
            // Metto la riga (TipoCommessa = 2) in stato = 2 (chiusa)
            statoTextBox.Text = "2";
            Salva();
            button5.BackColor = Color.Green;
        }

        private void RigaStampaStato2Sottocommesse(string IDCom)
        {
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            // Chiudi riga (Stato=2) stampaggio (TipoCommessa=2) tutte sottocommesse
            int[] IDSottocommesse = new int[30];
            int i = 0, j, IdS;
            DataRow[] SottoCommesse;
            SottoCommesse = target2021DataSet.Tables["AbbinamentiSuperCommesse"].Select("IdSuperCommessa = " + IDCom.ToString());
            foreach (DataRow Commessa in SottoCommesse)
            {
                // Estrai IDCommessa
                IDSottocommesse[i] = Convert .ToInt32(Commessa[2]);
                i++;
            }
            // recuperare fase2 // Per ora va bene così poi testare
            for (j=0;j<i;j++)
            {
                IdS = IDSottocommesse[j] + 1;
                RiportaTempiStampaggio(IdS);
                RiportaPezziStampati(IdS);
                SottocommessaStampaggioInStato2(IdS);
            }
            button7.BackColor = Color.Green;
            return;
        }

        private void SottocommessaStampaggioInStato2(int id)
        {
            DataRow riga;
            DataTable TabellaCommesse = target2021DataSet.Tables["Commesse"];
            riga = TabellaCommesse.Rows.Find(id);
            riga.BeginEdit();
            riga["Stato"] = 2;
            riga.EndEdit();
            commesseTableAdapter.Update(target2021DataSet);
        }

        private void RiportaTempiStampaggio(int id)
        {
            int IdSC;
            int Atg1, Atg2, Atg3, Atg4, Atg5;
            DateTime IG1 = new DateTime(2000, 01, 01), FG1 = new DateTime(2000, 01, 01), IG2 = new DateTime(2000, 01, 01), FG2 = new DateTime(2000, 01, 01), IG3 = new DateTime(2000, 01, 01), FG3 = new DateTime(2000, 01, 01);
            DateTime IG4 = new DateTime(2000, 01, 01), FG4 = new DateTime(2000, 01, 01), IG5 = new DateTime(2000, 01, 01), FG5 = new DateTime(2000, 01, 01);
            IdSC = Convert.ToInt32(iDCommessaTextBox.Text);
            // Copiare da SuperCommessa
            DataRow riga;
            DataTable TabellaCommesse = target2021DataSet.Tables["Commesse"];
            riga = TabellaCommesse.Rows.Find(IdSC);
            Atg1 = Convert.ToInt32(riga["AttG1"]);
            Atg2 = Convert.ToInt32(riga["AttG2"]);
            Atg3 = Convert.ToInt32(riga["AttG3"]);
            Atg4 = Convert.ToInt32(riga["AttG4"]);
            Atg5 = Convert.ToInt32(riga["AttG5"]);
            try
            {
                IG1 = Convert.ToDateTime(riga["OISG1"]);
            }
            catch { }
            try
            {
                FG1 = Convert.ToDateTime(riga["OFSG1"]);
            }
            catch { }
            try
            {
                IG2= Convert.ToDateTime(riga["OISG2"]);
            }
            catch { }
            try
            {
                FG2 = Convert.ToDateTime(riga["OFSG2"]);
            }
            catch { }
            try
            {
                IG3 = Convert.ToDateTime(riga["OISG3"]);
            }
            catch { }
            try
            {
                FG3 = Convert.ToDateTime(riga["OSFG3"]);
            }
            catch { }
            try
            {
                IG4 = Convert.ToDateTime(riga["OISG4"]);
            }
            catch { }
            try
            {
                FG4 = Convert.ToDateTime(riga["OFSG4"]);
            }
            catch { }
            try
            {
                IG5 = Convert.ToDateTime(riga["OISG5"]);
            }
            catch { }
            try
            {
                FG5 = Convert.ToDateTime(riga["OFSG5"]);
            }
            catch { }
            // Copiare in SottoCommesse

            DataRow riga1;
            DataTable TabellaCommesse1 = target2021DataSet.Tables["Commesse"];

            riga1 = TabellaCommesse1.Rows.Find(id);
            riga1.BeginEdit();
            riga1["AttG1"] = Atg1;
            riga1["AttG2"] = Atg2;
            riga1["AttG3"] = Atg3;
            riga1["AttG4"] = Atg4;
            riga1["AttG5"] = Atg5;
            riga1["OISG1"] = IG1;
            riga1["OFSG1"] = FG1;
            riga1["OISG2"] = IG2;
            riga1["OFSG2"] = FG2;
            riga1["OISG3"] = IG3;
            riga1["OSFG3"] = FG3;
            riga1["OISG4"] = IG4;
            riga1["OFSG4"] = FG4;
            riga1["OISG5"] = IG5;
            riga1["OFSG5"] = FG5;
            riga1.EndEdit();
            commesseTableAdapter.Update(target2021DataSet);
        }

        private void RiportaPezziStampati(int id)
        {
            int PezziCorretti=0, PezziScartati=0;
            string CodArtDopoStampo;
            // Copiare da Fase1
            DataRow riga;
            MessageBox.Show("ID Commessa :" + id);
            DataTable TabellaCommesse = target2021DataSet.Tables["Commesse"];
            riga = TabellaCommesse.Rows.Find(id-1);
            try
            {
                PezziCorretti = Convert.ToInt32(riga["NrPezziCorretti"]);
                PezziScartati = Convert.ToInt32(riga["NrPezziScartati"]);
                //PezziCorretti = riga.;
            }
            catch
            {
                MessageBox.Show("Errore nel recupero dei pezzi scartati");
            }
            CodArtDopoStampo = riga["CodArtiDopoStampo"].ToString();
            // Copiare in Fase2
            DataRow riga1;
            DataTable TabellaCommesse1 = target2021DataSet.Tables["Commesse"];
            riga1 = TabellaCommesse1.Rows.Find(id);
            riga1.BeginEdit();
            riga1["NrPezziCorretti"] = PezziCorretti;
            riga1["NrPezziScartati"] = PezziScartati;
            riga1.EndEdit();
            commesseTableAdapter.Update(target2021DataSet);
            // MOVIMENTAZIONI MAGAZZINO
            // Registrare Movimento Magazzino
            MovimentoCS(CodArtDopoStampo, PezziCorretti);
            // Registrare Carico Magazzino (Giacenza)
            AggiornaGiacenzeC(PezziCorretti, CodArtDopoStampo);
        }

        private void RigaOFStato4Sottocommesse(string IDCom)
        {
            // Chiudi riga (Stato=4) OF (TipoCommessa=1) tutte sottocommesse
            int[] IDSottocommesse = new int[30];
            int i = 0;
            DataRow[] SottoCommesse;
            SottoCommesse = target2021DataSet.Tables["AbbinamentiSuperCommesse"].Select("IdSuperCommessa = " + IDCom.ToString());
            foreach (DataRow Commessa in SottoCommesse)
            {
                // Estrai IDCommessa
                IDSottocommesse[i] = Convert.ToInt32(Commessa[2]);
                RigaOFStato4S(IDSottocommesse[i]);
                i++;
            }
            return;
        }
        
        private void RigaOFStato4S(int Id)
        {
            DataRow riga;
            DataTable TCommesse = target2021DataSet.Tables["Commesse"];

            riga = TCommesse.Rows.Find(Id);
            riga.BeginEdit();
            riga["Stato"] = 4;
            riga.EndEdit();
            commesseTableAdapter.Update(target2021DataSet);
        }

        private void RigaOFStato4()
        {
            // Metto la riga di OF (TipoCommessa = 1) in stato=4
            int NrCom;
            NrCom = Convert.ToInt32(nrCommessaTextBox.Text);
            string stringaconnessione, sql;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "UPDATE Commesse SET Stato = 4 WHERE TipoCommessa = 1 AND NrCommessa = "+NrCom.ToString();
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            comando.ExecuteNonQuery();
            connessione.Close();
            button6.BackColor = Color.Green;
        }

        private void CaricoMagazzino()
        {
            // Carico a magazzino i semilavorati (nr = NrPezziCorretti)
            string CodDopoStampo;
            CodDopoStampo = codArtiDopoStampoTextBox.Text;
            if (CodDopoStampo.Length <3)
            {
                MessageBox.Show("L'anagrafica di quest'articolo era incompleta! Devi caricare manualmente a magazzino il semilavorato.");
            }
            else
            {
                string CodArt = codArtiDopoStampoTextBox.Text;
                int qta = Convert.ToInt32(nrPezziCorrettiTextBox.Text);
                MovimentoCS(CodArt, qta);
                Giacenza();
                button7.BackColor = Color.Green;
            }
        }

        private void MovimentoCS(string CodArt, int qta)
        {
            // Registro il Carico in 'MovimentiMagazzino'
            try
            {
                int IdMagazzino, AMagazzino = 0;
                double peso = 0, prezzo = 0;
                string CS = "X", BarCode, NrOrdine, Causale;
                DateTime datamov;
                IdMagazzino = 4;
                //CodArt = codArtiDopoStampoTextBox.Text;
                Causale = codCommessaTextBox.Text;
                CS = "C";
                BarCode = codCommessaTextBox.Text;
                NrOrdine = nrCommessaTextBox.Text;
                datamov = dataTermineDateTimePicker.Value;
                if (IdMagazzino == 4) movimentiMagazzinoTableAdapter.Insert(IdMagazzino, "", "", "", CodArt, "", CS, qta, BarCode, NrOrdine, datamov, peso, prezzo, Causale,0,0,0);
                movimentiMagazzinoTableAdapter.Fill(this.target2021DataSet.MovimentiMagazzino);
            }
            catch
            {
                MessageBox.Show("Aggiornamento movimento di magazzino fallito!");
            }
        }

        private void Giacenza()
        {
            // Vario la giacenza in 'GiacenzeMagazzini'
            int pezzi = Convert.ToInt32(nrPezziCorrettiTextBox.Text);
            AggiornaGiacenzeC(pezzi, codArtiDopoStampoTextBox.Text);
        }

        private void AggiornaGiacenzeC(int q, string Cod)
        {
            int numero, numeroDisponibili;
            string query1, query2, query3, query4;
            DateTime ora;
            SqlCommand comando1, comando2, comando3, comando4;
            SqlConnection conn = new SqlConnection(Properties.Resources.StringaConnessione);
            conn.Open();
            // - Del semilavorato aggiorna solo la Giacenza complessiva. Serve aggiornare anche quella disponibile. FATTO - Da Testare
            query1 = "SELECT SUM(GiacenzaComplessiva) FROM GiacenzeMagazzini WHERE idSemilavorati='" + Cod + "'";
            query3 = "SELECT SUM(GiacenzaDisponibili) FROM GiacenzeMagazzini WHERE idSemilavorati='" + Cod + "'";
            comando1 = new SqlCommand(query1, conn);
            comando3 = new SqlCommand(query3, conn); try
            {
                numero = (int)comando1.ExecuteScalar();
                numeroDisponibili = (int)comando3.ExecuteScalar();
                numero = numero + q;
                numeroDisponibili = numeroDisponibili + q;
                // update
                ora = DateTime.Now;
                query2 = "UPDATE GiacenzeMagazzini SET GiacenzaComplessiva = " + numero.ToString() + ", DataUltimoMovimento = '" + ora.ToString() + "' WHERE idSemilavorati='" + Cod + "'";
                query4 = "UPDATE GiacenzeMagazzini SET GiacenzaDisponibili = " + numeroDisponibili.ToString() + ", DataUltimoMovimento = '" + ora.ToString() + "' WHERE idSemilavorati='" + Cod + "'";
                comando2 = new SqlCommand(query2, conn);
                comando2.ExecuteNonQuery();
                comando4 = new SqlCommand(query4, conn);
                comando4.ExecuteNonQuery();
                MessageBox.Show("Articolo: " + Cod + " - Giacenza: " + numero.ToString());
            }
            catch
            {
                numero = q;
                // insert
                ora = DateTime.Now;
                query2 = "INSERT INTO GiacenzeMagazzini (idMagazzino, idSemilavorati, GiacenzaComplessiva, GiacenzaDisponibili, GiacenzaImpegnati, DataUltimoMovimento, GiacenzaOrdinati, GiacImpegnSuOrd) VALUES (1, '" + Cod + "', " + numero.ToString() + ", " + numero.ToString() + ", 0, '" + ora.ToString() + "',0 ,0)";
                comando2 = new SqlCommand(query2, conn);
                comando2.ExecuteNonQuery();
                MessageBox.Show("Semilavorato non presente in magazzino. Creato.");
                MessageBox.Show("Articolo: " + Cod + " - Giacenza: " + numero.ToString());
            }
            conn.Close();
        }

        private void ScaricoLastre()
        {
            // Scarico da magazzino il nr delle lastre usate (nr = ?)
            // Movimento + Giacenza
            MovimentoScaricoLastre();
            GiacenzaLastre();
            button8.BackColor = Color.Green;
        }

        private void MovimentoScaricoLastre()
        {
            try
            {
                int IdMagazzino, qta=0;
                double peso = 0, prezzo = 0;
                string CodArt, CS = "X", BarCode, NrOrdine, Causale;
                DateTime datamov;

                IdMagazzino = 1;
                CodArt = iDMateriaPrimaTextBox.Text;
                Causale = codCommessaTextBox.Text;
                CS = "S";
                qta = Convert.ToInt32(nrLastreUtilizzateTextBox.Text);   //textBox4.Text);
                BarCode = codCommessaTextBox.Text;
                NrOrdine = nrCommessaTextBox.Text;
                datamov = dataTermineDateTimePicker.Value;
                if (IdMagazzino == 1) movimentiMagazzinoTableAdapter.Insert(IdMagazzino, CodArt, "", "", "", "", CS, qta, BarCode, NrOrdine, datamov, peso, prezzo, Causale,0,0,0);
                movimentiMagazzinoTableAdapter.Fill(this.target2021DataSet.MovimentiMagazzino);
            }
            catch
            {
                MessageBox.Show("Aggiornamento movimento di magazzino fallito!");
            }
        }

        private void GiacenzaLastre()
        {
            int qta = Convert.ToInt32(nrLastreUtilizzateTextBox.Text);  //textBox4.Text);
            int PezzidaLavorare = Convert.ToInt32(nrPezziDaLavorareTextBox.Text);
            string CodArt = iDMateriaPrimaTextBox.Text;
            AggiornaGiacenzeS(qta, CodArt, PezzidaLavorare);
        }

        private void AggiornaGiacenzeS(int q, string Cod, int DaLavorare)
        {
            int numero, impegnati, ImpegnataMateriaPrima, disponibili;
            string query2;
            DateTime ora;
            SqlCommand comando2;
            SqlConnection conn = new SqlConnection(Properties.Resources.StringaConnessione);
            conn.Open();
            string query1 = "SELECT SUM(GiacenzaComplessiva) FROM GiacenzeMagazzini WHERE idPrime='" + Cod + "'";
            disponibili = RecuperaLastreDisponibili();
            ImpegnataMateriaPrima = RecuperaNrLastreImpegnate();
            SqlCommand comando1 = new SqlCommand(query1, conn);
            try
            {
                numero = (int)comando1.ExecuteScalar();
                if (numero > 0)   // articolo già presente nelle giacenze
                {
                    query2 = "SELECT SUM(GiacenzaImpegnati) FROM GiacenzeMagazzini WHERE idPrime='" + Cod + "'";
                    comando2 = new SqlCommand(query2, conn);
                    impegnati = (int)comando2.ExecuteScalar();
                    numero = numero - q;
                    // impegnati = impegnati - ImpegnataMateriaPrima;   versione precedente
                    impegnati = impegnati - q + (q-DaLavorare);  // versione 10 marzo 2020
                    // disponibili = disponibili + ImpegnataMateriaPrima - q;    Versione precedente
                    disponibili = disponibili - (q-DaLavorare);  // versione 10 marzo 2020
                    // update
                    ora = DateTime.Now;
                    query2 = "UPDATE GiacenzeMagazzini SET GiacenzaComplessiva = " + numero.ToString() + ", GiacenzaImpegnati = " + impegnati.ToString() + ", GiacenzaDisponibili = " + disponibili.ToString() + ", DataUltimoMovimento = '" + ora.ToString() + "' WHERE idPrime='" + Cod + "'";
                    comando2 = new SqlCommand(query2, conn);
                    comando2.ExecuteNonQuery();
                    MessageBox.Show("Articolo: " + Cod + " - Giacenza: " + numero.ToString());
                }
            }
            catch
            {
                numero = 0;
                disponibili = 0;
                // insert
                ora = DateTime.Now;
                query2 = "INSERT INTO GiacenzeMagazzini (idMagazzino, idPrime, GiacenzaComplessiva, GiacenzaDisponibili, GiacenzaImpegnati, DataUltimoMovimento, GiacenzaOrdinati, GiacImpegnSuOrd) VALUES (1, '" + Cod + "', " + numero.ToString() + ", " + disponibili.ToString() + ", 0, '" + ora.ToString() + "',0 ,0)";
                comando2 = new SqlCommand(query2, conn);
                comando2.ExecuteNonQuery();
                MessageBox.Show("Materia prima non presente in magazzino. Creata. Scarico = 0!");
                MessageBox.Show("Articolo: " + Cod + " - Giacenza: " + numero.ToString() + " - Disponibili: " + disponibili.ToString());
            }
            conn.Close();
        }

        private int RecuperaNrLastreImpegnate()
        {
            string CodCommessa = codCommessaTextBox.Text;
            if (CodCommessa.Substring(0,2)!="SC") CodCommessa.Replace("S", "OF");
            CodCommessa = CodCommessa.Trim();
            int risultato;
            string filtro = "CodCommessa = '" + CodCommessa + "'";
            risultato = (int)target2021DataSet.Commesse.Compute("MAX(ImpegnataMatPrima)", filtro);
            return risultato;
        }

        private int RecuperaLastreDisponibili()
        {
            string CodLastra = iDMateriaPrimaTextBox.Text;
            int risultato;
            string filtro = "idPrime = '" + CodLastra + "'";
            risultato = (int)target2021DataSet.GiacenzeMagazzini.Compute("MAX(GiacenzaDisponibili)", filtro);
            return risultato;
        }

        private void nrPezziCorrettiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nrPezziScartatiTextBox_TextChanged(object sender, EventArgs e)
        {
            nrPezziScartatiTextBox.BackColor = Color.White;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(textBox5.Text);
            }
            catch
            {
                MessageBox.Show("Non riesco ad aprire questo file!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "APRI")
            {
                Abilita(3);
                button9.Text = "SALVA";
                oISG3DateTimePicker.Value = DateTime.Now;
            }
            else
                Salva();
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
            label16.Text = NomeCliente;
        }

        private void fotoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                textBox5.Text = file;
            }
            SalvaSchedaInAnArticolo();
        }

        private void SalvaSchedaInAnArticolo()
        {
            string PercorsoScheda;
            PercorsoScheda = textBox5.Text;
            int ID;
            DataRow[] riga;
            riga = target2021DataSet.Tables["DettArticoli"].Select("codice_articolo='" + codArticoloTextBox.Text + "' AND lavorazione=2");
            try
            {
                riga[0]["Allegato"] = PercorsoScheda;
                riga[0].EndEdit();
                dettArticoliTableAdapter.Update(target2021DataSet);
            }
            catch { }
        }

        private void nrLastreUtilizzateTextBox_TextChanged(object sender, EventArgs e)
        {
            nrLastreUtilizzateTextBox.BackColor = Color.White;
        }

        private void nrLastreUtilizzateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Formato A4
            // CodCommessa (ad es. S55)
            // CodArticolo uscita fase stampaggio (ad es. ITA.04.033) (+ grande)
            // Descrizione articolo -> (ad es. pinco pallino)
            // Quantità -> far inserire manualmente all'operatore (>0) + grande)
            string CodCommessa = codCommessaTextBox.Text;
            string CodArticolo = codArtiDopoStampoTextBox.Text;
            string DescArticolo = descrArticoloTextBox.Text;
            //string Qta = nrPezziCorrettiTextBox.Text;
            string Qta = Microsoft.VisualBasic.Interaction.InputBox("Quantità pezzi sul bancale?", "NUMERO PEZZI", "1", -1, -1);
            SSemilavorati stampa = new SSemilavorati(CodCommessa, CodArticolo, DescArticolo, Qta);
            stampa.Show();
        }

        private void statoTextBox_TextChanged(object sender, EventArgs e)
        {
            int stato = Convert.ToInt32(statoTextBox.Text);
            if (stato == 10)
            {
                button15.Visible = true;
                nrPezziCorrettiTextBox.Visible = false;
                nrPezziScartatiTextBox.Visible = false;
            }
            else
            {
                button15.Visible = false;
                nrPezziCorrettiTextBox.Visible = true;
                nrPezziScartatiTextBox.Visible = true;
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            ElencoCommesseInSC elenco = new ElencoCommesseInSC(codCommessaTextBox.Text);
            elenco.ShowDialog();
        }
    }
}
