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
    public partial class CheckStampaggio : Form
    {
        private string idcommessa;

        public CheckStampaggio()
        {
            InitializeComponent();
        }

        private void CheckStampaggio_Load(object sender, EventArgs e)
        {
            LoadStampaggio();
            button1.Enabled = false;
            button1.BackColor = Color.Gray;
        }

        private void LoadStampaggio()
        {
            String stringa = Properties.Resources.StringaConnessione;
            string query = "SELECT CodCommessa,DataCommessa,IDCliente,DataConsegna,NRPezziDaLavorare,DescrArticolo,IDStampo,NrPezziOrdinati,IDMateriaPrima FROM Commesse WHERE TipoCommessa=2 AND (Stato=0 OR Stato=1)";
            SqlConnection con = new SqlConnection(stringa);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            BindingSource source = new BindingSource();
            source.DataSource = dataTable;
            dataGridView1.DataSource = source;
            sda.Update(dataTable);
            con.Close();
        }

        private void CheckGiacenzaTotale()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    button1.Enabled = false;
                    int quantita = Convert.ToInt32(row.Cells[7].Value);
                    String stringa = Properties.Resources.StringaConnessione;
                    string query = "SELECT Giacenza FROM GiacenzeMagazzini WHERE idPrime='" + Convert.ToString(row.Cells[8].Value) + "'";
                    SqlConnection con = new SqlConnection(stringa);
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    int Giacenza = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                    int diff = Giacenza - quantita;
                    if (diff < 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                    if (Enumerable.Range(1, 10).Contains(diff))
                    {
                        button1.Enabled = true;;
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    if (diff > 10)
                    {
                        button1.Enabled = true;
                        row.DefaultCellStyle.BackColor = Color.Green;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void CheckGiacenzaRow(int index)
        {
            try
            {
                idcommessa = Convert.ToString(dataGridView1.Rows[index].Cells[0].Value);
                idcommessa.Replace("  ", string.Empty);
                button1.Enabled = false;
                int quantita = Convert.ToInt32(dataGridView1.Rows[index].Cells[7].Value);
                String stringa = Properties.Resources.StringaConnessione;
                string query = "SELECT Giacenza FROM GiacenzeMagazzini WHERE idPrime='" + Convert.ToString(dataGridView1.Rows[index].Cells[8].Value) + "'";
                SqlConnection con = new SqlConnection(stringa);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                int Giacenza = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                int diff = Giacenza - quantita;
                if (diff < 0)
                {
                    dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.Red;
                    MessageBox.Show("Giacenza insufficiente, si prega di effettuare il riordino");
                }
                if (Enumerable.Range(1, 10).Contains(diff))
                {
                    button1.Enabled = true; ;
                    dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.Yellow;
                    LavoraStampaggio lavoraStampaggio = new LavoraStampaggio(idcommessa);
                    lavoraStampaggio.Show();
                }
                if (diff > 10)
                {
                    button1.Enabled = true;
                    dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.Green;
                    LavoraStampaggio lavoraStampaggio = new LavoraStampaggio(idcommessa);
                    lavoraStampaggio.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadStampaggio();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CheckGiacenzaTotale();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CheckGiacenzaRow(e.RowIndex);
        }
    }
}