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
        public int macchina;

        public LavoraStampaggio(string id, int mac)
        {
            InitializeComponent();
            IDCommessa = id;
            macchina = mac;
        }

        private void LavoraStampaggio_Load(object sender, EventArgs e)
        {
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
                statoTextBox.Text = "1";
            }             
            else
            {
                evasoParzialeCheckBox.Checked = false;
                statoTextBox.Text = "0";
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
            int statoriga;
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
            int PzDaLavorare = 0, PzLavorati = 0, PzResidui;
            try
            {
                PzDaLavorare = Convert.ToInt32(nrPezziDaLavorareTextBox.Text);
                PzLavorati = Convert.ToInt32(nrPezziCorrettiTextBox.Text);
            }
            catch
            { }
            PzResidui = PzDaLavorare - PzLavorati;
            if (PzResidui > 0)
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
            RigaStampaStato2();
            RigaOFStato4();
            CaricoMagazzino();
            ScaricoLastre();
        }

        private void RigaStampaStato2()
        {
            // Metto la riga (TipoCommessa = 2) in stato = 2 (chiusa)
            statoTextBox.Text = "2";
            Salva();
            button5.BackColor = Color.Green;
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
                MovimentoCS();
                Giacenza();
                button7.BackColor = Color.Green;
            }
        }

        private void MovimentoCS()
        {
            // Registro il Carico in 'MovimentiMagazzino'
            try
            {
                int IdMagazzino, qta, AMagazzino = 0;
                double peso = 0, prezzo = 0;
                string CodArt, CS = "X", BarCode, NrOrdine, Causale;
                DateTime datamov;

                IdMagazzino = 4;
                CodArt = codArtiDopoStampoTextBox.Text;
                Causale = codCommessaTextBox.Text;
                CS = "C";
                qta = Convert.ToInt32(nrPezziCorrettiTextBox.Text);
                BarCode = codCommessaTextBox.Text;
                NrOrdine = nrCommessaTextBox.Text;
                datamov = dataTermineDateTimePicker.Value;
                if (IdMagazzino == 4) movimentiMagazzinoTableAdapter.Insert(IdMagazzino, "", "", "", CodArt, "", CS, qta, BarCode, NrOrdine, datamov, peso, prezzo, Causale);
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
            int numero;
            string query2;
            DateTime ora;
            SqlCommand comando2;
            SqlConnection conn = new SqlConnection(Properties.Resources.StringaConnessione);
            conn.Open();
            string query1 = "SELECT SUM(GiacenzaComplessiva) FROM GiacenzeMagazzini WHERE idSemilavorati='" + Cod + "'";
            SqlCommand comando1 = new SqlCommand(query1, conn);
            try
            {
                numero = (int)comando1.ExecuteScalar();
                numero = numero + q;
                // update
                ora = DateTime.Now;
                query2 = "UPDATE GiacenzeMagazzini SET GiacenzaComplessiva = " + numero.ToString() + ", DataUltimoMovimento = '" + ora.ToString() + "' WHERE idSemilavorati='" + Cod + "'";
                comando2 = new SqlCommand(query2, conn);
                comando2.ExecuteNonQuery();
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
                MessageBox.Show("Materia prima non presente in magazzino. Creata.");
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
                qta = Convert.ToInt32(textBox4.Text);
                BarCode = codCommessaTextBox.Text;
                NrOrdine = nrCommessaTextBox.Text;
                datamov = dataTermineDateTimePicker.Value;
                if (IdMagazzino == 1) movimentiMagazzinoTableAdapter.Insert(IdMagazzino, CodArt, "", "", "", "", CS, qta, BarCode, NrOrdine, datamov, peso, prezzo, Causale);
                movimentiMagazzinoTableAdapter.Fill(this.target2021DataSet.MovimentiMagazzino);
            }
            catch
            {
                MessageBox.Show("Aggiornamento movimento di magazzino fallito!");
            }
        }

        private void GiacenzaLastre()
        {
            int qta = Convert.ToInt32(textBox4.Text);
            string CodArt = iDMateriaPrimaTextBox.Text;
            AggiornaGiacenzeS(qta, CodArt);
        }

        private void AggiornaGiacenzeS(int q, string Cod)
        {
            int numero, disponibili;
            string query2;
            DateTime ora;
            SqlCommand comando2;
            SqlConnection conn = new SqlConnection(Properties.Resources.StringaConnessione);
            conn.Open();
            string query1 = "SELECT SUM(GiacenzaComplessiva) FROM GiacenzeMagazzini WHERE idPrime='" + Cod + "'";
            SqlCommand comando1 = new SqlCommand(query1, conn);
            try
            {
                numero = (int)comando1.ExecuteScalar();
                if (numero > 0)   // articolo già presente nelle giacenze
                {
                    query2 = "SELECT SUM(GiacenzaDisponibili) FROM GiacenzeMagazzini WHERE idPrime='" + Cod + "'";
                    comando2 = new SqlCommand(query2, conn);
                    disponibili = (int)comando2.ExecuteScalar();
                    numero = numero - q;
                    disponibili = disponibili - q;
                    // update
                    ora = DateTime.Now;
                    query2 = "UPDATE GiacenzeMagazzini SET GiacenzaComplessiva = " + numero.ToString() + ", GiacenzaDisponibili = " + disponibili.ToString() + ", DataUltimoMovimento = '" + ora.ToString() + "' WHERE idPrime='" + Cod + "'";
                    comando2 = new SqlCommand(query2, conn);
                    comando2.ExecuteNonQuery();
                    MessageBox.Show("Articolo: " + Cod + " - Giacenza: " + numero.ToString() + " - Disponibili: " + disponibili.ToString());
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

        private void nrPezziCorrettiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.White;
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
    }
}
