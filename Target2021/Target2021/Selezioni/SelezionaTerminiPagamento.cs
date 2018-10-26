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
    public partial class SelezionaTerminiPagamento : Form
    {
        public string codice;

        public SelezionaTerminiPagamento()
        {
            InitializeComponent();
        }

        private void SelezionaLastre_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.CodTermPagamento'. È possibile spostarla o rimuoverla se necessario.
            this.codTermPagamentoTableAdapter.Fill(this.target2021DataSet.CodTermPagamento);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Prime'. È possibile spostarla o rimuoverla se necessario.
            this.primeTableAdapter.Fill(this.target2021DataSet.Prime);
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
    }
}
