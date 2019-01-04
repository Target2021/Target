using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Fornitori
{
    public partial class CalcoloPrezzoKg : Form
    {
        public double prezzo;

        public CalcoloPrezzoKg()
        {
            InitializeComponent();
        }

        private void CalcoloPrezzoKg_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
        }

        private void ricalcola(object sender, EventArgs e)
        {
            Double PrezzoMateriaVergine=0, PrezzoContoLavoro=0, PrezzoSfrido=0, PercContoLavoro=0;
            try
            {
                PrezzoMateriaVergine = Convert.ToDouble(textBox1.Text);
                PrezzoContoLavoro = Convert.ToDouble(textBox2.Text);
                PrezzoSfrido = Convert.ToDouble(textBox3.Text);
                PercContoLavoro = Convert.ToDouble(textBox4.Text);
            }
            catch
            {
                MessageBox.Show("Qualche dato inserito non è corretto!");
            }
            prezzo = PrezzoMateriaVergine * ((100 - PercContoLavoro) / 100) + (PrezzoContoLavoro + PrezzoSfrido) * (PercContoLavoro / 100);
            label5.Text = prezzo.ToString();

            if (PercContoLavoro>0)
            {
                if (PrezzoContoLavoro == 0) textBox2.BackColor = Color.LightSalmon; 
                if (PrezzoSfrido == 0) textBox3.BackColor = Color.LightSalmon; 
            }
            if (PrezzoContoLavoro > 0) textBox2.BackColor = Color.White;
            if (PrezzoSfrido > 0) textBox3.BackColor = Color.White;
            if ((PercContoLavoro == 0 && PrezzoContoLavoro > 0) || (PercContoLavoro == 0 && PrezzoSfrido > 0))
                textBox4.BackColor = Color.LightSalmon; 
            if (PercContoLavoro > 0) textBox4.BackColor = Color.White;
            if (PrezzoContoLavoro == 0 && PrezzoSfrido == 0 && PercContoLavoro == 0)
            {
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White;
                textBox4.BackColor = Color.White;
            }
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
