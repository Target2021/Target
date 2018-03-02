using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Target2021
{
    public partial class Testata : Form
    {
        public Testata()
        {
            InitializeComponent();
        }

        private void testata_ordini_multirigaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.testata_ordini_multirigaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void Testata_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.testata_ordini_multiriga'. È possibile spostarla o rimuoverla se necessario.
            this.testata_ordini_multirigaTableAdapter.Fill(this.target2021DataSet.testata_ordini_multiriga);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            String stringa = "Data Source=target2021.database.windows.net;Initial Catalog=Target2021;Persist Security Info=True;User ID=Amministratore;Password=Barilla23";
            using (SqlConnection con = new SqlConnection(stringa))
            {
                string variabile = textBox1.Text;
                string query = "SELECT * FROM testata_ordini_multiriga WHERE numero_ordine LIKE '" + variabile+ "'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteScalar();
                con.Close();
            }
        }
    }
}
