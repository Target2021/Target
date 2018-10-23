namespace Target2021
{
    partial class CaricoScarico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaricoScarico));
            System.Windows.Forms.Label idMovimentoLabel;
            System.Windows.Forms.Label idMagazzinoLabel;
            System.Windows.Forms.Label idPrimeLabel;
            System.Windows.Forms.Label idStampiLabel;
            System.Windows.Forms.Label idDimeLabel;
            System.Windows.Forms.Label idSemilavoratiLabel;
            System.Windows.Forms.Label idArticoliLabel;
            System.Windows.Forms.Label carScarLabel;
            System.Windows.Forms.Label quantitaLabel;
            System.Windows.Forms.Label barcodeLabel;
            System.Windows.Forms.Label nrOrdineLabel;
            System.Windows.Forms.Label dataOraMovimentoLabel;
            System.Windows.Forms.Label pesoMateriaPrimaLabel;
            System.Windows.Forms.Label prezzoComplessivoMateriaPrimaLabel;
            this.target2021DataSet = new Target2021.Target2021DataSet();
            this.movimentiMagazzinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movimentiMagazzinoTableAdapter = new Target2021.Target2021DataSetTableAdapters.MovimentiMagazzinoTableAdapter();
            this.tableAdapterManager = new Target2021.Target2021DataSetTableAdapters.TableAdapterManager();
            this.movimentiMagazzinoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.movimentiMagazzinoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idMovimentoTextBox = new System.Windows.Forms.TextBox();
            this.idMagazzinoTextBox = new System.Windows.Forms.TextBox();
            this.idPrimeTextBox = new System.Windows.Forms.TextBox();
            this.idStampiTextBox = new System.Windows.Forms.TextBox();
            this.idDimeTextBox = new System.Windows.Forms.TextBox();
            this.idSemilavoratiTextBox = new System.Windows.Forms.TextBox();
            this.idArticoliTextBox = new System.Windows.Forms.TextBox();
            this.carScarTextBox = new System.Windows.Forms.TextBox();
            this.quantitaTextBox = new System.Windows.Forms.TextBox();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.nrOrdineTextBox = new System.Windows.Forms.TextBox();
            this.dataOraMovimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pesoMateriaPrimaTextBox = new System.Windows.Forms.TextBox();
            this.prezzoComplessivoMateriaPrimaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            idMovimentoLabel = new System.Windows.Forms.Label();
            idMagazzinoLabel = new System.Windows.Forms.Label();
            idPrimeLabel = new System.Windows.Forms.Label();
            idStampiLabel = new System.Windows.Forms.Label();
            idDimeLabel = new System.Windows.Forms.Label();
            idSemilavoratiLabel = new System.Windows.Forms.Label();
            idArticoliLabel = new System.Windows.Forms.Label();
            carScarLabel = new System.Windows.Forms.Label();
            quantitaLabel = new System.Windows.Forms.Label();
            barcodeLabel = new System.Windows.Forms.Label();
            nrOrdineLabel = new System.Windows.Forms.Label();
            dataOraMovimentoLabel = new System.Windows.Forms.Label();
            pesoMateriaPrimaLabel = new System.Windows.Forms.Label();
            prezzoComplessivoMateriaPrimaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentiMagazzinoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentiMagazzinoBindingNavigator)).BeginInit();
            this.movimentiMagazzinoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // target2021DataSet
            // 
            this.target2021DataSet.DataSetName = "Target2021DataSet";
            this.target2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movimentiMagazzinoBindingSource
            // 
            this.movimentiMagazzinoBindingSource.DataMember = "MovimentiMagazzino";
            this.movimentiMagazzinoBindingSource.DataSource = this.target2021DataSet;
            // 
            // movimentiMagazzinoTableAdapter
            // 
            this.movimentiMagazzinoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AbbinamentiArticoliTableAdapter = null;
            this.tableAdapterManager.AnaMagazziniTableAdapter = null;
            this.tableAdapterManager.ArtFornTableAdapter = null;
            this.tableAdapterManager.articoli_sempliciTableAdapter = null;
            this.tableAdapterManager.ArticoliBCTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientiTableAdapter = null;
            this.tableAdapterManager.CodModPagamentoTableAdapter = null;
            this.tableAdapterManager.CodSpedizioniTableAdapter = null;
            this.tableAdapterManager.CodTermPagamentoTableAdapter = null;
            this.tableAdapterManager.CommesseTableAdapter = null;
            this.tableAdapterManager.CompatibStampaTableAdapter = null;
            this.tableAdapterManager.CompatibTaglioTableAdapter = null;
            this.tableAdapterManager.ConfigurazioneTableAdapter = null;
            this.tableAdapterManager.dettaglio_ordini_acquistoTableAdapter = null;
            this.tableAdapterManager.dettaglio_ordini_multirigaTableAdapter = null;
            this.tableAdapterManager.DettArticoliTableAdapter = null;
            this.tableAdapterManager.dimensioniTableAdapter = null;
            this.tableAdapterManager.DimeTableAdapter = null;
            this.tableAdapterManager.FasiTableAdapter = null;
            this.tableAdapterManager.FornitoriTableAdapter = null;
            this.tableAdapterManager.GiacenzeMagazziniTableAdapter = null;
            this.tableAdapterManager.LavorazioniTableAdapter = null;
            this.tableAdapterManager.LivelliUtenzaTableAdapter = null;
            this.tableAdapterManager.MacchineStampoTableAdapter = null;
            this.tableAdapterManager.MacchineTaglioTableAdapter = null;
            this.tableAdapterManager.MinuterieTableAdapter = null;
            this.tableAdapterManager.MovimentiMagazzinoTableAdapter = this.movimentiMagazzinoTableAdapter;
            this.tableAdapterManager.OrdFornDettTableAdapter = null;
            this.tableAdapterManager.OrdFornTestTableAdapter = null;
            this.tableAdapterManager.PesiSpecificiTableAdapter = null;
            this.tableAdapterManager.PosizioniDimeStampiTableAdapter = null;
            this.tableAdapterManager.PrimeTableAdapter = null;
            this.tableAdapterManager.StampiDimeTableAdapter = null;
            this.tableAdapterManager.StampiTableAdapter = null;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.TaglioOnLineTableAdapter = null;
            this.tableAdapterManager.testata_ordini_multirigaTableAdapter = null;
            this.tableAdapterManager.TipoCommessaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Target2021.Target2021DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtentiTableAdapter = null;
            // 
            // movimentiMagazzinoBindingNavigator
            // 
            this.movimentiMagazzinoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.movimentiMagazzinoBindingNavigator.BindingSource = this.movimentiMagazzinoBindingSource;
            this.movimentiMagazzinoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.movimentiMagazzinoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.movimentiMagazzinoBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.movimentiMagazzinoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.movimentiMagazzinoBindingNavigatorSaveItem});
            this.movimentiMagazzinoBindingNavigator.Location = new System.Drawing.Point(0, 340);
            this.movimentiMagazzinoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.movimentiMagazzinoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.movimentiMagazzinoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.movimentiMagazzinoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.movimentiMagazzinoBindingNavigator.Name = "movimentiMagazzinoBindingNavigator";
            this.movimentiMagazzinoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.movimentiMagazzinoBindingNavigator.Size = new System.Drawing.Size(855, 25);
            this.movimentiMagazzinoBindingNavigator.TabIndex = 0;
            this.movimentiMagazzinoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Sposta in prima posizione";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Sposta indietro";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posizione";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posizione corrente";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 15);
            this.bindingNavigatorCountItem.Text = "di {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Numero totale di elementi";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Sposta avanti";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Sposta in ultima posizione";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Aggiungi nuovo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Elimina";
            // 
            // movimentiMagazzinoBindingNavigatorSaveItem
            // 
            this.movimentiMagazzinoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.movimentiMagazzinoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("movimentiMagazzinoBindingNavigatorSaveItem.Image")));
            this.movimentiMagazzinoBindingNavigatorSaveItem.Name = "movimentiMagazzinoBindingNavigatorSaveItem";
            this.movimentiMagazzinoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.movimentiMagazzinoBindingNavigatorSaveItem.Text = "Salva dati";
            this.movimentiMagazzinoBindingNavigatorSaveItem.Click += new System.EventHandler(this.movimentiMagazzinoBindingNavigatorSaveItem_Click);
            // 
            // idMovimentoLabel
            // 
            idMovimentoLabel.AutoSize = true;
            idMovimentoLabel.Location = new System.Drawing.Point(12, 56);
            idMovimentoLabel.Name = "idMovimentoLabel";
            idMovimentoLabel.Size = new System.Drawing.Size(73, 13);
            idMovimentoLabel.TabIndex = 1;
            idMovimentoLabel.Text = "id Movimento:";
            // 
            // idMovimentoTextBox
            // 
            this.idMovimentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movimentiMagazzinoBindingSource, "idMovimento", true));
            this.idMovimentoTextBox.Location = new System.Drawing.Point(189, 53);
            this.idMovimentoTextBox.Name = "idMovimentoTextBox";
            this.idMovimentoTextBox.Size = new System.Drawing.Size(200, 20);
            this.idMovimentoTextBox.TabIndex = 2;
            // 
            // idMagazzinoLabel
            // 
            idMagazzinoLabel.AutoSize = true;
            idMagazzinoLabel.Location = new System.Drawing.Point(12, 82);
            idMagazzinoLabel.Name = "idMagazzinoLabel";
            idMagazzinoLabel.Size = new System.Drawing.Size(72, 13);
            idMagazzinoLabel.TabIndex = 3;
            idMagazzinoLabel.Text = "id Magazzino:";
            // 
            // idMagazzinoTextBox
            // 
            this.idMagazzinoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movimentiMagazzinoBindingSource, "idMagazzino", true));
            this.idMagazzinoTextBox.Location = new System.Drawing.Point(189, 79);
            this.idMagazzinoTextBox.Name = "idMagazzinoTextBox";
            this.idMagazzinoTextBox.Size = new System.Drawing.Size(200, 20);
            this.idMagazzinoTextBox.TabIndex = 4;
            // 
            // idPrimeLabel
            // 
            idPrimeLabel.AutoSize = true;
            idPrimeLabel.Location = new System.Drawing.Point(12, 108);
            idPrimeLabel.Name = "idPrimeLabel";
            idPrimeLabel.Size = new System.Drawing.Size(47, 13);
            idPrimeLabel.TabIndex = 5;
            idPrimeLabel.Text = "id Prime:";
            // 
            // idPrimeTextBox
            // 
            this.idPrimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movimentiMagazzinoBindingSource, "idPrime", true));
            this.idPrimeTextBox.Location = new System.Drawing.Point(189, 105);
            this.idPrimeTextBox.Name = "idPrimeTextBox";
            this.idPrimeTextBox.Size = new System.Drawing.Size(200, 20);
            this.idPrimeTextBox.TabIndex = 6;
            // 
            // idStampiLabel
            // 
            idStampiLabel.AutoSize = true;
            idStampiLabel.Location = new System.Drawing.Point(12, 134);
            idStampiLabel.Name = "idStampiLabel";
            idStampiLabel.Size = new System.Drawing.Size(53, 13);
            idStampiLabel.TabIndex = 7;
            idStampiLabel.Text = "id Stampi:";
            // 
            // idStampiTextBox
            // 
            this.idStampiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movimentiMagazzinoBindingSource, "idStampi", true));
            this.idStampiTextBox.Location = new System.Drawing.Point(189, 131);
            this.idStampiTextBox.Name = "idStampiTextBox";
            this.idStampiTextBox.Size = new System.Drawing.Size(200, 20);
            this.idStampiTextBox.TabIndex = 8;
            // 
            // idDimeLabel
            // 
            idDimeLabel.AutoSize = true;
            idDimeLabel.Location = new System.Drawing.Point(12, 160);
            idDimeLabel.Name = "idDimeLabel";
            idDimeLabel.Size = new System.Drawing.Size(45, 13);
            idDimeLabel.TabIndex = 9;
            idDimeLabel.Text = "id Dime:";
            // 
            // idDimeTextBox
            // 
            this.idDimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movimentiMagazzinoBindingSource, "idDime", true));
            this.idDimeTextBox.Location = new System.Drawing.Point(189, 157);
            this.idDimeTextBox.Name = "idDimeTextBox";
            this.idDimeTextBox.Size = new System.Drawing.Size(200, 20);
            this.idDimeTextBox.TabIndex = 10;
            // 
            // idSemilavoratiLabel
            // 
            idSemilavoratiLabel.AutoSize = true;
            idSemilavoratiLabel.Location = new System.Drawing.Point(12, 186);
            idSemilavoratiLabel.Name = "idSemilavoratiLabel";
            idSemilavoratiLabel.Size = new System.Drawing.Size(78, 13);
            idSemilavoratiLabel.TabIndex = 11;
            idSemilavoratiLabel.Text = "id Semilavorati:";
            // 
            // idSemilavoratiTextBox
            // 
            this.idSemilavoratiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movimentiMagazzinoBindingSource, "idSemilavorati", true));
            this.idSemilavoratiTextBox.Location = new System.Drawing.Point(189, 183);
            this.idSemilavoratiTextBox.Name = "idSemilavoratiTextBox";
            this.idSemilavoratiTextBox.Size = new System.Drawing.Size(200, 20);
            this.idSemilavoratiTextBox.TabIndex = 12;
            // 
            // idArticoliLabel
            // 
            idArticoliLabel.AutoSize = true;
            idArticoliLabel.Location = new System.Drawing.Point(12, 212);
            idArticoliLabel.Name = "idArticoliLabel";
            idArticoliLabel.Size = new System.Drawing.Size(52, 13);
            idArticoliLabel.TabIndex = 13;
            idArticoliLabel.Text = "id Articoli:";
            // 
            // idArticoliTextBox
            // 
            this.idArticoliTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movimentiMagazzinoBindingSource, "idArticoli", true));
            this.idArticoliTextBox.Location = new System.Drawing.Point(189, 209);
            this.idArticoliTextBox.Name = "idArticoliTextBox";
            this.idArticoliTextBox.Size = new System.Drawing.Size(200, 20);
            this.idArticoliTextBox.TabIndex = 14;
            // 
            // carScarLabel
            // 
            carScarLabel.AutoSize = true;
            carScarLabel.Location = new System.Drawing.Point(441, 56);
            carScarLabel.Name = "carScarLabel";
            carScarLabel.Size = new System.Drawing.Size(51, 13);
            carScarLabel.TabIndex = 15;
            carScarLabel.Text = "Car Scar:";
            // 
            // carScarTextBox
            // 
            this.carScarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movimentiMagazzinoBindingSource, "CarScar", true));
            this.carScarTextBox.Location = new System.Drawing.Point(618, 53);
            this.carScarTextBox.Name = "carScarTextBox";
            this.carScarTextBox.Size = new System.Drawing.Size(200, 20);
            this.carScarTextBox.TabIndex = 16;
            // 
            // quantitaLabel
            // 
            quantitaLabel.AutoSize = true;
            quantitaLabel.Location = new System.Drawing.Point(441, 82);
            quantitaLabel.Name = "quantitaLabel";
            quantitaLabel.Size = new System.Drawing.Size(50, 13);
            quantitaLabel.TabIndex = 17;
            quantitaLabel.Text = "Quantita:";
            // 
            // quantitaTextBox
            // 
            this.quantitaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movimentiMagazzinoBindingSource, "Quantita", true));
            this.quantitaTextBox.Location = new System.Drawing.Point(618, 79);
            this.quantitaTextBox.Name = "quantitaTextBox";
            this.quantitaTextBox.Size = new System.Drawing.Size(200, 20);
            this.quantitaTextBox.TabIndex = 18;
            // 
            // barcodeLabel
            // 
            barcodeLabel.AutoSize = true;
            barcodeLabel.Location = new System.Drawing.Point(441, 108);
            barcodeLabel.Name = "barcodeLabel";
            barcodeLabel.Size = new System.Drawing.Size(50, 13);
            barcodeLabel.TabIndex = 19;
            barcodeLabel.Text = "Barcode:";
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movimentiMagazzinoBindingSource, "Barcode", true));
            this.barcodeTextBox.Location = new System.Drawing.Point(618, 105);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.barcodeTextBox.TabIndex = 20;
            // 
            // nrOrdineLabel
            // 
            nrOrdineLabel.AutoSize = true;
            nrOrdineLabel.Location = new System.Drawing.Point(441, 134);
            nrOrdineLabel.Name = "nrOrdineLabel";
            nrOrdineLabel.Size = new System.Drawing.Size(55, 13);
            nrOrdineLabel.TabIndex = 21;
            nrOrdineLabel.Text = "Nr Ordine:";
            // 
            // nrOrdineTextBox
            // 
            this.nrOrdineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movimentiMagazzinoBindingSource, "NrOrdine", true));
            this.nrOrdineTextBox.Location = new System.Drawing.Point(618, 131);
            this.nrOrdineTextBox.Name = "nrOrdineTextBox";
            this.nrOrdineTextBox.Size = new System.Drawing.Size(200, 20);
            this.nrOrdineTextBox.TabIndex = 22;
            // 
            // dataOraMovimentoLabel
            // 
            dataOraMovimentoLabel.AutoSize = true;
            dataOraMovimentoLabel.Location = new System.Drawing.Point(441, 161);
            dataOraMovimentoLabel.Name = "dataOraMovimentoLabel";
            dataOraMovimentoLabel.Size = new System.Drawing.Size(108, 13);
            dataOraMovimentoLabel.TabIndex = 23;
            dataOraMovimentoLabel.Text = "Data Ora Movimento:";
            // 
            // dataOraMovimentoDateTimePicker
            // 
            this.dataOraMovimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.movimentiMagazzinoBindingSource, "DataOraMovimento", true));
            this.dataOraMovimentoDateTimePicker.Location = new System.Drawing.Point(618, 157);
            this.dataOraMovimentoDateTimePicker.Name = "dataOraMovimentoDateTimePicker";
            this.dataOraMovimentoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataOraMovimentoDateTimePicker.TabIndex = 24;
            // 
            // pesoMateriaPrimaLabel
            // 
            pesoMateriaPrimaLabel.AutoSize = true;
            pesoMateriaPrimaLabel.Location = new System.Drawing.Point(441, 186);
            pesoMateriaPrimaLabel.Name = "pesoMateriaPrimaLabel";
            pesoMateriaPrimaLabel.Size = new System.Drawing.Size(101, 13);
            pesoMateriaPrimaLabel.TabIndex = 25;
            pesoMateriaPrimaLabel.Text = "Peso Materia Prima:";
            // 
            // pesoMateriaPrimaTextBox
            // 
            this.pesoMateriaPrimaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movimentiMagazzinoBindingSource, "PesoMateriaPrima", true));
            this.pesoMateriaPrimaTextBox.Location = new System.Drawing.Point(618, 183);
            this.pesoMateriaPrimaTextBox.Name = "pesoMateriaPrimaTextBox";
            this.pesoMateriaPrimaTextBox.Size = new System.Drawing.Size(200, 20);
            this.pesoMateriaPrimaTextBox.TabIndex = 26;
            // 
            // prezzoComplessivoMateriaPrimaLabel
            // 
            prezzoComplessivoMateriaPrimaLabel.AutoSize = true;
            prezzoComplessivoMateriaPrimaLabel.Location = new System.Drawing.Point(441, 212);
            prezzoComplessivoMateriaPrimaLabel.Name = "prezzoComplessivoMateriaPrimaLabel";
            prezzoComplessivoMateriaPrimaLabel.Size = new System.Drawing.Size(171, 13);
            prezzoComplessivoMateriaPrimaLabel.TabIndex = 27;
            prezzoComplessivoMateriaPrimaLabel.Text = "Prezzo Complessivo Materia Prima:";
            // 
            // prezzoComplessivoMateriaPrimaTextBox
            // 
            this.prezzoComplessivoMateriaPrimaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movimentiMagazzinoBindingSource, "PrezzoComplessivoMateriaPrima", true));
            this.prezzoComplessivoMateriaPrimaTextBox.Location = new System.Drawing.Point(618, 209);
            this.prezzoComplessivoMateriaPrimaTextBox.Name = "prezzoComplessivoMateriaPrimaTextBox";
            this.prezzoComplessivoMateriaPrimaTextBox.Size = new System.Drawing.Size(200, 20);
            this.prezzoComplessivoMateriaPrimaTextBox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 26);
            this.label1.TabIndex = 29;
            this.label1.Text = "Carico/Scarico manuale di magazzino";
            // 
            // CaricoScarico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 365);
            this.Controls.Add(this.label1);
            this.Controls.Add(idMovimentoLabel);
            this.Controls.Add(this.idMovimentoTextBox);
            this.Controls.Add(idMagazzinoLabel);
            this.Controls.Add(this.idMagazzinoTextBox);
            this.Controls.Add(idPrimeLabel);
            this.Controls.Add(this.idPrimeTextBox);
            this.Controls.Add(idStampiLabel);
            this.Controls.Add(this.idStampiTextBox);
            this.Controls.Add(idDimeLabel);
            this.Controls.Add(this.idDimeTextBox);
            this.Controls.Add(idSemilavoratiLabel);
            this.Controls.Add(this.idSemilavoratiTextBox);
            this.Controls.Add(idArticoliLabel);
            this.Controls.Add(this.idArticoliTextBox);
            this.Controls.Add(carScarLabel);
            this.Controls.Add(this.carScarTextBox);
            this.Controls.Add(quantitaLabel);
            this.Controls.Add(this.quantitaTextBox);
            this.Controls.Add(barcodeLabel);
            this.Controls.Add(this.barcodeTextBox);
            this.Controls.Add(nrOrdineLabel);
            this.Controls.Add(this.nrOrdineTextBox);
            this.Controls.Add(dataOraMovimentoLabel);
            this.Controls.Add(this.dataOraMovimentoDateTimePicker);
            this.Controls.Add(pesoMateriaPrimaLabel);
            this.Controls.Add(this.pesoMateriaPrimaTextBox);
            this.Controls.Add(prezzoComplessivoMateriaPrimaLabel);
            this.Controls.Add(this.prezzoComplessivoMateriaPrimaTextBox);
            this.Controls.Add(this.movimentiMagazzinoBindingNavigator);
            this.Name = "CaricoScarico";
            this.Text = "Carico/Scarico di magazzino";
            this.Load += new System.EventHandler(this.CaricoScarico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentiMagazzinoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentiMagazzinoBindingNavigator)).EndInit();
            this.movimentiMagazzinoBindingNavigator.ResumeLayout(false);
            this.movimentiMagazzinoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Target2021DataSet target2021DataSet;
        private System.Windows.Forms.BindingSource movimentiMagazzinoBindingSource;
        private Target2021DataSetTableAdapters.MovimentiMagazzinoTableAdapter movimentiMagazzinoTableAdapter;
        private Target2021DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator movimentiMagazzinoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton movimentiMagazzinoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idMovimentoTextBox;
        private System.Windows.Forms.TextBox idMagazzinoTextBox;
        private System.Windows.Forms.TextBox idPrimeTextBox;
        private System.Windows.Forms.TextBox idStampiTextBox;
        private System.Windows.Forms.TextBox idDimeTextBox;
        private System.Windows.Forms.TextBox idSemilavoratiTextBox;
        private System.Windows.Forms.TextBox idArticoliTextBox;
        private System.Windows.Forms.TextBox carScarTextBox;
        private System.Windows.Forms.TextBox quantitaTextBox;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.TextBox nrOrdineTextBox;
        private System.Windows.Forms.DateTimePicker dataOraMovimentoDateTimePicker;
        private System.Windows.Forms.TextBox pesoMateriaPrimaTextBox;
        private System.Windows.Forms.TextBox prezzoComplessivoMateriaPrimaTextBox;
        private System.Windows.Forms.Label label1;
    }
}