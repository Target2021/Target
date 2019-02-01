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
    public partial class DettAbbinamStampo : Form
    {
        public int CA;
        String Codice;

        public DettAbbinamStampo(int CodAbbinamento, string CodArt)
        {
            InitializeComponent();
            CA = CodAbbinamento;
            Codice = CodArt;
        }

        private void DettAbbinamStampo_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.articoli_semplici'. È possibile spostarla o rimuoverla se necessario.
            this.articoli_sempliciTableAdapter.Fill(this.target2021DataSet.articoli_semplici);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.AbbinamentiArticoli'. È possibile spostarla o rimuoverla se necessario.
            this.abbinamentiArticoliTableAdapter.Fill(this.target2021DataSet.AbbinamentiArticoli);
            textBox1.Text = CA.ToString();
            textBox2.Text = Codice;

            try
            {
                string filtro = "codice='" + Codice + "'";
                DataRow[] Stampo = target2021DataSet.Tables["articoli_semplici"].Select(filtro);
                textBox3.Text = Stampo[0].Field<String>("descrizione");
                textBox3.Refresh();
            }
            catch { };
            Filtra();
            if (textBox1.Text == "0") button2.Enabled = true;
            else button2.Enabled = false;
        }

        private void Filtra()
        {
            abbinamentiArticoliBindingSource.Filter = "IdAbbinamento = '" + textBox1.Text + "'";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int IdA;
            IdA = Convert.ToInt32(textBox1.Text);
            CercaArticolo cerca = new CercaArticolo(IdA);
            cerca.ShowDialog();
            Aggiorna();
        }

        private void Aggiorna()
        {
            this.abbinamentiArticoliTableAdapter.Fill(this.target2021DataSet.AbbinamentiArticoli);
            abbinamentiArticoliDataGridView.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdAbb;

            IdAbb = RecuperaNuovoId();
            textBox1.Text = IdAbb.ToString();
            CA = IdAbb;
            CreaRecordAbbinamento(IdAbb);
            AggiornaRecordDettArticolo();
            MessageBox.Show("Creato nuovo gruppo abbinamento e aggiornato valore articolo");
            Aggiorna();
            this.Refresh();
        }

        private int RecuperaNuovoId()
        {
            string stringaconnessione, sql;
            int max;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT MAX(AbbinamentoStampo) FROM DettArticoli";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            max=Convert .ToInt32(comando.ExecuteScalar());
            connessione.Close();
            return max + 1;
        }

        private void CreaRecordAbbinamento(int id)
        {
            int IDAbb, Qta;
            String Descrizione;

            IDAbb = id;
            try
            {
                Qta = Convert.ToInt32(textBox4.Text);
            }
            catch
            {
                Qta = 1;
            }
            Codice = textBox2.Text;
            Descrizione = textBox3.Text;

            Target2021DataSet.AbbinamentiArticoliRow riga = target2021DataSet.AbbinamentiArticoli.NewAbbinamentiArticoliRow();

            riga.IdAbbinamento = IDAbb;
            riga.Qta = Qta;
            riga.codice_articolo = Codice;
            riga.Descrizione = Descrizione;

            target2021DataSet.AbbinamentiArticoli.Rows.Add(riga);
            abbinamentiArticoliTableAdapter.Update(target2021DataSet.AbbinamentiArticoli);
        }

        private void AggiornaRecordDettArticolo()
        {
            string stringaconnessione, sql;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "UPDATE DettArticoli SET AbbinamentoStampo = " + textBox1.Text + " WHERE codice_articolo = '" + textBox2.Text + "'";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            comando.ExecuteNonQuery();
            connessione.Close();
        }
    }


}
