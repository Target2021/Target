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
        public string idcommessa;
        public int i = 0;
        public CheckStampaggio()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void CheckStampaggio_Load(object sender, EventArgs e)
        {
            int[] index=new int[10000];
            LoadStampaggio();
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                index[i] = row.Index;
                CheckGiacenza(index[i],false);
                i++;
            }
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

        private void CheckGiacenza(int index,bool lavora)
        {
            try
            {
                idcommessa = Convert.ToString(dataGridView1.Rows[index].Cells[0].Value);
                idcommessa.Replace("  ", string.Empty);
                //MessageBox.Show(idcommessa.ToString());
                button1.Enabled = true;
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
                    button1.BackColor = Color.Red;
                }
                if (Enumerable.Range(1, 10).Contains(diff))
                {
                    MessageBox.Show("materia prima in esaurimento, si prega di effettuare il riordino ", "Giacenza", MessageBoxButtons.OK);
                    button1.Enabled = true;
                    button1.BackColor = Color.Yellow;
                    dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.Yellow;
                }
                if (diff > 10)
                {
                    button1.Enabled = true;
                    button1.BackColor = Color.Green;
                    dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.Green;
                    if (lavora)
                    {
                        LavoraStampaggio lavoraStampaggio = new LavoraStampaggio(idcommessa);
                        lavoraStampaggio.Show();
                    }                      
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
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
                        MessageBox.Show("materia prima in esaurimento, si prega di effettuare il riordino ", "Giacenza", MessageBoxButtons.OK);
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
        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void commesseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commesseBindingSource.EndEdit();
            this.dataGridView1.Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CheckGiacenza(e.RowIndex,false);
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CheckGiacenza(e.RowIndex,true);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CheckGiacenzaTotale();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
