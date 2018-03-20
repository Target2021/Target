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
    public partial class Home : Form
    {
        public string user, pass;
        public Home(string user,string pass)
        {
            InitializeComponent();          
            menuStrip1.Renderer = new MyRenderer();
            this.user =user;
        }
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }      
        private void CheckPrivilege(string livello)
        {
            livello =livello.Replace(" ", string.Empty);
            if(livello=="Amministratore")
            {

            }
            if(livello=="Dirigente")
            {

            }
            if (livello == "Segretaria")
            {

            }
            if (livello == "Operaio")
            {
                clientiToolStripMenuItem.Enabled = false;
            }
        }
        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.DeepSkyBlue; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.Aqua; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.CadetBlue; }
            }
            public override Color MenuItemPressedGradientMiddle
            {
                get { return Color.Aquamarine; }
            }
        }
        private void anaMagazziniBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.anaMagazziniBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strconn = Properties.Resources.StringaConnessione;
            SqlConnection con = new SqlConnection(strconn);
            string query = "SELECT Livello FROM Utenti WHERE Nome='" + user + "'";
            SqlCommand sqlCommand = new SqlCommand(query, con);
            con.Open();
            object Livello = sqlCommand.ExecuteScalar();
            this.Text = "Target 2.0 - Utente: " + user + " - Livello: " + Livello.ToString();
            con.Close();
            CheckPrivilege(Livello.ToString());
        }
       
        private void testataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Testata_articoli testata = new Testata_articoli();
            testata.MdiParent = this;
            testata.Show();
        }

        private void dettaglioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dettaglio_Articoli dettaglio = new Dettaglio_Articoli();
            dettaglio.MdiParent = this;
            dettaglio.Show();
        }

        private void clientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clienti clienti = new Clienti();
            clienti.MdiParent = this;
            clienti.Show();
        }

        private void testataOrdiniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Testata_Ordini TestataOrdini = new Testata_Ordini();
            TestataOrdini.MdiParent = this;
            TestataOrdini.Show();
        }

        private void contatoriAziendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contatori ContaForm = new Contatori();
            ContaForm.MdiParent = this;
            ContaForm.Show();
        }

        private void controllaNuoviOrdiniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewOrderCheck ControllaNuoviOrdini = new NewOrderCheck();
            ControllaNuoviOrdini.MdiParent = this;
            ControllaNuoviOrdini.Show();
        }

        private void fornitoriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Clienti clienti = new Clienti();
            clienti.MdiParent = this;
            clienti.Show();
        }

        private void disconnettiUtenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
            this.Close();
        }

        private void registraUtentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistraUtenti registraUtenti = new RegistraUtenti();
            registraUtenti.MdiParent = this;
            registraUtenti.Show();
        }

        private void stampaggioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckStampaggio checkStampaggio = new CheckStampaggio();
            checkStampaggio.MdiParent = this;
            checkStampaggio.Show();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void articoliBCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.articoliBCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_A35212_targetDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'dB_A35212_targetDataSet.ArticoliBC'. È possibile spostarla o rimuoverla se necessario.
            this.articoliBCTableAdapter.Fill(this.dB_A35212_targetDataSet.ArticoliBC);

        }
    }
}
