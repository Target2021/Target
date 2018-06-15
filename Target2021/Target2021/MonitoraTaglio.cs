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
    public partial class MonitoraTaglio : Form
    {
        public MonitoraTaglio()
        {
            InitializeComponent();
        }

        private void taglioOnLineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.taglioOnLineBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void MonitoraTaglio_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.TaglioOnLine'. È possibile spostarla o rimuoverla se necessario.
            this.taglioOnLineTableAdapter.Fill(this.target2021DataSet.TaglioOnLine);

        }
    }
}
