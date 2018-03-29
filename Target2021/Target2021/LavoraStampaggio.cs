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
    public partial class LavoraStampaggio : Form
    {
        public string IDCommessa;
        public LavoraStampaggio(string id)
        {
            InitializeComponent();
            IDCommessa = id;
        }

        private void commesseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }

        private void LavoraStampaggio_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            String stringa = "Data Source=target2021.database.windows.net;Initial Catalog=Target2021;User ID=Amministratore;Password=Barilla23";
            string query = "SELECT IDCommessa,DataCommessa,DataConsegna,NRPezziDaLavorare,NrPezziOrdinati,DataTermine,NrPezziCorretti,NrPezziScartati,OraInizioStampo,OraFineStampo,SecondiCicloTaglio,MinutiAttrezzaggio,Stato FROM Commesse WHERE CODCommessa='"+IDCommessa+"'";
            SqlConnection con = new SqlConnection(stringa);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            BindingSource source = new BindingSource();
            source.DataSource = dataTable;
            commesseDataGridView.DataSource = source;
            sda.Update(dataTable);
            con.Close();

        }

        private void commesseDataGridView_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
