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

namespace Target2021.Fornitori
{
    public partial class CommesseCollegate : Form
    {
        private int IdOrdFornDett;

        public CommesseCollegate(int IdOFD)
        {
            InitializeComponent();
            IdOrdFornDett = IdOFD;
        }

        private void CommesseCollegate_Load(object sender, EventArgs e)
        {
            string stringa_connessione = Properties.Resources.StringaConnessione;
            //string query = "SELECT * FROM Commesse WHERE iDCOmmessa=(SELECT IdCommessa FROM ImpegnateOrdinato WHERE IdOrdFornDett="+ IdOrdFornDett.ToString() + " AND QtaImpegnata>0)";
            string query = "SELECT CodCommessa,DataCommessa, IDCliente, NrPezziDaLavorare, CodArticolo, DescrArticolo, IDFornitore, IDMateriaPrima, NrLastreRichieste, ImpegnateOrdinato.QtaImpegnata FROM Commesse INNER JOIN ImpegnateOrdinato ON Commesse.IDCommessa = ImpegnateOrdinato.IdCommessa WHERE Commesse.IDCOmmessa = ImpegnateOrdinato.IdCommessa AND QtaImpegnata> 0 AND ImpegnateOrdinato.IdOrdFornDett=" + IdOrdFornDett.ToString() + "";
            SqlConnection connessione = new SqlConnection(stringa_connessione);
            SqlCommand comando = new SqlCommand(query, connessione);
            connessione.Open();
            //SqlDataReader dati = comando.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(comando.ExecuteReader());
            dataGridView1.DataSource = table;
            connessione.Close();
        }
    }
}
