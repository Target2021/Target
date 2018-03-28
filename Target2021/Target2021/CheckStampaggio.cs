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
        public int idcommessa;
        public CheckStampaggio()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void CheckStampaggio_Load(object sender, EventArgs e)
        {
            LoadStampaggio();
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
            CheckGiacenza();
        }

        private void CheckGiacenza()
        {
            dataGridView1.ClearSelection();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                    try
                    {
                        //idcommessa = Convert.ToInt32(row.Cells[0].Value);
                        //MessageBox.Show(idcommessa.ToString());
                        button1.Enabled = true;
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
                            //MessageBox.Show("giacenza non sufficiente, si prega di effettuare il riordino");
                            button1.Enabled = false;
                            button1.BackColor = Color.Red;
                            row.DefaultCellStyle.BackColor = Color.Red;
                        }
                        if (Enumerable.Range(1, 10).Contains(diff))
                        {
                            //MessageBox.Show("materia prima in esaurimento, si prega di effettuare il riordino ", "Giacenza", MessageBoxButtons.OK);
                            button1.Enabled = true;
                            button1.BackColor = Color.Yellow;
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                        }
                        if (diff > 10)
                        {
                            button1.Enabled = true;
                            button1.BackColor = Color.Green;
                            dataGridView1.Rows[row.Index].DefaultCellStyle.BackColor = Color.Green;
                        
                            //LavoraStampaggio lavoraStampaggio = new LavoraStampaggio(idcommessa);
                            //lavoraStampaggio.Show();
                       
                        }
                        dataGridView1.Refresh();
                    }
                    catch(Exception ex) {
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
            dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Green;
            dataGridView1.Rows[1].DefaultCellStyle.BackColor = Color.Yellow;
        }
    }
}
