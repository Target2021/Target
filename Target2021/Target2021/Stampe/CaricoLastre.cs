using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Target2021.Report;

namespace Target2021.Stampe
{
    public partial class CaricoLastre : Form
    {
        public CaricoLastre()
        {
            InitializeComponent();
        }

        private void CaricoLastre_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet9.MovimentiMagazzino'. È possibile spostarla o rimuoverla se necessario.
            this.movimentiMagazzinoTableAdapter.Fill(this.target2021DataSet9.MovimentiMagazzino);
            filtra();
        }

        private void movimentiMagazzinoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movimentiMagazzinoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet9);
        }

        private void filtra()
        {
            DateTime data;
            data = dateTimePicker1.Value;
            data = data.Date;
            movimentiMagazzinoBindingSource.Filter = "DataOraMovimento = '" + data + "'";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            filtra();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nrmov;
            try
            {
                nrmov = Convert.ToInt32(movimentiMagazzinoDataGridView.SelectedRows[0].Cells[0].Value);
                WFCaricoLastra cl = new WFCaricoLastra(nrmov);
                cl.Show();
            }
            catch { }
        }
    }
}
