using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Target2021.SelezAna;

namespace Target2021.Anagrafiche
{
    public partial class AnaMateriePrime : Form
    {
        public AnaMateriePrime()
        {
            InitializeComponent();
        }

        private void primeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.primeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }

        private void AnaMateriePrime_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Prime'. È possibile spostarla o rimuoverla se necessario.
            this.primeTableAdapter.Fill(this.target2021DataSet.Prime);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Codice") primeBindingSource.Filter = "codice LIKE '*" + textBox1.Text + "*'";
            if (comboBox1.Text == "Descrizione") primeBindingSource.Filter = "descrizione LIKE '*" + textBox1.Text + "*'";
        }

        private void primeDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch (NoNullAllowedException ex) { MessageBox.Show("La tabella non può essere modificata"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nuovo = "-1";
            SelPrime selez = new SelPrime(nuovo);
            selez.ShowDialog();
            Aggiorna();
        }

        private void primeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.primeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void primeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (primeDataGridView.SelectedCells.Count > 0)
            {
                int rowindex = primeDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow riga = primeDataGridView.Rows[rowindex];
                string cod = Convert.ToString(riga.Cells["dataGridViewTextBoxColumn1"].Value);
                SelPrime selez = new SelPrime(cod);
                selez.ShowDialog();
                Aggiorna();
            }
        }

        private void Aggiorna()
        {
            this.primeTableAdapter.Fill(this.target2021DataSet.Prime);
            primeDataGridView.Refresh();
        }
    }
}
