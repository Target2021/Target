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
    public partial class AnaOrdiniEsclusi : Form
    {
        public AnaOrdiniEsclusi()
        {
            InitializeComponent();
        }

        private void ordiniEsclusiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordiniEsclusiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void AnaOrdiniEsclusi_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.OrdiniEsclusi'. È possibile spostarla o rimuoverla se necessario.
            this.ordiniEsclusiTableAdapter.Fill(this.target2021DataSet.OrdiniEsclusi);

        }
    }
}
