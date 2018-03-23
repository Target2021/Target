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
            String stringa = "Data Source=target2021.database.windows.net;Initial Catalog=Target2021;User ID=Amministratore;Password=Barilla23";
            string query = "SELECT IDCommessa,CodCommessa,DataCommessa,IDCliente,DataConsegna,NRPezziDaLavorare,DescrArticolo,IDStampo,NrPezziOrdinati,IDMateriaPrima FROM Commesse WHERE TipoCommessa=2 AND Stato IN (SELECT Stato FROM Commesse WHERE Stato=1 OR Stato=0)";
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
        private void CheckGiacenza(int index)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Index == index)
                {
                    button1.Enabled = true;
                    int quantita = Convert.ToInt32(row.Cells[8].Value);
                    String stringa = "Data Source=target2021.database.windows.net;Initial Catalog=Target2021;User ID=Amministratore;Password=Barilla23";
                    string query = "SELECT Giacenza FROM GiacenzeMagazzini WHERE idPrime='" + Convert.ToString(row.Cells[9].Value) + "'";
                    SqlConnection con = new SqlConnection(stringa);
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    int Giacenza = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                    int diff = Giacenza - quantita;
                    if (diff < 0)
                    {
                        MessageBox.Show("giacenza non sufficiente, si prega di effettuare il riordino");
                        button1.Enabled = false;
                        button1.BackColor = Color.Red;
                    }
                    if (Enumerable.Range(1, 10).Contains(diff))
                    {
                        MessageBox.Show("materia prima in esaurimento, si prega di effettuare il riordino ", "Giacenza", MessageBoxButtons.YesNo);
                        button1.Enabled = true;
                        button1.BackColor = Color.Yellow;
                    }
                    if (diff > 10)
                    {
                        button1.Enabled = true;
                        button1.BackColor = Color.Green;
                    }
                }
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CheckGiacenza(e.RowIndex);
        }
    }
}
