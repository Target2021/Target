using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void AnaArticoli_Load(object sender, EventArgs e)
        {
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

        private void CambiataSelezione(DataGridViewCellEventArgs e)
        {
            int NumeroFasi = 0;
            string codice = articoli_sempliciDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = codice;
            string descrizione= articoli_sempliciDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = descrizione;

            NumeroFasi  = (from row in target2021DataSet.Tables["DettArticoli"].AsEnumerable() where row.Field<string>("codice_articolo").Contains(codice) select row).Count();
            textBox5.Text = NumeroFasi.ToString();
            AggiornaTab(codice);
        }

        private void articoli_sempliciDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CambiataSelezione(e);
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
            catch { }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = "codice='" + comboBox4.SelectedValue + "'";
                DataRow[] Fornitore = target2021DataSet.Tables["Fornitori"].Select(filtro);
                label7.Text = Fornitore[0].Field<String>("ragione_sociale");
            }
            catch { }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = "IDFase='" + comboBox2.SelectedValue.ToString() + "'";
                DataRow[] Fase = target2021DataSet.Tables["Fasi"].Select(filtro);
                label8.Text = Fase[0].Field<String>("Descrizione");
            }
            catch { }
        }

        private void AggiornaTab(string codice)
        {
            Tab1(codice);
        }

        private void articoli_sempliciDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //CambiataSelezione(e);
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

            }           
            catch { }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
