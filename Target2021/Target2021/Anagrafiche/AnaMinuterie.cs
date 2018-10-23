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
    public partial class AnaMinuterie : Form
    {
        public AnaMinuterie()
        {
            InitializeComponent();
        }

        private void minuterieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.minuterieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void AnaMinuterie_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Minuterie'. È possibile spostarla o rimuoverla se necessario.
            this.minuterieTableAdapter.Fill(this.target2021DataSet.Minuterie);

        }
    }
}
