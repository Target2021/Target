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
    public partial class CercaArticolo : Form
    {
        public int ida;
        public string Codice;

        public CercaArticolo(int id)
        {
            InitializeComponent();
            ida = id;
        }

        private void articoli_sempliciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.articoli_sempliciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void CercaArticolo_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.DettArticoli'. È possibile spostarla o rimuoverla se necessario.
            this.dettArticoliTableAdapter.Fill(this.target2021DataSet.DettArticoli);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.AbbinamentiArticoli'. È possibile spostarla o rimuoverla se necessario.
            this.abbinamentiArticoliTableAdapter.Fill(this.target2021DataSet.AbbinamentiArticoli);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.articoli_semplici'. È possibile spostarla o rimuoverla se necessario.
            this.articoli_sempliciTableAdapter.Fill(this.target2021DataSet.articoli_semplici);

        }

        private void Filtra()
        {
            if (comboBox1.Text == "Codice") articoli_sempliciBindingSource.Filter = "codice LIKE '*" + textBox1.Text + "*'";
            if (comboBox1.Text == "Descrizione") articoli_sempliciBindingSource.Filter = "descrizione LIKE '*" + textBox1.Text + "*'";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Filtra();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InserisciAbbinamento();
            AggiornaCodAbbinamento();
            MessageBox.Show("Inserimento effettuato!");
            this.Close();
        }

        private void InserisciAbbinamento()
        {
            int IDAbb, Qta, Perc=0;
            String Descrizione, Prog="";

            IDAbb = ida;
            Qta = Convert.ToInt32(textBox2.Text);
            Codice = articoli_sempliciDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            Descrizione = articoli_sempliciDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            Perc = RecuperaPercentuale(Codice);
            Prog = RecuperaProgramma(Codice);

            Target2021DataSet.AbbinamentiArticoliRow riga = target2021DataSet.AbbinamentiArticoli.NewAbbinamentiArticoliRow();

            riga.IdAbbinamento = IDAbb;
            riga.Qta = Qta;
            riga.codice_articolo = Codice;
            riga.Descrizione = Descrizione;
            riga.PercentualeLastra = (Perc * Qta);
            riga.ProgrammaStampaggio = Prog;

            target2021DataSet.AbbinamentiArticoli.Rows.Add(riga);
            abbinamentiArticoliTableAdapter.Update(target2021DataSet.AbbinamentiArticoli);
        }

        private int RecuperaPercentuale(string Cod)
        {
            int Perc;
            DataRow[] riga;
            riga = target2021DataSet.Tables["DettArticoli"].Select("codice_articolo='" + Cod + "' AND lavorazione=2");
            try
            {
                Perc = Convert.ToInt32(riga[0]["PercentualeLastra"]);
                return Perc;
            }
            catch { return -1; }
        }

        private string RecuperaProgramma(string Cod)
        {
            string Prg;
            DataRow[] riga;
            riga = target2021DataSet.Tables["DettArticoli"].Select("codice_articolo='" + Cod + "' AND lavorazione=2");
            try
            {
                Prg = riga[0]["ProgStampaggio"].ToString();
                return Prg;
            }
            catch { return "Non trovato"; }
        }

        private void AggiornaCodAbbinamento()
        {
            string stringaconnessione, sql;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "UPDATE DettArticoli SET AbbinamentoStampo = " + ida.ToString() + " WHERE codice_articolo = '"+Codice+"'";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            comando.ExecuteNonQuery();
            connessione.Close();
        }
    }
}
