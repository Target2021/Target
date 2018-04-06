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
        public string c, v;

        public RigaCompleta(int idArt, string campo, string valore)
        {
            InitializeComponent();
            ID = idArt;
            c = campo;
            v = valore;
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
            if (c == "Codice articolo") dettArticoliBindingSource.Filter = "codice_articolo='" + v + "'";
            if (c == "Descrizione") dettArticoliBindingSource.Filter = "descrizionePrimaStampoDima LIKE '*" + v + "*'";
            dettArticoliBindingSource.Position = ID;
        }

        private void AggiornaFornitore(object sender, EventArgs e)
        {
            string CodFor,stringaconnessione, sql, NomeFornitore;
            NomeFornitore = label1.Text;
            CodFor = codice_fornitoreTextBox.Text;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT ragione_sociale FROM Fornitori WHERE codice='"+CodFor+"'";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            try
            {
                NomeFornitore = comando.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {

            }
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
            SelForn selezionafornitore = new SelForn(codice_fornitoreTextBox.Text);
            selezionafornitore.FormClosed += new FormClosedEventHandler(ChiudiSelezionaFornitore);
            selezionafornitore.Show();
        }

        private void ChiudiSelezionaFornitore(object sender, FormClosedEventArgs e)
        {
            SelForn sf = (SelForn) sender;
            string codfor = sf.CodFornitore;
            codice_fornitoreTextBox.Text = codfor;
        }

        private void AggMachStampPredef(object sender, EventArgs e)
        {
            string CodMSP, stringaconnessione, sql, NomeMachS;
            CodMSP = macPredefStampoTextBox.Text;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT Descrizione FROM MacchineStampo WHERE IdStampa=" + CodMSP;
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            NomeMachS = comando.ExecuteScalar().ToString();
            connessione.Close();
            label3.Text = NomeMachS;
        }

        private void AggMachTaglPredef(object sender, EventArgs e)
        {
            string CodMTP, stringaconnessione, sql, NomeMachT;
            CodMTP = macPredefTaglioTextBox.Text;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT Descrizione FROM MacchineTaglio WHERE IdTaglio=" + CodMTP;
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            NomeMachT = comando.ExecuteScalar().ToString();
            connessione.Close();
            label4.Text = NomeMachT;
        }
    }
}
