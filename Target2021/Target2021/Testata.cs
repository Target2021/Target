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
          
        }
        public void Search_Filter(string query)
        {
             String stringa = "Data Source=target2021.database.windows.net;Initial Catalog=Target2021;User ID=Amministratore;Password=Barilla23";
            SqlConnection con = new SqlConnection(stringa);
            string variabile = textBox1.Text;
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                BindingSource source = new BindingSource();
                source.DataSource = dataTable;
                testata_ordini_multirigaDataGridView.DataSource = source;
                sda.Update(dataTable);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Filter.Text == "Numero_ordine")
            {
                Search_Filter("SELECT * FROM testata_ordini_multiriga WHERE numero_ordine LIKE '%" + textBox1.Text + "%'");
            }
            else { MessageBox.Show("Controllare il filtro di ricerca"); }
        }
    }
}
