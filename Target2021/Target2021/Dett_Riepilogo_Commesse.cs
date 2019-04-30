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
        BindingSource source = new BindingSource();
        string stringa_connessione= Properties.Resources.StringaConnessione;
        DataTable dataTable = new DataTable();

        public Dett_Riepilogo_Commesse(int numero)
        {           InitializeComponent();           indice = numero;       }

        private void Dett_Riepilogo_Commesse_Load(object sender, EventArgs e)
        {            caricamento_dati();      }

        private void caricamento_dati()
        {
            switch (indice)
            {
                case 0:
                    query = "Select CodCommessa,DataCommessa,IDCliente,DataConsegna,NRPezziDaLavorare,CodArticolo,IDMateriaPrima,IDFornitore,ImpegnataMatPrima FROM Commesse WHERE TipoCommessa=1 AND Stato=0";
                    break;
                case 1:
                    query = "Select CodCommessa,DataCommessa,IDCliente,DataConsegna,NRPezziDaLavorare,CodArticolo,IDMateriaPrima,IDFornitore,ImpegnataMatPrima FROM Commesse WHERE TipoCommessa=1 AND Stato=1";
                    break;
                case 2:
                    query = "Select CodCommessa,DataCommessa,IDCliente,DataConsegna,NRPezziDaLavorare,CodArticolo,IDMateriaPrima,IDFornitore,ImpegnataMatPrima FROM Commesse WHERE TipoCommessa=1 AND Stato=2";
                    break;
                case 3:
                    query = "Select CodCommessa,DataCommessa,IDCliente,DataConsegna,NRPezziDaLavorare,CodArticolo,IDMateriaPrima,IDFornitore,ImpegnataMatPrima FROM Commesse WHERE TipoCommessa=1 AND Stato=3";
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
                    query = "Select CodCommessa,DataCommessa,IDCliente,DataConsegna,NRPezziDaLavorare,CodArticolo,NrPezziCorretti, NrPezziScartati, SecondiCicloTaglio FROM Commesse WHERE TipoCommessa=3 AND Stato=0";
                    break;
                case 8:
                    query = "Select CodCommessa,DataCommessa,IDCliente,DataConsegna,NRPezziDaLavorare,CodArticolo,NrPezziCorretti, NrPezziScartati, SecondiCicloTaglio FROM Commesse WHERE TipoCommessa=3 AND Stato=1";
                    break;
                case 9:
                    query = "Select CodCommessa,DataCommessa,IDCliente,DataConsegna,NRPezziDaLavorare,CodArticolo,NrPezziCorretti, NrPezziScartati, SecondiCicloTaglio FROM Commesse WHERE TipoCommessa=3 AND Stato=2";
                    break;
                case 13:
                    query = "Select CodCommessa,DataCommessa,IDCliente,DataConsegna,NRPezziDaLavorare,CodArticolo,IDMateriaPrima,IDFornitore,ImpegnataMatPrima FROM Commesse WHERE TipoCommessa=1 AND Stato=4";
                    break;
                case 41:
                    query = "Select CodCommessa,DataCommessa,IDCliente,DataConsegna,NRPezziDaLavorare,CodArticolo,IDMinuteria,Qtaminuteria FROM Commesse WHERE TipoCommessa=4 AND Stato=0";
                    break;
                case 42:
                    query = "Select CodCommessa,DataCommessa,IDCliente,DataConsegna,NRPezziDaLavorare,CodArticolo,IDMinuteria,Qtaminuteria FROM Commesse WHERE TipoCommessa=4 AND Stato=1";
                    break;
                case 43:
                    query = "Select CodCommessa,DataCommessa,IDCliente,DataConsegna,NRPezziDaLavorare,CodArticolo,IDMinuteria,Qtaminuteria FROM Commesse WHERE TipoCommessa=4 AND Stato=2";
                    break;
            }
            SqlConnection conn = new SqlConnection(stringa_connessione);
            SqlCommand comando = new SqlCommand(query, conn);
            conn.Open();
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.SelectCommand = comando;
            SDA.Fill(dataTable);
            source.DataSource = dataTable;
            dataGridView1.DataSource = source;
            SDA.Update(dataTable);
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {            ricerca();       }

        private void ricerca()
        {
            if (comboBox1.Text == "Codice") source.Filter = "CodCommessa LIKE '*" + textBox1.Text + "*'";
            if (comboBox1.Text == "Data") source.Filter = "DataCommessa LIKE '*" + textBox1.Text + "*'";
            dataGridView1.DataSource = source;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {           ricerca();       }
    }
}
