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
    public partial class DettAbbinamStampo : Form
    {
        int CA;
        String Codice;

        public DettAbbinamStampo(int CodAbbinamento, string CodArt)
        {
            InitializeComponent();
            CA = CodAbbinamento;
            Codice = CodArt;
        }

        private void DettAbbinamStampo_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.articoli_semplici'. È possibile spostarla o rimuoverla se necessario.
            this.articoli_sempliciTableAdapter.Fill(this.target2021DataSet.articoli_semplici);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.AbbinamentiArticoli'. È possibile spostarla o rimuoverla se necessario.
            this.abbinamentiArticoliTableAdapter.Fill(this.target2021DataSet.AbbinamentiArticoli);
            textBox1.Text = CA.ToString();
            textBox2.Text = Codice;

            try
            {
                string filtro = "codice='" + Codice + "'";
                DataRow[] Stampo = target2021DataSet.Tables["articoli_semplici"].Select(filtro);
                textBox3.Text = Stampo[0].Field<String>("descrizione");
                textBox3.Refresh();
            }
            catch { };
            cAToolStripTextBox.Text = CA.ToString();
            aggiornaDGV();
        }

        private void aggiornaDGV()
        {
            try
            {

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CercaArticolo cerca = new CercaArticolo();
            cerca.Show();
        }
    }

}
