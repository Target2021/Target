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
    public partial class SelezionaModalitaPagamento : Form
    {
        public string codice;

        public SelezionaModalitaPagamento()
        {
            InitializeComponent();
        }

        private void SelezionaLastre_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.CodModPagamento'. È possibile spostarla o rimuoverla se necessario.
            this.codModPagamentoTableAdapter.Fill(this.target2021DataSet.CodModPagamento);
        }

        private void primeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.primeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }

        private void Filtra(object sender, EventArgs e)
        {
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

        private void primeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
