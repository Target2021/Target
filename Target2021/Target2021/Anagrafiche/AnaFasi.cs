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
    public partial class AnaFasi : Form
    {
        public AnaFasi()
        {
            InitializeComponent();
        }

        private void fasiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fasiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void AnaFasi_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Fasi'. È possibile spostarla o rimuoverla se necessario.
            this.fasiTableAdapter.Fill(this.target2021DataSet.Fasi);

        }

        private void fasiDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch (NoNullAllowedException ex) { MessageBox.Show("La tabella non può essere modificata"); }
        }
    }
}
