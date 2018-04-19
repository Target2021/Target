namespace Target2021
{
    partial class RigaCompleta
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
            System.Windows.Forms.Label iDDettaglioArticoloLabel;
            System.Windows.Forms.Label codice_articoloLabel;
            System.Windows.Forms.Label progressivoLabel;
            System.Windows.Forms.Label descrizionePrimaStampoDimaLabel;
            System.Windows.Forms.Label codiceInputLabel;
            System.Windows.Forms.Label codiceOutputLabel;
            System.Windows.Forms.Label codice_fornitoreLabel;
            System.Windows.Forms.Label lavorazioneLabel;
            System.Windows.Forms.Label percentualeLastraLabel;
            System.Windows.Forms.Label lottoMinimoRiordinoLabel;
            System.Windows.Forms.Label macPredefStampoLabel;
            System.Windows.Forms.Label macPredefTaglioLabel;
            System.Windows.Forms.Label costoBaseLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RigaCompleta));
            this.codicePrimaStampoDimaLabel = new System.Windows.Forms.Label();
            this.target2021DataSet = new Target2021.Target2021DataSet();
            this.dettArticoliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dettArticoliTableAdapter = new Target2021.Target2021DataSetTableAdapters.DettArticoliTableAdapter();
            this.tableAdapterManager = new Target2021.Target2021DataSetTableAdapters.TableAdapterManager();
            this.dettArticoliBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dettArticoliBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDDettaglioArticoloTextBox = new System.Windows.Forms.TextBox();
            this.codice_articoloTextBox = new System.Windows.Forms.TextBox();
            this.progressivoTextBox = new System.Windows.Forms.TextBox();
            this.codicePrimaStampoDimaTextBox = new System.Windows.Forms.TextBox();
            this.descrizionePrimaStampoDimaTextBox = new System.Windows.Forms.TextBox();
            this.codiceInputTextBox = new System.Windows.Forms.TextBox();
            this.codiceOutputTextBox = new System.Windows.Forms.TextBox();
            this.codice_fornitoreTextBox = new System.Windows.Forms.TextBox();
            this.lavorazioneTextBox = new System.Windows.Forms.TextBox();
            this.percentualeLastraTextBox = new System.Windows.Forms.TextBox();
            this.lottoMinimoRiordinoTextBox = new System.Windows.Forms.TextBox();
            this.macPredefStampoTextBox = new System.Windows.Forms.TextBox();
            this.macPredefTaglioTextBox = new System.Windows.Forms.TextBox();
            this.costoBaseTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            iDDettaglioArticoloLabel = new System.Windows.Forms.Label();
            codice_articoloLabel = new System.Windows.Forms.Label();
            progressivoLabel = new System.Windows.Forms.Label();
            descrizionePrimaStampoDimaLabel = new System.Windows.Forms.Label();
            codiceInputLabel = new System.Windows.Forms.Label();
            codiceOutputLabel = new System.Windows.Forms.Label();
            codice_fornitoreLabel = new System.Windows.Forms.Label();
            lavorazioneLabel = new System.Windows.Forms.Label();
            percentualeLastraLabel = new System.Windows.Forms.Label();
            lottoMinimoRiordinoLabel = new System.Windows.Forms.Label();
            macPredefStampoLabel = new System.Windows.Forms.Label();
            macPredefTaglioLabel = new System.Windows.Forms.Label();
            costoBaseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dettArticoliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dettArticoliBindingNavigator)).BeginInit();
            this.dettArticoliBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDDettaglioArticoloLabel
            // 
            iDDettaglioArticoloLabel.AutoSize = true;
            iDDettaglioArticoloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDDettaglioArticoloLabel.Location = new System.Drawing.Point(67, 72);
            iDDettaglioArticoloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iDDettaglioArticoloLabel.Name = "iDDettaglioArticoloLabel";
            iDDettaglioArticoloLabel.Size = new System.Drawing.Size(199, 24);
            iDDettaglioArticoloLabel.TabIndex = 1;
            iDDettaglioArticoloLabel.Text = "ID Dettaglio Articolo:";
            // 
            // codice_articoloLabel
            // 
            codice_articoloLabel.AutoSize = true;
            codice_articoloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codice_articoloLabel.Location = new System.Drawing.Point(84, 105);
            codice_articoloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codice_articoloLabel.Name = "codice_articoloLabel";
            codice_articoloLabel.Size = new System.Drawing.Size(159, 24);
            codice_articoloLabel.TabIndex = 3;
            codice_articoloLabel.Text = "Codice Articolo:";
            // 
            // progressivoLabel
            // 
            progressivoLabel.AutoSize = true;
            progressivoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            progressivoLabel.Location = new System.Drawing.Point(84, 137);
            progressivoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            progressivoLabel.Name = "progressivoLabel";
            progressivoLabel.Size = new System.Drawing.Size(126, 24);
            progressivoLabel.TabIndex = 5;
            progressivoLabel.Text = "Progressivo:";
            // 
            // descrizionePrimaStampoDimaLabel
            // 
            descrizionePrimaStampoDimaLabel.AutoSize = true;
            descrizionePrimaStampoDimaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descrizionePrimaStampoDimaLabel.Location = new System.Drawing.Point(93, 199);
            descrizionePrimaStampoDimaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descrizionePrimaStampoDimaLabel.Name = "descrizionePrimaStampoDimaLabel";
            descrizionePrimaStampoDimaLabel.Size = new System.Drawing.Size(126, 24);
            descrizionePrimaStampoDimaLabel.TabIndex = 9;
            descrizionePrimaStampoDimaLabel.Text = "Descrizione:";
            // 
            // codiceInputLabel
            // 
            codiceInputLabel.AutoSize = true;
            codiceInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codiceInputLabel.Location = new System.Drawing.Point(93, 231);
            codiceInputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codiceInputLabel.Name = "codiceInputLabel";
            codiceInputLabel.Size = new System.Drawing.Size(134, 24);
            codiceInputLabel.TabIndex = 11;
            codiceInputLabel.Text = "Codice Input:";
            // 
            // codiceOutputLabel
            // 
            codiceOutputLabel.AutoSize = true;
            codiceOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codiceOutputLabel.Location = new System.Drawing.Point(93, 263);
            codiceOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codiceOutputLabel.Name = "codiceOutputLabel";
            codiceOutputLabel.Size = new System.Drawing.Size(150, 24);
            codiceOutputLabel.TabIndex = 13;
            codiceOutputLabel.Text = "Codice Output:";
            // 
            // codice_fornitoreLabel
            // 
            codice_fornitoreLabel.AutoSize = true;
            codice_fornitoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codice_fornitoreLabel.Location = new System.Drawing.Point(93, 295);
            codice_fornitoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codice_fornitoreLabel.Name = "codice_fornitoreLabel";
            codice_fornitoreLabel.Size = new System.Drawing.Size(101, 24);
            codice_fornitoreLabel.TabIndex = 15;
            codice_fornitoreLabel.Text = "Fornitore:";
            // 
            // lavorazioneLabel
            // 
            lavorazioneLabel.AutoSize = true;
            lavorazioneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lavorazioneLabel.Location = new System.Drawing.Point(93, 327);
            lavorazioneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lavorazioneLabel.Name = "lavorazioneLabel";
            lavorazioneLabel.Size = new System.Drawing.Size(129, 24);
            lavorazioneLabel.TabIndex = 17;
            lavorazioneLabel.Text = "Lavorazione:";
            // 
            // percentualeLastraLabel
            // 
            percentualeLastraLabel.AutoSize = true;
            percentualeLastraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            percentualeLastraLabel.Location = new System.Drawing.Point(93, 359);
            percentualeLastraLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            percentualeLastraLabel.Name = "percentualeLastraLabel";
            percentualeLastraLabel.Size = new System.Drawing.Size(189, 24);
            percentualeLastraLabel.TabIndex = 19;
            percentualeLastraLabel.Text = "Percentuale Lastra:";
            // 
            // lottoMinimoRiordinoLabel
            // 
            lottoMinimoRiordinoLabel.AutoSize = true;
            lottoMinimoRiordinoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lottoMinimoRiordinoLabel.Location = new System.Drawing.Point(62, 393);
            lottoMinimoRiordinoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lottoMinimoRiordinoLabel.Name = "lottoMinimoRiordinoLabel";
            lottoMinimoRiordinoLabel.Size = new System.Drawing.Size(220, 24);
            lottoMinimoRiordinoLabel.TabIndex = 21;
            lottoMinimoRiordinoLabel.Text = "Lotto Minimo Riordino:";
            // 
            // macPredefStampoLabel
            // 
            macPredefStampoLabel.AutoSize = true;
            macPredefStampoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            macPredefStampoLabel.Location = new System.Drawing.Point(84, 425);
            macPredefStampoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            macPredefStampoLabel.Name = "macPredefStampoLabel";
            macPredefStampoLabel.Size = new System.Drawing.Size(198, 24);
            macPredefStampoLabel.TabIndex = 23;
            macPredefStampoLabel.Text = "Mac Predef Stampo:";
            // 
            // macPredefTaglioLabel
            // 
            macPredefTaglioLabel.AutoSize = true;
            macPredefTaglioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            macPredefTaglioLabel.Location = new System.Drawing.Point(93, 457);
            macPredefTaglioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            macPredefTaglioLabel.Name = "macPredefTaglioLabel";
            macPredefTaglioLabel.Size = new System.Drawing.Size(186, 24);
            macPredefTaglioLabel.TabIndex = 25;
            macPredefTaglioLabel.Text = "Mac Predef Taglio:";
            // 
            // costoBaseLabel
            // 
            costoBaseLabel.AutoSize = true;
            costoBaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            costoBaseLabel.Location = new System.Drawing.Point(93, 489);
            costoBaseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            costoBaseLabel.Name = "costoBaseLabel";
            costoBaseLabel.Size = new System.Drawing.Size(121, 24);
            costoBaseLabel.TabIndex = 27;
            costoBaseLabel.Text = "Costo Base:";
            // 
            // codicePrimaStampoDimaLabel
            // 
            this.codicePrimaStampoDimaLabel.AutoSize = true;
            this.codicePrimaStampoDimaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codicePrimaStampoDimaLabel.Location = new System.Drawing.Point(93, 167);
            this.codicePrimaStampoDimaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codicePrimaStampoDimaLabel.Name = "codicePrimaStampoDimaLabel";
            this.codicePrimaStampoDimaLabel.Size = new System.Drawing.Size(82, 24);
            this.codicePrimaStampoDimaLabel.TabIndex = 7;
            this.codicePrimaStampoDimaLabel.Text = "Codice:";
            // 
            // target2021DataSet
            // 
            this.target2021DataSet.DataSetName = "Target2021DataSet";
            this.target2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dettArticoliBindingSource
            // 
            this.dettArticoliBindingSource.DataMember = "DettArticoli";
            this.dettArticoliBindingSource.DataSource = this.target2021DataSet;
            // 
            // dettArticoliTableAdapter
            // 
            this.dettArticoliTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AbbinamentiArticoliTableAdapter = null;
            this.tableAdapterManager.AnaMagazziniTableAdapter = null;
            this.tableAdapterManager.articoli_sempliciTableAdapter = null;
            this.tableAdapterManager.ArticoliBCTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientiTableAdapter = null;
            this.tableAdapterManager.CommesseTableAdapter = null;
            this.tableAdapterManager.CompatibStampaTableAdapter = null;
            this.tableAdapterManager.CompatibTaglioTableAdapter = null;
            this.tableAdapterManager.ConfigurazioneTableAdapter = null;
            this.tableAdapterManager.dettaglio_ordini_multirigaTableAdapter = null;
            this.tableAdapterManager.DettArticoliTableAdapter = this.dettArticoliTableAdapter;
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
            // dettArticoliBindingNavigator
            // 
            this.dettArticoliBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dettArticoliBindingNavigator.BindingSource = this.dettArticoliBindingSource;
            this.dettArticoliBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dettArticoliBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dettArticoliBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dettArticoliBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.dettArticoliBindingNavigatorSaveItem});
            this.dettArticoliBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dettArticoliBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dettArticoliBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dettArticoliBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dettArticoliBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dettArticoliBindingNavigator.Name = "dettArticoliBindingNavigator";
            this.dettArticoliBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dettArticoliBindingNavigator.Size = new System.Drawing.Size(1071, 27);
            this.dettArticoliBindingNavigator.TabIndex = 0;
            this.dettArticoliBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Aggiungi nuovo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 24);
            this.bindingNavigatorCountItem.Text = "di {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Numero totale di elementi";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Elimina";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Sposta in prima posizione";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Sposta indietro";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posizione";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posizione corrente";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Sposta avanti";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Sposta in ultima posizione";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // dettArticoliBindingNavigatorSaveItem
            // 
            this.dettArticoliBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dettArticoliBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dettArticoliBindingNavigatorSaveItem.Image")));
            this.dettArticoliBindingNavigatorSaveItem.Name = "dettArticoliBindingNavigatorSaveItem";
            this.dettArticoliBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.dettArticoliBindingNavigatorSaveItem.Text = "Salva dati";
            this.dettArticoliBindingNavigatorSaveItem.Click += new System.EventHandler(this.dettArticoliBindingNavigatorSaveItem_Click);
            // 
            // iDDettaglioArticoloTextBox
            // 
            this.iDDettaglioArticoloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dettArticoliBindingSource, "IDDettaglioArticolo", true));
            this.iDDettaglioArticoloTextBox.Enabled = false;
            this.iDDettaglioArticoloTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDDettaglioArticoloTextBox.Location = new System.Drawing.Point(315, 68);
            this.iDDettaglioArticoloTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iDDettaglioArticoloTextBox.Name = "iDDettaglioArticoloTextBox";
            this.iDDettaglioArticoloTextBox.Size = new System.Drawing.Size(203, 29);
            this.iDDettaglioArticoloTextBox.TabIndex = 2;
            this.iDDettaglioArticoloTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // codice_articoloTextBox
            // 
            this.codice_articoloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dettArticoliBindingSource, "codice_articolo", true));
            this.codice_articoloTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codice_articoloTextBox.Location = new System.Drawing.Point(315, 100);
            this.codice_articoloTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codice_articoloTextBox.Name = "codice_articoloTextBox";
            this.codice_articoloTextBox.Size = new System.Drawing.Size(203, 29);
            this.codice_articoloTextBox.TabIndex = 4;
            this.codice_articoloTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressivoTextBox
            // 
            this.progressivoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dettArticoliBindingSource, "progressivo", true));
            this.progressivoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressivoTextBox.Location = new System.Drawing.Point(315, 132);
            this.progressivoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressivoTextBox.Name = "progressivoTextBox";
            this.progressivoTextBox.Size = new System.Drawing.Size(203, 29);
            this.progressivoTextBox.TabIndex = 6;
            this.progressivoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // codicePrimaStampoDimaTextBox
            // 
            this.codicePrimaStampoDimaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dettArticoliBindingSource, "codicePrimaStampoDima", true));
            this.codicePrimaStampoDimaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codicePrimaStampoDimaTextBox.Location = new System.Drawing.Point(315, 164);
            this.codicePrimaStampoDimaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codicePrimaStampoDimaTextBox.Name = "codicePrimaStampoDimaTextBox";
            this.codicePrimaStampoDimaTextBox.Size = new System.Drawing.Size(203, 29);
            this.codicePrimaStampoDimaTextBox.TabIndex = 8;
            this.codicePrimaStampoDimaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descrizionePrimaStampoDimaTextBox
            // 
            this.descrizionePrimaStampoDimaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dettArticoliBindingSource, "descrizionePrimaStampoDima", true));
            this.descrizionePrimaStampoDimaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrizionePrimaStampoDimaTextBox.Location = new System.Drawing.Point(315, 196);
            this.descrizionePrimaStampoDimaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descrizionePrimaStampoDimaTextBox.Name = "descrizionePrimaStampoDimaTextBox";
            this.descrizionePrimaStampoDimaTextBox.Size = new System.Drawing.Size(563, 29);
            this.descrizionePrimaStampoDimaTextBox.TabIndex = 10;
            this.descrizionePrimaStampoDimaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // codiceInputTextBox
            // 
            this.codiceInputTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dettArticoliBindingSource, "CodiceInput", true));
            this.codiceInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codiceInputTextBox.Location = new System.Drawing.Point(315, 228);
            this.codiceInputTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codiceInputTextBox.Name = "codiceInputTextBox";
            this.codiceInputTextBox.Size = new System.Drawing.Size(203, 29);
            this.codiceInputTextBox.TabIndex = 12;
            this.codiceInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // codiceOutputTextBox
            // 
            this.codiceOutputTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dettArticoliBindingSource, "CodiceOutput", true));
            this.codiceOutputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codiceOutputTextBox.Location = new System.Drawing.Point(315, 260);
            this.codiceOutputTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codiceOutputTextBox.Name = "codiceOutputTextBox";
            this.codiceOutputTextBox.Size = new System.Drawing.Size(203, 29);
            this.codiceOutputTextBox.TabIndex = 14;
            this.codiceOutputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // codice_fornitoreTextBox
            // 
            this.codice_fornitoreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dettArticoliBindingSource, "codice_fornitore", true));
            this.codice_fornitoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codice_fornitoreTextBox.Location = new System.Drawing.Point(315, 292);
            this.codice_fornitoreTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codice_fornitoreTextBox.Name = "codice_fornitoreTextBox";
            this.codice_fornitoreTextBox.Size = new System.Drawing.Size(203, 29);
            this.codice_fornitoreTextBox.TabIndex = 16;
            this.codice_fornitoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codice_fornitoreTextBox.Click += new System.EventHandler(this.CambiaFornitore);
            this.codice_fornitoreTextBox.TextChanged += new System.EventHandler(this.AggiornaFornitore);
            // 
            // lavorazioneTextBox
            // 
            this.lavorazioneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dettArticoliBindingSource, "lavorazione", true));
            this.lavorazioneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lavorazioneTextBox.Location = new System.Drawing.Point(315, 324);
            this.lavorazioneTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lavorazioneTextBox.Name = "lavorazioneTextBox";
            this.lavorazioneTextBox.Size = new System.Drawing.Size(203, 29);
            this.lavorazioneTextBox.TabIndex = 18;
            this.lavorazioneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lavorazioneTextBox.Click += new System.EventHandler(this.CambiaFase);
            this.lavorazioneTextBox.TextChanged += new System.EventHandler(this.AggiornaLavorazione);
            // 
            // percentualeLastraTextBox
            // 
            this.percentualeLastraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dettArticoliBindingSource, "PercentualeLastra", true));
            this.percentualeLastraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentualeLastraTextBox.Location = new System.Drawing.Point(315, 356);
            this.percentualeLastraTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.percentualeLastraTextBox.Name = "percentualeLastraTextBox";
            this.percentualeLastraTextBox.Size = new System.Drawing.Size(203, 29);
            this.percentualeLastraTextBox.TabIndex = 20;
            this.percentualeLastraTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lottoMinimoRiordinoTextBox
            // 
            this.lottoMinimoRiordinoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dettArticoliBindingSource, "LottoMinimoRiordino", true));
            this.lottoMinimoRiordinoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lottoMinimoRiordinoTextBox.Location = new System.Drawing.Point(315, 388);
            this.lottoMinimoRiordinoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lottoMinimoRiordinoTextBox.Name = "lottoMinimoRiordinoTextBox";
            this.lottoMinimoRiordinoTextBox.Size = new System.Drawing.Size(111, 29);
            this.lottoMinimoRiordinoTextBox.TabIndex = 22;
            this.lottoMinimoRiordinoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // macPredefStampoTextBox
            // 
            this.macPredefStampoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dettArticoliBindingSource, "MacPredefStampo", true));
            this.macPredefStampoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macPredefStampoTextBox.Location = new System.Drawing.Point(315, 420);
            this.macPredefStampoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.macPredefStampoTextBox.Name = "macPredefStampoTextBox";
            this.macPredefStampoTextBox.Size = new System.Drawing.Size(111, 29);
            this.macPredefStampoTextBox.TabIndex = 24;
            this.macPredefStampoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.macPredefStampoTextBox.TextChanged += new System.EventHandler(this.AggMachStampPredef);
            // 
            // macPredefTaglioTextBox
            // 
            this.macPredefTaglioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dettArticoliBindingSource, "MacPredefTaglio", true));
            this.macPredefTaglioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macPredefTaglioTextBox.Location = new System.Drawing.Point(315, 452);
            this.macPredefTaglioTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.macPredefTaglioTextBox.Name = "macPredefTaglioTextBox";
            this.macPredefTaglioTextBox.Size = new System.Drawing.Size(111, 29);
            this.macPredefTaglioTextBox.TabIndex = 26;
            this.macPredefTaglioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.macPredefTaglioTextBox.TextChanged += new System.EventHandler(this.AggMachTaglPredef);
            // 
            // costoBaseTextBox
            // 
            this.costoBaseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dettArticoliBindingSource, "CostoBase", true));
            this.costoBaseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costoBaseTextBox.Location = new System.Drawing.Point(315, 485);
            this.costoBaseTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.costoBaseTextBox.Name = "costoBaseTextBox";
            this.costoBaseTextBox.Size = new System.Drawing.Size(111, 29);
            this.costoBaseTextBox.TabIndex = 28;
            this.costoBaseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(527, 295);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(527, 327);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 423);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(435, 455);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "label4";
            // 
            // RigaCompleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1071, 524);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(costoBaseLabel);
            this.Controls.Add(this.costoBaseTextBox);
            this.Controls.Add(macPredefTaglioLabel);
            this.Controls.Add(this.macPredefTaglioTextBox);
            this.Controls.Add(macPredefStampoLabel);
            this.Controls.Add(this.macPredefStampoTextBox);
            this.Controls.Add(lottoMinimoRiordinoLabel);
            this.Controls.Add(this.lottoMinimoRiordinoTextBox);
            this.Controls.Add(percentualeLastraLabel);
            this.Controls.Add(this.percentualeLastraTextBox);
            this.Controls.Add(lavorazioneLabel);
            this.Controls.Add(this.lavorazioneTextBox);
            this.Controls.Add(codice_fornitoreLabel);
            this.Controls.Add(this.codice_fornitoreTextBox);
            this.Controls.Add(codiceOutputLabel);
            this.Controls.Add(this.codiceOutputTextBox);
            this.Controls.Add(codiceInputLabel);
            this.Controls.Add(this.codiceInputTextBox);
            this.Controls.Add(descrizionePrimaStampoDimaLabel);
            this.Controls.Add(this.descrizionePrimaStampoDimaTextBox);
            this.Controls.Add(this.codicePrimaStampoDimaLabel);
            this.Controls.Add(this.codicePrimaStampoDimaTextBox);
            this.Controls.Add(progressivoLabel);
            this.Controls.Add(this.progressivoTextBox);
            this.Controls.Add(codice_articoloLabel);
            this.Controls.Add(this.codice_articoloTextBox);
            this.Controls.Add(iDDettaglioArticoloLabel);
            this.Controls.Add(this.iDDettaglioArticoloTextBox);
            this.Controls.Add(this.dettArticoliBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RigaCompleta";
            this.Text = "RigaCompleta";
            this.Load += new System.EventHandler(this.RigaCompleta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dettArticoliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dettArticoliBindingNavigator)).EndInit();
            this.dettArticoliBindingNavigator.ResumeLayout(false);
            this.dettArticoliBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Target2021DataSet target2021DataSet;
        private System.Windows.Forms.BindingSource dettArticoliBindingSource;
        private Target2021DataSetTableAdapters.DettArticoliTableAdapter dettArticoliTableAdapter;
        private Target2021DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dettArticoliBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton dettArticoliBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDDettaglioArticoloTextBox;
        private System.Windows.Forms.TextBox codice_articoloTextBox;
        private System.Windows.Forms.TextBox progressivoTextBox;
        private System.Windows.Forms.TextBox codicePrimaStampoDimaTextBox;
        private System.Windows.Forms.TextBox descrizionePrimaStampoDimaTextBox;
        private System.Windows.Forms.TextBox codiceInputTextBox;
        private System.Windows.Forms.TextBox codiceOutputTextBox;
        private System.Windows.Forms.TextBox codice_fornitoreTextBox;
        private System.Windows.Forms.TextBox lavorazioneTextBox;
        private System.Windows.Forms.TextBox percentualeLastraTextBox;
        private System.Windows.Forms.TextBox lottoMinimoRiordinoTextBox;
        private System.Windows.Forms.TextBox macPredefStampoTextBox;
        private System.Windows.Forms.TextBox macPredefTaglioTextBox;
        private System.Windows.Forms.TextBox costoBaseTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label codicePrimaStampoDimaLabel;
    }
}