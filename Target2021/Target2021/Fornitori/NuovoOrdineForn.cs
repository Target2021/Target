using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Target2021.Selezioni;

namespace Target2021.Fornitori
{
    public partial class NuovoOrdineForn : Form
    {
        public NuovoOrdineForn()
        {
            InitializeComponent();
        }

        private void SelezForn(object sender, MouseEventArgs e)
        {
            SelezionaFornitore SF = new SelezionaFornitore();
            SF.ShowDialog();
            string cod = SF.codice;
            textBox1.Text = cod;
        }

        private void fornitoriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornitoriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }

        private void NuovoOrdineForn_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.OrdFornDett'. È possibile spostarla o rimuoverla se necessario.
            this.ordFornDettTableAdapter.Fill(this.target2021DataSet.OrdFornDett);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.CodTermPagamento'. È possibile spostarla o rimuoverla se necessario.
            this.codTermPagamentoTableAdapter.Fill(this.target2021DataSet.CodTermPagamento);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.CodModPagamento'. È possibile spostarla o rimuoverla se necessario.
            this.codModPagamentoTableAdapter.Fill(this.target2021DataSet.CodModPagamento);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.CodSpedizioni'. È possibile spostarla o rimuoverla se necessario.
            this.codSpedizioniTableAdapter.Fill(this.target2021DataSet.CodSpedizioni);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Fornitori'. È possibile spostarla o rimuoverla se necessario.
            this.fornitoriTableAdapter.Fill(this.target2021DataSet.Fornitori);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fornitoriBindingSource.Filter = "codice = '" + textBox1.Text+"'";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            codSpedizioniBindingSource.Filter = "idCodSped = '" + textBox3.Text + "'";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            codModPagamentoBindingSource.Filter = "IdCodModPag = '" + textBox4.Text + "'";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           codTermPagamentoBindingSource.Filter = "idCodTermPag = '" + textBox5.Text + "'";
        }

        private void SelezSpediz(object sender, MouseEventArgs e)
        {
            SelezionaSpedizione SS = new SelezionaSpedizione();
            SS.ShowDialog();
            string cod = SS.codice;
            textBox3.Text = cod;
        }

        private void SelezModPag(object sender, MouseEventArgs e)
        {
            SelezionaModalitaPagamento SMP = new SelezionaModalitaPagamento();
            SMP.ShowDialog();
            string cod = SMP.codice;
            textBox4.Text = cod;
        }

        private void SelezTermPag(object sender, MouseEventArgs e)
        {
            SelezionaTerminiPagamento STP = new SelezionaTerminiPagamento();
            STP.ShowDialog();
            string cod = STP.codice;
            textBox5.Text = cod;
        }
    }
}
