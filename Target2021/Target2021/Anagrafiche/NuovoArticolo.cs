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

namespace Target2021.Anagrafiche
{
    public partial class NuovoArticolo : Form
    {
        public NuovoArticolo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "";
            string stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection conn = new SqlConnection(stringaconnessione);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.CommandText = "INSERT INTO articoli_semplici(codice,descrizione,prezzo_b,tipo,note,unita_misura) VALUES(@codice,@descrizione,@prezzo_b,@tipo,@note,@unita_misura)";
            cmd.Parameters.AddWithValue("@codice", txtCodice.Text);
            cmd.Parameters.AddWithValue("@descrizione", txtDesc.Text);
            cmd.Parameters.AddWithValue("@prezzo_b", txtPrezzo.Text);
            cmd.Parameters.AddWithValue("@tipo", txtTipo.Text);
            cmd.Parameters.AddWithValue("@note", txtNote.Text);
            cmd.Parameters.AddWithValue("@unita_misura", comboUnita.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
