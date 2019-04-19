using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.SelezAna
{
    public partial class SelPrime : Form
    {
        public string Codice;

        public SelPrime(string idArt)
        {
            InitializeComponent();
            Codice = idArt;
        }

        private void primeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.primeBindingSource.EndEdit();
            this.primeTableAdapter.Update(this.target2021DataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cod = codiceTextBox.Text;
            String des = descrizioneTextBox.Text;
            AnArticForn artforn = new AnArticForn(cod,des);
            artforn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
        }

        private void assegna(object sender, EventArgs e)
        {
            string codice, descrizione;
            try
            {
                codice = comboBox1.SelectedValue.ToString();
                descrizione = ((DataRowView)comboBox1.SelectedItem).Row["ragione_sociale"].ToString();
                codice_fornitoreTextBox.Text = codice;
                descrizione_fornitoreTextBox.Text = descrizione;
                comboBox1.Visible = false;
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox2.Visible = true;
            comboBox2.Focus();
            string codice;
            try
            {
                codice = comboBox2.SelectedValue.ToString();
                materialeTextBox.Text = codice;
            }
            catch { }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Seleziona();
        }

        private void Seleziona()
        {
            string codice;
            try
            {
                codice = comboBox2.SelectedValue.ToString();
                materialeTextBox.Text = codice;
                comboBox2.Visible = false;
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string codice;
            double ps,peso;
            double x=1, y=1, z=1;
            try
            {
            x = Convert.ToDouble(dimXTextBox.Text);
            y = Convert.ToDouble(dimYTextBox.Text);
            z = Convert.ToDouble(dimZTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Ricordati di compilare le dimesioni!");
            }

            try
            {
                codice = materialeTextBox.Text;
                DataRow[] riga;
                DataTable TabellaMateriali;
                TabellaMateriali = target2021DataSet.Tables["PesiSpecifici"];
                riga = target2021DataSet.Tables["PesiSpecifici"].Select("Materiale='" + codice+"'");
                ps = Convert.ToDouble (riga[0]["PesoSpecifico"]);
                peso = (ps * x * y * z) / 1000000;
                pesoTextBox.Text = peso.ToString("N"+3);
            }
            catch
            {
                MessageBox.Show("Inserire il tipo di materiale");
            }
        }

        private void Salvare(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Vuoi salvare le modifiche?", "SALVARE?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Validate();
                this.primeBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.target2021DataSet);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void SelPrime_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.PesiSpecifici'.
            this.pesiSpecificiTableAdapter.Fill(this.target2021DataSet.PesiSpecifici);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Fornitori'.
            this.fornitoriTableAdapter.Fill(this.target2021DataSet.Fornitori);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Prime'. 
            this.primeTableAdapter.Fill(this.target2021DataSet.Prime);
            if (Codice == "-1") this.primeBindingSource.AddNew();
            else primeBindingSource.Filter = "codice = '" + Codice +"'";
        }
    }
}