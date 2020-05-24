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
    public partial class LastraCommessa : Form
    {
        public LastraCommessa()
        {
            InitializeComponent();
        }

        private void commesseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commesseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void LastraCommessa_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            commesseBindingSource.Filter = "Stato=0 AND TipoCommessa=1";
        }

        private void commesseDataGridView_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void commesseDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow riga in commesseDataGridView.SelectedRows)
            {
                string NrCommessa = riga.Cells[2].Value.ToString();
                DateTime DataCommessa = (DateTime) riga.Cells[3].Value;
                string CodiceLastra = riga.Cells[22].Value.ToString();
                CambiaLastra Cambia = new CambiaLastra(NrCommessa, DataCommessa, CodiceLastra);
                Cambia.ShowDialog();
                this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
                commesseBindingSource.Filter = "Stato=0 AND TipoCommessa=1";
                commesseDataGridView.Update();
                commesseDataGridView.Refresh();
            }
        }

        private void commesseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
