using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021
{
    public partial class LavoraStampaggio : Form
    {
        public String stringa = Properties.Resources.StringaConnessione;
        public string IDCommessa;

        public LavoraStampaggio(string id)
        {
            InitializeComponent();
            IDCommessa = id;
        }

        private void LavoraStampaggio_Load(object sender, EventArgs e)
        {
            this.stampiTableAdapter.Fill(this.target2021DataSet.Stampi);
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            commesseBindingSource.Filter = "IDCommessa = '" + IDCommessa + "'";
        }



    }
}
