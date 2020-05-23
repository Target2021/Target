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
    public partial class CheckTaglio : Form
    {
        
        public CheckTaglio()
        {
            InitializeComponent();
        }

        private void CheckTaglio_Load(object sender, EventArgs e)
        {
            aggiorna();
            WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aggiorna();
        }

        private void aggiorna()
        {
            String stringa = Properties.Resources.StringaConnessione;
            string query = "SELECT taglio.CodCommessa AS Codice, taglio.NrCommessa AS Numero, taglio.DataCommessa AS Data, taglio.IDCliente AS Cliente, taglio.DescrArticolo AS Articolo, taglio.IDMachTaglio AS Macchina, macchina.Descrizione AS Macchinario, taglio.IDDima AS Dima, taglio.NrPezziDaLavorare AS Pezzi, taglio.NrPezziCorretti AS GiàTagliati " +
                "FROM Commesse AS taglio " +
                "INNER JOIN Commesse AS stampo " +
                "ON taglio.NrCommessa = stampo.NrCommessa " +
                "INNER JOIN MacchineTaglio AS macchina " +
                "ON taglio.IDMachTaglio = macchina.IDTaglio " +
                "WHERE stampo.TipoCommessa = 2 AND taglio.TipoCommessa = 3 AND(taglio.Stato = 0 OR taglio.Stato = 1) AND (stampo.Stato = 0 OR stampo.Stato = 1 OR stampo.Stato = 2)" +
                "ORDER BY stampo.Stato DESC";
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

        private void colora()
        {
            int numcom, stato;

            foreach (DataGridViewRow riga in dataGridView1.Rows)
            {
                numcom = Convert.ToInt32(riga.Cells["Numero"].Value);
                stato=ControllaStatoStampo(numcom);
                if (stato == 0)
                {
                    riga.DefaultCellStyle.BackColor = Color.Orange;
                }
                if (stato == 1)
                {
                    riga.DefaultCellStyle.BackColor = Color.Yellow;
                }
                if (stato == 2)
                {
                    riga.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
            dataGridView1 .Update();
        }

        private int ControllaStatoStampo(int NC)    // oltre a colorare potrebbe valorizzare la colonna (da creare) con il nr dei pezzi stampati
        {
            string stringaconnessione, sql;
            int StatoStampo;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT Stato FROM Commesse WHERE NrCommessa = " + NC.ToString() + " AND TipoCommessa = 2";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            StatoStampo = Convert.ToInt32(comando.ExecuteScalar());
            connessione.Close();
            return StatoStampo;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
            colora();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idcommessa;
            idcommessa = dataGridView1.Rows[e.RowIndex].Cells["Codice"].Value.ToString();

            LavoraTaglio_cs LavTag = new LavoraTaglio_cs(idcommessa);
            LavTag.ShowDialog();
            aggiorna();
        }
    }
}
