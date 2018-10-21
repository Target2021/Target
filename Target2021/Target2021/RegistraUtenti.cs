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
