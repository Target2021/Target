namespace Target2021
{
    partial class Dettaglio_Articoli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dettaglio_Articoli));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Filter = new System.Windows.Forms.ComboBox();
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
            this.dettArticoliDataGridView = new System.Windows.Forms.DataGridView();
            this.IDDettaglioArticolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dettArticoliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dettArticoliBindingNavigator)).BeginInit();
            this.dettArticoliBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dettArticoliDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(499, 50);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 30);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.button1_Click);
            // 
            // Filter
            // 
            this.Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter.FormattingEnabled = true;
            this.Filter.Items.AddRange(new object[] {
            "Codice articolo",
            "Descrizione",
            "Codice Input",
            "Codice Output"});
            this.Filter.Location = new System.Drawing.Point(285, 48);
            this.Filter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(191, 33);
            this.Filter.TabIndex = 7;
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
            this.tableAdapterManager.ArtFornTableAdapter = null;
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
            this.tableAdapterManager.TaglioOnLineTableAdapter = null;
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
            this.dettArticoliBindingNavigator.Size = new System.Drawing.Size(1169, 27);
            this.dettArticoliBindingNavigator.TabIndex = 8;
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
            this.dettArticoliBindingNavigatorSaveItem.Click += new System.EventHandler(this.dettArticoliBindingNavigatorSaveItem_Click_3);
            // 
            // dettArticoliDataGridView
            // 
            this.dettArticoliDataGridView.AllowUserToAddRows = false;
            this.dettArticoliDataGridView.AllowUserToDeleteRows = false;
            this.dettArticoliDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dettArticoliDataGridView.AutoGenerateColumns = false;
            this.dettArticoliDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dettArticoliDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dettArticoliDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDettaglioArticolo,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9});
            this.dettArticoliDataGridView.DataSource = this.dettArticoliBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dettArticoliDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dettArticoliDataGridView.Location = new System.Drawing.Point(0, 94);
            this.dettArticoliDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dettArticoliDataGridView.Name = "dettArticoliDataGridView";
            this.dettArticoliDataGridView.ReadOnly = true;
            this.dettArticoliDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dettArticoliDataGridView.Size = new System.Drawing.Size(1167, 476);
            this.dettArticoliDataGridView.TabIndex = 8;
            this.dettArticoliDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dettArticoliDataGridView_CellContentClick);
            this.dettArticoliDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelezionaRiga);
            this.dettArticoliDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dettArticoliDataGridView_DataError);
            // 
            // IDDettaglioArticolo
            // 
            this.IDDettaglioArticolo.DataPropertyName = "IDDettaglioArticolo";
            this.IDDettaglioArticolo.HeaderText = "IDDettaglioArticolo";
            this.IDDettaglioArticolo.Name = "IDDettaglioArticolo";
            this.IDDettaglioArticolo.ReadOnly = true;
            this.IDDettaglioArticolo.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "codice_articolo";
            this.dataGridViewTextBoxColumn2.HeaderText = "codice_articolo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "codicePrimaStampoDima";
            this.dataGridViewTextBoxColumn4.HeaderText = "codicePrimaStampoDima";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "descrizionePrimaStampoDima";
            this.dataGridViewTextBoxColumn5.HeaderText = "descrizionePrimaStampoDima";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 300;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CodiceInput";
            this.dataGridViewTextBoxColumn6.HeaderText = "CodiceInput";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CodiceOutput";
            this.dataGridViewTextBoxColumn7.HeaderText = "CodiceOutput";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "lavorazione";
            this.dataGridViewTextBoxColumn9.HeaderText = "lavorazione";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Campo da filtrare:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(732, 46);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "CERCA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dettaglio_Articoli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1169, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dettArticoliDataGridView);
            this.Controls.Add(this.dettArticoliBindingNavigator);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dettaglio_Articoli";
            this.Text = "Anagrafica Articoli";
            this.Load += new System.EventHandler(this.Dettaglio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dettArticoliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dettArticoliBindingNavigator)).EndInit();
            this.dettArticoliBindingNavigator.ResumeLayout(false);
            this.dettArticoliBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dettArticoliDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox Filter;
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
        private System.Windows.Forms.DataGridView dettArticoliDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDettaglioArticolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button button1;
    }
}