﻿namespace Target2021
{
    partial class LavoraStampaggio
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
            System.Windows.Forms.Label iDCommessaLabel;
            System.Windows.Forms.Label codCommessaLabel;
            System.Windows.Forms.Label nrCommessaLabel;
            System.Windows.Forms.Label dataCommessaLabel;
            System.Windows.Forms.Label iDClienteLabel;
            System.Windows.Forms.Label dataConsegnaLabel;
            System.Windows.Forms.Label nrPezziDaLavorareLabel;
            System.Windows.Forms.Label codArticoloLabel;
            System.Windows.Forms.Label descrArticoloLabel;
            System.Windows.Forms.Label iDStampoLabel;
            System.Windows.Forms.Label codArtiDopoStampoLabel;
            System.Windows.Forms.Label nrPezziOrdinatiLabel;
            System.Windows.Forms.Label dataTermineLabel;
            System.Windows.Forms.Label nrPezziCorrettiLabel;
            System.Windows.Forms.Label nrPezziScartatiLabel;
            System.Windows.Forms.Label oraInizioStampoLabel;
            System.Windows.Forms.Label oraFineStampoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LavoraStampaggio));
            this.label1 = new System.Windows.Forms.Label();
            this.target2021DataSet = new Target2021.Target2021DataSet();
            this.commesseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commesseTableAdapter = new Target2021.Target2021DataSetTableAdapters.CommesseTableAdapter();
            this.tableAdapterManager = new Target2021.Target2021DataSetTableAdapters.TableAdapterManager();
            this.commesseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.commesseBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDCommessaTextBox = new System.Windows.Forms.TextBox();
            this.codCommessaTextBox = new System.Windows.Forms.TextBox();
            this.nrCommessaTextBox = new System.Windows.Forms.TextBox();
            this.iDClienteTextBox = new System.Windows.Forms.TextBox();
            this.nrPezziDaLavorareTextBox = new System.Windows.Forms.TextBox();
            this.codArticoloTextBox = new System.Windows.Forms.TextBox();
            this.descrArticoloTextBox = new System.Windows.Forms.TextBox();
            this.iDStampoTextBox = new System.Windows.Forms.TextBox();
            this.codArtiDopoStampoTextBox = new System.Windows.Forms.TextBox();
            this.nrPezziOrdinatiTextBox = new System.Windows.Forms.TextBox();
            this.nrPezziCorrettiTextBox = new System.Windows.Forms.TextBox();
            this.nrPezziScartatiTextBox = new System.Windows.Forms.TextBox();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.cCToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.cCToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            iDCommessaLabel = new System.Windows.Forms.Label();
            codCommessaLabel = new System.Windows.Forms.Label();
            nrCommessaLabel = new System.Windows.Forms.Label();
            dataCommessaLabel = new System.Windows.Forms.Label();
            iDClienteLabel = new System.Windows.Forms.Label();
            dataConsegnaLabel = new System.Windows.Forms.Label();
            nrPezziDaLavorareLabel = new System.Windows.Forms.Label();
            codArticoloLabel = new System.Windows.Forms.Label();
            descrArticoloLabel = new System.Windows.Forms.Label();
            iDStampoLabel = new System.Windows.Forms.Label();
            codArtiDopoStampoLabel = new System.Windows.Forms.Label();
            nrPezziOrdinatiLabel = new System.Windows.Forms.Label();
            dataTermineLabel = new System.Windows.Forms.Label();
            nrPezziCorrettiLabel = new System.Windows.Forms.Label();
            nrPezziScartatiLabel = new System.Windows.Forms.Label();
            oraInizioStampoLabel = new System.Windows.Forms.Label();
            oraFineStampoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commesseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commesseBindingNavigator)).BeginInit();
            this.commesseBindingNavigator.SuspendLayout();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDCommessaLabel
            // 
            iDCommessaLabel.AutoSize = true;
            iDCommessaLabel.Location = new System.Drawing.Point(83, 135);
            iDCommessaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iDCommessaLabel.Name = "iDCommessaLabel";
            iDCommessaLabel.Size = new System.Drawing.Size(94, 17);
            iDCommessaLabel.TabIndex = 2;
            iDCommessaLabel.Text = "IDCommessa:";
            // 
            // codCommessaLabel
            // 
            codCommessaLabel.AutoSize = true;
            codCommessaLabel.Location = new System.Drawing.Point(68, 167);
            codCommessaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codCommessaLabel.Name = "codCommessaLabel";
            codCommessaLabel.Size = new System.Drawing.Size(110, 17);
            codCommessaLabel.TabIndex = 4;
            codCommessaLabel.Text = "Cod Commessa:";
            // 
            // nrCommessaLabel
            // 
            nrCommessaLabel.AutoSize = true;
            nrCommessaLabel.Location = new System.Drawing.Point(79, 199);
            nrCommessaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nrCommessaLabel.Name = "nrCommessaLabel";
            nrCommessaLabel.Size = new System.Drawing.Size(100, 17);
            nrCommessaLabel.TabIndex = 6;
            nrCommessaLabel.Text = "Nr Commessa:";
            // 
            // dataCommessaLabel
            // 
            dataCommessaLabel.AutoSize = true;
            dataCommessaLabel.Location = new System.Drawing.Point(63, 233);
            dataCommessaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataCommessaLabel.Name = "dataCommessaLabel";
            dataCommessaLabel.Size = new System.Drawing.Size(115, 17);
            dataCommessaLabel.TabIndex = 8;
            dataCommessaLabel.Text = "Data Commessa:";
            // 
            // iDClienteLabel
            // 
            iDClienteLabel.AutoSize = true;
            iDClienteLabel.Location = new System.Drawing.Point(108, 263);
            iDClienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iDClienteLabel.Name = "iDClienteLabel";
            iDClienteLabel.Size = new System.Drawing.Size(68, 17);
            iDClienteLabel.TabIndex = 10;
            iDClienteLabel.Text = "IDCliente:";
            // 
            // dataConsegnaLabel
            // 
            dataConsegnaLabel.AutoSize = true;
            dataConsegnaLabel.Location = new System.Drawing.Point(67, 297);
            dataConsegnaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataConsegnaLabel.Name = "dataConsegnaLabel";
            dataConsegnaLabel.Size = new System.Drawing.Size(110, 17);
            dataConsegnaLabel.TabIndex = 12;
            dataConsegnaLabel.Text = "Data Consegna:";
            // 
            // nrPezziDaLavorareLabel
            // 
            nrPezziDaLavorareLabel.AutoSize = true;
            nrPezziDaLavorareLabel.Location = new System.Drawing.Point(31, 327);
            nrPezziDaLavorareLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nrPezziDaLavorareLabel.Name = "nrPezziDaLavorareLabel";
            nrPezziDaLavorareLabel.Size = new System.Drawing.Size(148, 17);
            nrPezziDaLavorareLabel.TabIndex = 14;
            nrPezziDaLavorareLabel.Text = "Nr Pezzi Da Lavorare:";
            // 
            // codArticoloLabel
            // 
            codArticoloLabel.AutoSize = true;
            codArticoloLabel.Location = new System.Drawing.Point(89, 391);
            codArticoloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codArticoloLabel.Name = "codArticoloLabel";
            codArticoloLabel.Size = new System.Drawing.Size(88, 17);
            codArticoloLabel.TabIndex = 16;
            codArticoloLabel.Text = "Cod Articolo:";
            // 
            // descrArticoloLabel
            // 
            descrArticoloLabel.AutoSize = true;
            descrArticoloLabel.Location = new System.Drawing.Point(77, 423);
            descrArticoloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descrArticoloLabel.Name = "descrArticoloLabel";
            descrArticoloLabel.Size = new System.Drawing.Size(100, 17);
            descrArticoloLabel.TabIndex = 18;
            descrArticoloLabel.Text = "Descr Articolo:";
            // 
            // iDStampoLabel
            // 
            iDStampoLabel.AutoSize = true;
            iDStampoLabel.Location = new System.Drawing.Point(552, 135);
            iDStampoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iDStampoLabel.Name = "iDStampoLabel";
            iDStampoLabel.Size = new System.Drawing.Size(73, 17);
            iDStampoLabel.TabIndex = 20;
            iDStampoLabel.Text = "IDStampo:";
            // 
            // codArtiDopoStampoLabel
            // 
            codArtiDopoStampoLabel.AutoSize = true;
            codArtiDopoStampoLabel.Location = new System.Drawing.Point(475, 167);
            codArtiDopoStampoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codArtiDopoStampoLabel.Name = "codArtiDopoStampoLabel";
            codArtiDopoStampoLabel.Size = new System.Drawing.Size(152, 17);
            codArtiDopoStampoLabel.TabIndex = 22;
            codArtiDopoStampoLabel.Text = "Cod Arti Dopo Stampo:";
            // 
            // nrPezziOrdinatiLabel
            // 
            nrPezziOrdinatiLabel.AutoSize = true;
            nrPezziOrdinatiLabel.Location = new System.Drawing.Point(61, 359);
            nrPezziOrdinatiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nrPezziOrdinatiLabel.Name = "nrPezziOrdinatiLabel";
            nrPezziOrdinatiLabel.Size = new System.Drawing.Size(119, 17);
            nrPezziOrdinatiLabel.TabIndex = 24;
            nrPezziOrdinatiLabel.Text = "Nr Pezzi Ordinati:";
            // 
            // dataTermineLabel
            // 
            dataTermineLabel.AutoSize = true;
            dataTermineLabel.Location = new System.Drawing.Point(529, 201);
            dataTermineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataTermineLabel.Name = "dataTermineLabel";
            dataTermineLabel.Size = new System.Drawing.Size(98, 17);
            dataTermineLabel.TabIndex = 26;
            dataTermineLabel.Text = "Data Termine:";
            // 
            // nrPezziCorrettiLabel
            // 
            nrPezziCorrettiLabel.AutoSize = true;
            nrPezziCorrettiLabel.Location = new System.Drawing.Point(515, 233);
            nrPezziCorrettiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nrPezziCorrettiLabel.Name = "nrPezziCorrettiLabel";
            nrPezziCorrettiLabel.Size = new System.Drawing.Size(115, 17);
            nrPezziCorrettiLabel.TabIndex = 28;
            nrPezziCorrettiLabel.Text = "Nr Pezzi Corretti:";
            // 
            // nrPezziScartatiLabel
            // 
            nrPezziScartatiLabel.AutoSize = true;
            nrPezziScartatiLabel.Location = new System.Drawing.Point(511, 263);
            nrPezziScartatiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nrPezziScartatiLabel.Name = "nrPezziScartatiLabel";
            nrPezziScartatiLabel.Size = new System.Drawing.Size(117, 17);
            nrPezziScartatiLabel.TabIndex = 30;
            nrPezziScartatiLabel.Text = "Nr Pezzi Scartati:";
            // 
            // oraInizioStampoLabel
            // 
            oraInizioStampoLabel.AutoSize = true;
            oraInizioStampoLabel.Location = new System.Drawing.Point(504, 297);
            oraInizioStampoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            oraInizioStampoLabel.Name = "oraInizioStampoLabel";
            oraInizioStampoLabel.Size = new System.Drawing.Size(124, 17);
            oraInizioStampoLabel.TabIndex = 32;
            oraInizioStampoLabel.Text = "Ora Inizio Stampo:";
            // 
            // oraFineStampoLabel
            // 
            oraFineStampoLabel.AutoSize = true;
            oraFineStampoLabel.Location = new System.Drawing.Point(509, 329);
            oraFineStampoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            oraFineStampoLabel.Name = "oraFineStampoLabel";
            oraFineStampoLabel.Size = new System.Drawing.Size(119, 17);
            oraFineStampoLabel.TabIndex = 34;
            oraFineStampoLabel.Text = "Ora Fine Stampo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "STAMPAGGIO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // target2021DataSet
            // 
            this.target2021DataSet.DataSetName = "Target2021DataSet";
            this.target2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commesseBindingSource
            // 
            this.commesseBindingSource.DataMember = "Commesse";
            this.commesseBindingSource.DataSource = this.target2021DataSet;
            // 
            // commesseTableAdapter
            // 
            this.commesseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnaMagazziniTableAdapter = null;
            this.tableAdapterManager.articoli_sempliciTableAdapter = null;
            this.tableAdapterManager.ArticoliBCTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientiTableAdapter = null;
            this.tableAdapterManager.CommesseTableAdapter = this.commesseTableAdapter;
            this.tableAdapterManager.CompatibStampaTableAdapter = null;
            this.tableAdapterManager.CompatibTaglioTableAdapter = null;
            this.tableAdapterManager.ConfigurazioneTableAdapter = null;
            this.tableAdapterManager.dettaglio_ordini_multirigaTableAdapter = null;
            this.tableAdapterManager.DettArticoliTableAdapter = null;
            this.tableAdapterManager.DimeTableAdapter = null;
            this.tableAdapterManager.FasiTableAdapter = null;
            this.tableAdapterManager.FornitoriTableAdapter = null;
            this.tableAdapterManager.GiacenzeMagazziniTableAdapter = null;
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
            // commesseBindingNavigator
            // 
            this.commesseBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.commesseBindingNavigator.BindingSource = this.commesseBindingSource;
            this.commesseBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.commesseBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.commesseBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.commesseBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.commesseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.commesseBindingNavigatorSaveItem});
            this.commesseBindingNavigator.Location = new System.Drawing.Point(0, 615);
            this.commesseBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.commesseBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.commesseBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.commesseBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.commesseBindingNavigator.Name = "commesseBindingNavigator";
            this.commesseBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.commesseBindingNavigator.Size = new System.Drawing.Size(1371, 27);
            this.commesseBindingNavigator.TabIndex = 1;
            this.commesseBindingNavigator.Text = "bindingNavigator1";
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
            // commesseBindingNavigatorSaveItem
            // 
            this.commesseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.commesseBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("commesseBindingNavigatorSaveItem.Image")));
            this.commesseBindingNavigatorSaveItem.Name = "commesseBindingNavigatorSaveItem";
            this.commesseBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.commesseBindingNavigatorSaveItem.Text = "Salva dati";
            this.commesseBindingNavigatorSaveItem.Click += new System.EventHandler(this.commesseBindingNavigatorSaveItem_Click_1);
            // 
            // iDCommessaTextBox
            // 
            this.iDCommessaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commesseBindingSource, "IDCommessa", true));
            this.iDCommessaTextBox.Location = new System.Drawing.Point(187, 132);
            this.iDCommessaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.iDCommessaTextBox.Name = "iDCommessaTextBox";
            this.iDCommessaTextBox.Size = new System.Drawing.Size(132, 22);
            this.iDCommessaTextBox.TabIndex = 3;
            // 
            // codCommessaTextBox
            // 
            this.codCommessaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commesseBindingSource, "CodCommessa", true));
            this.codCommessaTextBox.Location = new System.Drawing.Point(187, 164);
            this.codCommessaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.codCommessaTextBox.Name = "codCommessaTextBox";
            this.codCommessaTextBox.Size = new System.Drawing.Size(132, 22);
            this.codCommessaTextBox.TabIndex = 5;
            // 
            // nrCommessaTextBox
            // 
            this.nrCommessaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commesseBindingSource, "NrCommessa", true));
            this.nrCommessaTextBox.Location = new System.Drawing.Point(187, 196);
            this.nrCommessaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nrCommessaTextBox.Name = "nrCommessaTextBox";
            this.nrCommessaTextBox.Size = new System.Drawing.Size(132, 22);
            this.nrCommessaTextBox.TabIndex = 7;
            // 
            // iDClienteTextBox
            // 
            this.iDClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commesseBindingSource, "IDCliente", true));
            this.iDClienteTextBox.Location = new System.Drawing.Point(187, 260);
            this.iDClienteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.iDClienteTextBox.Name = "iDClienteTextBox";
            this.iDClienteTextBox.Size = new System.Drawing.Size(132, 22);
            this.iDClienteTextBox.TabIndex = 11;
            // 
            // nrPezziDaLavorareTextBox
            // 
            this.nrPezziDaLavorareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commesseBindingSource, "NrPezziDaLavorare", true));
            this.nrPezziDaLavorareTextBox.Location = new System.Drawing.Point(187, 324);
            this.nrPezziDaLavorareTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nrPezziDaLavorareTextBox.Name = "nrPezziDaLavorareTextBox";
            this.nrPezziDaLavorareTextBox.Size = new System.Drawing.Size(132, 22);
            this.nrPezziDaLavorareTextBox.TabIndex = 15;
            // 
            // codArticoloTextBox
            // 
            this.codArticoloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commesseBindingSource, "CodArticolo", true));
            this.codArticoloTextBox.Location = new System.Drawing.Point(187, 388);
            this.codArticoloTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.codArticoloTextBox.Name = "codArticoloTextBox";
            this.codArticoloTextBox.Size = new System.Drawing.Size(132, 22);
            this.codArticoloTextBox.TabIndex = 17;
            // 
            // descrArticoloTextBox
            // 
            this.descrArticoloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commesseBindingSource, "DescrArticolo", true));
            this.descrArticoloTextBox.Location = new System.Drawing.Point(187, 420);
            this.descrArticoloTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descrArticoloTextBox.Name = "descrArticoloTextBox";
            this.descrArticoloTextBox.Size = new System.Drawing.Size(265, 22);
            this.descrArticoloTextBox.TabIndex = 19;
            // 
            // iDStampoTextBox
            // 
            this.iDStampoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commesseBindingSource, "IDStampo", true));
            this.iDStampoTextBox.Location = new System.Drawing.Point(636, 132);
            this.iDStampoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.iDStampoTextBox.Name = "iDStampoTextBox";
            this.iDStampoTextBox.Size = new System.Drawing.Size(132, 22);
            this.iDStampoTextBox.TabIndex = 21;
            // 
            // codArtiDopoStampoTextBox
            // 
            this.codArtiDopoStampoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commesseBindingSource, "CodArtiDopoStampo", true));
            this.codArtiDopoStampoTextBox.Location = new System.Drawing.Point(636, 164);
            this.codArtiDopoStampoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.codArtiDopoStampoTextBox.Name = "codArtiDopoStampoTextBox";
            this.codArtiDopoStampoTextBox.Size = new System.Drawing.Size(132, 22);
            this.codArtiDopoStampoTextBox.TabIndex = 23;
            // 
            // nrPezziOrdinatiTextBox
            // 
            this.nrPezziOrdinatiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commesseBindingSource, "NrPezziOrdinati", true));
            this.nrPezziOrdinatiTextBox.Location = new System.Drawing.Point(187, 356);
            this.nrPezziOrdinatiTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nrPezziOrdinatiTextBox.Name = "nrPezziOrdinatiTextBox";
            this.nrPezziOrdinatiTextBox.Size = new System.Drawing.Size(132, 22);
            this.nrPezziOrdinatiTextBox.TabIndex = 25;
            // 
            // nrPezziCorrettiTextBox
            // 
            this.nrPezziCorrettiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commesseBindingSource, "NrPezziCorretti", true));
            this.nrPezziCorrettiTextBox.Location = new System.Drawing.Point(636, 229);
            this.nrPezziCorrettiTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nrPezziCorrettiTextBox.Name = "nrPezziCorrettiTextBox";
            this.nrPezziCorrettiTextBox.Size = new System.Drawing.Size(132, 22);
            this.nrPezziCorrettiTextBox.TabIndex = 29;
            // 
            // nrPezziScartatiTextBox
            // 
            this.nrPezziScartatiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commesseBindingSource, "NrPezziScartati", true));
            this.nrPezziScartatiTextBox.Location = new System.Drawing.Point(636, 260);
            this.nrPezziScartatiTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nrPezziScartatiTextBox.Name = "nrPezziScartatiTextBox";
            this.nrPezziScartatiTextBox.Size = new System.Drawing.Size(132, 22);
            this.nrPezziScartatiTextBox.TabIndex = 31;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cCToolStripLabel,
            this.cCToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1371, 27);
            this.fillByToolStrip.TabIndex = 36;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // cCToolStripLabel
            // 
            this.cCToolStripLabel.Name = "cCToolStripLabel";
            this.cCToolStripLabel.Size = new System.Drawing.Size(30, 24);
            this.cCToolStripLabel.Text = "CC:";
            // 
            // cCToolStripTextBox
            // 
            this.cCToolStripTextBox.Name = "cCToolStripTextBox";
            this.cCToolStripTextBox.Size = new System.Drawing.Size(132, 27);
            this.cCToolStripTextBox.TextChanged += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 24);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yy-MM-dd";
            this.dateTimePicker1.Location = new System.Drawing.Point(189, 234);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(263, 22);
            this.dateTimePicker1.TabIndex = 37;
            this.dateTimePicker1.Value = new System.DateTime(2018, 3, 29, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(184, 292);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(263, 22);
            this.dateTimePicker2.TabIndex = 38;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(638, 196);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(263, 22);
            this.dateTimePicker3.TabIndex = 39;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(638, 292);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(263, 22);
            this.dateTimePicker4.TabIndex = 40;
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Location = new System.Drawing.Point(638, 329);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(263, 22);
            this.dateTimePicker5.TabIndex = 41;
            // 
            // LavoraStampaggio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 642);
            this.Controls.Add(this.dateTimePicker5);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(oraFineStampoLabel);
            this.Controls.Add(oraInizioStampoLabel);
            this.Controls.Add(nrPezziScartatiLabel);
            this.Controls.Add(this.nrPezziScartatiTextBox);
            this.Controls.Add(nrPezziCorrettiLabel);
            this.Controls.Add(this.nrPezziCorrettiTextBox);
            this.Controls.Add(dataTermineLabel);
            this.Controls.Add(nrPezziOrdinatiLabel);
            this.Controls.Add(this.nrPezziOrdinatiTextBox);
            this.Controls.Add(codArtiDopoStampoLabel);
            this.Controls.Add(this.codArtiDopoStampoTextBox);
            this.Controls.Add(iDStampoLabel);
            this.Controls.Add(this.iDStampoTextBox);
            this.Controls.Add(descrArticoloLabel);
            this.Controls.Add(this.descrArticoloTextBox);
            this.Controls.Add(codArticoloLabel);
            this.Controls.Add(this.codArticoloTextBox);
            this.Controls.Add(nrPezziDaLavorareLabel);
            this.Controls.Add(this.nrPezziDaLavorareTextBox);
            this.Controls.Add(dataConsegnaLabel);
            this.Controls.Add(iDClienteLabel);
            this.Controls.Add(this.iDClienteTextBox);
            this.Controls.Add(dataCommessaLabel);
            this.Controls.Add(nrCommessaLabel);
            this.Controls.Add(this.nrCommessaTextBox);
            this.Controls.Add(codCommessaLabel);
            this.Controls.Add(this.codCommessaTextBox);
            this.Controls.Add(iDCommessaLabel);
            this.Controls.Add(this.iDCommessaTextBox);
            this.Controls.Add(this.commesseBindingNavigator);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LavoraStampaggio";
            this.Text = "LavoraStampaggio";
            this.Load += new System.EventHandler(this.LavoraStampaggio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commesseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commesseBindingNavigator)).EndInit();
            this.commesseBindingNavigator.ResumeLayout(false);
            this.commesseBindingNavigator.PerformLayout();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Target2021DataSet target2021DataSet;
        private System.Windows.Forms.BindingSource commesseBindingSource;
        private Target2021DataSetTableAdapters.CommesseTableAdapter commesseTableAdapter;
        private Target2021DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator commesseBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton commesseBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDCommessaTextBox;
        private System.Windows.Forms.TextBox codCommessaTextBox;
        private System.Windows.Forms.TextBox nrCommessaTextBox;
        private System.Windows.Forms.TextBox iDClienteTextBox;
        private System.Windows.Forms.TextBox nrPezziDaLavorareTextBox;
        private System.Windows.Forms.TextBox codArticoloTextBox;
        private System.Windows.Forms.TextBox descrArticoloTextBox;
        private System.Windows.Forms.TextBox iDStampoTextBox;
        private System.Windows.Forms.TextBox codArtiDopoStampoTextBox;
        private System.Windows.Forms.TextBox nrPezziOrdinatiTextBox;
        private System.Windows.Forms.TextBox nrPezziCorrettiTextBox;
        private System.Windows.Forms.TextBox nrPezziScartatiTextBox;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel cCToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox cCToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
    }
}