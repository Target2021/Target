namespace Target2021
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.target2021DataSet = new Target2021.Target2021DataSet();
            this.anaMagazziniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anaMagazziniTableAdapter = new Target2021.Target2021DataSetTableAdapters.AnaMagazziniTableAdapter();
            this.tableAdapterManager = new Target2021.Target2021DataSetTableAdapters.TableAdapterManager();
            this.anaMagazziniBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.anaMagazziniBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.anaMagazziniDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anaMagazziniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anaMagazziniBindingNavigator)).BeginInit();
            this.anaMagazziniBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anaMagazziniDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Benvenuti";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 158);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
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
            // anaMagazziniBindingNavigator
            // 
            this.anaMagazziniBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.anaMagazziniBindingNavigator.BindingSource = this.anaMagazziniBindingSource;
            this.anaMagazziniBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.anaMagazziniBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.anaMagazziniBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.anaMagazziniBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.anaMagazziniBindingNavigatorSaveItem});
            this.anaMagazziniBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.anaMagazziniBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.anaMagazziniBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.anaMagazziniBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.anaMagazziniBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.anaMagazziniBindingNavigator.Name = "anaMagazziniBindingNavigator";
            this.anaMagazziniBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.anaMagazziniBindingNavigator.Size = new System.Drawing.Size(591, 27);
            this.anaMagazziniBindingNavigator.TabIndex = 2;
            this.anaMagazziniBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 24);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
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
            // anaMagazziniBindingNavigatorSaveItem
            // 
            this.anaMagazziniBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.anaMagazziniBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("anaMagazziniBindingNavigatorSaveItem.Image")));
            this.anaMagazziniBindingNavigatorSaveItem.Name = "anaMagazziniBindingNavigatorSaveItem";
            this.anaMagazziniBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.anaMagazziniBindingNavigatorSaveItem.Text = "Salva dati";
            this.anaMagazziniBindingNavigatorSaveItem.Click += new System.EventHandler(this.anaMagazziniBindingNavigatorSaveItem_Click);
            // 
            // anaMagazziniDataGridView
            // 
            this.anaMagazziniDataGridView.AutoGenerateColumns = false;
            this.anaMagazziniDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.anaMagazziniDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.anaMagazziniDataGridView.DataSource = this.anaMagazziniBindingSource;
            this.anaMagazziniDataGridView.Location = new System.Drawing.Point(226, 59);
            this.anaMagazziniDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.anaMagazziniDataGridView.Name = "anaMagazziniDataGridView";
            this.anaMagazziniDataGridView.RowTemplate.Height = 24;
            this.anaMagazziniDataGridView.Size = new System.Drawing.Size(225, 179);
            this.anaMagazziniDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDMagazzino";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDMagazzino";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descrizione";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrizione";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(193, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(270, 36);
            this.button3.TabIndex = 4;
            this.button3.Text = "Ciao Ciao";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 420);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.anaMagazziniDataGridView);
            this.Controls.Add(this.anaMagazziniBindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anaMagazziniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anaMagazziniBindingNavigator)).EndInit();
            this.anaMagazziniBindingNavigator.ResumeLayout(false);
            this.anaMagazziniBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anaMagazziniDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Target2021DataSet target2021DataSet;
        private System.Windows.Forms.BindingSource anaMagazziniBindingSource;
        private Target2021DataSetTableAdapters.AnaMagazziniTableAdapter anaMagazziniTableAdapter;
        private Target2021DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator anaMagazziniBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton anaMagazziniBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView anaMagazziniDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button3;
    }
}

