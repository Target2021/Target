﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Target2021.Anagrafiche;

namespace Target2021
{
    public partial class Home : Form
    {
        public object Livello;
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
        public  void CheckPrivilege(string livello)
        {
            livello =livello.Replace(" ", string.Empty);
            if(livello=="Amministratore")
            {
                registraNuovoUtenteToolStripMenuItem.Enabled = true;
            }
            if(livello=="Dirigente")
            {
                registraNuovoUtenteToolStripMenuItem.Enabled = true;

            }
            if (livello == "Segretaria")
            {

            }
            if (livello == "Operaio")
            {
                clientiToolStripMenuItem.Enabled = false;
                registraNuovoUtenteToolStripMenuItem.Enabled = false;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            string strconn = Properties.Resources.StringaConnessione;
            SqlConnection con = new SqlConnection(strconn);
            string query = "SELECT Livello FROM Utenti WHERE Nome='" + user + "'";
            SqlCommand sqlCommand = new SqlCommand(query, con);
            con.Open();
            Livello = sqlCommand.ExecuteScalar();
            this.Text = "Target 2.0 - Utente: " + user + " - Livello: " + Livello.ToString();
            con.Close();
            CheckPrivilege(Livello.ToString());
            this.WindowState = FormWindowState.Maximized;
        }
       
        private void dettaglioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dettaglio_Articoli dettaglio = new Dettaglio_Articoli();
            dettaglio.MdiParent = this;
            dettaglio.Show();
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

        private void clientiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Clienti clienti = new Clienti();
            clienti.MdiParent = this;
            clienti.Show();
        }

        private void disconnettiUtenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void registraUtenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistraUtenti registraUtenti = new RegistraUtenti();
            registraUtenti.MdiParent = this;
            registraUtenti.Show();
        }

        private void impiegataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckImpiegato checkImpiegato = new CheckImpiegato();
            checkImpiegato.MdiParent = this;
            checkImpiegato.Show();
        }

        private void taglioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckTaglio checkTaglio = new CheckTaglio();
            checkTaglio.MdiParent = this;
            checkTaglio.Show();
        }

        private void caricoscaricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Generare etichetta da attaccare sul bancale vedi foglio etichetta file di XLS
        }

        private void materiePrimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaMateriePrime AnaPrime = new AnaMateriePrime();
            AnaPrime.MdiParent = this;
            AnaPrime.Show();
        }

        private void stampiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaStampi AS = new AnaStampi();
            AS.MdiParent = this;
            AS.Show();
        }

        private void dimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaDime AD = new AnaDime();
            AD.MdiParent = this;
            AD.Show();
        }

        private void macchineDiStampoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaMStampo AMS = new AnaMStampo();
            AMS.MdiParent = this;
            AMS.Show();
        }

        private void fasiLavorazioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaFasi AF = new AnaFasi();
            AF.MdiParent = this;
            AF.Show();
        }

        private void assemblaggioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckAssemblaggio checkassemblaggio = new CheckAssemblaggio();
            checkassemblaggio.MdiParent = this;
            checkassemblaggio.Show();
        }

        private void inserisciNuovoCaricoscaricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScaricoCaricoMagazzini scaricoCarico = new ScaricoCaricoMagazzini();
            scaricoCarico.MdiParent = this;
            scaricoCarico.Show();
        }

        private void interrogazioneMovimentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RiepilogoMovimenti riepilogoMovimenti = new RiepilogoMovimenti();
            riepilogoMovimenti.MdiParent = this;
            riepilogoMovimenti.Show();
        }

        private void anagraficheMagazziniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaMagazzini AnaMag = new AnaMagazzini();
            AnaMag.MdiParent = this;
            AnaMag.Show();
        }

        private void interrogazioneGiacenzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaGiacenze AnaGia = new AnaGiacenze();
            AnaGia.MdiParent = this;
            AnaGia.Show();
        }

        private void fornitoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaFornitori AnaForn = new AnaFornitori();
            AnaForn.MdiParent = this;
            AnaForn.Show();
        }

        private void macchineDiTaglioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaMTaglio AMT = new AnaMTaglio();
            AMT.MdiParent = this;
            AMT.Show();
        }

        private void disconnettiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Enabled = false;
        }

        private void commesseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RiepilogoCommesse riepilogocommesse = new RiepilogoCommesse();
            riepilogocommesse.MdiParent = this;
            riepilogocommesse.Show();
        }

        private void tipiCommesseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pianificazioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckPianificazione pianificazione = new CheckPianificazione();
            pianificazione.MdiParent = this;
            pianificazione.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void registraNuovoUtenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistraUtenti registraUtenti = new RegistraUtenti();
            registraUtenti.MdiParent = this;
            registraUtenti.Show();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
