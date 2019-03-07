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
    public partial class AnaGiacenze : Form
    {
        public AnaGiacenze()
        {
            InitializeComponent();
        }

        private void giacenzeMagazziniBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.giacenzeMagazziniBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }

        private void AnaGiacenze_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.GiacenzeMagazzini'. È possibile spostarla o rimuoverla se necessario.
            this.giacenzeMagazziniTableAdapter.Fill(this.target2021DataSet.GiacenzeMagazzini);

        }

        private void giacenzeMagazziniDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch (NoNullAllowedException ex) { MessageBox.Show("La tabella non può essere modificata"); }
        }

        private void filtra(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Materie prime") giacenzeMagazziniBindingSource.Filter = "idPrime LIKE '*" + textBox1.Text + "*'";
            if (comboBox1.Text == "Semilavorati") giacenzeMagazziniBindingSource.Filter = "idSemilavorati LIKE '*" + textBox1.Text + "*'";
            if (comboBox1.Text == "Prodotti finiti") giacenzeMagazziniBindingSource.Filter = "idArticoli LIKE '*" + textBox1.Text + "*'";
        }
    }
}
