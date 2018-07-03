using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Anagrafiche
{
    public partial class AnaMTaglio : Form
    {
        public AnaMTaglio()
        {
            InitializeComponent();
        }

        private void macchineTaglioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.macchineTaglioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void AnaMTaglio_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.MacchineTaglio'. È possibile spostarla o rimuoverla se necessario.
            this.macchineTaglioTableAdapter.Fill(this.target2021DataSet.MacchineTaglio);

        }

        private void macchineTaglioDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch (NoNullAllowedException ex) { MessageBox.Show("La tabella non può essere modificata"); }
        }
    }
}
