using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Report
{
    public partial class WFCaricoLastra : Form
    {
        int numero;

        public WFCaricoLastra(int nr)
        {
            InitializeComponent();
            numero = nr;
        }

        private void WFCaricoLastra_Load(object sender, EventArgs e)
        {
            label1.Text = numero.ToString();
            this.reportViewer1.RefreshReport();
        }
    }
}
