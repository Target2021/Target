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
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
