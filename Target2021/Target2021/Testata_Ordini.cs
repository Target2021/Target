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
                    Filtro_Dati("SELECT * FROM testata_ordini_multiriga WHERE numero_ordine LIKE '" + textBox1.Text + "'");
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

        private void testata_ordini_multirigaDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in testata_ordini_multirigaDataGridView.Rows)
            {
                if (row.Index == testata_ordini_multirigaDataGridView.CurrentRow.Index)
                {
                    String id;
                    id = row.Cells[1].Value.ToString();
                    MessageBox.Show(id);
                    RigaCompleta rigaCompleta = new RigaCompleta();
                    rigaCompleta.MdiParent = this.MdiParent;
                    rigaCompleta.Show();
                    rigaCompleta.LoadRow(id, this.Text); //passo l'id in modo da caricare nell'altro form solo la riga interessata
                    //la condizione è che  la proprietà Text che gli passiamo deve essere uguale a quello di questo form così da identificare i vari form
                }
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
