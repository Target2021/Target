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
    public partial class AnaGiacenze : Form
    {
        public AnaGiacenze()
        {
            InitializeComponent();
        }

        private void giacenzeMagazziniBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.giacenzeMagazziniBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void AnaGiacenze_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.GiacenzeMagazzini'. È possibile spostarla o rimuoverla se necessario.
            this.giacenzeMagazziniTableAdapter.Fill(this.target2021DataSet.GiacenzeMagazzini);

        }
    }
}
