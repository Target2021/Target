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
            cCToolStripTextBox.Text = IDCommessa;
            int i =0;
            RecuperoDate("SELECT DataCommessa FROM Commesse WHERE CODCommessa='" + IDCommessa + "'",i);
        }
        public void RecuperoDate(string query,int i)
        {
            for (i = 0; i < 3; i++)
            {
                String stringa = Properties.Resources.StringaConnessione;
                if(i==0)
                {
                    SqlConnection con = new SqlConnection(stringa);
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    string dateTime = cmd.ExecuteScalar().ToString();
                    DateTime dt = Convert.ToDateTime(dateTime);
                    dateTimePicker1.Value = dt;
                    con.Close();
                }
                if(i==1)
                {
                    query = "SELECT DataConsegna FROM Commesse WHERE CODCommessa='" + IDCommessa + "'";
                    SqlConnection con = new SqlConnection(stringa);
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    string dateTime = cmd.ExecuteScalar().ToString();
                    DateTime dt = Convert.ToDateTime(dateTime);
                    dateTimePicker2.Value = dt;
                    con.Close();
                }
                if(i==2)
                {
                    query = "SELECT DataTermine FROM Commesse WHERE CODCommessa='" + IDCommessa + "'";
                    SqlConnection con = new SqlConnection(stringa);
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    string dateTime = cmd.ExecuteScalar().ToString();
                    DateTime dt = Convert.ToDateTime(dateTime);
                    dateTimePicker3.Value = dt;
                    con.Close();
                }
            }
        }
        private void commesseDataGridView_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
          
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void commesseBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            String stringa = Properties.Resources.StringaConnessione;
            string query = " UPDATE Commesse SET  CodCommessa='"+codCommessaTextBox.Text+"', NrCommessa='"+nrCommessaTextBox.Text+"',IDCliente='"+iDClienteTextBox.Text+"',NrPezziDaLavorare='"+nrPezziDaLavorareTextBox.Text+"',CodArticolo='"+codArticoloTextBox.Text+"',DescrArticolo='"+descrArticoloTextBox.Text+"', IDStampo='"+iDStampoTextBox.Text+"',CodArtiDopoStampo='"+codArtiDopoStampoTextBox.Text+"',NrPezziCorretti='"+nrPezziCorrettiTextBox.Text+"',NrPezziScartati='"+nrPezziScartatiTextBox.Text+"', DataCommessa='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',DataConsegna='" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "',DataTermine='" + dateTimePicker3.Value.ToString("yyyy-MM-dd") + "',OraInizioStampo='"+dateTimePicker4.Value.ToString("yyyy-MM-dd") + " "+ dateTimePicker5.Value.ToLongTimeString() +  "',OraFineStampo='"+dateTimePicker5.Value.ToString("yyyy-MM-dd") + " "+dateTimePicker5.Value.ToLongTimeString()+"' WHERE CODCommessa='"+IDCommessa+"'";
            SqlConnection con = new SqlConnection(stringa);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.commesseTableAdapter.FillBy(this.target2021DataSet.Commesse, cCToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           DialogResult dialogResult= MessageBox.Show("Sicuro di apportare le seguenti modifiche?","Modifiche",MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                String stringa = Properties.Resources.StringaConnessione;
                string query = " UPDATE Commesse SET  CodCommessa='" + codCommessaTextBox.Text + "', NrCommessa='" + nrCommessaTextBox.Text + "',IDCliente='" + iDClienteTextBox.Text + "',NrPezziDaLavorare='" + nrPezziDaLavorareTextBox.Text + "',CodArticolo='" + codArticoloTextBox.Text + "',DescrArticolo='" + descrArticoloTextBox.Text + "', IDStampo='" + iDStampoTextBox.Text + "',CodArtiDopoStampo='" + codArtiDopoStampoTextBox.Text + "',NrPezziCorretti='" + nrPezziCorrettiTextBox.Text + "',NrPezziScartati='" + nrPezziScartatiTextBox.Text + "', DataCommessa='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',DataConsegna='" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "',DataTermine='" + dateTimePicker3.Value.ToString("yyyy-MM-dd") + "',OraInizioStampo='" + dateTimePicker4.Value.ToString("yyyy-MM-dd") + " " + dateTimePicker5.Value.ToLongTimeString() + "',OraFineStampo='" + dateTimePicker5.Value.ToString("yyyy-MM-dd") + " " + dateTimePicker5.Value.ToLongTimeString() + "',Stato='"+3+"' WHERE CODCommessa='" + IDCommessa + "'";
                SqlConnection con = new SqlConnection(stringa);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();
            }
        }
    }
}
