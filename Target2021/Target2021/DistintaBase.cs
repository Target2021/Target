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
    public partial class DistintaBase : Form
    {
        string stringaconnessione = Properties.Resources.StringaConnessione;
        public DistintaBase()
        {
            InitializeComponent();
        }

        private void DistintaBase_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet7.Fornitori'. È possibile spostarla o rimuoverla se necessario.
            this.fornitoriTableAdapter.Fill(this.target2021DataSet.Fornitori);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet5.Prime'. È possibile spostarla o rimuoverla se necessario.
            this.primeTableAdapter.Fill(this.target2021DataSet.Prime);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.articoli_semplici'. È possibile spostarla o rimuoverla se necessario.
            this.articoli_sempliciTableAdapter.Fill(this.target2021DataSet.articoli_semplici);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string codice = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = codice;
            string descrizione = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = descrizione;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Codice") articolisempliciBindingSource.Filter = "codice LIKE '*" + textBox1.Text + "*'";
            if (comboBox1.Text == "Descrizione") articolisempliciBindingSource.Filter = "descrizione LIKE '*" + textBox1.Text + "*'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int maxidi = 0;
            string sql = "SELECT MAX(IDDettaglioArticolo) AS idmax FROM DettArticoli";
            SqlConnection connection = new SqlConnection(stringaconnessione);
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader dati = cmd.ExecuteReader();
            while (dati.Read())
            {
                maxidi = (int)dati["idmax"];// conversione in intero 
            }
            dati.Close();
            connection.Close();

            maxidi++;

            SqlCommand Command = new SqlCommand();
            Command.Connection = connection;
            Command.CommandText = "INSERT INTO Iscrizioni VALUES (@IDI, @IDA, @IDC, @mar, @mer, @gio,0,0,0,@data)";
            Command.Parameters.AddWithValue("@IDI", maxidi);
            //Command.Parameters.AddWithValue("@IDA", mio);
            //Command.Parameters.AddWithValue("@IDC", idcorso);
            //Command.Parameters.AddWithValue("@mar", mar);
            //Command.Parameters.AddWithValue("@mer", mer);
            //Command.Parameters.AddWithValue("@gio", gio);
            //Command.Parameters.AddWithValue("@data", timestamp);
            connection.Open();
            int righe = Command.ExecuteNonQuery();
            // if (righe >0) 
            connection.Close();
        }
    }
}
