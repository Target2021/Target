using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Target2021
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numero, anno;
            numero = textBox1.Text;
            anno = textBox2.Text;

            string stringaconnessione, sql = "", note;
            stringaconnessione = Properties.Resources.ConnessioneAccess;
            OleDbConnection connessione = new OleDbConnection (stringaconnessione);
            sql = "UPDATE dettaglio_ordini_multiriga SET aliquota_iva=1 WHERE numero_ordine=" + numero + " AND data_ordine > "+anno;
            OleDbCommand comando = new OleDbCommand(sql, connessione);
            connessione.Open();
            try
            {
                note = comando.ExecuteScalar().ToString();
            }
            catch
            {
                note = null;
            }
            connessione.Close();
            MessageBox.Show("Bingo!");
        }
    }
}
