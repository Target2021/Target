using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.SelezAna
{
    public partial class SelSemilavorato : Form
    {
        public List<DataGridViewRow> selezionati = new List<DataGridViewRow>();

        public SelSemilavorato()
        {
            InitializeComponent();
        }

        private void articoli_sempliciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.articoli_sempliciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }

        private void SelSemilavorato_Load(object sender, EventArgs e)
        {
            button1.Text = "Solo 08";
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.articoli_semplici'. È possibile spostarla o rimuoverla se necessario.
            this.articoli_sempliciTableAdapter.Fill(this.target2021DataSet.articoli_semplici);
            filtra(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Solo 08")
            {
                button1.Text = "TUTTO";
                button1.BackColor = Color.LightCyan;
                filtra(1);  // mostra tutto (=1)
            }
            else 
            {
                button1.Text = "Solo 08";
                button1.BackColor = Color.LightGreen;
                filtra(0);  // mostra solo gli 08 (=0)
            }
        }

        private void filtra (int cosa)
        {
            string codice;
            int posizione;
            articoli_sempliciDataGridView.CurrentCell = null;
            if (cosa==0)
            {
                foreach (DataGridViewRow riga in articoli_sempliciDataGridView.Rows)
                {
                    codice = riga.Cells[0].Value.ToString();
                    posizione = riga.Index;
                    try
                    {
                        string[] pezzi = codice.Split('.');
                        if (pezzi[1] != "08")
                        {
                            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[articoli_sempliciDataGridView.DataSource];
                            currencyManager1.SuspendBinding();
                            articoli_sempliciDataGridView.Rows[posizione].Visible = false;
                            currencyManager1.ResumeBinding();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Nell'anagrafica articoli c'è un codice articolo anomalo: " + codice);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
