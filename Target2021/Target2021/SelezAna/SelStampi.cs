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
    public partial class SelStampi : Form
    {
        public SelStampi(string codice)
        {
            InitializeComponent();
            CodFase = codice;
        }
        public string CodFase { get; set; }
        private void stampiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stampiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void SelStampi_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Stampi'. È possibile spostarla o rimuoverla se necessario.
            this.stampiTableAdapter.Fill(this.target2021DataSet.Stampi);

        }

        private void stampiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String IDS;
            int NumeroRiga;
            NumeroRiga = stampiDataGridView.SelectedCells[0].RowIndex;
            IDS = stampiDataGridView.Rows[NumeroRiga].Cells[0].Value.ToString();
            CodFase = IDS;
            this.Close();
        }
    }
}
