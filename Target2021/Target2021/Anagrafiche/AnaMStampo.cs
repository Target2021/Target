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
    public partial class AnaMStampo : Form
    {
        public AnaMStampo()
        {
            InitializeComponent();
        }

        private void macchineStampoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.macchineStampoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void AnaMStampo_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.MacchineStampo'. È possibile spostarla o rimuoverla se necessario.
            this.macchineStampoTableAdapter.Fill(this.target2021DataSet.MacchineStampo);

        }

        private void macchineStampoDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch (NoNullAllowedException ex) { MessageBox.Show("La tabella non può essere modificata"); }
        }
    }
}
