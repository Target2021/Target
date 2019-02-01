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
    public partial class ConfermaNumero : Form
    {
        public int NumeroTotale;
        public int[] NumeriBancali=new int[6];
        public int NBanc;

        public ConfermaNumero(int n)
        {
            InitializeComponent();
            NumeroTotale = n;
        }

        private void ConfermaNumero_Load(object sender, EventArgs e)
        {
            Disabilita();
            textBox1.Text = NumeroTotale.ToString();
        }

        private void Disabilita()
        {
            button1.Enabled = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bancali;
            Disabilita();
            Inizializza();
            bancali = Convert.ToInt32(comboBox1.SelectedItem);
            if (bancali==1)
            {
                button1.Enabled = true;
                textBox2.Text = NumeroTotale.ToString();
            }
            if (bancali == 2)
            {
                Mostra(2);
                textBox2.Text = (NumeroTotale / 2).ToString();
                textBox3.Text = (NumeroTotale / 2).ToString();
            }
            if (bancali == 3)
            {
                Mostra(3);
                textBox2.Text = (NumeroTotale / 3).ToString();
                textBox3.Text = (NumeroTotale / 3).ToString();
                textBox4.Text = (NumeroTotale / 3).ToString();
            }
            if (bancali == 4)
            {
                Mostra(4);
                textBox2.Text = (NumeroTotale / 4).ToString();
                textBox3.Text = (NumeroTotale / 4).ToString();
                textBox4.Text = (NumeroTotale / 4).ToString();
                textBox7.Text = (NumeroTotale / 4).ToString();
            }
            if (bancali == 5)
            {
                Mostra(5);
                textBox2.Text = (NumeroTotale / 5).ToString();
                textBox3.Text = (NumeroTotale / 5).ToString();
                textBox4.Text = (NumeroTotale / 5).ToString();
                textBox7.Text = (NumeroTotale / 5).ToString();
                textBox6.Text = (NumeroTotale / 5).ToString();
            }
            if (bancali == 6)
            {
                Mostra(6);
                textBox2.Text = (NumeroTotale / 6).ToString();
                textBox3.Text = (NumeroTotale / 6).ToString();
                textBox4.Text = (NumeroTotale / 6).ToString();
                textBox7.Text = (NumeroTotale / 6).ToString();
                textBox6.Text = (NumeroTotale / 6).ToString();
                textBox5.Text = (NumeroTotale / 6).ToString();
            }
            if (bancali!=1) ControllaSomma();
        }

        private void Inizializza()
        {
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumeriBancali[0] = Convert.ToInt32(textBox2.Text);
            NumeriBancali[1] = Convert.ToInt32(textBox3.Text);
            NumeriBancali[2] = Convert.ToInt32(textBox4.Text);
            NumeriBancali[3] = Convert.ToInt32(textBox7.Text);
            NumeriBancali[4] = Convert.ToInt32(textBox6.Text);
            NumeriBancali[5] = Convert.ToInt32(textBox5.Text);
            NBanc =Convert.ToInt32(comboBox1.SelectedItem);
            this.Close();
        }

        private void Mostra(int n)
        {
            if (n==2)
            {
                label3.Visible = true;
                label4.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                label9.Visible = true;
                textBox8.Visible = true;
            }
            if (n==3)
            {
                Mostra(2);
                label5.Visible = true;
                textBox4.Visible = true;
            }
            if (n == 4)
            {
                Mostra(3);
                label8.Visible = true;
                textBox7.Visible = true;
            }
            if (n == 5)
            {
                Mostra(4);
                label7.Visible = true;
                textBox6.Visible = true;
            }
            if (n == 6)
            {
                Mostra(5);
                label6.Visible = true;
                textBox5.Visible = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ControllaSomma();
        }

        private void ControllaSomma()
        {
            int n1=0, n2=0, n3=0, n4=0, n5=0, n6=0, somma;
            try
            {
                n1 = Convert.ToInt32(textBox2.Text);
                n2 = Convert.ToInt32(textBox3.Text);
                n3 = Convert.ToInt32(textBox4.Text);
                n4 = Convert.ToInt32(textBox5.Text);
                n5 = Convert.ToInt32(textBox6.Text);
                n6 = Convert.ToInt32(textBox7.Text);
            }
            catch
            {
            }
            somma = n1 + n2 + n3 + n4 + n5 + n6;
            textBox8.Text = somma.ToString();
            if (somma == NumeroTotale) button1.Enabled = true;
            else button1.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ControllaSomma();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            ControllaSomma();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            ControllaSomma();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            ControllaSomma();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            ControllaSomma();
        }
    }
}
