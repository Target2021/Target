using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Fornitori
{
    public partial class ArrivoMerce : Form
    {
        public ArrivoMerce()
        {
            InitializeComponent();
        }

        private void ordFornTestBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordFornTestBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void ArrivoMerce_Load(object sender, EventArgs e)
        {
            this.ordFornTestTableAdapter.Fill(this.target2021DataSet.OrdFornTest);
            filtra();
        }

        private void filtra()
        {
            ordFornTestBindingSource.Filter = "StatoOrdine = 0 OR StatoOrdine = 1";
        }

        private void selezionata(object sender, DataGridViewCellEventArgs e)
        {
            int NrOrd;
            NrOrd = Convert.ToInt32(ordFornTestDataGridView.Rows[e.RowIndex].Cells[11].Value);
            //MessageBox.Show(NrOrd.ToString());
            dettaglio(NrOrd);
        }

        private void dettaglio(int NrOrdine)
        {
            this.ordFornDettTableAdapter.Fill(this.target2021DataSet.OrdFornDett);
            ordFornDettBindingSource.Filter = "Stato=0 AND idOFTestata = " + NrOrdine.ToString();

        }
    }
}
