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
    public partial class SelMinuteria : Form
    {
        public List<DataGridViewRow> selezionati = new List<DataGridViewRow>();

        public SelMinuteria()
        {
            InitializeComponent();
        }

        private void minuterieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.minuterieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void SelMinuteria_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Minuterie'. È possibile spostarla o rimuoverla se necessario.
            this.minuterieTableAdapter.Fill(this.target2021DataSet.Minuterie);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            selezionati.Clear();
            foreach (DataGridViewRow riga in minuterieDataGridView.SelectedRows)
            {
                selezionati.Add(riga);
            }
            this.Close();
        }
    }
}
