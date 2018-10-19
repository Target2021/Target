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
    public partial class AnaPesiSpecifici : Form
    {
        public AnaPesiSpecifici()
        {
            InitializeComponent();
        }


        private void AnaPesiSpecifici_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.PesiSpecifici'. È possibile spostarla o rimuoverla se necessario.
            this.pesiSpecificiTableAdapter.Fill(this.target2021DataSet.PesiSpecifici);
        }

        private void pesiSpecificiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pesiSpecificiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }
    }
}
