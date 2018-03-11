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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contatori));
            System.Windows.Forms.Label nrUltimoOrdineLettoLabel;
            System.Windows.Forms.Label dataUltimoOrdineLabel;
            this.target2021DataSet = new Target2021.Target2021DataSet();
            this.configurazioneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.configurazioneTableAdapter = new Target2021.Target2021DataSetTableAdapters.ConfigurazioneTableAdapter();
            this.tableAdapterManager = new Target2021.Target2021DataSetTableAdapters.TableAdapterManager();
            this.configurazioneBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.iDAziendaTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.configurazioneBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
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
            // 
            // configurazioneBindingNavigator
            // 
            this.configurazioneBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.configurazioneBindingNavigator.BindingSource = this.configurazioneBindingSource;
            this.configurazioneBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.configurazioneBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.configurazioneBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.configurazioneBindingNavigator.TabIndex = 0;
            this.configurazioneBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 22);
            this.bindingNavigatorCountItem.Text = "di {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Numero totale di elementi";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // iDAziendaLabel
            // 
            iDAziendaLabel.AutoSize = true;
            iDAziendaLabel.Location = new System.Drawing.Point(128, 101);
            iDAziendaLabel.Name = "iDAziendaLabel";
            iDAziendaLabel.Size = new System.Drawing.Size(59, 13);
            iDAziendaLabel.TabIndex = 1;
            iDAziendaLabel.Text = "IDAzienda:";
            // 
            // iDAziendaTextBox
            // 
            this.iDAziendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurazioneBindingSource, "IDAzienda", true));
            this.iDAziendaTextBox.Location = new System.Drawing.Point(193, 98);
            this.iDAziendaTextBox.Name = "iDAziendaTextBox";
            this.iDAziendaTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDAziendaTextBox.TabIndex = 2;
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
            // configurazioneBindingNavigatorSaveItem
            // 
            this.configurazioneBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.configurazioneBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("configurazioneBindingNavigatorSaveItem.Image")));
            this.configurazioneBindingNavigatorSaveItem.Name = "configurazioneBindingNavigatorSaveItem";
            this.configurazioneBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.configurazioneBindingNavigatorSaveItem.Text = "Salva dati";
            this.configurazioneBindingNavigatorSaveItem.Click += new System.EventHandler(this.configurazioneBindingNavigatorSaveItem_Click);
            // 
            // nrUltimoOrdineLettoLabel
            // 
            nrUltimoOrdineLettoLabel.AutoSize = true;
            nrUltimoOrdineLettoLabel.Location = new System.Drawing.Point(73, 127);
            nrUltimoOrdineLettoLabel.Name = "nrUltimoOrdineLettoLabel";
            nrUltimoOrdineLettoLabel.Size = new System.Drawing.Size(114, 13);
            nrUltimoOrdineLettoLabel.TabIndex = 3;
            nrUltimoOrdineLettoLabel.Text = "Nr Ultimo Ordine Letto:";
            // 
            // nrUltimoOrdineLettoTextBox
            // 
            this.nrUltimoOrdineLettoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurazioneBindingSource, "NrUltimoOrdineLetto", true));
            this.nrUltimoOrdineLettoTextBox.Location = new System.Drawing.Point(193, 124);
            this.nrUltimoOrdineLettoTextBox.Name = "nrUltimoOrdineLettoTextBox";
            this.nrUltimoOrdineLettoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nrUltimoOrdineLettoTextBox.TabIndex = 4;
            // 
            // dataUltimoOrdineLabel
            // 
            dataUltimoOrdineLabel.AutoSize = true;
            dataUltimoOrdineLabel.Location = new System.Drawing.Point(88, 154);
            dataUltimoOrdineLabel.Name = "dataUltimoOrdineLabel";
            dataUltimoOrdineLabel.Size = new System.Drawing.Size(99, 13);
            dataUltimoOrdineLabel.TabIndex = 5;
            dataUltimoOrdineLabel.Text = "Data Ultimo Ordine:";
            // 
            // dataUltimoOrdineDateTimePicker
            // 
            this.dataUltimoOrdineDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.configurazioneBindingSource, "DataUltimoOrdine", true));
            this.dataUltimoOrdineDateTimePicker.Location = new System.Drawing.Point(193, 150);
            this.dataUltimoOrdineDateTimePicker.Name = "dataUltimoOrdineDateTimePicker";
            this.dataUltimoOrdineDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataUltimoOrdineDateTimePicker.TabIndex = 6;
            // 
            // Contatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(dataUltimoOrdineLabel);
            this.Controls.Add(this.dataUltimoOrdineDateTimePicker);
            this.Controls.Add(nrUltimoOrdineLettoLabel);
            this.Controls.Add(this.nrUltimoOrdineLettoTextBox);
            this.Controls.Add(iDAziendaLabel);
            this.Controls.Add(this.iDAziendaTextBox);
            this.Controls.Add(this.configurazioneBindingNavigator);
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