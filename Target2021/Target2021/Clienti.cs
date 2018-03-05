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
    public partial class Clienti : Form
    {
        public Clienti()
        {
            InitializeComponent();
        }

        private void clientiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void Clienti_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.clienti'. È possibile spostarla o rimuoverla se necessario.
            this.clientiTableAdapter.Fill(this.target2021DataSet.clienti);

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (Filter.Text == "Codice")
            {
                Search_Filter("SELECT * FROM clienti WHERE codice LIKE '%" + textBox1.Text + "%'");
            }
            if (Filter.Text == "Ragione_sociale")
            {
                Search_Filter("SELECT * FROM clienti WHERE ragione_sociale LIKE '%" + textBox1.Text + "%'");
            }
            if (Filter.Text == "Località")
            {
                ControlNumber(textBox1.Text);       
                Search_Filter("SELECT * FROM clienti WHERE localita LIKE '%" + textBox1.Text + "%'");
            }
        }
        public void ControlNumber(string frase)
        {
            string words = frase;
            int parsedvalue;
            foreach (char word in words)
            {
                if (int.TryParse(Convert.ToString(word), out parsedvalue))
                {
                    MessageBox.Show("non sono ammessi valori numerici");
                    textBox1.Text = "";
                    return;
                }
            }
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
                clientiDataGridView.DataSource = source;
                sda.Update(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Filter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
