using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            
        }

        private void anaMagazziniBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.anaMagazziniBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.AnaMagazzini'. È possibile spostarla o rimuoverla se necessario.
            this.anaMagazziniTableAdapter.Fill(this.target2021DataSet.AnaMagazzini);

        }

        private void testataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Testata testata = new Testata();
            testata.MdiParent = this;
            testata.Show();
        }

        private void dettaglioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dettaglio dettaglio = new Dettaglio();
            dettaglio.MdiParent = this;
            dettaglio.Show();
        }

        private void clientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clienti clienti = new Clienti();
            clienti.MdiParent = this;
            clienti.Show();
        }

        private void testataOrdiniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Testata_Ordini TestataOrdini = new Testata_Ordini();
            TestataOrdini.MdiParent = this;
            TestataOrdini.Show();
        }
    }
}
