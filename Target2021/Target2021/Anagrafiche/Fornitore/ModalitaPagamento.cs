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
    public partial class ModalitaPagamento : Form
    {
        public ModalitaPagamento()
        {
            InitializeComponent();
        }

        private void codModPagamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.codModPagamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void ModalitaPagamento_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.CodModPagamento'. È possibile spostarla o rimuoverla se necessario.
            this.codModPagamentoTableAdapter.Fill(this.target2021DataSet.CodModPagamento);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.CodModPagamento'. È possibile spostarla o rimuoverla se necessario.
            this.codModPagamentoTableAdapter.Fill(this.target2021DataSet.CodModPagamento);

        }

        private void codModPagamentoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.codModPagamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }
    }
}
