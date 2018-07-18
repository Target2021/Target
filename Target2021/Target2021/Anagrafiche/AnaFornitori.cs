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
    public partial class AnaFornitori : Form
    {
        public AnaFornitori()
        {
            InitializeComponent();
        }

        private void fornitoriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornitoriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (Filter.Text == "Codice") fornitoriBindingSource.Filter = "codice LIKE '*" + textBox1.Text + "*'";
            if (Filter.Text == "Ragione_sociale") fornitoriBindingSource.Filter = "ragione_sociale LIKE '*" + textBox1.Text + "*'";
            if (Filter.Text == "Località") { ControlNumber(textBox1.Text); fornitoriBindingSource.Filter = "localita LIKE '*" + textBox1.Text + "*'"; }
        }
        public void ControlNumber(string frase)
        {
            string words = frase;
            int parsedvalue;
            foreach (char word in words)
            {
                if (int.TryParse(Convert.ToString(word), out parsedvalue))
                {
                    MessageBox.Show("non sono ammessi valori numerici");
                    textBox1.Text = "";
                    return;
                }
            }
        }
        private void AnaFornitori_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Fornitori'. È possibile spostarla o rimuoverla se necessario.
            this.fornitoriTableAdapter.Fill(this.target2021DataSet.Fornitori);

        }

        private void fornitoriDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
