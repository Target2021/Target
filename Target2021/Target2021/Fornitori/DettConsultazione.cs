using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Target2021.Stampe;

namespace Target2021.Fornitori
{
    public partial class DettConsultazione : Form
    {
        private int Num;
        public DettConsultazione(int no)
        {
            InitializeComponent();
            Num = no;
        }

        private void DettConsultazione_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.CodTermPagamento'. È possibile spostarla o rimuoverla se necessario.
            this.codTermPagamentoTableAdapter.Fill(this.target2021DataSet.CodTermPagamento);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.CodModPagamento'. È possibile spostarla o rimuoverla se necessario.
            this.codModPagamentoTableAdapter.Fill(this.target2021DataSet.CodModPagamento);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.CodSpedizioni'. È possibile spostarla o rimuoverla se necessario.
            this.codSpedizioniTableAdapter.Fill(this.target2021DataSet.CodSpedizioni);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.OrdFornDett'. È possibile spostarla o rimuoverla se necessario.
            this.ordFornDettTableAdapter.Fill(this.target2021DataSet.OrdFornDett);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Fornitori'. È possibile spostarla o rimuoverla se necessario.
            this.fornitoriTableAdapter.Fill(this.target2021DataSet.Fornitori);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.OrdFornTest'. È possibile spostarla o rimuoverla se necessario.
            this.ordFornTestTableAdapter.Fill(this.target2021DataSet.OrdFornTest);
            //MessageBox.Show("Visualizzare ordine nr. " + Num.ToString());
            Filtra();
        }

        private void Filtra()
        {
            ordFornTestBindingSource.Filter = "idOFTestata = '"+Num.ToString()+"'";
            fornitoriBindingSource.Filter = "codice = '" + textBox1.Text + "'";
            ordFornDettBindingSource.Filter = "idOFTestata = '" + Num.ToString() + "'";
            bindingSource1.Filter = "idCodSped = '" + textBox3.Text + "'";
            bindingSource2.Filter = "IdCodModPag = '" + textBox4.Text + "'";
            bindingSource3.Filter = "idCodTermPag = '" + textBox5.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string NrO = textBox2.Text;
            string dto = dateTimePicker1.Text;
            string p3 = textBox7.Text;
            string p4 = textBox8.Text;
            string p5 = textBox9.Text;
            string p6 = textBox1.Text;
            string p7 = Num.ToString();
            StampaOrdFor stampa = new StampaOrdFor(NrO, dto, p3, p4, p5, p6, p7);
            stampa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Riapri();
        }

        private void Riapri()
        {
            comboBox1.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = true;
            dateTimePicker2.Enabled = true;
            button1.Enabled = true;
            ordFornDettDataGridView.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Cosa visualizzo? l'elenco delle commesse per le quali era
            // stato impegnato su ordinato il materiale in ques'ordine
            // a fornitore?
            MessageBox.Show("Click sulla singola riga per vedere l'elenco delle commesse che hanno impegnato del matriale su quest'ordine");
        }

        private void ordFornDettDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SelezRiga(object sender, DataGridViewCellEventArgs e)
        {
            int IdOrdFornDett;
            IdOrdFornDett = Convert.ToInt32(ordFornDettDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn12"].Value);
            //MessageBox.Show(IdOrdFornDett.ToString());
            CommesseCollegate Dettaglio = new CommesseCollegate(IdOrdFornDett);
            Dettaglio.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
