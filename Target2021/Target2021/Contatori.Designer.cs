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
            System.Windows.Forms.Label iDAziendaLabel;
            System.Windows.Forms.Label nrUltimoOrdineLettoLabel;
            System.Windows.Forms.Label dataUltimoOrdineLabel;
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
            this.iDAziendaTextBox = new System.Windows.Forms.TextBox();
            this.nrUltimoOrdineLettoTextBox = new System.Windows.Forms.TextBox();
            this.dataUltimoOrdineDateTimePicker = new System.Windows.Forms.DateTimePicker();
            iDAziendaLabel = new System.Windows.Forms.Label();
            nrUltimoOrdineLettoLabel = new System.Windows.Forms.Label();
            dataUltimoOrdineLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurazioneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurazioneBindingNavigator)).BeginInit();
            this.configurazioneBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDAziendaLabel
            // 
            iDAziendaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            iDAziendaLabel.AutoSize = true;
            iDAziendaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDAziendaLabel.Location = new System.Drawing.Point(134, 168);
            iDAziendaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iDAziendaLabel.Name = "iDAziendaLabel";
            iDAziendaLabel.Size = new System.Drawing.Size(128, 29);
            iDAziendaLabel.TabIndex = 1;
            iDAziendaLabel.Text = "IDAzienda:";
            // 
            // nrUltimoOrdineLettoLabel
            // 
            nrUltimoOrdineLettoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            nrUltimoOrdineLettoLabel.AutoSize = true;
            nrUltimoOrdineLettoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nrUltimoOrdineLettoLabel.Location = new System.Drawing.Point(7, 245);
            nrUltimoOrdineLettoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nrUltimoOrdineLettoLabel.Name = "nrUltimoOrdineLettoLabel";
            nrUltimoOrdineLettoLabel.Size = new System.Drawing.Size(259, 29);
            nrUltimoOrdineLettoLabel.TabIndex = 3;
            nrUltimoOrdineLettoLabel.Text = "Nr Ultimo Ordine Letto:";
            // 
            // dataUltimoOrdineLabel
            // 
            dataUltimoOrdineLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataUltimoOrdineLabel.AutoSize = true;
            dataUltimoOrdineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataUltimoOrdineLabel.Location = new System.Drawing.Point(39, 300);
            dataUltimoOrdineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataUltimoOrdineLabel.Name = "dataUltimoOrdineLabel";
            dataUltimoOrdineLabel.Size = new System.Drawing.Size(223, 29);
            dataUltimoOrdineLabel.TabIndex = 5;
            dataUltimoOrdineLabel.Text = "Data Ultimo Ordine:";
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
            this.tableAdapterManager.AnaMagazziniTableAdapter = null;
            this.tableAdapterManager.articoli_sempliciTableAdapter = null;
            this.tableAdapterManager.ArticoliBCTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientiTableAdapter = null;
            this.tableAdapterManager.CommesseTableAdapter = null;
            this.tableAdapterManager.CompatibStampaTableAdapter = null;
            this.tableAdapterManager.CompatibTaglioTableAdapter = null;
            this.tableAdapterManager.ConfigurazioneTableAdapter = this.configurazioneTableAdapter;
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
            // configurazioneBindingNavigator
            // 
            this.configurazioneBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.configurazioneBindingNavigator.BindingSource = this.configurazioneBindingSource;
            this.configurazioneBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.configurazioneBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.configurazioneBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.configurazioneBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.configurazioneBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.configurazioneBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.configurazioneBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.configurazioneBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.configurazioneBindingNavigator.Name = "configurazioneBindingNavigator";
            this.configurazioneBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.configurazioneBindingNavigator.Size = new System.Drawing.Size(1067, 27);
            this.configurazioneBindingNavigator.TabIndex = 0;
            this.configurazioneBindingNavigator.Text = "bindingNavigator1";
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
            // configurazioneBindingNavigatorSaveItem
            // 
            this.configurazioneBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.configurazioneBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("configurazioneBindingNavigatorSaveItem.Image")));
            this.configurazioneBindingNavigatorSaveItem.Name = "configurazioneBindingNavigatorSaveItem";
            this.configurazioneBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.configurazioneBindingNavigatorSaveItem.Text = "Salva dati";
            this.configurazioneBindingNavigatorSaveItem.Click += new System.EventHandler(this.configurazioneBindingNavigatorSaveItem_Click);
            // 
            // iDAziendaTextBox
            // 
            this.iDAziendaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iDAziendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurazioneBindingSource, "IDAzienda", true));
            this.iDAziendaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDAziendaTextBox.Location = new System.Drawing.Point(274, 168);
            this.iDAziendaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iDAziendaTextBox.Name = "iDAziendaTextBox";
            this.iDAziendaTextBox.Size = new System.Drawing.Size(132, 34);
            this.iDAziendaTextBox.TabIndex = 2;
            // 
            // nrUltimoOrdineLettoTextBox
            // 
            this.nrUltimoOrdineLettoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nrUltimoOrdineLettoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurazioneBindingSource, "NrUltimoOrdineLetto", true));
            this.nrUltimoOrdineLettoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrUltimoOrdineLettoTextBox.Location = new System.Drawing.Point(274, 240);
            this.nrUltimoOrdineLettoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nrUltimoOrdineLettoTextBox.Name = "nrUltimoOrdineLettoTextBox";
            this.nrUltimoOrdineLettoTextBox.Size = new System.Drawing.Size(132, 34);
            this.nrUltimoOrdineLettoTextBox.TabIndex = 4;
            // 
            // dataUltimoOrdineDateTimePicker
            // 
            this.dataUltimoOrdineDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataUltimoOrdineDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.configurazioneBindingSource, "DataUltimoOrdine", true));
            this.dataUltimoOrdineDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataUltimoOrdineDateTimePicker.Location = new System.Drawing.Point(274, 300);
            this.dataUltimoOrdineDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataUltimoOrdineDateTimePicker.Name = "dataUltimoOrdineDateTimePicker";
            this.dataUltimoOrdineDateTimePicker.Size = new System.Drawing.Size(265, 34);
            this.dataUltimoOrdineDateTimePicker.TabIndex = 6;
            // 
            // Contatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(dataUltimoOrdineLabel);
            this.Controls.Add(this.dataUltimoOrdineDateTimePicker);
            this.Controls.Add(nrUltimoOrdineLettoLabel);
            this.Controls.Add(this.nrUltimoOrdineLettoTextBox);
            this.Controls.Add(iDAziendaLabel);
            this.Controls.Add(this.iDAziendaTextBox);
            this.Controls.Add(this.configurazioneBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox iDAziendaTextBox;
        private System.Windows.Forms.TextBox nrUltimoOrdineLettoTextBox;
        private System.Windows.Forms.DateTimePicker dataUltimoOrdineDateTimePicker;
    }
}