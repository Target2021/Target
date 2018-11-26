using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021
{
    public partial class CheckStampaggio : Form
    {
        public CheckStampaggio()
        {
            InitializeComponent();
        }

        private void LoadStampaggio()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LavoraStampaggio LS = new LavoraStampaggio("1");
            LS.Show();
        }
    }
}