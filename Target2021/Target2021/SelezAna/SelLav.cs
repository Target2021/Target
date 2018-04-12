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
    public partial class SelLav : Form
    {
        public SelLav(string codice)
        {
            InitializeComponent();
            CodFase = codice;
        }

        public string CodFase{ get; set; }

        private void fasiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fasiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void SelLav_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Fasi'. È possibile spostarla o rimuoverla se necessario.
            this.fasiTableAdapter.Fill(this.target2021DataSet.Fasi);

        }

        private void fasiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String NF;
            int NumeroRiga;
            NumeroRiga = fasiDataGridView.SelectedCells[0].RowIndex;
            NF = fasiDataGridView.Rows[NumeroRiga].Cells[0].Value.ToString();
            CodFase = NF;
            this.Close();
        }

        private void fasiBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
