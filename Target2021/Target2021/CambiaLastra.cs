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
    public partial class CambiaLastra : Form
    {
        public CambiaLastra(string Codice, DateTime Data, string Lastra)
        {
            InitializeComponent();
            textBox1.Text = Codice;
            textBox2.Text = Data.ToShortDateString();
            textBox3.Text = Lastra;
        }

        private void CambiaLastra_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Prime'. È possibile spostarla o rimuoverla se necessario.
            this.primeTableAdapter.Fill(this.target2021DataSet.Prime);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Descrizione = comboBox1.SelectedValue.ToString();
                label6.Text = Descrizione;
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NrCommessa, DataCommessa, NuovaLastra;

            NrCommessa = textBox1.Text.Trim();
            DataCommessa = textBox2.Text;
            NuovaLastra = comboBox1.GetItemText(comboBox1.SelectedItem);

            try
            {
                string stringaconnessione, sql;
                stringaconnessione = Properties.Resources.StringaConnessione;
                SqlConnection connessione = new SqlConnection(stringaconnessione);
                sql = "UPDATE Commesse SET IDMateriaPrima = '"+NuovaLastra+"' WHERE NrCommessa = "+NrCommessa+" AND DataCommessa = '"+DataCommessa+"'";
                SqlCommand comando = new SqlCommand(sql, connessione);
                connessione.Open();
                comando.ExecuteNonQuery();
                connessione.Close();
                MessageBox.Show("Aggiornamento lastra per questa commessa completato con successo");
                this.Close();
            }
            catch
            {
                // errore
                MessageBox.Show("Ops... qualcosa è andato storto");
                this.Close();
            }
        }
    }
}
