using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Target2021.SelezAna;

namespace Target2021.Anagrafiche
{
    public partial class AnaArticoli : Form
    {
        int t1 = 0;
        int t2 = 0;
        int t3 = 0;

        public AnaArticoli()
        {
            InitializeComponent();
        }

        private void articoli_sempliciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.articoli_sempliciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }

        private void pulisci()
        {
            //comboBox2.Text = "0";
            comboBox3.Text = "LAS.00.000";
            comboBox4.Text = "";
            //comboBox5.Text = "0";
            comboBox6.Text = "STA.00.000";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            comboBox8.Text = "0";
            comboBox9.Text = "0";
            comboBox10.Text = "AAA";
            comboBox11.Text = "AAA.02.001";
            //comboBox12.Text = "0";
            textBox17.Text = "0";
            textBox23.Text = textBox24.Text = textBox25.Text = "0";
            textBox19.Text = textBox20.Text = textBox21.Text = "0";
            label25.Text = "";
            comboBox8.Text = "";
            label26.Text = "";
            comboBox9.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
        }

        private void AnaArticoli_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Stampi'. È possibile spostarla o rimuoverla se necessario.
            this.stampiTableAdapter1.Fill(this.target2021DataSet.Stampi);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.DettArticoli'. È possibile spostarla o rimuoverla se necessario.
            this.dettArticoliTableAdapter.Fill(this.target2021DataSet.DettArticoli);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.MacchineTaglio'. È possibile spostarla o rimuoverla se necessario.
            this.macchineTaglioTableAdapter1.Fill(this.target2021DataSet.MacchineTaglio);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Dime'. È possibile spostarla o rimuoverla se necessario.
            this.dimeTableAdapter.Fill(this.target2021DataSet.Dime);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet8.MacchineTaglio'. È possibile spostarla o rimuoverla se necessario.
            this.macchineTaglioTableAdapter.Fill(this.target2021DataSet.MacchineTaglio);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet4.MacchineStampo'. È possibile spostarla o rimuoverla se necessario.
            this.macchineStampoTableAdapter.Fill(this.target2021DataSet.MacchineStampo);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet3.Fornitori'. È possibile spostarla o rimuoverla se necessario.
            this.fornitoriTableAdapter1.Fill(this.target2021DataSet.Fornitori);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet2.Stampi'. È possibile spostarla o rimuoverla se necessario.
            this.stampiTableAdapter.Fill(this.target2021DataSet.Stampi);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet1.Fasi'. È possibile spostarla o rimuoverla se necessario.
            this.fasiTableAdapter1.Fill(this.target2021DataSet.Fasi);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Fornitori'. È possibile spostarla o rimuoverla se necessario.
            this.fornitoriTableAdapter.Fill(this.target2021DataSet.Fornitori);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Prime'. È possibile spostarla o rimuoverla se necessario.
            this.primeTableAdapter.Fill(this.target2021DataSet.Prime);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Fasi'. È possibile spostarla o rimuoverla se necessario.
            this.fasiTableAdapter.Fill(this.target2021DataSet.Fasi);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.articoli_semplici'. È possibile spostarla o rimuoverla se necessario.
            this.articoli_sempliciTableAdapter.Fill(this.target2021DataSet.articoli_semplici);
            pulisci();
            this.ActiveControl = textBox1;
            WindowState = FormWindowState.Maximized;
            RendiDisable();
        }

        private void Filtra(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Codice") articoli_sempliciBindingSource.Filter = "codice LIKE '*" + textBox1.Text + "*'";
            if (comboBox1.Text == "Descrizione") articoli_sempliciBindingSource.Filter = "descrizione LIKE '*" + textBox1.Text + "*'";
        }

        private void CambiataSelezione(int numero)
        {
            //pulisci();
            int NumeroFasi = 0, lottominimo=0;
            string codice = articoli_sempliciDataGridView.Rows[numero].Cells[0].Value.ToString();
            textBox2.Text = codice;
            string descrizione = articoli_sempliciDataGridView.Rows[numero].Cells[1].Value.ToString();
            textBox3.Text = descrizione;
            string costo = articoli_sempliciDataGridView.Rows[numero].Cells[4].Value.ToString();
            if (costo == "") textBox4.Text = "0"; else textBox4.Text = costo;
            string prezzo = articoli_sempliciDataGridView.Rows[numero].Cells[2].Value.ToString();
            if (prezzo == "") textBox17.Text = "0"; else textBox17.Text = prezzo;
            NumeroFasi = (from row in target2021DataSet.Tables["DettArticoli"].AsEnumerable() where row.Field<string>("codice_articolo").Contains(codice) select row).Count();
            textBox5.Text = NumeroFasi.ToString();
            string imballaggio = articoli_sempliciDataGridView.Rows[numero].Cells[5].Value.ToString();
            textBox18.Text = imballaggio;
            try
            {
                lottominimo =Convert.ToInt32(articoli_sempliciDataGridView.Rows[numero].Cells[7].Value);
            }
            catch
            {
                lottominimo = 0;
            }
            textBox28.Text = lottominimo.ToString();
            string immagine = articoli_sempliciDataGridView.Rows[numero].Cells[6].Value.ToString();
            try
            {
                pictureBox1.Image = new Bitmap(immagine);
            }
            catch
            {
                pictureBox1.Image = Properties.Resources.question_mark;
            }
            AggiornaTab(codice);
        }

        private void articoli_sempliciDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow riga;
            riga = articoli_sempliciDataGridView.CurrentRow;
            if (riga != null) CambiataSelezione(riga.Index);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaContenutoTab1();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaFornitorePrima();
        }

        private void AggiornaFornitorePrima()
        {
            try
            {
                string filtro = "codice='" + comboBox4.Text + "'";
                DataRow[] Fornitore = target2021DataSet.Tables["Fornitori"].Select(filtro);
                label7.Text = Fornitore[0].Field<String>("ragione_sociale");
            }
            catch
            {
                label7.Text = " ";
            }
        }

        private void AggiornaTab(string codice)
        {
            // DA AGGIUNGERE CHE SE LA FASE è ASSENTE VUOTA LE CASELLE E LE METTE IN ENABLE = FALSE
            // ------------------------------------------------------------------------------------
            Tab1(codice);
            Assente(1);
            //Thread.Sleep(200);
            Tab2(codice);
            Assente(2);
            //Thread.Sleep(200);
            Tab3(codice);
            Assente(3);
            //Thread.Sleep(200);
            Tab4(codice);
        }

        private void Assente (int NrTab)
        {
            if (NrTab==1 && comboBox2.Text == "Assente")
            {

            }
            if (NrTab == 2 && comboBox5.Text == "Assente")
            {

            }
            if (NrTab == 3 && comboBox12.Text == "Assente")
            {

            }
        }

        private void articoli_sempliciDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow riga;
            riga = articoli_sempliciDataGridView.CurrentRow;
            if (riga != null) CambiataSelezione(riga.Index);
        }

        private void Tab1(string codice)
        {
            try
            {
                string filtro = "codice_articolo='" + codice + "' AND lavorazione=1";
                DataRow[] Fase1 = target2021DataSet.Tables["DettArticoli"].Select(filtro);
                if (Fase1.Length > 0)
                    comboBox2.Text = "Presente";
                else
                    comboBox2.Text = "Assente";
                //comboBox2.Text = Fase1[0].Field<int>("lavorazione").ToString();
                //comboBox2.Refresh();
                comboBox3.Text = Fase1[0].Field<string>("codicePrimaStampoDima");
                comboBox3.Refresh();
                comboBox4.Text = Fase1[0].Field<string>("codice_fornitore");
                comboBox4.Refresh();
                textBox6.Text = Fase1[0].Field<string>("CodiceInput");
                textBox6.Refresh();
                textBox7.Text = Fase1[0].Field<string>("CodiceOutput");
                textBox7.Refresh();
                textBox8.Text = Fase1[0].Field<int>("LottoMinimoRiordino").ToString();
                textBox8.Refresh();
                comboBox4_SelectedIndexChanged(new object(), new EventArgs());
            }
            catch
            {
                //comboBox2.Text = "0";
                comboBox3.Text = "LAS.00.000";
                comboBox4.Text = "AAA";
                label6.Text = "";
                label7.Text = "";
                //label8.Text = "";
            }
        }

        private void Tab2(string codice)
        {
            try
            {
                string filtro = "codice_articolo='" + codice + "' AND lavorazione=2";
                //target2021DataSet.Tables["DettArticoli"].upda
                DataRow[] Fase2 = target2021DataSet.Tables["DettArticoli"].Select(filtro);
                if (Fase2.Length > 0)
                    comboBox5.Text = "Presente";
                else
                    comboBox5.Text = "Assente";
                comboBox5.Refresh();
                comboBox6.Text = Fase2[0].Field<string>("codicePrimaStampoDima");
                comboBox6.Refresh();
                comboBox7.Text = Fase2[0].Field<string>("codice_fornitore");
                comboBox7.Refresh();
                textBox9.Text = Fase2[0].Field<string>("CodiceInput");
                textBox9.Refresh();
                textBox10.Text = Fase2[0].Field<string>("CodiceOutput");
                textBox10.Refresh();
                textBox11.Text = Fase2[0].Field<int>("PercentualeLastra").ToString();
                textBox11.Refresh();
                //comboBox8.Text = Fase2[0].Field<int>("MacPredefStampo").ToString();
                //comboBox8.Refresh();
                label25.Text= Fase2[0].Field<int>("MacPredefStampo").ToString();
                VisualizzaInComboBox8(label25.Text);
                try
                {
                    textBox12.Text = Fase2[0].Field<int>("AbbinamentoStampo").ToString();
                }
                catch
                {
                    textBox12.Text = "0";
                }
                textBox12.Refresh();
                textBox26.Text = Fase2[0].Field<int>("NrPezziAStampo").ToString();
                textBox26.Refresh();
                textBox27.Text = Fase2[0].Field<int>("TempoStampaggio").ToString();
                textBox27.Refresh();
                try
                {
                    textBox30.Text = Fase2[0].Field<string>("Allegato").ToString();
                    textBox30.Refresh();
                }
                catch
                {
                    textBox30.Text = "Non presente";
                }
                comboBox7_SelectedIndexChanged(new object(), new EventArgs());
                DataRow[] riga;
                riga = target2021DataSet.Tables["Stampi"].Select("codice='" + comboBox6.Text + "'");
                if (riga.Length == 0)
                    MessageBox.Show("Inserire lo Stampo nell'anagrafica stampi");
                try
                {
                    textBox19.Text = riga[0]["Corsia"].ToString();
                    textBox20.Text = riga[0]["Campata"].ToString();
                    textBox21.Text = riga[0]["Posizione"].ToString();
                }
                catch { }
                textBox22.Text = Fase2[0].Field<string>("ProgStampaggio").ToString();
                textBox22.Refresh();
            }

            catch
            {
                //comboBox5.Text = "0";
                //comboBox6.Text = "AAA.01.001";
                //comboBox7.Text = "AAA";
                //comboBox8.Text = "0";
                ////label13.Text = "";
                //label15.Text = "";
                //label18.Text = "";
                //label25.Text = "";
                //label26.Text = "";
            }
        }

        private void VisualizzaInComboBox8(string machstamp)
        {
            int NrMac;
            NrMac = Convert.ToInt32(machstamp);
            String DescrMach;

            string stringaconnessione, sql;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "select Descrizione from MacchineStampo WHERE IdStampa = " + NrMac;
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            try
            {
                DescrMach = comando.ExecuteScalar().ToString();
            }
            catch
            {
                DescrMach = "ERR";
            }
            connessione.Close();
            comboBox8.Text = DescrMach;
        }

        private void VisualizzaInComboBox9(string machTaglio)
        {
            int NrMac;
            NrMac = Convert.ToInt32(machTaglio);
            String DescrMach;

            string stringaconnessione, sql;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "select Descrizione from MacchineTaglio WHERE IDTaglio = " + NrMac;
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            try
            {
                DescrMach = comando.ExecuteScalar().ToString();
            }
            catch
            {
                DescrMach = "ERR";
            }
            connessione.Close();
            comboBox9.Text = DescrMach;
        }

        private void Tab3(string codice)
        {
            try
            {
                // inserita PF 30 aprile 2020
                textBox13.Text = "";
                textBox14.Text = "";
                // fine modifica PF 30 aprile 2020

                string filtro = "codice_articolo='" + codice + "' AND lavorazione=3";
                DataRow[] Fase3 = target2021DataSet.Tables["DettArticoli"].Select(filtro);
                if (Fase3.Length > 0)
                    comboBox12.Text = "Presente";
                else
                    comboBox12.Text = "Assente";
                comboBox12.Refresh();
                comboBox11.Text = Fase3[0].Field<string>("codicePrimaStampoDima");
                comboBox11.Refresh();
                comboBox10.Text = Fase3[0].Field<string>("codice_fornitore");
                comboBox10.Refresh();
                textBox15.Text = Fase3[0].Field<string>("CodiceInput");
                textBox15.Refresh();
                textBox16.Text = Fase3[0].Field<string>("CodiceOutput");
                textBox16.Refresh();
                //comboBox9.Text = Fase3[0].Field<int>("MacPredefTaglio").ToString();
                //comboBox9.Refresh();
                label26.Text = Fase3[0].Field<int>("MacPredefTaglio").ToString();
                VisualizzaInComboBox9(label26.Text);
                textBox13.Text = Fase3[0].Field<string>("ProgrTaglio1").Replace(" ", string.Empty); 
                textBox13.Refresh();
                textBox14.Text = Fase3[0].Field<string>("ProgrTaglio2").Replace(" ", string.Empty);
                textBox14.Refresh();
                comboBox11_SelectedIndexChanged(new object(), new EventArgs());
                comboBox10_SelectedIndexChanged(new object(), new EventArgs());
                DataRow[] riga;
                riga = target2021DataSet.Tables["Dime"].Select("codice='" + comboBox11.Text + "'");
                textBox23.Text = riga[0]["Corsia"].ToString();
                textBox24.Text = riga[0]["Campata"].ToString();
                textBox25.Text = riga[0]["Posizione"].ToString();
            }
            catch
            {
                //comboBox9.Text = "0";
                //comboBox10.Text = "AAA";
                //comboBox11.Text = "AAA.02.001";
                ////comboBox12.Text = "0";
                //label26.Text = "";
                //label32.Text = "";
                //label34.Text = "";
                //label37.Text = "";
            }
        }

        private void Tab4(string codice)
        {
            string filtro = "codice_articolo='" + codice + "' AND lavorazione=4";
            DataRow[] Fase4 = target2021DataSet.Tables["DettArticoli"].Select(filtro);
            
            if (Fase4.Length > 0)
                comboBox13.Text = "Presente";
            else
                comboBox13.Text = "Assente";
            //dataGridView1.DataSource = Fase4;
            dettArticoliBindingSource.Filter = "codice_articolo = '" + codice + "' AND lavorazione=4";
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = "codice='" + comboBox6.SelectedValue + "'";
                DataRow[] Stampo = target2021DataSet.Tables["Stampi"].Select(filtro);
                label15.Text = Stampo[0].Field<String>("descrizione");
                DataRow[] riga;
                riga = target2021DataSet.Tables["Stampi"].Select("codice='" + comboBox6.Text + "'");
                textBox19.Text = riga[0]["Corsia"].ToString();
                textBox20.Text = riga[0]["Campata"].ToString();
                textBox21.Text = riga[0]["Posizione"].ToString();
                comboBox7.Text = riga[0]["codice_fornitore"].ToString();
                AggiornaAnaFornitore();
            }
            catch { }
        }

        private void AggiornaAnaFornitore()
        {
            try
            {
                string filtro = "codice='" + comboBox7.Text.Trim() + "'";
                DataRow[] Fornitore = target2021DataSet.Tables["Fornitori"].Select(filtro);
                label18.Text = Fornitore[0].Field<String>("ragione_sociale");
            }
            catch { }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaAnaFornitore();
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //string filtro = "IdStampa='" + comboBox8.SelectedValue + "'";
                //DataRow[] MPredef = target2021DataSet.Tables["MacchineStampo"].Select(filtro);
                //label25.Text = MPredef[0].Field<String>("Descrizione");
                label25.Text = comboBox8.SelectedValue.ToString();
                //SelectNextControl(ActiveControl, true, true, true, true);
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int CodAbb;
            try
            {
                CodAbb = Convert.ToInt32(textBox12.Text);
                DettAbbinamStampo DAS = new DettAbbinamStampo(CodAbb, textBox2.Text, textBox11.Text, textBox22.Text);
                DAS.ShowDialog();
                textBox12.Text = DAS.CA.ToString();
            }
            catch
            {
                MessageBox.Show("Errore! Forse non esiste la fase 2 per questo articolo!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdFase1, IdFase2, IdFase3, IdFase4;
            string codice = textBox2.Text;

            // Carica i dati corretti in ciascun TAB prima del salvataggio  
            ScorriTab();

            IdFase1 = RecuperaIdFase(codice, 1);
            IdFase2 = RecuperaIdFase(codice, 2);
            IdFase3 = RecuperaIdFase(codice, 3);
            IdFase4 = RecuperaIdFase(codice, 4);
            try
            {
                SalvaGenerale();
                if (IdFase1 >= 0) SalvaTab1(IdFase1);
                if (IdFase2 >= 0 && t2==1) SalvaTab2(IdFase2);
                if (IdFase3 >= 0 && t3==1) SalvaTab3(IdFase3);
                //if (IdFase4 >= 0) SalvaTab4(IdFase4);
                SalvaTab4(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Il salvataggio richiede attenzione: " + ex.Message);
            }

            MessageBox.Show("Il salvataggio è stato effettuato correttamente!");
            RendiDisable();
        }

        private void ScorriTab()
        {

        }

        private int RecuperaIdFase(string cod, int fase)
        {
            int ID;
            DataRow[] riga;
            riga = target2021DataSet.Tables["DettArticoli"].Select("codice_articolo='" + cod + "' AND lavorazione="+fase.ToString());
            try
            {
                ID = Convert.ToInt32(riga[0]["IDDettaglioArticolo"]);
                return ID;
            }
            catch { return -1; }
        }

        private void AggiornaTabulato(object sender, EventArgs e)
        {
            DataGridViewRow riga;
            riga = articoli_sempliciDataGridView.CurrentRow;
            try {
                string codice = articoli_sempliciDataGridView.Rows[riga.Index].Cells[0].Value.ToString();
                AggiornaTab(codice);
            }
            catch
            {
                MessageBox.Show("Errore recupero codice articolo");
            }
            if (tabControl1.SelectedTab.Name == "tabPage2")
            {
                t2 = 1;
            }
            if (tabControl1.SelectedTab.Name == "tabPage3")
            {
                t3 = 1;
            }
        }

        private void AggiornaContenutoTab1()
        {
            try
            {
                string filtro = "codice='" + comboBox3.SelectedValue + "'";
                DataRow[] MatPrima = target2021DataSet.Tables["Prime"].Select(filtro);
                label6.Text = MatPrima[0].Field<String>("descrizione");
                comboBox4.Text = MatPrima[0].Field<String>("codice_fornitore");
                AggiornaFornitorePrima();
            }
            catch
            {
                label6.Text = " ";
            }
        }

        private void AggiornaContenutoTab3()
        {
            try
            {
                string filtro = "codice='" + comboBox11.Text + "'";
                DataRow[] Dima = target2021DataSet.Tables["Dime"].Select(filtro);
                label34.Text = Dima[0].Field<String>("descrizione");
                DataRow[] riga;
                riga = target2021DataSet.Tables["Dime"].Select("codice='" + comboBox11.Text + "'");
                textBox23.Text = riga[0]["Corsia"].ToString();
                textBox24.Text = riga[0]["Campata"].ToString();
                textBox25.Text = riga[0]["Posizione"].ToString();
                comboBox10.Text = riga[0]["codice_fornitore"].ToString();
                AggiornaFornitoreDima();
            }
            catch (Exception ex)
            { //MessageBox.Show(ex.Message); 
            }
        }

        private void AggiornaFornitoreDima()
        {
            try
            {
                string filtro = "codice='" + comboBox10.Text.Trim() + "'";
                DataRow[] Fornitore = target2021DataSet.Tables["Fornitori"].Select(filtro);
                label32.Text = Fornitore[0].Field<String>("ragione_sociale");
            }
            catch { }
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaContenutoTab3();
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaFornitoreDima();
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //string filtro = "IDTaglio='" + comboBox9.SelectedValue + "'";
                //DataRow[] MPredef = target2021DataSet.Tables["MacchineTaglio"].Select(filtro);
                //label26.Text = MPredef[0].Field<String>("Descrizione");
                label26.Text = comboBox9.SelectedValue.ToString();
                //SelectNextControl(ActiveControl, true, true, true, true);
            }
            catch (Exception ex) { //MessageBox.Show(ex.Message); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuovoArticolo nuovo = new NuovoArticolo();
            nuovo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    pictureBox1.Image = new Bitmap(file);
                    articoli_sempliciDataGridView.Rows[articoli_sempliciDataGridView.CurrentRow.Index].Cells[6].Value = file;
                }
                catch { pictureBox1.Image = new Bitmap("C:\\Users\\targe\\Source\\Repos\\Target\\Target2021\\Target2021\\Immagini\\question-mark.jpg"); }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void controllaNumero(object sender, EventArgs e)
        {
            double numero;
            try
            {
                numero = Convert.ToDouble(textBox4.Text);
            }
            catch
            {
                MessageBox.Show("Il valore inserito non è corretto");
                textBox4.Text = "0";
                textBox4.Focus();
            }
        }

        private void SalvaGenerale()
        {
            // Per la testata articoli aggiorna solo Descrizione e Costo Base Produzione
            string codice, descrizione, imballaggio;
            double costo, prezzo;
            int LottoMinimoProduzione;

            codice = textBox2.Text;
            descrizione = textBox3.Text;
            imballaggio = textBox18.Text;
            costo = Convert.ToDouble(textBox4.Text);
            prezzo = Convert.ToDouble(textBox17.Text);
            try
            {
                LottoMinimoProduzione = Convert.ToInt32(textBox28.Text);
            }
            catch
            {
                LottoMinimoProduzione = 0;
            }


            DataRow riga;
            DataTable TabellaArticoli;
            TabellaArticoli = target2021DataSet.Tables["articoli_semplici"];

            riga = TabellaArticoli.Rows.Find(codice);
            riga.BeginEdit();
            riga["descrizione"] = descrizione;
            riga["costo_standard"] = costo;
            riga["prezzo_b"] = prezzo;
            riga["note"] = imballaggio;
            riga["LottoMinimoProduzione"] = LottoMinimoProduzione;
            riga.EndEdit();

            articoli_sempliciTableAdapter.Update(target2021DataSet);
        }

        private void SalvaTab1(int Id)
        {
            // Per Tab1 aggiorna ....
            string codice, CodMateriaPrima, CodFornitoreLastra, CodIn, CodOut, DescrMatPrima;
            int LottoMinimo;

            codice = textBox2.Text;
            CodMateriaPrima  = comboBox3.Text;
            DescrMatPrima = label6.Text;
            CodFornitoreLastra  = comboBox4.Text;
            CodIn = textBox6.Text.Trim(); 
            CodOut = textBox7.Text.Trim();
            try
            {
                LottoMinimo = Convert.ToInt32(textBox8.Text);
            }
            catch
            {
                LottoMinimo = 0;
                MessageBox.Show("Lotto minimo non corretto!");
            }


            DataRow riga;
            DataTable TArticoli;
            TArticoli = target2021DataSet.Tables["DettArticoli"];

            riga = TArticoli.Rows.Find(Id);

            riga.BeginEdit();
            riga["codicePrimaStampoDima"] = CodMateriaPrima;
            riga["descrizionePrimaStampoDima"] = DescrMatPrima;
            riga["codice_fornitore"] = CodFornitoreLastra;
            riga["CodiceInput"] = CodIn;
            riga["CodiceOutput"] = CodOut;
            riga["LottoMinimoRiordino"] = LottoMinimo;
            riga.EndEdit();

            dettArticoliTableAdapter.Update(target2021DataSet);
        }

        private void SalvaTab2(int Id)
        {
            //Per Tab2 aggiorna....
            string codice, ProgrStamp, CodStampo, DescrStampo, CodForn, CodIn, CodOut, Allegato;
            int NrImpronte, Tempo, MachPred, PercLastra;

            codice = textBox2.Text.Trim();
            ProgrStamp = textBox22.Text.Trim();
            MachPred = Convert.ToInt32(label25.Text);
            CodStampo = comboBox6.Text.Trim();
            DescrStampo = label15.Text.Trim();
            CodForn = comboBox7.Text.Trim();
            CodIn = textBox9.Text.Trim();
            CodOut = textBox10.Text.Trim();
            Allegato = textBox30.Text.Trim();
            try
            {
                NrImpronte = Convert.ToInt32(textBox26.Text);
            }
            catch
            {
                NrImpronte = 0;
                MessageBox.Show("Numero impronte a stampo non corretto!");
            }
            try
            {
                Tempo = Convert.ToInt32(textBox27.Text);
            }
            catch
            {
                Tempo = 0;
                MessageBox.Show("Tempo stampaggio non corretto!");
            }
            try
            {
                PercLastra = Convert.ToInt32(textBox11.Text);
            }
            catch
            {
                PercLastra = 0;
                MessageBox.Show("Percentuale utilizzo lastra non corretto!");
            }

            DataRow riga;
            DataTable TArticoli;
            TArticoli = target2021DataSet.Tables["DettArticoli"];

            riga = TArticoli.Rows.Find(Id);
            riga.BeginEdit();
            riga["ProgStampaggio"] = ProgrStamp;
            riga["NrPezziAStampo"] = NrImpronte;
            riga["TempoStampaggio"] = Tempo;
            riga["MacPredefStampo"] = MachPred;
            riga["codicePrimaStampoDima"] = CodStampo;
            riga["descrizionePrimaStampoDima"] = DescrStampo;
            riga["codice_fornitore"] = CodForn;
            if (CodIn.Length > 11) riga["CodiceInput"] = CodIn.Substring(0, 11);
            else riga["CodiceInput"] = CodIn;
            if (CodOut.Length > 11) riga["CodiceOutput"] = CodOut.Substring(0, 11);
            else riga["CodiceOutput"] = CodOut;
            riga["Percentualelastra"] = PercLastra;
            riga["Allegato"] = Allegato;
            riga.EndEdit();

            dettArticoliTableAdapter.Update(target2021DataSet);
            double p3=0;
            try
            {
                p3 = Convert.ToDouble(textBox21.Text);
            }
            catch
            {
                p3 = 0;
                MessageBox.Show("Posizione stampo non corretta!");
            }
            AggiornaPosizioneStampo(CodStampo, textBox19.Text.Trim(), textBox20.Text.Trim(), p3);
        }

        private void SalvaTab3(int Id)
        {
            int MachP;
            string CodDima, DescDim, CodIn, CodOut, CodForn, Prog1, Prog2;

            MachP = Convert.ToInt32(label26.Text);
            CodDima = comboBox11.Text;
            DescDim = label34.Text;
            CodForn = comboBox10.Text;
            CodIn = textBox15.Text.Trim();
            CodOut = textBox16.Text.Trim();
            Prog1 = textBox13.Text.Trim();
            Prog2 = textBox14.Text.Trim();
            DataRow riga;
            DataTable TArticoli;
            TArticoli = target2021DataSet.Tables["DettArticoli"];

            riga = TArticoli.Rows.Find(Id);
            riga.BeginEdit();
            riga["MacPredefTaglio"] = MachP;
            if (CodDima.Length > 11) riga["codicePrimaStampoDima"] = CodDima.Substring(0, 11);
            else riga["codicePrimaStampoDima"] = CodDima;
            riga["descrizionePrimaStampoDima"] = DescDim;
            riga["codice_fornitore"] = CodForn;
            if (CodIn.Length > 11) riga["CodiceInput"] = CodIn.Substring(0, 11);
            else riga["CodiceInput"] = CodIn;
            if (CodOut.Length > 11) riga["CodiceOutput"] = CodOut.Substring(0, 11);
            else riga["CodiceOutput"] = CodOut;
            riga["ProgrTaglio1"] = Prog1;
            riga["ProgrTaglio2"] = Prog2;
            riga.EndEdit();

            dettArticoliTableAdapter.Update(target2021DataSet);

            double p3;
            try
            {
                p3 = Convert.ToDouble(textBox25.Text);
            }
            catch
            {
                p3 = 0;
                MessageBox.Show("Errore nella posizione dello stampo. Posizione 3");
            }
            AggiornaPosizioneDima(CodDima, textBox23.Text, textBox24.Text, p3);
        }

        private void SalvaTab4(int Id)
        {   
            // DA TESTARE *****************************
            this.Validate();
            this.dettArticoliBindingSource.EndEdit();
            dettArticoliTableAdapter.Update(target2021DataSet.DettArticoli);
            //this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }

        private void AggiornaPosizioneStampo(string cod, string p1, string p2, double p3)
        {
            DataRow riga;
            DataTable TPosizioni;
            TPosizioni = target2021DataSet.Tables["Stampi"];

            riga = TPosizioni.Rows.Find(cod);

            riga.BeginEdit();
            riga["Corsia"] = p1;
            riga["Campata"] = p2;
            riga["Posizione"] = p3;
            riga.EndEdit();

            stampiTableAdapter.Update(target2021DataSet);
        }

        private void AggiornaPosizioneDima(string cod, string p1, string p2, double p3)
        {
            DataRow riga;
            DataTable TPosizioni;
            TPosizioni = target2021DataSet.Tables["Dime"];

            riga = TPosizioni.Rows.Find(cod);

            riga.BeginEdit();
            riga["Corsia"] = p1;
            riga["Campata"] = p2;
            riga["Posizione"] = p3;
            riga.EndEdit();

            dimeTableAdapter.Update(target2021DataSet);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                textBox30.Text = file;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(textBox30.Text);
            }
            catch
            {
                MessageBox.Show("Non riesco ad aprire questo file!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler eliminare l'articolo "+textBox2 .Text +"?", "Eliminazione Articolo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string CodArt = textBox2.Text;
                // Elimino le righe da DettArticolo
                DataRow[] Riga = target2021DataSet.DettArticoli.Select("codice_articolo = '" + CodArt + "'");
                foreach (DataRow R in Riga)
                {
                    R.Delete();
                }
                dettArticoliTableAdapter.Update(target2021DataSet.DettArticoli);
                // Elimino le righe la artioli_semplici
                DataRow[] Riga2 = target2021DataSet.articoli_semplici.Select("codice = '" + CodArt + "'");
                foreach (DataRow R in Riga2)
                {
                    R.Delete();
                }
                articoli_sempliciTableAdapter.Update(target2021DataSet.articoli_semplici);
                MessageBox.Show("Articolo eliminato con successo!");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            if (comboBox2 .Text == "Assente")
            {
                DialogResult dialogResult = MessageBox.Show("Vuoi creare una fase 1 per questo articolo?", "Nuova fase", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CreaFase1(textBox2 .Text);
                    comboBox2.Text = "Presente";
                    tabControl1.Refresh();
                    MessageBox.Show("Fase creata!");
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            if (comboBox2.Text == "Presente")
            {
                DialogResult dialogResult = MessageBox.Show("Vuoi eliminare la fase 1 per questo articolo?", "Eliminazione fase", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    EliminaFase1(textBox2.Text);
                    comboBox2.Text = "Assente";
                    tabControl1.Refresh();
                    MessageBox.Show("Fase eliminata!");
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void CreaFase1(string CodArt)
        {
            Target2021DataSet.DettArticoliRow riga = target2021DataSet.DettArticoli.NewDettArticoliRow();
            riga.codice_articolo = CodArt;
            riga.progressivo = 1;
            riga.lavorazione = 1;
            target2021DataSet.DettArticoli.Rows.Add(riga);
            dettArticoliTableAdapter.Update(target2021DataSet.DettArticoli);
        }

        private void EliminaFase1(string CodArt)
        {
            DataRow[] Riga = target2021DataSet.DettArticoli.Select("codice_articolo = '" + CodArt + "' AND lavorazione = 1");
            foreach (DataRow R in Riga)
            {
                R.Delete();
            }
            dettArticoliTableAdapter.Update(target2021DataSet.DettArticoli);
        }

        private void comboBox5_Click(object sender, EventArgs e)
        {
            if (comboBox5.Text == "Assente")
            {
                DialogResult dialogResult = MessageBox.Show("Vuoi creare una fase 2 per questo articolo?", "Nuova fase", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CreaFase2(textBox2.Text);
                    comboBox5.Text = "Presente";
                    MessageBox.Show("Fase creata!");
                    return;
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            if (comboBox5.Text == "Presente")
            {
                DialogResult dialogResult = MessageBox.Show("Vuoi eliminare la fase 2 per questo articolo?", "Eliminazione fase", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    EliminaFase2(textBox2.Text);
                    comboBox5.Text = "Assente";
                    MessageBox.Show("Fase eliminata!");
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void CreaFase2(string CodArt)
        {
            Target2021DataSet.DettArticoliRow riga = target2021DataSet.DettArticoli.NewDettArticoliRow();
            riga.codice_articolo = CodArt;
            riga.progressivo = 2;
            riga.lavorazione = 2;
            target2021DataSet.DettArticoli.Rows.Add(riga);
            dettArticoliTableAdapter.Update(target2021DataSet.DettArticoli);
        }

        private void EliminaFase2(string CodArt)
        {
            DataRow[] Riga = target2021DataSet.DettArticoli.Select("codice_articolo = '" + CodArt + "' AND lavorazione = 2");
            foreach (DataRow R in Riga)
            {
                R.Delete();
            }
            dettArticoliTableAdapter.Update(target2021DataSet.DettArticoli);
        }

        private void comboBox12_Click(object sender, EventArgs e)
        {
            if (comboBox12.Text == "Assente")
            {
                DialogResult dialogResult = MessageBox.Show("Vuoi creare una fase 3 per questo articolo?", "Nuova fase", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CreaFase3(textBox2.Text);
                    comboBox12.Text = "Presente";
                    MessageBox.Show("Fase creata!");
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            if (comboBox12.Text == "Presente")
            {
                DialogResult dialogResult = MessageBox.Show("Vuoi eliminare la fase 3 per questo articolo?", "Eliminazione fase", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    EliminaFase3(textBox2.Text);
                    comboBox12.Text = "Assente";
                    MessageBox.Show("Fase eliminata!");
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void CreaFase3(string CodArt)
        {
            Target2021DataSet.DettArticoliRow riga = target2021DataSet.DettArticoli.NewDettArticoliRow();
            riga.codice_articolo = CodArt;
            riga.progressivo = 3;
            riga.lavorazione = 3;
            target2021DataSet.DettArticoli.Rows.Add(riga);
            dettArticoliTableAdapter.Update(target2021DataSet.DettArticoli);
        }

        private void EliminaFase3(string CodArt)
        {
            DataRow[] Riga = target2021DataSet.DettArticoli.Select("codice_articolo = '" + CodArt + "' AND lavorazione = 3");
            foreach (DataRow R in Riga)
            {
                R.Delete();
            }
            dettArticoliTableAdapter.Update(target2021DataSet.DettArticoli);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox30.Text = "";
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> semilavorati = new List<DataGridViewRow>();
            SelSemilavorato semi = new SelSemilavorato();
            semi.ShowDialog();
            semilavorati = semi.selezionati;
            aggiungi(semilavorati);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> minuteria = new List<DataGridViewRow>();
            SelMinuteria minu = new SelMinuteria();
            minu.ShowDialog();
            minuteria = minu.selezionati;
            aggiungi(minuteria);
        }

        private void aggiungi(List<DataGridViewRow> elenco)
        {
            int MaxProgressivo;
            string progr, descr, cod, CodArt;
            CodArt = textBox2.Text.Trim();
            MaxProgressivo = RecuperaMassimo(CodArt);
            //if (MaxProgressivo == 0) MessageBox.Show("Errore nel recupero nr progressivo massimo");
            foreach (var elemento in elenco)
            {
                MaxProgressivo++;
                progr = MaxProgressivo.ToString();
                descr = elemento.Cells[1].Value.ToString();
                cod = elemento.Cells[0].Value.ToString();
                DataRow riga = target2021DataSet.DettArticoli.NewRow();

                //riga[0] = 2050+MaxProgressivo;
                riga[1] = CodArt;
                riga[2] = progr;
                riga[3] = cod.Trim();
                riga[4] = descr;
                riga[5] = cod.Trim();
                riga[8] = 4;

                target2021DataSet.DettArticoli.Rows.Add(riga);
                //this.dettArticoliTableAdapter.Fill(this.target2021DataSet.DettArticoli);
                dettArticoliDataGridView.Refresh();
            }
        }

        private int RecuperaMassimo(string CodArt)
        {
            int NrUltProgressivo = 0;
            string stringaconnessione, sql;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT MAX(progressivo) FROM DettArticoli WHERE codice_articolo = '"+CodArt+"' AND lavorazione=4";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            try
            {
                NrUltProgressivo = Convert.ToInt32(comando.ExecuteScalar());
            }
            catch
            {
                return 0;
            }
            connessione.Close();
            return NrUltProgressivo;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int t1 = 0;
            int t2 = 0;
            int t3 = 0;
            AggiornaTab(textBox2.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.Text == "Modifica")
            {
                RendiEnable();
                button12.Text = "Chiudi Modifica";
                return;
            }
            if (button12.Text == "Chiudi Modifica")
            {
                RendiDisable();
                button12.Text = "Modifica";
                return;
            }
        }

        private void RendiEnable()
        {
            textBox2.Enabled = false;   // Codice - SEMPRE in sola lettura
            textBox4.Enabled = true;    // Costo di produzione
            textBox17.Enabled = true;   // Prezzo di vendita
            textBox5.Enabled = false;   // Nr. di fasi - SEMPRE in sola lettura
            textBox28.Enabled = true;   // Lotto minimo di produzione
            textBox18.Enabled = true;   // Imballaggio
            button4.Enabled = true;     // Bottone cambio immagine del pezzo
            // TAB 1
            comboBox2.Enabled = true;   // Presente/Assente fase 1
            comboBox3.Enabled = true;   // Codice materia prima
            comboBox4.Enabled = true;   // Codice fornitore lastra
            textBox6.Enabled = false;   // Codice input - Sempre Disabilitato
            textBox7.Enabled = true;    // Codice di output
            textBox8.Enabled = true;    // Lotto minimo di riordino
            // TAB 2 
            comboBox5.Enabled = true;   // Presente/Assente fase 2
            textBox22.Enabled = true;   // Programma di stampaggio
            comboBox8.Enabled = true;   // Macchina predefinita di stampaggio
            comboBox6.Enabled = true;   // Codice stampo
            textBox19.Enabled = true;   // Posizione a magazzino
            textBox20.Enabled = true;   // Posizione a magazzino
            textBox21.Enabled = true;   // Posizione a magazzino
            comboBox7.Enabled = true;   // Codice fornitore stampo
            textBox12.Enabled = true;   // Abbinamento stampo ?
            button2.Enabled = true;     // Bottone di abbinamento stampo
            textBox9.Enabled = true;    // Codice input
            textBox10.Enabled = true;   // Codice output
            textBox11.Enabled = true;   // Percentuale utilizzo lastra
            textBox26.Enabled = true;   // Numero pezzi per stampo
            textBox27.Enabled = true;   // Tempo di stampaggio in secondi
            textBox29.Enabled = true;   // Pezzi all'ora
            textBox30.Enabled = true;   // Percorso dell'allegato
            button6.Enabled = true;     // Gestione dell'allegato
            button5.Enabled = true;     // Gestione dell'allegato
            button8.Enabled = true;     // Gestione dell'allegato
            // TAB 3
            comboBox12.Enabled = true;  // Presente/Assente Fase 3
            comboBox9.Enabled = true;   // Codice macchina di taglio
            comboBox11.Enabled = true;  // Codice dima
            textBox23.Enabled = true;   // Posizione a magazzino
            textBox24.Enabled = true;   // Posizione a magazzino
            textBox25.Enabled = true;   // Posizione a magazzino
            comboBox10.Enabled = true;  // Codice fornitore Dima
            textBox15.Enabled = true;   // Codice Input
            textBox16.Enabled = true;   // Codice Output
            textBox13.Enabled = true;   // Programma di taglio 1
            textBox14.Enabled = true;   // Programma di taglio 2
            // TAB 4
            comboBox13.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
        }

        private void RendiDisable()
        {
            textBox2.Enabled = false;   // Codice - SEMPRE in sola lettura
            textBox4.Enabled = false;    // Costo di produzione
            textBox17.Enabled = false;   // Prezzo di vendita
            textBox5.Enabled = false;   // Nr. di fasi - SEMPRE in sola lettura
            textBox28.Enabled = false;   // Lotto minimo di produzione
            textBox18.Enabled = false;   // Imballaggio
            button4.Enabled = false;     // Bottone cambio immagine del pezzo
            // TAB 1
            comboBox2.Enabled = false;   // Presente/Assente fase 1
            comboBox3.Enabled = false;   // Codice materia prima
            comboBox4.Enabled = false;   // Codice fornitore lastra
            textBox6.Enabled = false;   // Codice input - Sempre Disabilitato
            textBox7.Enabled = false;    // Codice di output
            textBox8.Enabled = false;    // Lotto minimo di riordino
            // TAB 2 
            comboBox5.Enabled = false;   // Presente/Assente fase 2
            textBox22.Enabled = false;   // Programma di stampaggio
            comboBox8.Enabled = false;   // Macchina predefinita di stampaggio
            comboBox6.Enabled = false;   // Codice stampo
            textBox19.Enabled = false;   // Posizione a magazzino
            textBox20.Enabled = false;   // Posizione a magazzino
            textBox21.Enabled = false;   // Posizione a magazzino
            comboBox7.Enabled = false;   // Codice fornitore stampo
            textBox12.Enabled = false;   // Abbinamento stampo ?
            button2.Enabled = false;     // Bottone di abbinamento stampo
            textBox9.Enabled = false;    // Codice input
            textBox10.Enabled = false;   // Codice output
            textBox11.Enabled = false;   // Percentuale utilizzo lastra
            textBox26.Enabled = false;   // Numero pezzi per stampo
            textBox27.Enabled = false;   // Tempo di stampaggio in secondi
            textBox29.Enabled = false;   // Pezzi all'ora
            textBox30.Enabled = false;   // Percorso dell'allegato
            button6.Enabled = false;     // Gestione dell'allegato
            button5.Enabled = false;     // Gestione dell'allegato
            button8.Enabled = false;     // Gestione dell'allegato
            // TAB 3
            comboBox12.Enabled = false;  // Presente/Assente Fase 3
            comboBox9.Enabled = false;   // Codice macchina di taglio
            comboBox11.Enabled = false;  // Codice dima
            textBox23.Enabled = false;   // Posizione a magazzino
            textBox24.Enabled = false;   // Posizione a magazzino
            textBox25.Enabled = false;   // Posizione a magazzino
            comboBox10.Enabled = false;  // Codice fornitore Dima
            textBox15.Enabled = false;   // Codice Input
            textBox16.Enabled = false;   // Codice Output
            textBox13.Enabled = false;   // Programma di taglio 1
            textBox14.Enabled = false;   // Programma di taglio 2
            // TAB 4
            comboBox13.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int IDRiga, esito;
            DataGridViewRow riga;
            riga = dettArticoliDataGridView.SelectedRows[0];
            IDRiga = Convert.ToInt32(riga.Cells["ID"].Value);
            esito=Cancella(IDRiga);
            if (esito==0) MessageBox.Show("Componente eliminato con successo");
            else MessageBox.Show("Problema eliminazione componente");
        }

        private int Cancella(int NrRiga)
        {
            DataRow[] Riga = target2021DataSet.DettArticoli.Select("IDDettaglioArticolo = " + NrRiga.ToString());
            foreach (DataRow R in Riga)
            {
                R.Delete();
            }
            try
            {
                dettArticoliTableAdapter.Update(target2021DataSet.DettArticoli);
                return 0;
            }
            catch
            {
                return 1;
            }
            
        }

        private void comboBox11_TextChanged(object sender, EventArgs e)
        {
            AggiornaContenutoTab3();
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            AggiornaContenutoTab1();
        }
    }
}
