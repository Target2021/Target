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
    public partial class AnaArticoli : Form
    {
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
            comboBox2.Text = "0";
            comboBox3.Text = "LAS.00.000";
            comboBox4.Text = "";
            comboBox5.Text = "0";
            comboBox6.Text = "STA.00.000";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            comboBox8.Text = "0";
            comboBox9.Text = "0";
            comboBox10.Text = "AAA";
            comboBox11.Text = "AAA.02.001";
            comboBox12.Text = "0";
        }

        private void AnaArticoli_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.MacchineTaglio'. È possibile spostarla o rimuoverla se necessario.
            this.macchineTaglioTableAdapter1.Fill(this.target2021DataSet.MacchineTaglio);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Dime'. È possibile spostarla o rimuoverla se necessario.
            this.dimeTableAdapter.Fill(this.target2021DataSet.Dime);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet8.MacchineTaglio'. È possibile spostarla o rimuoverla se necessario.
            this.macchineTaglioTableAdapter.Fill(this.target2021DataSet8.MacchineTaglio);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet4.MacchineStampo'. È possibile spostarla o rimuoverla se necessario.
            this.macchineStampoTableAdapter.Fill(this.target2021DataSet4.MacchineStampo);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet3.Fornitori'. È possibile spostarla o rimuoverla se necessario.
            this.fornitoriTableAdapter1.Fill(this.target2021DataSet3.Fornitori);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet2.Stampi'. È possibile spostarla o rimuoverla se necessario.
            this.stampiTableAdapter.Fill(this.target2021DataSet2.Stampi);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet1.Fasi'. È possibile spostarla o rimuoverla se necessario.
            this.fasiTableAdapter1.Fill(this.target2021DataSet1.Fasi);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.DettArticoli'. È possibile spostarla o rimuoverla se necessario.
            this.dettArticoliTableAdapter.Fill(this.target2021DataSet.DettArticoli);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Fornitori'. È possibile spostarla o rimuoverla se necessario.
            this.fornitoriTableAdapter.Fill(this.target2021DataSet.Fornitori);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Prime'. È possibile spostarla o rimuoverla se necessario.
            this.primeTableAdapter.Fill(this.target2021DataSet.Prime);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Fasi'. È possibile spostarla o rimuoverla se necessario.
            this.fasiTableAdapter.Fill(this.target2021DataSet.Fasi);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.articoli_semplici'. È possibile spostarla o rimuoverla se necessario.
            this.articoli_sempliciTableAdapter.Fill(this.target2021DataSet.articoli_semplici);
            pulisci();
        }

        private void Filtra(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Codice") articoli_sempliciBindingSource.Filter = "codice LIKE '*" + textBox1.Text + "*'";
            if (comboBox1.Text == "Descrizione") articoli_sempliciBindingSource.Filter = "descrizione LIKE '*" + textBox1.Text + "*'";
        }

        private void CambiataSelezione(int numero)
        {
            int NumeroFasi = 0;
            string codice = articoli_sempliciDataGridView.Rows[numero].Cells[0].Value.ToString();
            textBox2.Text = codice;
            string descrizione= articoli_sempliciDataGridView.Rows[numero].Cells[1].Value.ToString();
            textBox3.Text = descrizione;
            string costo = articoli_sempliciDataGridView.Rows[numero].Cells[4].Value.ToString();
            if (costo == "") textBox4.Text = "0"; else textBox4.Text = costo;
            NumeroFasi  = (from row in target2021DataSet.Tables["DettArticoli"].AsEnumerable() where row.Field<string>("codice_articolo").Contains(codice) select row).Count();
            textBox5.Text = NumeroFasi.ToString();
            string immagine= articoli_sempliciDataGridView.Rows[numero].Cells[6].Value.ToString();
            try
            {
                pictureBox1.Image = new Bitmap(immagine);
            }
            catch { pictureBox1.Image = new Bitmap("C:\\Users\\targe\\Source\\Repos\\Target\\Target2021\\Target2021\\Immagini\\question-mark.jpg"); }
            AggiornaTab(codice);
        }

        private void articoli_sempliciDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CambiataSelezione(e.RowIndex);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            string filtro = "codice='" + comboBox3.SelectedValue+"'";
            DataRow[] MatPrima = target2021DataSet.Tables["Prime"].Select(filtro);
            label6.Text = MatPrima[0].Field <String>("descrizione");
            }
            catch
            {
                label6.Text = " ";
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = "codice='" + comboBox4.SelectedValue + "'";
                DataRow[] Fornitore = target2021DataSet.Tables["Fornitori"].Select(filtro);
                label7.Text = Fornitore[0].Field<String>("ragione_sociale");
            }
            catch
            {
                label7.Text = " ";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = "IDFase='" + comboBox2.SelectedValue.ToString() + "'";
                DataRow[] Fase = target2021DataSet.Tables["Fasi"].Select(filtro);
                label8.Text = Fase[0].Field<String>("Descrizione");
            }
            catch
            {
                label8.Text = " ";
            }
        }

        private void AggiornaTab(string codice)
        {
            Tab1(codice);
            Tab2(codice);
            Tab3(codice);
        }

        private void articoli_sempliciDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow riga;
            riga = articoli_sempliciDataGridView.CurrentRow;
            if (riga!=null) CambiataSelezione(riga.Index);
        }

        private void Tab1(string codice)
        {
            try
            {
                string filtro = "codice_articolo='" + codice + "' AND lavorazione=1";
                DataRow[] Fase1 = target2021DataSet.Tables["DettArticoli"].Select(filtro);
                comboBox2.Text = Fase1[0].Field<int>("lavorazione").ToString();
                comboBox2.Refresh();
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
                comboBox2.Text = "0";
                comboBox3.Text = "LAS.00.000";
                comboBox4.Text = "AAA";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
            }
        }

        private void Tab2(string codice)
        {
            try
            {
                string filtro = "codice_articolo='" + codice + "' AND lavorazione=2";
                DataRow[] Fase2 = target2021DataSet.Tables["DettArticoli"].Select(filtro);
                comboBox5.Text = Fase2[0].Field<int>("lavorazione").ToString();
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
                comboBox8.Text = Fase2[0].Field<int>("MacPredefStampo").ToString();
                comboBox8.Refresh();
                textBox12.Text = Fase2[0].Field<int>("AbbinamentoStampo").ToString();
                textBox12.Refresh();
                comboBox7_SelectedIndexChanged(new object(), new EventArgs());
            }
            catch
            {
                comboBox5.Text = "0";
                comboBox6.Text = "AAA.01.001";
                comboBox7.Text = "AAA";
                comboBox8.Text = "0";
                label13.Text = "";
                label15.Text = "";
                label18.Text = "";
                label25.Text = "";
            }
        }

        private void Tab3(string codice)
        {
            try
            {
                string filtro = "codice_articolo='" + codice + "' AND lavorazione=3";
                DataRow[] Fase3 = target2021DataSet.Tables["DettArticoli"].Select(filtro);
                comboBox12.Text = Fase3[0].Field<int>("lavorazione").ToString();
                comboBox12.Refresh();
                comboBox11.Text = Fase3[0].Field<string>("codicePrimaStampoDima");
                comboBox11.Refresh();
                comboBox10.Text = Fase3[0].Field<string>("codice_fornitore");
                comboBox10.Refresh();
                textBox15.Text = Fase3[0].Field<string>("CodiceInput");
                textBox15.Refresh();
                textBox16.Text = Fase3[0].Field<string>("CodiceOutput");
                textBox16.Refresh();
                comboBox9.Text = Fase3[0].Field<int>("MacPredefTaglio").ToString();
                comboBox9.Refresh();
                textBox13.Text = Fase3[0].Field<string>("ProgrTaglio1");
                textBox13.Refresh();
                textBox14.Text = Fase3[0].Field<string>("ProgrTaglio2");
                textBox14.Refresh();
                comboBox11_SelectedIndexChanged(new object(), new EventArgs());
                comboBox10_SelectedIndexChanged(new object(), new EventArgs());
            }
            catch
            {
                comboBox9.Text = "0";
                comboBox10.Text = "AAA";
                comboBox11.Text = "AAA.02.001";
                comboBox12.Text = "0";
                label26.Text = "";
                label32.Text = "";
                label34.Text = "";
                label37.Text = "";
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = "IDFase='" + comboBox5.SelectedValue.ToString() + "'";
                DataRow[] Fase = target2021DataSet.Tables["Fasi"].Select(filtro);
                label13.Text = Fase[0].Field<String>("Descrizione");
            }
            catch { }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = "codice='" + comboBox6.SelectedValue + "'";
                DataRow[] Stampo = target2021DataSet2.Tables["Stampi"].Select(filtro);
                label15.Text = Stampo[0].Field<String>("descrizione");
            }
            catch { }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = "codice='" + comboBox7.SelectedValue + "'";
                DataRow[] Fornitore = target2021DataSet3.Tables["Fornitori"].Select(filtro);
                label18.Text = Fornitore[0].Field<String>("ragione_sociale");
            }
            catch { }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = "IdStampa='" + comboBox8.SelectedValue + "'";
                DataRow[] MPredef = target2021DataSet4.Tables["MacchineStampo"].Select(filtro);
                label25.Text = MPredef[0].Field<String>("Descrizione");
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int CodAbb;
            CodAbb = Convert.ToInt32(textBox12.Text);
            DettAbbinamStampo DAS = new DettAbbinamStampo(CodAbb,textBox2.Text);
            DAS.Show();
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = "IDFase='" + comboBox12.SelectedValue.ToString() + "'";
                DataRow[] Fase = target2021DataSet.Tables["Fasi"].Select(filtro);
                label37.Text = Fase[0].Field<String>("Descrizione");
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Per la testata articoli aggiorna solo Descrizione e Costo Base Produzione
            string codice, descrizione;
            double costo;

            codice = textBox2.Text;
            descrizione = textBox3.Text;
            costo = Convert.ToDouble(textBox4.Text);

            DataRow riga;
            DataTable TabellaArticoli;
            TabellaArticoli = target2021DataSet.Tables["articoli_semplici"];

            riga = TabellaArticoli.Rows.Find(codice);
            riga.BeginEdit();
            riga["descrizione"] = descrizione;
            riga["costo_standard"] = costo;
            riga.EndEdit();

            articoli_sempliciTableAdapter.Update(target2021DataSet);
        }

        private void AggiornaTabulato(object sender, EventArgs e)
        {
            //DataGridViewRow riga;
            //riga = articoli_sempliciDataGridView.CurrentRow;
            //string codice = articoli_sempliciDataGridView.Rows[riga.Index].Cells[0].Value.ToString();
            //AggiornaTab(codice);
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = "codice='" + comboBox11.SelectedValue + "'";
                DataRow[] Dima = target2021DataSet.Tables["Dime"].Select(filtro);
                label34.Text = Dima[0].Field<String>("descrizione");
            }
            catch (Exception ex) { //MessageBox.Show(ex.Message); 
            }
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = "codice='" + comboBox10.SelectedValue + "'";
                DataRow[] Fornitore = target2021DataSet3.Tables["Fornitori"].Select(filtro);
                label32.Text = Fornitore[0].Field<String>("ragione_sociale");
            }
            catch { }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = "IDTaglio='" + comboBox9.SelectedValue + "'";
                DataRow[] MPredef = target2021DataSet.Tables["MacchineTaglio"].Select(filtro);
                label26.Text = MPredef[0].Field<String>("Descrizione");
            }
            catch (Exception ex) { //MessageBox.Show(ex.Message); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //    string file = openFileDialog1.FileName;
        //    try
        //        {
        //            pictureBox1.Image = new Bitmap(file);
        //            articoli_sempliciDataGridView.Rows[articoli_sempliciDataGridView.CurrentRow.Index].Cells[6].Value = file;
        //        }
        //    catch { pictureBox1.Image = new Bitmap("C:\\Users\\targe\\Source\\Repos\\Target\\Target2021\\Target2021\\Immagini\\question-mark.jpg"); }
        //    }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.articoli_sempliciTableAdapter.FillBy(this.target2021DataSet.articoli_semplici);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

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
    }
}
