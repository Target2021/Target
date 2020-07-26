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

namespace Target2021.Anagrafiche
{
    public partial class NuovoArticolo : Form
    {
        public NuovoArticolo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txtPercorso.Text = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int corretto;
            corretto = ControllaCampi();
            if (corretto==1)
            {
                Target2021DataSet.articoli_sempliciRow riga = target2021DataSet.articoli_semplici.Newarticoli_sempliciRow();
                riga.codice = txtCodice.Text;
                try
                {   
                    riga.prezzo_b = Convert .ToDouble(txtPrezzo.Text);
                }
                catch
                {
                    MessageBox.Show("Errore nel prezzo dell'articolo!");
                    riga.prezzo_b = 0;
                }
                riga.unita_misura = comboUnita.Text;
                try
                {
                    riga.costo_standard = Convert.ToDouble(textBox1.Text);
                }
                catch
                {
                    MessageBox.Show("Errore nel costo dell'articolo!");
                    riga.costo_standard = 0;
                }
                riga.descrizione = txtDesc.Text;
                riga.note = txtNote.Text;
                riga.indirizzo_immagine = txtPercorso.Text;
                try
                {
                    target2021DataSet.articoli_semplici.Rows.Add(riga);
                    articoli_sempliciTableAdapter.Update(target2021DataSet.articoli_semplici);
                    SalvaTab1();
                    SalvaTab2();
                    SalvaTab3();
                    MessageBox.Show("Articolo inserito correttamente!");
                }
                catch (Exception err)
                {
                    MessageBox.Show("Errore inserimento articolo! "+err.Message);
                }
            }
            else
            {
                MessageBox.Show("Compilare i campi obbligatori!");
            }
        }

        private int ControllaCampi()
        {
            int rit = 1;
            if (comboBox2.Text == "")
            {
                rit = 0;  // fase 1
                comboBox2.BackColor = Color.OrangeRed;
            }
            if (comboBox5.Text == "")
            {
                rit = 0;  // fase 2
                comboBox5.BackColor = Color.OrangeRed;
            }
            if (comboBox12.Text == "")
            {
                rit = 0; // fase 3
                comboBox12.BackColor = Color.OrangeRed;
            }
            if (comboBox1.Text == "")
            {
                rit = 0;  // fase 4
                comboBox1.BackColor = Color.OrangeRed;
            }
            return rit;   // ritorna 1 se tutti i campi obbligatori sono compilati, altrimenti ritorna 0
        }

        private void SalvaTab1()
        {
            if (comboBox2 .Text == "Presente")
            {
                Target2021DataSet.DettArticoliRow riga = target2021DataSet.DettArticoli.NewDettArticoliRow();
                riga.codice_articolo = txtCodice.Text;
                riga.progressivo = 1;
                riga.codicePrimaStampoDima = comboBox3.Text;
                riga.descrizionePrimaStampoDima = label13.Text;
                riga.CodiceOutput = textBox7.Text;
                riga.codice_fornitore = comboBox4.Text;
                riga.lavorazione = 1;
                riga.LottoMinimoRiordino =Convert.ToInt32(textBox8.Text);
                target2021DataSet.DettArticoli.Rows.Add(riga);      
                dettArticoliTableAdapter1.Update(target2021DataSet.DettArticoli);
                textBox2.Text = textBox2.Text + " Fase 1 ok";
            }
        }

        private void SalvaTab2()
        {
            if (comboBox5.Text == "Presente")
            {
                Target2021DataSet.DettArticoliRow riga = target2021DataSet.DettArticoli.NewDettArticoliRow();
                riga.codice_articolo = txtCodice.Text;
                riga.progressivo = 2;
                riga.codicePrimaStampoDima = comboBox6.Text;
                riga.descrizionePrimaStampoDima = label17.Text;
                riga.CodiceInput = textBox9.Text;
                riga.CodiceOutput = textBox10.Text;
                riga.codice_fornitore = comboBox7.Text;
                riga.lavorazione = 2;
                riga.PercentualeLastra = Convert.ToInt32(textBox11.Text);
                riga.MacPredefStampo = Convert.ToInt32(comboBox8.Text);
                riga.AbbinamentoStampo = Convert.ToInt32(textBox12.Text);
                riga.ProgStampaggio = textBox22.Text;
                riga.TempoStampaggio = Convert.ToInt32(textBox27.Text);
                riga.NrPezziAStampo = Convert.ToInt32(textBox26.Text);
                target2021DataSet.DettArticoli.Rows.Add(riga);
                dettArticoliTableAdapter1.Update(target2021DataSet.DettArticoli);
                textBox2.Text = textBox2.Text + " Fase 2 ok";
            }
        }

        private void SalvaTab3()
        {
            if (comboBox12.Text == "Presente")
            {
                Target2021DataSet.DettArticoliRow riga = target2021DataSet.DettArticoli.NewDettArticoliRow();
                riga.codice_articolo = txtCodice.Text;
                riga.progressivo = 3;
                riga.codicePrimaStampoDima = comboBox11.Text.Substring(0, 10);
                riga.descrizionePrimaStampoDima = label37.Text;
                riga.CodiceInput = textBox15.Text;
                riga.CodiceOutput = textBox16.Text;
                riga.codice_fornitore = comboBox10.Text;
                riga.lavorazione = 3;
                riga.MacPredefTaglio = Convert.ToInt32(comboBox9.Text);
                riga.ProgrTaglio1 = textBox13.Text;
                riga.ProgrTaglio2 = textBox14.Text;
                target2021DataSet.DettArticoli.Rows.Add(riga);
                dettArticoliTableAdapter1.Update(target2021DataSet.DettArticoli);
                textBox2.Text = textBox2.Text + " Fase 3 ok";
            }
        }

        private void SalvaTab4()
        {
            if (comboBox1.Text == "Presente")
            {

            }
        }
        private void articoli_sempliciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.articoli_sempliciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void NuovoArticolo_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.DettArticoli'. È possibile spostarla o rimuoverla se necessario.
            this.dettArticoliTableAdapter1.Fill(this.target2021DataSet.DettArticoli);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Dime'. È possibile spostarla o rimuoverla se necessario.
            this.dimeTableAdapter.Fill(this.target2021DataSet.Dime);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.MacchineTaglio'. È possibile spostarla o rimuoverla se necessario.
            this.macchineTaglioTableAdapter.Fill(this.target2021DataSet.MacchineTaglio);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Stampi'. È possibile spostarla o rimuoverla se necessario.
            this.stampiTableAdapter.Fill(this.target2021DataSet.Stampi);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.MacchineStampo'. È possibile spostarla o rimuoverla se necessario.
            this.macchineStampoTableAdapter.Fill(this.target2021DataSet.MacchineStampo);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Fornitori'. È possibile spostarla o rimuoverla se necessario.
            this.fornitoriTableAdapter.Fill(this.target2021DataSet.Fornitori);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Prime'. È possibile spostarla o rimuoverla se necessario.
            this.primeTableAdapter.Fill(this.target2021DataSet.Prime);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.articoli_semplici'. È possibile spostarla o rimuoverla se necessario.
            this.articoli_sempliciTableAdapter.Fill(this.target2021DataSet.articoli_semplici);
            MessageBox.Show("Ricordati che per inserire un nuovo articolo serve che siano presenti Stampi e Dime nelle rispettive anagrafiche");
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox7.Text = comboBox3.Text;
            textBox9.Text = comboBox3.Text;
            try
            {
                string filtro = "codice='" + comboBox3.SelectedValue + "'";
                DataRow[] MatPrima = target2021DataSet.Tables["Prime"].Select(filtro);
                comboBox4.Text = MatPrima[0].Field<String>("codice_fornitore");
                AggiornaFornitorePrima();
            }
            catch
            {
                label6.Text = " ";
            }
        }

        private void AggiornaFornitorePrima()
        {
            try
            {
                string filtro = "codice='" + comboBox4.Text + "'";
                DataRow[] Fornitore = target2021DataSet.Tables["Fornitori"].Select(filtro);
                label9.Text = Fornitore[0].Field<String>("ragione_sociale");
            }
            catch
            {
                label9.Text = " ";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.BackColor = Color.White;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox5.BackColor = Color.White;
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox12.BackColor = Color.White;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Ottieni max colonna IdAbbinamento da Tabella AbbinamentiArticoli
            // e incrementa di 1
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = "codice='" + comboBox6.SelectedValue + "'";
                DataRow[] Stampo = target2021DataSet.Tables["Stampi"].Select(filtro);
                DataRow[] riga;
                riga = target2021DataSet.Tables["Stampi"].Select("codice='" + comboBox6.Text + "'");
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

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = "codice='" + comboBox11.Text + "'";
                DataRow[] Dima = target2021DataSet.Tables["Dime"].Select(filtro);
                DataRow[] riga;
                riga = target2021DataSet.Tables["Dime"].Select("codice='" + comboBox11.Text + "'");
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
                label35.Text = Fornitore[0].Field<String>("ragione_sociale");
            }
            catch { }
        }
    }
}
