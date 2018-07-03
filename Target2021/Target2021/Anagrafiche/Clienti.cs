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

namespace Target2021
{
    public partial class Clienti : Form
    {
        public Clienti()
        {
            InitializeComponent();
        }

        private void clientiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void Clienti_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.clienti'. È possibile spostarla o rimuoverla se necessario.
            this.clientiTableAdapter.Fill(this.target2021DataSet.clienti);

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (Filter.Text == "Codice") clientiBindingSource.Filter = "codice LIKE '*" + textBox1.Text + "*'";
            if (Filter.Text == "Ragione_sociale") clientiBindingSource.Filter = "ragione_sociale LIKE '*" + textBox1.Text + "*'";
            if (Filter.Text == "Località") { ControlNumber(textBox1.Text); clientiBindingSource.Filter = "localita LIKE '*" + textBox1.Text + "*'"; }
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

        private void Filter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Button2_Click(sender, e);
            }

        }

        private void clientiDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch (NoNullAllowedException ex) { MessageBox.Show("La tabella non può essere modificata"); }
        }
    }
}
