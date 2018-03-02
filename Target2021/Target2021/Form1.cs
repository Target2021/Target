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

        private void commesseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commesseBindingSource.EndEdit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
        }

        private void commesseBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.commesseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }
    }
}
