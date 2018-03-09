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
    public partial class RigaCompleta : Form
    {
        public RigaCompleta()
        {
            InitializeComponent();
        }
        internal void LoadRow(String ID,String form)
        {
            BindingSource bindingSource = new BindingSource();
            MessageBox.Show(ID,form);
            if (form == "Dettaglio_Articolo")
            {
                bindingSource.DataSource = GetData("SELECT * FROM DettArticoli WHERE IDDettaglioArticolo='"+ID+"'"); //ottengo i dati in base all'ID ottenuto dal form
                dataGridView1.DataSource = bindingSource;
            }
            if(form=="Testata")
            {
                bindingSource.DataSource = GetData("SELECT  * FROM ArticoliBC WHERE codice_articolo='" + ID + "'");
                dataGridView1.DataSource = bindingSource;
            }
            if(form=="Testata_Ordini")
            {
                bindingSource.DataSource = GetData("SELECT * FROM testata_ordini_multiriga WHERE numero_ordine='" + ID + "'");
                dataGridView1.DataSource = bindingSource;
            }
             DataTable GetData(string query) //metodo interno a LoadRow per ottenere i dati dal db
            {
                string stringa = "Data Source=target2021.database.windows.net;Initial Catalog=Target2021;Persist Security Info=True;User ID=Amministratore;Password=Barilla23";
                SqlConnection sqlConnection = new SqlConnection(stringa);
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = cmd;
                DataTable dataTable = new DataTable();
                dataTable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

    }
}
