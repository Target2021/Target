using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021
{
    public partial class RiepilogoMovimenti : Form
    {
        public RiepilogoMovimenti()
        {
            InitializeComponent();
        }

        private void movimentiMagazzinoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movimentiMagazzinoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void RiepilogoMovimenti_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.MovimentiMagazzino'. È possibile spostarla o rimuoverla se necessario.
            this.movimentiMagazzinoTableAdapter.Fill(this.target2021DataSet.MovimentiMagazzino);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.Filter.GetItemText(this.Filter.SelectedItem) == "ID") movimentiMagazzinoBindingSource.Filter = "idMovimento='" +Int32.Parse(textBox1.Text) + "'";
            if (Filter.Text == "Magazzino") movimentiMagazzinoBindingSource.Filter = "idMagazzino='" + textBox1.Text + "'";
            if (Filter.Text == "Materia prima") movimentiMagazzinoBindingSource.Filter = "idPrime LIKE '*" + textBox1.Text + "*'";
            if (Filter.Text == "Stampi") movimentiMagazzinoBindingSource.Filter = "idStampi ='" + textBox1.Text + "'";
            if (Filter.Text == "Dime") movimentiMagazzinoBindingSource.Filter = "idDime ='" + textBox1.Text + "'";
            if (Filter.Text == "Semilavorati") movimentiMagazzinoBindingSource.Filter = "idSemilavorati LIKE ='" + textBox1.Text + "'";
            if (Filter.Text == "Articoli") movimentiMagazzinoBindingSource.Filter = "idArticoli LIKE '*" + textBox1.Text + "*'";

        }

        private void Filter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void movimentiMagazzinoDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch (NoNullAllowedException ex) { MessageBox.Show("La tabella non può essere modificata"); }
        }
    }
}
