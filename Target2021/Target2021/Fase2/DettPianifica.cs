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
    public partial class DettPianifica : Form
    {
        public DateTime data;
        public string ora;
        public int durata;
        public int elimina = 0;

        public DettPianifica(DateTime d, string o, int du)
        {
            InitializeComponent();
            data = d;
            ora = o;
            durata = du;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void DettPianifica_Load(object sender, EventArgs e)
        {
            imposta();
        }

        private void imposta()
        {
            dateTimePicker1.Value = data;
            comboBox1.Text = ora;
            textBox1.Text = durata.ToString();     
        }

        private void dateTimePicker1_DropDown(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data = dateTimePicker1.Value;
            ora = comboBox1.Text;
            durata = Convert.ToInt32(textBox1.Text);
            this.Dispose();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            elimina = 1;
            this.Close();
        }
    }
}
