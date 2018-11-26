using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Fase2
{
    public partial class DettaglioSC : Form
    {
        private int IDSuperC;

        public DettaglioSC(int IdSC)
        {
            InitializeComponent();
            IDSuperC = IdSC;
        }

        private void DettaglioSC_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.AbbinamentiSuperCommesse'. È possibile spostarla o rimuoverla se necessario.
            this.abbinamentiSuperCommesseTableAdapter.Fill(this.target2021DataSet.AbbinamentiSuperCommesse);
            abbinamentiSuperCommesseBindingSource.Filter = "IdSuperCommessa = "+IDSuperC.ToString();
        }

        private void abbinamentiSuperCommesseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.abbinamentiSuperCommesseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }
    }
}
