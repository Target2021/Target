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
    public partial class CheckStampaggio : Form
    {
        public CheckStampaggio()
        {
            InitializeComponent();
        }

        private void CheckStampaggio_Load(object sender, EventArgs e)
        {
            string stringaconnessione = Properties.Resources.StringaConnessione;
            string query = "SELECT * FROM Commesse WHERE TipoCommessa=2 AND Stato=1 OR Stato=0";
            SqlConnection sql = new SqlConnection(stringaconnessione);
            SqlCommand cmd = new SqlCommand(query,sql);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
            sqlDataAdapter.Fill(dt);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            dataGridView1.DataSource = bindingSource;
            sqlDataAdapter.Update(dt);
        }
    }
}
