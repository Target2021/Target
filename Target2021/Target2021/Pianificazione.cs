using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021
{
    public partial class Pianificazione : Form
    {
        public String CodiceCommessa;

        public Pianificazione(String cc)
        {
            InitializeComponent();
            CodiceCommessa = cc;
        }

        private void Pianificazione_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            textBox3.Enabled = false;
            button1.Enabled = false;
            textBox1.Text = CodiceCommessa;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query="SELECT CodCommessa FROM Commesse WHERE CodCommessa='"+textBox1.Text+"'";
            string querylastre="SELECT NrLastreRichieste FROM Commesse WHERE CodCommessa='"+textBox1.Text+"'";
            SqlConnection conn = new SqlConnection(Properties.Resources.StringaConnessione);
            SqlCommand comando = new SqlCommand(query, conn);
            conn.Open();
            try
            {
                textBox1.Text = Convert.ToString(comando.ExecuteScalar());
                if (textBox1.Text != "")
                {
                    textBox2.Enabled = true;
                    textBox3.Enabled = true;
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ordine fornitore non presente, si prega di controllare il codice commessa");
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    radioButton1.Enabled =false;
                    radioButton2.Enabled = false;
                }
                }
            catch (Exception EX)
            {
                MessageBox.Show("Ordine fornitore non presente, si prega di controllare il codice della commessa");
            }           
            try {
                comando.CommandText = querylastre;
                textBox2.Text = Convert.ToString(comando.ExecuteScalar());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ordine fornitore non presente, si prega di controllare il codice della commessa");
            }
            conn.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label2.Visible = true;
                textBox3.Visible = true;
            } else
            {
                label2.Visible = false;
                textBox3.Visible = false;
            }
        }
}
