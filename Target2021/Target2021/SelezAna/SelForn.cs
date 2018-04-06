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
    public partial class SelForn : Form
    {
        public SelForn()
        {
            InitializeComponent();
        }

        public string CodFornitore { get; set; }

        private void fornitoriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornitoriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void SelForn_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Fornitori'. È possibile spostarla o rimuoverla se necessario.
            this.fornitoriTableAdapter.Fill(this.target2021DataSet.Fornitori);

        }

        private void fornitoriDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String NF;
            int NumeroRiga;
            NumeroRiga = fornitoriDataGridView.SelectedCells[0].RowIndex;
            NF = fornitoriDataGridView.Rows[NumeroRiga].Cells[0].Value.ToString();
            CodFornitore = NF;
            this.Close();
        }
    }
}
