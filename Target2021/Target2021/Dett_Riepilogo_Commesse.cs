using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021
{
    public partial class Dett_Riepilogo_Commesse : Form
    {
        int indice;
        string query="";
        string mio;
        string stringa_connessione= Properties.Resources.StringaConnessione;
        DataTable dataTable = new DataTable();
        public Dett_Riepilogo_Commesse(int numero)
        {
            InitializeComponent();
            indice = numero;
        }

        private void Dett_Riepilogo_Commesse_Load(object sender, EventArgs e)
        {
            caricamento_dati();
        }
        private void caricamento_dati()
        {
            switch (indice)
            {
                case 1:
                    query = "Select CodCommessa,DataCommessa,IDCliente,DataConsegna,NRPezziDaLavorare,CodArticolo,IDMateriaPrima,IDFornitore,ImpegnataMatPrima FROM Commesse WHERE TipoCommessa=1 AND Stato=0";
                    break;
                case 2:
                    query = "Select CodCommessa,DataCommessa,IDCliente,DataConsegna,NRPezziDaLavorare,CodArticolo,IDMateriaPrima,IDFornitore,ImpegnataMatPrima FROM Commesse WHERE TipoCommessa=1 AND Stato=1";
                    break;
                case 3:
                    query = "Select CodCommessa,DataCommessa,IDCliente,DataConsegna,NRPezziDaLavorare,CodArticolo,IDMateriaPrima,IDFornitore,ImpegnataMatPrima FROM Commesse WHERE TipoCommessa=1 AND Stato=2";
                    break;
                case 4:
                    query = "Select CodCommessa,DataCommessa,IDCliente,DataConsegna,NRPezziDaLavorare,CodArticolo,IDMateriaPrima,IDFornitore,ImpegnataMatPrima FROM Commesse WHERE TipoCommessa=2 AND Stato=0";
                    break;
                case 5:
                    query = "Select CodCommessa,DataCommessa,IDCliente,DataConsegna,NRPezziDaLavorare,CodArticolo,IDMateriaPrima,IDFornitore,ImpegnataMatPrima FROM Commesse WHERE TipoCommessa=2 AND Stato=1";
                    break;
                case 6:
                    query = "Select CodCommessa,DataCommessa,IDCliente,DataConsegna,NRPezziDaLavorare,CodArticolo,IDMateriaPrima,IDFornitore,ImpegnataMatPrima FROM Commesse WHERE TipoCommessa=2 AND Stato=2";
                    break;
                case 7:
                    query = "Select CodCommessa,DataCommessa,IDCliente,DataConsegna,NRPezziDaLavorare,CodArticolo,IDMateriaPrima,IDFornitore,ImpegnataMatPrima FROM Commesse WHERE TipoCommessa=3 AND Stato=0";
                    break;
                case 8:
                    query = "Select CodCommessa,DataCommessa,IDCliente,DataConsegna,NRPezziDaLavorare,CodArticolo,IDMateriaPrima,IDFornitore,ImpegnataMatPrima FROM Commesse WHERE TipoCommessa=3 AND Stato=1";
                    break;
                case 9:
                    query = "Select CodCommessa,DataCommessa,IDCliente,DataConsegna,NRPezziDaLavorare,CodArticolo,IDMateriaPrima,IDFornitore,ImpegnataMatPrima FROM Commesse WHERE TipoCommessa=3 AND Stato=2";
                    break;
            }
            SqlConnection conn = new SqlConnection(stringa_connessione);
            SqlCommand comando = new SqlCommand(query, conn);
            conn.Open();
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.SelectCommand = comando;
            SDA.Fill(dataTable);
            BindingSource source = new BindingSource();
            source.DataSource = dataTable;
            dataGridView1.DataSource = source;
            SDA.Update(dataTable);
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ricerca();
        }
        private void ricerca()
        {
            BindingSource risorsa = new BindingSource();
            risorsa.DataSource = dataTable;
            if (comboBox1.Text == "Codice articolo")
            {

            }
           
        }
    }
}
