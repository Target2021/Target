using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                bindingSource.DataSource = GetData("SELECT * FROM DettArticoli");
            }
        }
        public static DataTable GetData(string query)
        {
            DataTable dataTable = new DataTable();
            return dataTable;
        }
    }
}
