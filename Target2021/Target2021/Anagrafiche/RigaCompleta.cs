using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Target2021.SelezAna;

namespace Target2021
{
    public partial class RigaCompleta : Form
    {
        public int ID;

        public RigaCompleta(int idArt)
        {
            InitializeComponent();
            ID = idArt;
        }

        private void dettArticoliBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dettArticoliBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }

        private void RigaCompleta_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.DettArticoli'. È possibile spostarla o rimuoverla se necessario.
            this.dettArticoliTableAdapter.Fill(this.target2021DataSet.DettArticoli);
            dettArticoliBindingSource.Position = ID;
        }

        private void AggiornaFornitore(object sender, EventArgs e)
        {
            string CodFor,stringaconnessione, sql, NomeFornitore;
            CodFor = codice_fornitoreTextBox.Text;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT ragione_sociale FROM Fornitori WHERE codice='"+CodFor+"'";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            NomeFornitore = comando.ExecuteScalar().ToString();
            connessione.Close();
            label1.Text = NomeFornitore;
        }

        private void AggiornaLavorazione(object sender, EventArgs e)
        {
            string CodLav, stringaconnessione, sql, NomeLavorazione;
            CodLav = lavorazioneTextBox.Text;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT Descrizione FROM Fasi WHERE IDFase=" + CodLav;
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            NomeLavorazione  = comando.ExecuteScalar().ToString();
            connessione.Close();
            label2.Text = NomeLavorazione ;
        }

        private void CambiaFornitore(object sender, EventArgs e)
        {
            SelForn selezionafornitore = new SelForn();
            selezionafornitore.FormClosed += new FormClosedEventHandler(ChiudiSelezionaFornitore);
            selezionafornitore.Show();
        }

        private void ChiudiSelezionaFornitore(object sender, FormClosedEventArgs e)
        {
            SelForn sf = (SelForn) sender;
            string codfor = sf.CodFornitore;
            codice_fornitoreTextBox.Text = codfor;
        }
    }
}
