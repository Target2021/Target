namespace Target2021
{
    partial class Home
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.target2021DataSet = new Target2021.Target2021DataSet();
            this.anaMagazziniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anaMagazziniTableAdapter = new Target2021.Target2021DataSetTableAdapters.AnaMagazziniTableAdapter();
            this.tableAdapterManager = new Target2021.Target2021DataSetTableAdapters.TableAdapterManager();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anagraficeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articoloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dettaglioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornitoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.macchinariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.macchineDiStampoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.macchineDiTaglioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strumentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiePrimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stampiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minuterieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipiCommesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fasiLavorazioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compatibilitàStampiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compatibilitàDimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testataOrdiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dettaglioOrdiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commesseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.controllaNuoviOrdiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magazziniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anagraficheMagazziniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interrogazioneGiacenzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interrogazioneMovimentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caricoscaricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciNuovoCaricoscaricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impostazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contatoriAziendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registraUtentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruoliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impiegataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pianificazioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stampaggioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taglioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assemblaggioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnettiUtenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registraUtenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anaMagazziniBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // target2021DataSet
            // 
            this.target2021DataSet.DataSetName = "Target2021DataSet";
            this.target2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anaMagazziniBindingSource
            // 
            this.anaMagazziniBindingSource.DataMember = "AnaMagazzini";
            this.anaMagazziniBindingSource.DataSource = this.target2021DataSet;
            // 
            // anaMagazziniTableAdapter
            // 
            this.anaMagazziniTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnaMagazziniTableAdapter = this.anaMagazziniTableAdapter;
            this.tableAdapterManager.articoli_sempliciTableAdapter = null;
            this.tableAdapterManager.ArticoliBCTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientiTableAdapter = null;
            this.tableAdapterManager.CommesseTableAdapter = null;
            this.tableAdapterManager.CompatibStampaTableAdapter = null;
            this.tableAdapterManager.CompatibTaglioTableAdapter = null;
            this.tableAdapterManager.ConfigurazioneTableAdapter = null;
            this.tableAdapterManager.dettaglio_ordini_multirigaTableAdapter = null;
            this.tableAdapterManager.DettArticoliTableAdapter = null;
            this.tableAdapterManager.DimeTableAdapter = null;
            this.tableAdapterManager.FasiTableAdapter = null;
            this.tableAdapterManager.FornitoriTableAdapter = null;
            this.tableAdapterManager.GiacenzeMagazziniTableAdapter = null;
            this.tableAdapterManager.LavorazioniTableAdapter = null;
            this.tableAdapterManager.LivelliUtenzaTableAdapter = null;
            this.tableAdapterManager.MacchineStampoTableAdapter = null;
            this.tableAdapterManager.MacchineTaglioTableAdapter = null;
            this.tableAdapterManager.MinuterieTableAdapter = null;
            this.tableAdapterManager.MovimentiMagazzinoTableAdapter = null;
            this.tableAdapterManager.PrimeTableAdapter = null;
            this.tableAdapterManager.StampiTableAdapter = null;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.testata_ordini_multirigaTableAdapter = null;
            this.tableAdapterManager.TipoCommessaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Target2021.Target2021DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtentiTableAdapter = null;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anagraficeToolStripMenuItem,
            this.ordiniToolStripMenuItem,
            this.magazziniToolStripMenuItem,
            this.impostazioniToolStripMenuItem,
            this.ruoliToolStripMenuItem,
            this.disconnettiUtenteToolStripMenuItem,
            this.registraUtenteToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(896, 36);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anagraficeToolStripMenuItem
            // 
            this.anagraficeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articoloToolStripMenuItem,
            this.clientiToolStripMenuItem,
            this.fornitoriToolStripMenuItem,
            this.macchinariToolStripMenuItem,
            this.strumentiToolStripMenuItem,
            this.tipiCommesseToolStripMenuItem,
            this.fasiLavorazioneToolStripMenuItem,
            this.compatibilitàStampiToolStripMenuItem,
            this.compatibilitàDimeToolStripMenuItem});
            this.anagraficeToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anagraficeToolStripMenuItem.Name = "anagraficeToolStripMenuItem";
            this.anagraficeToolStripMenuItem.Size = new System.Drawing.Size(111, 32);
            this.anagraficeToolStripMenuItem.Text = "Anagrafiche";
            // 
            // articoloToolStripMenuItem
            // 
            this.articoloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dettaglioToolStripMenuItem});
            this.articoloToolStripMenuItem.Name = "articoloToolStripMenuItem";
            this.articoloToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.articoloToolStripMenuItem.Text = "Articoli";
            // 
            // dettaglioToolStripMenuItem
            // 
            this.dettaglioToolStripMenuItem.Name = "dettaglioToolStripMenuItem";
            this.dettaglioToolStripMenuItem.Size = new System.Drawing.Size(151, 32);
            this.dettaglioToolStripMenuItem.Text = "Dettaglio";
            this.dettaglioToolStripMenuItem.Click += new System.EventHandler(this.dettaglioToolStripMenuItem_Click);
            // 
            // clientiToolStripMenuItem
            // 
            this.clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
            this.clientiToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.clientiToolStripMenuItem.Text = "Clienti";
            this.clientiToolStripMenuItem.Click += new System.EventHandler(this.clientiToolStripMenuItem_Click_1);
            // 
            // fornitoriToolStripMenuItem
            // 
            this.fornitoriToolStripMenuItem.Name = "fornitoriToolStripMenuItem";
            this.fornitoriToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.fornitoriToolStripMenuItem.Text = "Fornitori";
            this.fornitoriToolStripMenuItem.Click += new System.EventHandler(this.fornitoriToolStripMenuItem_Click);
            // 
            // macchinariToolStripMenuItem
            // 
            this.macchinariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.macchineDiStampoToolStripMenuItem,
            this.macchineDiTaglioToolStripMenuItem});
            this.macchinariToolStripMenuItem.Name = "macchinariToolStripMenuItem";
            this.macchinariToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.macchinariToolStripMenuItem.Text = "Macchinari";
            // 
            // macchineDiStampoToolStripMenuItem
            // 
            this.macchineDiStampoToolStripMenuItem.Name = "macchineDiStampoToolStripMenuItem";
            this.macchineDiStampoToolStripMenuItem.Size = new System.Drawing.Size(229, 32);
            this.macchineDiStampoToolStripMenuItem.Text = "Macchine di stampo";
            this.macchineDiStampoToolStripMenuItem.Click += new System.EventHandler(this.macchineDiStampoToolStripMenuItem_Click);
            // 
            // macchineDiTaglioToolStripMenuItem
            // 
            this.macchineDiTaglioToolStripMenuItem.Name = "macchineDiTaglioToolStripMenuItem";
            this.macchineDiTaglioToolStripMenuItem.Size = new System.Drawing.Size(229, 32);
            this.macchineDiTaglioToolStripMenuItem.Text = "Macchine di taglio";
            // 
            // strumentiToolStripMenuItem
            // 
            this.strumentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materiePrimeToolStripMenuItem,
            this.stampiToolStripMenuItem,
            this.dimeToolStripMenuItem,
            this.minuterieToolStripMenuItem});
            this.strumentiToolStripMenuItem.Name = "strumentiToolStripMenuItem";
            this.strumentiToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.strumentiToolStripMenuItem.Text = "Strumenti";
            // 
            // materiePrimeToolStripMenuItem
            // 
            this.materiePrimeToolStripMenuItem.Name = "materiePrimeToolStripMenuItem";
            this.materiePrimeToolStripMenuItem.Size = new System.Drawing.Size(188, 32);
            this.materiePrimeToolStripMenuItem.Text = "Materie prime";
            this.materiePrimeToolStripMenuItem.Click += new System.EventHandler(this.materiePrimeToolStripMenuItem_Click);
            // 
            // stampiToolStripMenuItem
            // 
            this.stampiToolStripMenuItem.Name = "stampiToolStripMenuItem";
            this.stampiToolStripMenuItem.Size = new System.Drawing.Size(188, 32);
            this.stampiToolStripMenuItem.Text = "Stampi";
            this.stampiToolStripMenuItem.Click += new System.EventHandler(this.stampiToolStripMenuItem_Click);
            // 
            // dimeToolStripMenuItem
            // 
            this.dimeToolStripMenuItem.Name = "dimeToolStripMenuItem";
            this.dimeToolStripMenuItem.Size = new System.Drawing.Size(188, 32);
            this.dimeToolStripMenuItem.Text = "Dime";
            this.dimeToolStripMenuItem.Click += new System.EventHandler(this.dimeToolStripMenuItem_Click);
            // 
            // minuterieToolStripMenuItem
            // 
            this.minuterieToolStripMenuItem.Name = "minuterieToolStripMenuItem";
            this.minuterieToolStripMenuItem.Size = new System.Drawing.Size(188, 32);
            this.minuterieToolStripMenuItem.Text = "Minuterie";
            // 
            // tipiCommesseToolStripMenuItem
            // 
            this.tipiCommesseToolStripMenuItem.Name = "tipiCommesseToolStripMenuItem";
            this.tipiCommesseToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.tipiCommesseToolStripMenuItem.Text = "Tipi commesse";
            // 
            // fasiLavorazioneToolStripMenuItem
            // 
            this.fasiLavorazioneToolStripMenuItem.Name = "fasiLavorazioneToolStripMenuItem";
            this.fasiLavorazioneToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.fasiLavorazioneToolStripMenuItem.Text = "Fasi lavorazione";
            this.fasiLavorazioneToolStripMenuItem.Click += new System.EventHandler(this.fasiLavorazioneToolStripMenuItem_Click);
            // 
            // compatibilitàStampiToolStripMenuItem
            // 
            this.compatibilitàStampiToolStripMenuItem.Name = "compatibilitàStampiToolStripMenuItem";
            this.compatibilitàStampiToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.compatibilitàStampiToolStripMenuItem.Text = "Compatibilità Stampi";
            // 
            // compatibilitàDimeToolStripMenuItem
            // 
            this.compatibilitàDimeToolStripMenuItem.Name = "compatibilitàDimeToolStripMenuItem";
            this.compatibilitàDimeToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.compatibilitàDimeToolStripMenuItem.Text = "Compatibilità Dime";
            // 
            // ordiniToolStripMenuItem
            // 
            this.ordiniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testataOrdiniToolStripMenuItem,
            this.dettaglioOrdiniToolStripMenuItem,
            this.commesseToolStripMenuItem1,
            this.controllaNuoviOrdiniToolStripMenuItem});
            this.ordiniToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordiniToolStripMenuItem.Name = "ordiniToolStripMenuItem";
            this.ordiniToolStripMenuItem.Size = new System.Drawing.Size(72, 32);
            this.ordiniToolStripMenuItem.Text = "Ordini";
            // 
            // testataOrdiniToolStripMenuItem
            // 
            this.testataOrdiniToolStripMenuItem.Name = "testataOrdiniToolStripMenuItem";
            this.testataOrdiniToolStripMenuItem.Size = new System.Drawing.Size(246, 32);
            this.testataOrdiniToolStripMenuItem.Text = "Testata ordini";
            // 
            // dettaglioOrdiniToolStripMenuItem
            // 
            this.dettaglioOrdiniToolStripMenuItem.Name = "dettaglioOrdiniToolStripMenuItem";
            this.dettaglioOrdiniToolStripMenuItem.Size = new System.Drawing.Size(246, 32);
            this.dettaglioOrdiniToolStripMenuItem.Text = "Dettaglio ordini";
            // 
            // commesseToolStripMenuItem1
            // 
            this.commesseToolStripMenuItem1.Name = "commesseToolStripMenuItem1";
            this.commesseToolStripMenuItem1.Size = new System.Drawing.Size(246, 32);
            this.commesseToolStripMenuItem1.Text = "Commesse";
            // 
            // controllaNuoviOrdiniToolStripMenuItem
            // 
            this.controllaNuoviOrdiniToolStripMenuItem.Name = "controllaNuoviOrdiniToolStripMenuItem";
            this.controllaNuoviOrdiniToolStripMenuItem.Size = new System.Drawing.Size(246, 32);
            this.controllaNuoviOrdiniToolStripMenuItem.Text = "Controlla nuovi ordini";
            this.controllaNuoviOrdiniToolStripMenuItem.Click += new System.EventHandler(this.controllaNuoviOrdiniToolStripMenuItem_Click);
            // 
            // magazziniToolStripMenuItem
            // 
            this.magazziniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anagraficheMagazziniToolStripMenuItem,
            this.interrogazioneGiacenzeToolStripMenuItem,
            this.interrogazioneMovimentiToolStripMenuItem,
            this.caricoscaricoToolStripMenuItem});
            this.magazziniToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magazziniToolStripMenuItem.Name = "magazziniToolStripMenuItem";
            this.magazziniToolStripMenuItem.Size = new System.Drawing.Size(97, 32);
            this.magazziniToolStripMenuItem.Text = "Magazzini";
            // 
            // anagraficheMagazziniToolStripMenuItem
            // 
            this.anagraficheMagazziniToolStripMenuItem.Name = "anagraficheMagazziniToolStripMenuItem";
            this.anagraficheMagazziniToolStripMenuItem.Size = new System.Drawing.Size(277, 32);
            this.anagraficheMagazziniToolStripMenuItem.Text = "Anagrafiche magazzini";
            this.anagraficheMagazziniToolStripMenuItem.Click += new System.EventHandler(this.anagraficheMagazziniToolStripMenuItem_Click);
            // 
            // interrogazioneGiacenzeToolStripMenuItem
            // 
            this.interrogazioneGiacenzeToolStripMenuItem.Name = "interrogazioneGiacenzeToolStripMenuItem";
            this.interrogazioneGiacenzeToolStripMenuItem.Size = new System.Drawing.Size(277, 32);
            this.interrogazioneGiacenzeToolStripMenuItem.Text = "Interrogazione giacenze";
            this.interrogazioneGiacenzeToolStripMenuItem.Click += new System.EventHandler(this.interrogazioneGiacenzeToolStripMenuItem_Click);
            // 
            // interrogazioneMovimentiToolStripMenuItem
            // 
            this.interrogazioneMovimentiToolStripMenuItem.Name = "interrogazioneMovimentiToolStripMenuItem";
            this.interrogazioneMovimentiToolStripMenuItem.Size = new System.Drawing.Size(277, 32);
            this.interrogazioneMovimentiToolStripMenuItem.Text = "Interrogazione movimenti";
            this.interrogazioneMovimentiToolStripMenuItem.Click += new System.EventHandler(this.interrogazioneMovimentiToolStripMenuItem_Click);
            // 
            // caricoscaricoToolStripMenuItem
            // 
            this.caricoscaricoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserisciNuovoCaricoscaricoToolStripMenuItem});
            this.caricoscaricoToolStripMenuItem.Name = "caricoscaricoToolStripMenuItem";
            this.caricoscaricoToolStripMenuItem.Size = new System.Drawing.Size(277, 32);
            this.caricoscaricoToolStripMenuItem.Text = "Carico/scarico manuale";
            this.caricoscaricoToolStripMenuItem.Click += new System.EventHandler(this.caricoscaricoToolStripMenuItem_Click);
            // 
            // inserisciNuovoCaricoscaricoToolStripMenuItem
            // 
            this.inserisciNuovoCaricoscaricoToolStripMenuItem.Name = "inserisciNuovoCaricoscaricoToolStripMenuItem";
            this.inserisciNuovoCaricoscaricoToolStripMenuItem.Size = new System.Drawing.Size(299, 32);
            this.inserisciNuovoCaricoscaricoToolStripMenuItem.Text = "Inserisci nuovo carico/scarico";
            this.inserisciNuovoCaricoscaricoToolStripMenuItem.Click += new System.EventHandler(this.inserisciNuovoCaricoscaricoToolStripMenuItem_Click);
            // 
            // impostazioniToolStripMenuItem
            // 
            this.impostazioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contatoriAziendaToolStripMenuItem,
            this.registraUtentiToolStripMenuItem});
            this.impostazioniToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impostazioniToolStripMenuItem.Name = "impostazioniToolStripMenuItem";
            this.impostazioniToolStripMenuItem.Size = new System.Drawing.Size(119, 32);
            this.impostazioniToolStripMenuItem.Text = "Impostazioni";
            // 
            // contatoriAziendaToolStripMenuItem
            // 
            this.contatoriAziendaToolStripMenuItem.Name = "contatoriAziendaToolStripMenuItem";
            this.contatoriAziendaToolStripMenuItem.Size = new System.Drawing.Size(214, 32);
            this.contatoriAziendaToolStripMenuItem.Text = "Contatori azienda";
            this.contatoriAziendaToolStripMenuItem.Click += new System.EventHandler(this.contatoriAziendaToolStripMenuItem_Click);
            // 
            // registraUtentiToolStripMenuItem
            // 
            this.registraUtentiToolStripMenuItem.Name = "registraUtentiToolStripMenuItem";
            this.registraUtentiToolStripMenuItem.Size = new System.Drawing.Size(214, 32);
            this.registraUtentiToolStripMenuItem.Text = "Registra utenti";
            this.registraUtentiToolStripMenuItem.Click += new System.EventHandler(this.registraUtentiToolStripMenuItem_Click);
            // 
            // ruoliToolStripMenuItem
            // 
            this.ruoliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impiegataToolStripMenuItem,
            this.pianificazioneToolStripMenuItem,
            this.stampaggioToolStripMenuItem,
            this.taglioToolStripMenuItem,
            this.assemblaggioToolStripMenuItem});
            this.ruoliToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 13.8F);
            this.ruoliToolStripMenuItem.Name = "ruoliToolStripMenuItem";
            this.ruoliToolStripMenuItem.Size = new System.Drawing.Size(62, 32);
            this.ruoliToolStripMenuItem.Text = "Ruoli";
            // 
            // impiegataToolStripMenuItem
            // 
            this.impiegataToolStripMenuItem.Name = "impiegataToolStripMenuItem";
            this.impiegataToolStripMenuItem.Size = new System.Drawing.Size(185, 32);
            this.impiegataToolStripMenuItem.Text = "Impiegata";
            this.impiegataToolStripMenuItem.Click += new System.EventHandler(this.impiegataToolStripMenuItem_Click);
            // 
            // pianificazioneToolStripMenuItem
            // 
            this.pianificazioneToolStripMenuItem.Name = "pianificazioneToolStripMenuItem";
            this.pianificazioneToolStripMenuItem.Size = new System.Drawing.Size(185, 32);
            this.pianificazioneToolStripMenuItem.Text = "Pianificazione";
            // 
            // stampaggioToolStripMenuItem
            // 
            this.stampaggioToolStripMenuItem.Name = "stampaggioToolStripMenuItem";
            this.stampaggioToolStripMenuItem.Size = new System.Drawing.Size(185, 32);
            this.stampaggioToolStripMenuItem.Text = "Stampaggio";
            this.stampaggioToolStripMenuItem.Click += new System.EventHandler(this.stampaggioToolStripMenuItem_Click);
            // 
            // taglioToolStripMenuItem
            // 
            this.taglioToolStripMenuItem.Name = "taglioToolStripMenuItem";
            this.taglioToolStripMenuItem.Size = new System.Drawing.Size(185, 32);
            this.taglioToolStripMenuItem.Text = "Taglio";
            this.taglioToolStripMenuItem.Click += new System.EventHandler(this.taglioToolStripMenuItem_Click);
            // 
            // assemblaggioToolStripMenuItem
            // 
            this.assemblaggioToolStripMenuItem.Name = "assemblaggioToolStripMenuItem";
            this.assemblaggioToolStripMenuItem.Size = new System.Drawing.Size(185, 32);
            this.assemblaggioToolStripMenuItem.Text = "Assemblaggio";
            this.assemblaggioToolStripMenuItem.Click += new System.EventHandler(this.assemblaggioToolStripMenuItem_Click);
            // 
            // disconnettiUtenteToolStripMenuItem
            // 
            this.disconnettiUtenteToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnettiUtenteToolStripMenuItem.Name = "disconnettiUtenteToolStripMenuItem";
            this.disconnettiUtenteToolStripMenuItem.Size = new System.Drawing.Size(160, 32);
            this.disconnettiUtenteToolStripMenuItem.Text = "Disconnetti utente";
            this.disconnettiUtenteToolStripMenuItem.Click += new System.EventHandler(this.disconnettiUtenteToolStripMenuItem_Click);
            // 
            // registraUtenteToolStripMenuItem
            // 
            this.registraUtenteToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 13.8F);
            this.registraUtenteToolStripMenuItem.Name = "registraUtenteToolStripMenuItem";
            this.registraUtenteToolStripMenuItem.Size = new System.Drawing.Size(139, 32);
            this.registraUtenteToolStripMenuItem.Text = "Registra Utente";
            this.registraUtenteToolStripMenuItem.Click += new System.EventHandler(this.registraUtenteToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(53, 32);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(896, 518);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Target2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anaMagazziniBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Target2021DataSet target2021DataSet;
        private System.Windows.Forms.BindingSource anaMagazziniBindingSource;
        private Target2021DataSetTableAdapters.AnaMagazziniTableAdapter anaMagazziniTableAdapter;
        private Target2021DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anagraficeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articoloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dettaglioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornitoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem macchinariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strumentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiePrimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stampiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minuterieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipiCommesseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fasiLavorazioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compatibilitàStampiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compatibilitàDimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testataOrdiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dettaglioOrdiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commesseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem magazziniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impostazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anagraficheMagazziniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interrogazioneGiacenzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interrogazioneMovimentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caricoscaricoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contatoriAziendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controllaNuoviOrdiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnettiUtenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registraUtentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruoliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impiegataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stampaggioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taglioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registraUtenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pianificazioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem macchineDiStampoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem macchineDiTaglioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assemblaggioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserisciNuovoCaricoscaricoToolStripMenuItem;
    }
}

