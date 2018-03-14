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
           string stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection con = new SqlConnection(stringaconnessione);
            string query = "SELECT * FROM Utenti WHERE Nome ='" + textBox1.Text + "' AND Password='" + textBox2.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            if(dt.Rows.Count==1)
            {
                MessageBox.Show("Benvenuto");
            }
            
        }
    }
}
