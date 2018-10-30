using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Stampe
{
    public partial class StampaOrdFor : Form
    {
        public StampaOrdFor()
        {
            InitializeComponent();
        }

        private void StampaOrdFor_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
