using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Target2021.Anagrafiche;
using Target2021.Stampe;
using Target2021.Fornitori;
using Target2021.Anagrafiche.Fornitore;
using Target2021.Fase2;
using Target2021.Magazzino;

namespace Target2021
{
    public partial class Form1 : Form
    {
        public string user;
        public Form1()
        {
            InitializeComponent();          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int livello;
            Login logga = new Login();
            logga.ShowDialog();
            user = logga.NomeUtente;
            livello = logga.livello;
            if (livello == 0) Application.Exit();
            this.Text = "Target 2.0 - Utente: " + user + " - Livello: " + livello.ToString();
            this.WindowState = FormWindowState.Maximized;
            if (livello == 2)
            {
                menuStrip1.Visible = false;
                CheckStampaggio checkStampaggio = new CheckStampaggio();
                checkStampaggio.MdiParent = this;
                checkStampaggio.Show();
            }
            if (livello == 3)
            {
                menuStrip1.Visible = false;
                CheckTaglio taglia = new CheckTaglio();
                taglia.MdiParent = this;
                taglia.Show();
            }
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
            CaricoScarico CS = new CaricoScarico();
            CS.MdiParent = this;
            CS.Show();
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
        public void log()
        {
            Login login = new Login();
            login.ShowDialog();
        }
        private void disconnettiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(log);
            thread.Start();
            this.Close();
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
            //CheckPianificazione pianificazione = new CheckPianificazione();
            //pianificazione.MdiParent = this;
            //pianificazione.Show();
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

        private void taglioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MonitoraTaglio mt = new MonitoraTaglio();
            mt.MdiParent = this;
            mt.Show();
        }

        private void stampaSchedaCommessaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stampacommessa stampa = new stampacommessa();
            stampa.MdiParent = this;
            stampa.Show();
        }

        private void schermataTaglioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MascheraTaglio MT = new MascheraTaglio();
            MT.MdiParent = this;
            MT.Show();
        }

        private void nuovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuovoArticolo NA = new NuovoArticolo();
            NA.MdiParent = this;
            NA.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void etichetteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaricoLastre CLastre = new CaricoLastre();
            CLastre.MdiParent = this;
            CLastre.Show();
        }

        private void minuterieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaMinuterie AnaMin = new AnaMinuterie();
            AnaMin.MdiParent = this;
            AnaMin.Show();
        }

        private void compatibilitàStampiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaAbbinamentoStampi AAS = new AnaAbbinamentoStampi();
            AAS.MdiParent = this;
            AAS.Show();
        }

        private void compatibilitàDimeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void distintaBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DistintaBase DistintaBase = new DistintaBase();
            DistintaBase.MdiParent = this;
            DistintaBase.Show();
        }

        private void articoloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void anagraficaArticoloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaArticoli AnArt = new AnaArticoli();
            AnArt.MdiParent = this;
            AnArt.Show();
        }

        private void pesiSpecificiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaPesiSpecifici aps = new AnaPesiSpecifici();
            aps.MdiParent = this;
            aps.Show();
        }

        private void posizioniStampiEDimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PosizioniStampiDime PSD = new PosizioniStampiDime();
            PSD.MdiParent = this;
            PSD.Show();
        }

        private void magazziniToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
         // Stati riga di commessa:
            // TipoCommessa = 1  // Approvigionamento materia prima
                // Stato 0 = Fase da prendere in carico
                // Stato 5 = Ordinata la merce, impegnato su ordinato, in attesa di arrivo
                // Stato 1 = Evasione parziale (ovvero impegno di una quantità < quantità richiesta)
                // Stato 51 = Evasione parziale + Ordino (impegnato su ordinato)
                // Stato 2 = Approvigionamento materia prima completato
                // Stato 3 = Pianificato
                // Stato 9 = Inserito in SuperCommessa
                // Stato 5 = Stampato
            // TipoCommessa = 2 // Stampaggio
            
         // Stati di riga SuperCommessa (materia prima SEMPRE già reperita):
            // Stato = 0 -> Riga non pianificata
            // Stato = 1 -> Riga pianificata
            // Stato = 2 -> Riga stampata
        }

        private void ordiniToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void caricoProdottiFinitiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SEtichette StampaEtichette = new SEtichette();
            StampaEtichette.MdiParent = this;
            StampaEtichette.Show();
        }

        private void ordiniAFornitoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuovoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NuovoOrdineForn NOF = new NuovoOrdineForn();
            NOF.MdiParent = this;
            NOF.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaOrdine CO = new ConsultaOrdine();
            CO.MdiParent = this;
            CO.Show();
        }

        private void arrivoMerceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrivoMerce AM = new ArrivoMerce();
            AM.MdiParent = this;
            AM.Show();
        }

        private void confermaDordineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfermaOrdine CO = new ConfermaOrdine();
            CO.MdiParent = this;
            CO.Show();
        }

        private void creaSuperCommessaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckPianificazione pianificazione = new CheckPianificazione();
            pianificazione.MdiParent = this;
            pianificazione.Show();
        }

        private void pianificazioneTemporaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PianificaStampo PS = new PianificaStampo();
            PS.MdiParent = this;
            PS.Show();
        }

        private void eliminaSuperCommessaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminaSC EliminaSuperCommessa = new EliminaSC();
            EliminaSuperCommessa.MdiParent = this;
            EliminaSuperCommessa.Show();
        }

        private void splittaCommessaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplittaCommessa SC = new SplittaCommessa();
            SC.MdiParent = this;
            SC.Show();
        }

        private void valorizzaMagazziniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ValorizzaMagazzini vm = new ValorizzaMagazzini();
            vm.MdiParent = this;
            vm.Show();
        }

        private void stampaSchedaCommessaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            stampacommessa sc = new stampacommessa();
            sc.MdiParent = this;
            sc.Show();
        }

        private void consultaOrdiniImportatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaOrdiniImportati ordimp = new AnaOrdiniImportati();
            ordimp.MdiParent = this;
            ordimp.Show();
        }

        private void modalitàPagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModalitaPagamento mp = new ModalitaPagamento();
            mp.MdiParent = this;
            mp.Show();
        }

        private void terminiPagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TerminiPagamento tp = new TerminiPagamento();
            tp.MdiParent = this;
            tp.Show();
        }

        private void spedizioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CodiciSpedizione cs = new CodiciSpedizione();
            cs.MdiParent = this;
            cs.Show();
        }

        private void nuovoArticoloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuovoArticolo nuovo = new NuovoArticolo();
            nuovo.MdiParent = this;
            nuovo.Show();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void riincludiOrdiniEsclusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaOrdiniEsclusi esclusi = new AnaOrdiniEsclusi();
            esclusi.MdiParent = this;
            esclusi.Show();
        }

        private void allineaDDTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllineaDDT allinea = new AllineaDDT();
            allinea.MdiParent = this;
            allinea.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Test nok = new Test();
            nok.MdiParent = this;
            nok.Show();
        }
    }
}
