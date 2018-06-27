using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Target2021.Stampe
{
    public partial class SEtichette : Form
    {
        int nrcommessa = 0, qtaprodotta = 0;
        int fase = 0;   // Fase 1=stampaggio, 2=taglio 3=assemblaggio

        public SEtichette()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
              MessageBox.Show("Compila il campo 'Numero commessa'!");
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("Compila il campo 'Q.tà prodotta'!");
            }

            if (radioButton1.Checked == true) fase = 1;
            if (radioButton2.Checked == true) fase = 2;
            if (radioButton3.Checked == true) fase = 3;

            if (nrcommessa !=0 && qtaprodotta !=0 && fase !=0)
            {
                generareport();
            }
        }

        private void SoloNumeri(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void SEtichette_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void generareport()
        {

        }

    }
}
