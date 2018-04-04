using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Target2021
{
    public partial class RigaCompleta : Form
    {
        public int ID;

        public RigaCompleta(int idArt)
        {
            InitializeComponent();
            ID = idArt;
        }

        private void dettArticoliBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dettArticoliBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }

        private void RigaCompleta_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.DettArticoli'. È possibile spostarla o rimuoverla se necessario.
            this.dettArticoliTableAdapter.Fill(this.target2021DataSet.DettArticoli);
            dettArticoliBindingSource.Position = ID;
        }
    }
}
