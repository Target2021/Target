namespace Target2021
{
    partial class Contatori
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
            System.Windows.Forms.Label nrUltimoOrdineLettoLabel;
            System.Windows.Forms.Label dataUltimoOrdineLabel;
            System.Windows.Forms.Label nrOrdineFornitoreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contatori));
            this.target2021DataSet = new Target2021.Target2021DataSet();
            this.configurazioneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.configurazioneTableAdapter = new Target2021.Target2021DataSetTableAdapters.ConfigurazioneTableAdapter();
            this.tableAdapterManager = new Target2021.Target2021DataSetTableAdapters.TableAdapterManager();
            this.configurazioneBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.configurazioneBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nrUltimoOrdineLettoTextBox = new System.Windows.Forms.TextBox();
            this.dataUltimoOrdineDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nrOrdineFornitoreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            nrUltimoOrdineLettoLabel = new System.Windows.Forms.Label();
            dataUltimoOrdineLabel = new System.Windows.Forms.Label();
            nrOrdineFornitoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurazioneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurazioneBindingNavigator)).BeginInit();
            this.configurazioneBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nrUltimoOrdineLettoLabel
            // 
            nrUltimoOrdineLettoLabel.AutoSize = true;
            nrUltimoOrdineLettoLabel.Location = new System.Drawing.Point(41, 118);
            nrUltimoOrdineLettoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            nrUltimoOrdineLettoLabel.Name = "nrUltimoOrdineLettoLabel";
            nrUltimoOrdineLettoLabel.Size = new System.Drawing.Size(198, 25);
            nrUltimoOrdineLettoLabel.TabIndex = 1;
            nrUltimoOrdineLettoLabel.Text = "Nr Ultimo Ordine Letto:";
            // 
            // dataUltimoOrdineLabel
            // 
            dataUltimoOrdineLabel.AutoSize = true;
            dataUltimoOrdineLabel.Location = new System.Drawing.Point(69, 170);
            dataUltimoOrdineLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataUltimoOrdineLabel.Name = "dataUltimoOrdineLabel";
            dataUltimoOrdineLabel.Size = new System.Drawing.Size(171, 25);
            dataUltimoOrdineLabel.TabIndex = 3;
            dataUltimoOrdineLabel.Text = "Data Ultimo Ordine:";
            // 
            // nrOrdineFornitoreLabel
            // 
            nrOrdineFornitoreLabel.AutoSize = true;
            nrOrdineFornitoreLabel.Location = new System.Drawing.Point(69, 218);
            nrOrdineFornitoreLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            nrOrdineFornitoreLabel.Name = "nrOrdineFornitoreLabel";
            nrOrdineFornitoreLabel.Size = new System.Drawing.Size(167, 25);
            nrOrdineFornitoreLabel.TabIndex = 5;
            nrOrdineFornitoreLabel.Text = "Nr Ordine Fornitore:";
            // 
            // target2021DataSet
            // 
            this.target2021DataSet.DataSetName = "Target2021DataSet";
            this.target2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // configurazioneBindingSource
            // 
            this.configurazioneBindingSource.DataMember = "Configurazione";
            this.configurazioneBindingSource.DataSource = this.target2021DataSet;
            // 
            // configurazioneTableAdapter
            // 
            this.configurazioneTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ConfigurazioneTableAdapter = this.configurazioneTableAdapter;
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
            this.tableAdapterManager.MinuterieTableAdapter = null;
            this.tableAdapterManager.MovimentiMagazzinoTableAdapter = null;
            this.tableAdapterManager.OrdFornDettTableAdapter = null;
            this.tableAdapterManager.OrdFornTestTableAdapter = null;
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
            // configurazioneBindingNavigator
            // 
            this.configurazioneBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.configurazioneBindingNavigator.BindingSource = this.configurazioneBindingSource;
            this.configurazioneBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.configurazioneBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.configurazioneBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.configurazioneBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.configurazioneBindingNavigatorSaveItem});
            this.configurazioneBindingNavigator.Location = new System.Drawing.Point(0, 364);
            this.configurazioneBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.configurazioneBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.configurazioneBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.configurazioneBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.configurazioneBindingNavigator.Name = "configurazioneBindingNavigator";
            this.configurazioneBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.configurazioneBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.configurazioneBindingNavigator.Size = new System.Drawing.Size(704, 25);
            this.configurazioneBindingNavigator.TabIndex = 0;
            this.configurazioneBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 22);
            this.bindingNavigatorCountItem.Text = "di {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Numero totale di elementi";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Elimina";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Sposta avanti";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Sposta in ultima posizione";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // configurazioneBindingNavigatorSaveItem
            // 
            this.configurazioneBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.configurazioneBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("configurazioneBindingNavigatorSaveItem.Image")));
            this.configurazioneBindingNavigatorSaveItem.Name = "configurazioneBindingNavigatorSaveItem";
            this.configurazioneBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.configurazioneBindingNavigatorSaveItem.Text = "Salva dati";
            this.configurazioneBindingNavigatorSaveItem.Click += new System.EventHandler(this.configurazioneBindingNavigatorSaveItem_Click_1);
            // 
            // nrUltimoOrdineLettoTextBox
            // 
            this.nrUltimoOrdineLettoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurazioneBindingSource, "NrUltimoOrdineLetto", true));
            this.nrUltimoOrdineLettoTextBox.Location = new System.Drawing.Point(261, 112);
            this.nrUltimoOrdineLettoTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.nrUltimoOrdineLettoTextBox.Name = "nrUltimoOrdineLettoTextBox";
            this.nrUltimoOrdineLettoTextBox.Size = new System.Drawing.Size(180, 31);
            this.nrUltimoOrdineLettoTextBox.TabIndex = 2;
            this.nrUltimoOrdineLettoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataUltimoOrdineDateTimePicker
            // 
            this.dataUltimoOrdineDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.configurazioneBindingSource, "DataUltimoOrdine", true));
            this.dataUltimoOrdineDateTimePicker.Location = new System.Drawing.Point(261, 162);
            this.dataUltimoOrdineDateTimePicker.Margin = new System.Windows.Forms.Padding(6);
            this.dataUltimoOrdineDateTimePicker.Name = "dataUltimoOrdineDateTimePicker";
            this.dataUltimoOrdineDateTimePicker.Size = new System.Drawing.Size(363, 31);
            this.dataUltimoOrdineDateTimePicker.TabIndex = 4;
            // 
            // nrOrdineFornitoreTextBox
            // 
            this.nrOrdineFornitoreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurazioneBindingSource, "NrOrdineFornitore", true));
            this.nrOrdineFornitoreTextBox.Location = new System.Drawing.Point(261, 212);
            this.nrOrdineFornitoreTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.nrOrdineFornitoreTextBox.Name = "nrOrdineFornitoreTextBox";
            this.nrOrdineFornitoreTextBox.Size = new System.Drawing.Size(180, 31);
            this.nrOrdineFornitoreTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Parametri configurazione azienda";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "SALVA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Contatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(704, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(nrOrdineFornitoreLabel);
            this.Controls.Add(this.nrOrdineFornitoreTextBox);
            this.Controls.Add(dataUltimoOrdineLabel);
            this.Controls.Add(this.dataUltimoOrdineDateTimePicker);
            this.Controls.Add(nrUltimoOrdineLettoLabel);
            this.Controls.Add(this.nrUltimoOrdineLettoTextBox);
            this.Controls.Add(this.configurazioneBindingNavigator);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Contatori";
            this.Text = "Contatori";
            this.Load += new System.EventHandler(this.Contatori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurazioneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurazioneBindingNavigator)).EndInit();
            this.configurazioneBindingNavigator.ResumeLayout(false);
            this.configurazioneBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Target2021DataSet target2021DataSet;
        private System.Windows.Forms.BindingSource configurazioneBindingSource;
        private Target2021DataSetTableAdapters.ConfigurazioneTableAdapter configurazioneTableAdapter;
        private Target2021DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator configurazioneBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton configurazioneBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nrUltimoOrdineLettoTextBox;
        private System.Windows.Forms.DateTimePicker dataUltimoOrdineDateTimePicker;
        private System.Windows.Forms.TextBox nrOrdineFornitoreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}