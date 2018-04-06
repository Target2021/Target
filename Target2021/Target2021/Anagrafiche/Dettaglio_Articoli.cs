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
    public partial class Dettaglio_Articoli : Form
    {
        public Dettaglio_Articoli()
        {
            InitializeComponent();
        }

        private void Dettaglio_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.DettArticoli'. È possibile spostarla o rimuoverla se necessario.
            this.dettArticoliTableAdapter.Fill(this.target2021DataSet.DettArticoli);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (Filter.Text == "IDArticolo")
            {
                Search_Filter("SELECT * FROM DettArticoli WHERE IDDettaglioArticolo LIKE '" + textBox1.Text + "'");
            }
            if (Filter.Text == "Progressivo")
            {
                //backgroundWorker1.RunWorkerAsync( ControlLetters(textBox1.Text));
                Search_Filter("SELECT * FROM DettArticoli WHERE progressivo LIKE '%" + textBox1.Text + "%'");
            }
            if (Filter.Text == "Codice_articolo")
            {
                Search_Filter("SELECT * FROM DettArticoli WHERE codice_articolo LIKE '%" + textBox1.Text + "%'");
            }
        }

        public int ControlLetters(string frase)
        {
            int parsedValue;
            if (!int.TryParse(frase, out parsedValue)) //se restituisce falso vuol dire che nella stringa ci sono lettere
            {
                MessageBox.Show("non sono ammesse lettere");
                textBox1.Text = "";
                return 0;
            }
            return 0;
        }

        public void Search_Filter(string query) //metodo di connessione al db
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
                dettArticoliDataGridView.DataSource = source;
                sda.Update(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Button2_Click(sender, e);
            }

        }

        private void dettArticoliBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.dettArticoliBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }

        private void Ordina(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //this.dettArticoliDataGridView.Sort(this.dettArticoliDataGridView.Columns[0], ListSortDirection.Ascending);
        }

        private void SelezionaRiga(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = Convert.ToInt32(dettArticoliDataGridView.Rows[dettArticoliDataGridView.SelectedCells[0].RowIndex].Cells["IDDettaglioArticolo"].Value);
            RigaCompleta rigaCompleta = new RigaCompleta(id);
            rigaCompleta.MdiParent = this.MdiParent;
            rigaCompleta.Show();
        }
    }
}
