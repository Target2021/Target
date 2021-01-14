using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Split
{
    public partial class SpliCommessa : Form
    {
        public SpliCommessa()
        {
            InitializeComponent();
        }

        private void SpliCommessa_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            commesseBindingSource.Filter = "TipoCommessa = 2 AND Stato=0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow r;
            int IDCommessa;
            IDCommessa =Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            var pippo = target2021DataSet.Commesse.AsEnumerable().Where(dr => dr.Field<int>("IDCommessa") == IDCommessa);
            r = pippo.First();
            Splitta sp = new Splitta(r);
            sp.ShowDialog();
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            commesseBindingSource.Filter = "TipoCommessa = 2 AND Stato=0";
        }
    }
}
