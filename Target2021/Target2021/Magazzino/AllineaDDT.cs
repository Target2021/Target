using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Magazzino
{
    public partial class AllineaDDT : Form
    {
        public AllineaDDT()
        {
            InitializeComponent();
        }

        private void dettaglio_ddtBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dettaglio_ddtBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void AllineaDDT_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.dettaglio_ddt'. È possibile spostarla o rimuoverla se necessario.
            this.dettaglio_ddtTableAdapter.Fill(this.target2021DataSet.dettaglio_ddt);
            int anno;
            anno = DateTime.Now.Year;
            comboBox1.Text = anno.ToString();
            filtra();
        }

        private void filtra()
        {
            dettaglio_ddtBindingSource.Filter = "data_ddt > '" + comboBox1.Text + "0000'";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtra();
        }
    }
}
