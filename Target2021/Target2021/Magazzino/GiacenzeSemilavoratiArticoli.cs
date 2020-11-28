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
    public partial class GiacenzeSemilavoratiArticoli : Form
    {
        public GiacenzeSemilavoratiArticoli()
        {
            InitializeComponent();
        }

        private void GiacenzeSemilavoratiArticoli_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.GiacenzeSemilavorati'. È possibile spostarla o rimuoverla se necessario.
            this.giacenzeSemilavoratiTableAdapter.Fill(this.target2021DataSet.GiacenzeSemilavorati);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.GiacenzaFiniti'. È possibile spostarla o rimuoverla se necessario.
            this.giacenzaFinitiTableAdapter.Fill(this.target2021DataSet.GiacenzaFiniti);

        }
    }
}
