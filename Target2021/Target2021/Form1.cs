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
            menuStrip1.Renderer = new MyRenderer();

        }
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }
        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.DeepSkyBlue; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.Aqua; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.CadetBlue; }
            }
            public override Color MenuItemPressedGradientMiddle
            {
                get { return Color.Aquamarine; }
            }
        }
        private void anaMagazziniBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.anaMagazziniBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void testataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Testata_articoli testata = new Testata_articoli();
            testata.MdiParent = this;
            testata.Show();
        }

        private void dettaglioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dettaglio_Articoli dettaglio = new Dettaglio_Articoli();
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

        private void contatoriAziendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contatori ContaForm = new Contatori();
            ContaForm.MdiParent = this;
            ContaForm.Show();
        }

        private void controllaNuoviOrdiniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewOrderCheck ControllaNuoviOrdini = new NewOrderCheck();
            ControllaNuoviOrdini.MdiParent = this;
            ControllaNuoviOrdini.Show();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
