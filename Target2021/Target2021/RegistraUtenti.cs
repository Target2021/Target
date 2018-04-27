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
    public partial class RegistraUtenti : Form
    {
        public string stringaconnessione = Properties.Resources.StringaConnessione;
        public RegistraUtenti()
        {
            InitializeComponent();
            Login login = new Login();
            login.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
   
        }
        public void Registra()
        {
            try
            {
                
                SqlConnection con = new SqlConnection(stringaconnessione);
                string query = "SELECT * FROM Utenti WHERE Nome ='" + textBox1.Text + "' AND Cognome='" + textBox3.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(query, con);
                con.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                con.Close();
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("l'utente esiste già");
                }
                else
                {
                    SqlConnection conn = new SqlConnection(stringaconnessione);
                    string query1 = "INSERT INTO Utenti(IDutente,Nome,Cognome,Password,Livello) VALUES(@id,@nom,@cognome,@pass,@livello)";
                    string query2 = "SELECT MAX(IDutente) FROM Utenti";
                    SqlCommand sqlCommand2 = new SqlCommand(query1, conn);
                    SqlCommand sqlCommand3 = new SqlCommand(query2, conn);
                    conn.Open();
                    int id = Convert.ToInt32(sqlCommand3.ExecuteScalar()) + 1;
                    sqlCommand2.Parameters.Add(new SqlParameter("@id", id));
                    sqlCommand2.Parameters.Add(new SqlParameter("@nom", textBox1.Text));
                    sqlCommand2.Parameters.Add(new SqlParameter("@cognome", textBox3.Text));
                    sqlCommand2.Parameters.Add(new SqlParameter("@pass", textBox2.Text));
                    sqlCommand2.Parameters.Add(new SqlParameter("@livello", comboBox1.SelectedItem.ToString()));
                    SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(sqlCommand2);
                    DataTable dt2 = new DataTable();
                    sqlDataAdapter2.Fill(dt2);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void utentiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utentiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }
        private void RegistraUtenti_Load(object sender, EventArgs e)
        {
            this.utentiTableAdapter.Fill(this.target2021DataSet.Utenti);
        }
    }
}
