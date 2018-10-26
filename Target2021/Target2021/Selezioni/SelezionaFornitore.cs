using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Selezioni
{
    public partial class SelezionaFornitore : Form
    {
        public string codice;

        public SelezionaFornitore()
        {
            InitializeComponent();
        }

        private void SelezionaLastre_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Fornitori'. È possibile spostarla o rimuoverla se necessario.
            this.fornitoriTableAdapter.Fill(this.target2021DataSet.Fornitori);
        }

        private void Filtra(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Codice") fornitoriBindingSource.Filter = "codice LIKE '*" + textBox1.Text + "*'";
            if (comboBox1.Text == "Ragione Sociale") fornitoriBindingSource.Filter = "ragione_sociale LIKE '*" + textBox1.Text + "*'";
        }

        private void Selezionata(object sender, DataGridViewCellEventArgs e)
        {
            codice = Convert.ToString(primeDataGridView.Rows[e.RowIndex].Cells[0].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Chiuso(object sender, FormClosingEventArgs e)
        {

        }
    }
}
