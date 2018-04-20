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

        private void Seleziona(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = primeBindingSource.Position;
            SelPrime Seleziona = new SelPrime(id, comboBox1 .Text, textBox1 .Text);
            Seleziona.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Codice") primeBindingSource.Filter = "codice LIKE '*" + textBox1.Text + "*'";
            if (comboBox1.Text == "Descrizione") primeBindingSource.Filter = "descrizione LIKE '*" + textBox1.Text + "*'";
        }
    }
}
