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
    public partial class GiacenzaLastre : Form
    {
        public GiacenzaLastre()
        {
            InitializeComponent();
        }

        private void GiacenzaLastre_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.GiacenzaLastre'. È possibile spostarla o rimuoverla se necessario.
            this.giacenzaLastreTableAdapter.Fill(this.target2021DataSet.GiacenzaLastre);

        }
    }
}
