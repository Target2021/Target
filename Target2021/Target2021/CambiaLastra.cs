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
        private string C;
        private DateTime D;

        public CambiaLastra(string Codice, DateTime Data, string Lastra)
        {
            InitializeComponent();
            textBox1.Text = Codice;
            C = Codice;
            textBox2.Text = Data.ToShortDateString();
            D = Data;
            textBox3.Text = Lastra;
        }

        private void CambiaLastra_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Prime'. È possibile spostarla o rimuoverla se necessario.
            this.primeTableAdapter.Fill(this.target2021DataSet.Prime);
            MostraPercentualeLastra(C, D);
            textBox5.Text = textBox4.Text;
            // Prendere TextBox3 e metterlo in ComboBox1 - FP 24.12.2020
            comboBox1.Text = textBox3.Text;
        }

        private void MostraPercentualeLastra(string CodiceCommessa, DateTime DataCommessa)
        {
            string query = string.Format("NrCommessa = {0} AND DataCommessa = '{1}'", CodiceCommessa, DataCommessa.ToShortDateString());
            DataRow[] result = target2021DataSet.Commesse.Select(query);
            int perc = Convert.ToInt32(result[0][17]);
            textBox4.Text = perc.ToString();
            textBox5.Text = perc.ToString();
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
            int NuovaPercentuale;

            NrCommessa = textBox1.Text.Trim();
            DataCommessa = textBox2.Text;
            // Prendere i testo del ComboBox e non l'elemento selezionato
            NuovaLastra = comboBox1.GetItemText(comboBox1.SelectedItem);
            // Fine modifica (da fare)
            NuovaPercentuale = Convert.ToInt32(textBox5.Text);
            try
            {
                string stringaconnessione, sql;
                stringaconnessione = Properties.Resources.StringaConnessione;
                SqlConnection connessione = new SqlConnection(stringaconnessione);
                sql = "UPDATE Commesse SET IDMateriaPrima = '"+NuovaLastra+"', PercentualeUtilizzoLastra = "+NuovaPercentuale.ToString() + " WHERE NrCommessa = "+NrCommessa+" AND DataCommessa = '"+DataCommessa+"'";
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
