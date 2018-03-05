using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021
{
    public partial class Testata_Ordini : Form
    {
        public Testata_Ordini()
        {
            InitializeComponent();
        }

        private void testata_ordini_multirigaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.testata_ordini_multirigaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void Testata_Ordini_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.testata_ordini_multiriga'. È possibile spostarla o rimuoverla se necessario.
            this.testata_ordini_multirigaTableAdapter.Fill(this.target2021DataSet.testata_ordini_multiriga);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (Filtro.SelectedIndex)
            {
                case 0:
                    Filtro_Dati("SELECT * FROM testata_ordini_multiriga WHERE numero_ordine LIKE '%" + textBox1.Text + "%'");
                    break;
                case 1:
                    Filtro_Dati("SELECT * FROM testata_ordini_multiriga WHERE data_ordine LIKE '%" + textBox1.Text + "%'");
                    break;
                case 2:
                    Filtro_Dati("SELECT * FROM testata_ordini_multiriga WHERE codice_cliente LIKE '%" + textBox1.Text + "%'");
                    break;
            }
        }

        public void Filtro_Dati(string query)
        {
            String Stringaconn = "Data Source=target2021.database.windows.net;Initial Catalog=Target2021;User ID=Amministratore;Password=Barilla23";
            SqlConnection conn = new SqlConnection(Stringaconn);
            SqlCommand comando = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            testata_ordini_multirigaDataGridView.DataSource = dataTable;
        }
    }
}
