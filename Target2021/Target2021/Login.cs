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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string stringaconnessione = Properties.Resources.StringaConnessione;
                SqlConnection con = new SqlConnection(stringaconnessione);
                string query = "SELECT * FROM Utenti WHERE Nome ='" + textBox1.Text + "' AND Password='" + textBox2.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(query, con);
                con.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    string NomeUtente = textBox1.Text;
                    string Password = textBox2.Text;
                    Home home = new Home(NomeUtente, Password);
                    this.Hide();
                    home.ShowDialog();
                    con.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("verificare le credenziali di accesso");
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            RegistraUtenti registraUtenti = new RegistraUtenti();
            this.Hide();
            registraUtenti.ShowDialog();
            this.Close();
        }
    }
}
