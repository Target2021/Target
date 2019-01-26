using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Anagrafiche.Fornitore
{
    public partial class CodiciSpedizione : Form
    {
        public CodiciSpedizione()
        {
            InitializeComponent();
        }

        private void codSpedizioniBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.codSpedizioniBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void CodiciSpedizione_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.CodSpedizioni'. È possibile spostarla o rimuoverla se necessario.
            this.codSpedizioniTableAdapter.Fill(this.target2021DataSet.CodSpedizioni);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.CodSpedizioni'. È possibile spostarla o rimuoverla se necessario.
            this.codSpedizioniTableAdapter.Fill(this.target2021DataSet.CodSpedizioni);

        }

        private void codSpedizioniBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.codSpedizioniBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }
    }
}
