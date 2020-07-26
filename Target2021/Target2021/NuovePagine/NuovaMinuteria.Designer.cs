namespace Target2021.NuovePagine
{
    partial class NuovaMinuteria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codiceLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label descrizioneLabel;
            System.Windows.Forms.Label prezzo_acqLabel;
            System.Windows.Forms.Label unita_misuraLabel;
            System.Windows.Forms.Label quantita_riordinoLabel;
            System.Windows.Forms.Label scorta_minimaLabel;
            System.Windows.Forms.Label codice_fornitoreLabel;
            System.Windows.Forms.Label descrizione_fornitoreLabel;
            System.Windows.Forms.Label barcodeLabel;
            System.Windows.Forms.Label dimXLabel;
            System.Windows.Forms.Label dimYLabel;
            System.Windows.Forms.Label dimZLabel;
            System.Windows.Forms.Label pesoLabel;
            System.Windows.Forms.Label posizioneLabel;
            this.target2021DataSet = new Target2021.Target2021DataSet();
            this.minuterieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.minuterieTableAdapter = new Target2021.Target2021DataSetTableAdapters.MinuterieTableAdapter();
            this.tableAdapterManager = new Target2021.Target2021DataSetTableAdapters.TableAdapterManager();
            this.codiceTextBox = new System.Windows.Forms.TextBox();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.descrizioneTextBox = new System.Windows.Forms.TextBox();
            this.prezzo_acqTextBox = new System.Windows.Forms.TextBox();
            this.unita_misuraTextBox = new System.Windows.Forms.TextBox();
            this.quantita_riordinoTextBox = new System.Windows.Forms.TextBox();
            this.scorta_minimaTextBox = new System.Windows.Forms.TextBox();
            this.descrizione_fornitoreTextBox = new System.Windows.Forms.TextBox();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.dimXTextBox = new System.Windows.Forms.TextBox();
            this.dimYTextBox = new System.Windows.Forms.TextBox();
            this.dimZTextBox = new System.Windows.Forms.TextBox();
            this.pesoTextBox = new System.Windows.Forms.TextBox();
            this.posizioneTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fornitoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornitoriTableAdapter = new Target2021.Target2021DataSetTableAdapters.FornitoriTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            codiceLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            descrizioneLabel = new System.Windows.Forms.Label();
            prezzo_acqLabel = new System.Windows.Forms.Label();
            unita_misuraLabel = new System.Windows.Forms.Label();
            quantita_riordinoLabel = new System.Windows.Forms.Label();
            scorta_minimaLabel = new System.Windows.Forms.Label();
            codice_fornitoreLabel = new System.Windows.Forms.Label();
            descrizione_fornitoreLabel = new System.Windows.Forms.Label();
            barcodeLabel = new System.Windows.Forms.Label();
            dimXLabel = new System.Windows.Forms.Label();
            dimYLabel = new System.Windows.Forms.Label();
            dimZLabel = new System.Windows.Forms.Label();
            pesoLabel = new System.Windows.Forms.Label();
            posizioneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuterieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornitoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codiceLabel
            // 
            codiceLabel.AutoSize = true;
            codiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codiceLabel.Location = new System.Drawing.Point(143, 114);
            codiceLabel.Name = "codiceLabel";
            codiceLabel.Size = new System.Drawing.Size(140, 20);
            codiceLabel.TabIndex = 1;
            codiceLabel.Text = "Codice minuteria:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoLabel.Location = new System.Drawing.Point(662, 114);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(46, 20);
            tipoLabel.TabIndex = 3;
            tipoLabel.Text = "Tipo:";
            // 
            // descrizioneLabel
            // 
            descrizioneLabel.AutoSize = true;
            descrizioneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descrizioneLabel.Location = new System.Drawing.Point(179, 147);
            descrizioneLabel.Name = "descrizioneLabel";
            descrizioneLabel.Size = new System.Drawing.Size(104, 20);
            descrizioneLabel.TabIndex = 5;
            descrizioneLabel.Text = "Descrizione:";
            // 
            // prezzo_acqLabel
            // 
            prezzo_acqLabel.AutoSize = true;
            prezzo_acqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prezzo_acqLabel.Location = new System.Drawing.Point(130, 180);
            prezzo_acqLabel.Name = "prezzo_acqLabel";
            prezzo_acqLabel.Size = new System.Drawing.Size(153, 20);
            prezzo_acqLabel.TabIndex = 7;
            prezzo_acqLabel.Text = "Prezzo di acquisto:";
            // 
            // unita_misuraLabel
            // 
            unita_misuraLabel.AutoSize = true;
            unita_misuraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            unita_misuraLabel.Location = new System.Drawing.Point(590, 180);
            unita_misuraLabel.Name = "unita_misuraLabel";
            unita_misuraLabel.Size = new System.Drawing.Size(127, 20);
            unita_misuraLabel.TabIndex = 9;
            unita_misuraLabel.Text = "Unità di misura:";
            // 
            // quantita_riordinoLabel
            // 
            quantita_riordinoLabel.AutoSize = true;
            quantita_riordinoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantita_riordinoLabel.Location = new System.Drawing.Point(127, 249);
            quantita_riordinoLabel.Name = "quantita_riordinoLabel";
            quantita_riordinoLabel.Size = new System.Drawing.Size(156, 20);
            quantita_riordinoLabel.TabIndex = 11;
            quantita_riordinoLabel.Text = "Quantita di riordino:";
            // 
            // scorta_minimaLabel
            // 
            scorta_minimaLabel.AutoSize = true;
            scorta_minimaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            scorta_minimaLabel.Location = new System.Drawing.Point(161, 279);
            scorta_minimaLabel.Name = "scorta_minimaLabel";
            scorta_minimaLabel.Size = new System.Drawing.Size(122, 20);
            scorta_minimaLabel.TabIndex = 13;
            scorta_minimaLabel.Text = "Scorta minima:";
            // 
            // codice_fornitoreLabel
            // 
            codice_fornitoreLabel.AutoSize = true;
            codice_fornitoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codice_fornitoreLabel.Location = new System.Drawing.Point(150, 213);
            codice_fornitoreLabel.Name = "codice_fornitoreLabel";
            codice_fornitoreLabel.Size = new System.Drawing.Size(133, 20);
            codice_fornitoreLabel.TabIndex = 15;
            codice_fornitoreLabel.Text = "Codice fornitore:";
            // 
            // descrizione_fornitoreLabel
            // 
            descrizione_fornitoreLabel.AutoSize = true;
            descrizione_fornitoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descrizione_fornitoreLabel.Location = new System.Drawing.Point(546, 216);
            descrizione_fornitoreLabel.Name = "descrizione_fornitoreLabel";
            descrizione_fornitoreLabel.Size = new System.Drawing.Size(171, 20);
            descrizione_fornitoreLabel.TabIndex = 17;
            descrizione_fornitoreLabel.Text = "Descrizione fornitore:";
            // 
            // barcodeLabel
            // 
            barcodeLabel.AutoSize = true;
            barcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            barcodeLabel.Location = new System.Drawing.Point(640, 249);
            barcodeLabel.Name = "barcodeLabel";
            barcodeLabel.Size = new System.Drawing.Size(77, 20);
            barcodeLabel.TabIndex = 19;
            barcodeLabel.Text = "Barcode:";
            // 
            // dimXLabel
            // 
            dimXLabel.AutoSize = true;
            dimXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dimXLabel.Location = new System.Drawing.Point(177, 315);
            dimXLabel.Name = "dimXLabel";
            dimXLabel.Size = new System.Drawing.Size(106, 20);
            dimXLabel.TabIndex = 21;
            dimXLabel.Text = "Dim X (mm):";
            // 
            // dimYLabel
            // 
            dimYLabel.AutoSize = true;
            dimYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dimYLabel.Location = new System.Drawing.Point(465, 315);
            dimYLabel.Name = "dimYLabel";
            dimYLabel.Size = new System.Drawing.Size(105, 20);
            dimYLabel.TabIndex = 23;
            dimYLabel.Text = "Dim Y (mm):";
            // 
            // dimZLabel
            // 
            dimZLabel.AutoSize = true;
            dimZLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dimZLabel.Location = new System.Drawing.Point(724, 315);
            dimZLabel.Name = "dimZLabel";
            dimZLabel.Size = new System.Drawing.Size(104, 20);
            dimZLabel.TabIndex = 25;
            dimZLabel.Text = "Dim Z (mm):";
            // 
            // pesoLabel
            // 
            pesoLabel.AutoSize = true;
            pesoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pesoLabel.Location = new System.Drawing.Point(665, 282);
            pesoLabel.Name = "pesoLabel";
            pesoLabel.Size = new System.Drawing.Size(52, 20);
            pesoLabel.TabIndex = 27;
            pesoLabel.Text = "Peso:";
            // 
            // posizioneLabel
            // 
            posizioneLabel.AutoSize = true;
            posizioneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            posizioneLabel.Location = new System.Drawing.Point(196, 348);
            posizioneLabel.Name = "posizioneLabel";
            posizioneLabel.Size = new System.Drawing.Size(87, 20);
            posizioneLabel.TabIndex = 29;
            posizioneLabel.Text = "Posizione:";
            // 
            // target2021DataSet
            // 
            this.target2021DataSet.DataSetName = "Target2021DataSet";
            this.target2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // minuterieBindingSource
            // 
            this.minuterieBindingSource.DataMember = "Minuterie";
            this.minuterieBindingSource.DataSource = this.target2021DataSet;
            // 
            // minuterieTableAdapter
            // 
            this.minuterieTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AbbinamentiArticoliTableAdapter = null;
            this.tableAdapterManager.AbbinamentiSuperCommesseTableAdapter = null;
            this.tableAdapterManager.AnaMagazziniTableAdapter = null;
            this.tableAdapterManager.ArtFornTableAdapter = null;
            this.tableAdapterManager.articoli_sempliciTableAdapter = null;
            this.tableAdapterManager.ArticoliBCTableAdapter = null;
            this.tableAdapterManager.AvvisiAbbinamentiTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientiTableAdapter = null;
            this.tableAdapterManager.CodModPagamentoTableAdapter = null;
            this.tableAdapterManager.CodSpedizioniTableAdapter = null;
            this.tableAdapterManager.CodTermPagamentoTableAdapter = null;
            this.tableAdapterManager.CommesseTableAdapter = null;
            this.tableAdapterManager.CompatibStampaTableAdapter = null;
            this.tableAdapterManager.CompatibTaglioTableAdapter = null;
            this.tableAdapterManager.ConfigurazioneTableAdapter = null;
            this.tableAdapterManager.dettaglio_ddtTableAdapter = null;
            this.tableAdapterManager.dettaglio_ordini_acquistoTableAdapter = null;
            this.tableAdapterManager.dettaglio_ordini_multirigaTableAdapter = null;
            this.tableAdapterManager.DettArticoliTableAdapter = null;
            this.tableAdapterManager.dimensioniTableAdapter = null;
            this.tableAdapterManager.DimeTableAdapter = null;
            this.tableAdapterManager.FasiTableAdapter = null;
            this.tableAdapterManager.FornitoriTableAdapter = null;
            this.tableAdapterManager.GiacenzeMagazziniTableAdapter = null;
            this.tableAdapterManager.ImpegnateOrdinatoTableAdapter = null;
            this.tableAdapterManager.LavorazioniTableAdapter = null;
            this.tableAdapterManager.LivelliUtenzaTableAdapter = null;
            this.tableAdapterManager.MacchineStampoTableAdapter = null;
            this.tableAdapterManager.MacchineTaglioTableAdapter = null;
            this.tableAdapterManager.MinuterieTableAdapter = this.minuterieTableAdapter;
            this.tableAdapterManager.MovimentiMagazzinoTableAdapter = null;
            this.tableAdapterManager.OrdFornDettTableAdapter = null;
            this.tableAdapterManager.OrdFornTestTableAdapter = null;
            this.tableAdapterManager.OrdiniEsclusiTableAdapter = null;
            this.tableAdapterManager.OrdiniImportatiTableAdapter = null;
            this.tableAdapterManager.PesiSpecificiTableAdapter = null;
            this.tableAdapterManager.PosizioniDimeStampiTableAdapter = null;
            this.tableAdapterManager.PrimeTableAdapter = null;
            this.tableAdapterManager.SchedulazioneTableAdapter = null;
            this.tableAdapterManager.StampiTableAdapter = null;
            this.tableAdapterManager.SuperCommessaTableAdapter = null;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.TaglioOnLineTableAdapter = null;
            this.tableAdapterManager.TempStampTableAdapter = null;
            this.tableAdapterManager.TempTableAdapter = null;
            this.tableAdapterManager.testata_ordini_multirigaTableAdapter = null;
            this.tableAdapterManager.TipoCommessaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Target2021.Target2021DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtentiTableAdapter = null;
            // 
            // codiceTextBox
            // 
            this.codiceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codiceTextBox.Location = new System.Drawing.Point(296, 111);
            this.codiceTextBox.Name = "codiceTextBox";
            this.codiceTextBox.Size = new System.Drawing.Size(151, 27);
            this.codiceTextBox.TabIndex = 2;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.Enabled = false;
            this.tipoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoTextBox.Location = new System.Drawing.Point(714, 111);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(151, 27);
            this.tipoTextBox.TabIndex = 4;
            this.tipoTextBox.Text = "MINUTE";
            this.tipoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descrizioneTextBox
            // 
            this.descrizioneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrizioneTextBox.Location = new System.Drawing.Point(296, 144);
            this.descrizioneTextBox.Name = "descrizioneTextBox";
            this.descrizioneTextBox.Size = new System.Drawing.Size(569, 27);
            this.descrizioneTextBox.TabIndex = 6;
            // 
            // prezzo_acqTextBox
            // 
            this.prezzo_acqTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prezzo_acqTextBox.Location = new System.Drawing.Point(296, 177);
            this.prezzo_acqTextBox.Name = "prezzo_acqTextBox";
            this.prezzo_acqTextBox.Size = new System.Drawing.Size(151, 27);
            this.prezzo_acqTextBox.TabIndex = 8;
            this.prezzo_acqTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prezzo_acqTextBox_KeyPress);
            // 
            // unita_misuraTextBox
            // 
            this.unita_misuraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unita_misuraTextBox.Location = new System.Drawing.Point(723, 177);
            this.unita_misuraTextBox.Name = "unita_misuraTextBox";
            this.unita_misuraTextBox.Size = new System.Drawing.Size(151, 27);
            this.unita_misuraTextBox.TabIndex = 10;
            // 
            // quantita_riordinoTextBox
            // 
            this.quantita_riordinoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantita_riordinoTextBox.Location = new System.Drawing.Point(296, 243);
            this.quantita_riordinoTextBox.Name = "quantita_riordinoTextBox";
            this.quantita_riordinoTextBox.Size = new System.Drawing.Size(151, 27);
            this.quantita_riordinoTextBox.TabIndex = 12;
            this.quantita_riordinoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantita_riordinoTextBox_KeyPress);
            // 
            // scorta_minimaTextBox
            // 
            this.scorta_minimaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorta_minimaTextBox.Location = new System.Drawing.Point(296, 276);
            this.scorta_minimaTextBox.Name = "scorta_minimaTextBox";
            this.scorta_minimaTextBox.Size = new System.Drawing.Size(151, 27);
            this.scorta_minimaTextBox.TabIndex = 14;
            this.scorta_minimaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.scorta_minimaTextBox_KeyPress);
            // 
            // descrizione_fornitoreTextBox
            // 
            this.descrizione_fornitoreTextBox.Enabled = false;
            this.descrizione_fornitoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrizione_fornitoreTextBox.Location = new System.Drawing.Point(723, 213);
            this.descrizione_fornitoreTextBox.Name = "descrizione_fornitoreTextBox";
            this.descrizione_fornitoreTextBox.Size = new System.Drawing.Size(388, 27);
            this.descrizione_fornitoreTextBox.TabIndex = 18;
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeTextBox.Location = new System.Drawing.Point(723, 246);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(142, 27);
            this.barcodeTextBox.TabIndex = 20;
            // 
            // dimXTextBox
            // 
            this.dimXTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimXTextBox.Location = new System.Drawing.Point(297, 312);
            this.dimXTextBox.Name = "dimXTextBox";
            this.dimXTextBox.Size = new System.Drawing.Size(150, 27);
            this.dimXTextBox.TabIndex = 22;
            this.dimXTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dimXTextBox_KeyPress);
            // 
            // dimYTextBox
            // 
            this.dimYTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimYTextBox.Location = new System.Drawing.Point(576, 312);
            this.dimYTextBox.Name = "dimYTextBox";
            this.dimYTextBox.Size = new System.Drawing.Size(142, 27);
            this.dimYTextBox.TabIndex = 24;
            this.dimYTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dimYTextBox_KeyPress);
            // 
            // dimZTextBox
            // 
            this.dimZTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimZTextBox.Location = new System.Drawing.Point(834, 312);
            this.dimZTextBox.Name = "dimZTextBox";
            this.dimZTextBox.Size = new System.Drawing.Size(142, 27);
            this.dimZTextBox.TabIndex = 26;
            this.dimZTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dimZTextBox_KeyPress);
            // 
            // pesoTextBox
            // 
            this.pesoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesoTextBox.Location = new System.Drawing.Point(723, 279);
            this.pesoTextBox.Name = "pesoTextBox";
            this.pesoTextBox.Size = new System.Drawing.Size(142, 27);
            this.pesoTextBox.TabIndex = 28;
            this.pesoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pesoTextBox_KeyPress);
            // 
            // posizioneTextBox
            // 
            this.posizioneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posizioneTextBox.Location = new System.Drawing.Point(297, 345);
            this.posizioneTextBox.Name = "posizioneTextBox";
            this.posizioneTextBox.Size = new System.Drawing.Size(679, 27);
            this.posizioneTextBox.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 52);
            this.label1.TabIndex = 31;
            this.label1.Text = "Inserimento nuova minuteria";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(475, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 44);
            this.button1.TabIndex = 32;
            this.button1.Text = "SALVA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fornitoriBindingSource
            // 
            this.fornitoriBindingSource.DataMember = "Fornitori";
            this.fornitoriBindingSource.DataSource = this.target2021DataSet;
            // 
            // fornitoriTableAdapter
            // 
            this.fornitoriTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataSource = this.fornitoriBindingSource;
            this.comboBox1.DisplayMember = "codice";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(296, 210);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.ValueMember = "ragione_sociale";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NuovaMinuteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1134, 471);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(codiceLabel);
            this.Controls.Add(this.codiceTextBox);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoTextBox);
            this.Controls.Add(descrizioneLabel);
            this.Controls.Add(this.descrizioneTextBox);
            this.Controls.Add(prezzo_acqLabel);
            this.Controls.Add(this.prezzo_acqTextBox);
            this.Controls.Add(unita_misuraLabel);
            this.Controls.Add(this.unita_misuraTextBox);
            this.Controls.Add(quantita_riordinoLabel);
            this.Controls.Add(this.quantita_riordinoTextBox);
            this.Controls.Add(scorta_minimaLabel);
            this.Controls.Add(this.scorta_minimaTextBox);
            this.Controls.Add(codice_fornitoreLabel);
            this.Controls.Add(descrizione_fornitoreLabel);
            this.Controls.Add(this.descrizione_fornitoreTextBox);
            this.Controls.Add(barcodeLabel);
            this.Controls.Add(this.barcodeTextBox);
            this.Controls.Add(dimXLabel);
            this.Controls.Add(this.dimXTextBox);
            this.Controls.Add(dimYLabel);
            this.Controls.Add(this.dimYTextBox);
            this.Controls.Add(dimZLabel);
            this.Controls.Add(this.dimZTextBox);
            this.Controls.Add(pesoLabel);
            this.Controls.Add(this.pesoTextBox);
            this.Controls.Add(posizioneLabel);
            this.Controls.Add(this.posizioneTextBox);
            this.Name = "NuovaMinuteria";
            this.Text = "Nuova Minuteria";
            this.Load += new System.EventHandler(this.NuovaMinuteria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuterieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornitoriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Target2021DataSet target2021DataSet;
        private System.Windows.Forms.BindingSource minuterieBindingSource;
        private Target2021DataSetTableAdapters.MinuterieTableAdapter minuterieTableAdapter;
        private Target2021DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox codiceTextBox;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.TextBox descrizioneTextBox;
        private System.Windows.Forms.TextBox prezzo_acqTextBox;
        private System.Windows.Forms.TextBox unita_misuraTextBox;
        private System.Windows.Forms.TextBox quantita_riordinoTextBox;
        private System.Windows.Forms.TextBox scorta_minimaTextBox;
        private System.Windows.Forms.TextBox descrizione_fornitoreTextBox;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.TextBox dimXTextBox;
        private System.Windows.Forms.TextBox dimYTextBox;
        private System.Windows.Forms.TextBox dimZTextBox;
        private System.Windows.Forms.TextBox pesoTextBox;
        private System.Windows.Forms.TextBox posizioneTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource fornitoriBindingSource;
        private Target2021DataSetTableAdapters.FornitoriTableAdapter fornitoriTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}