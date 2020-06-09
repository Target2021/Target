using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Target2021
{
    public partial class Login : Form
    {
        public string NomeUtente;
        public int livello;    // 1 = admin 2=stampaggio 3=taglio
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
                NomeUtente = comboBox1.SelectedValue.ToString();
                string query = "SELECT * FROM Utenti WHERE Nome ='" + NomeUtente + "' AND Password='" + textBox2.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(query, con);
                con.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                con.Close();
                if (dt.Rows.Count == 1)
                {
                    // NomeUtente = textBox1.Text;
                    //  NomeUtente = comboBox1.SelectedText;
                    livello =Convert .ToInt32(dt.Rows[0][3]);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("verificare le credenziali di accesso");
                }
            }
            catch (Exception ex)
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

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Utenti'. È possibile spostarla o rimuoverla se necessario.
            this.utentiTableAdapter.Fill(this.target2021DataSet.Utenti);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            livello = 0;
            this.Close();
        }
    }
}
