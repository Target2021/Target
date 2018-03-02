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

        private void articoliBCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.articoliBCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_A35212_targetDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'dB_A35212_targetDataSet.ArticoliBC'. È possibile spostarla o rimuoverla se necessario.
            this.articoliBCTableAdapter.Fill(this.dB_A35212_targetDataSet.ArticoliBC);

        }
    }
}
