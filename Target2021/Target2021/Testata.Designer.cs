namespace Target2021
{
    partial class Testata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Testata));
            this.target2021DataSet = new Target2021.Target2021DataSet();
            this.testata_ordini_multirigaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testata_ordini_multirigaTableAdapter = new Target2021.Target2021DataSetTableAdapters.testata_ordini_multirigaTableAdapter();
            this.tableAdapterManager = new Target2021.Target2021DataSetTableAdapters.TableAdapterManager();
            this.testata_ordini_multirigaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.testata_ordini_multirigaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Filter = new System.Windows.Forms.ComboBox();
            this.Cerca = new System.Windows.Forms.Button();
            this.articoliBCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articoliBCTableAdapter = new Target2021.Target2021DataSetTableAdapters.ArticoliBCTableAdapter();
            this.articoliBCDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testata_ordini_multirigaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testata_ordini_multirigaBindingNavigator)).BeginInit();
            this.testata_ordini_multirigaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articoliBCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articoliBCDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // target2021DataSet
            // 
            this.target2021DataSet.DataSetName = "Target2021DataSet";
            this.target2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testata_ordini_multirigaBindingSource
            // 
            this.testata_ordini_multirigaBindingSource.DataMember = "testata_ordini_multiriga";
            this.testata_ordini_multirigaBindingSource.DataSource = this.target2021DataSet;
            // 
            // testata_ordini_multirigaTableAdapter
            // 
            this.testata_ordini_multirigaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.testata_ordini_multirigaTableAdapter = this.testata_ordini_multirigaTableAdapter;
            this.tableAdapterManager.TipoCommessaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Target2021.Target2021DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // testata_ordini_multirigaBindingNavigator
            // 
            this.testata_ordini_multirigaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.testata_ordini_multirigaBindingNavigator.BindingSource = this.testata_ordini_multirigaBindingSource;
            this.testata_ordini_multirigaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.testata_ordini_multirigaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.testata_ordini_multirigaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.testata_ordini_multirigaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.testata_ordini_multirigaBindingNavigatorSaveItem});
            this.testata_ordini_multirigaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.testata_ordini_multirigaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.testata_ordini_multirigaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.testata_ordini_multirigaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.testata_ordini_multirigaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.testata_ordini_multirigaBindingNavigator.Name = "testata_ordini_multirigaBindingNavigator";
            this.testata_ordini_multirigaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.testata_ordini_multirigaBindingNavigator.Size = new System.Drawing.Size(1004, 27);
            this.testata_ordini_multirigaBindingNavigator.TabIndex = 0;
            this.testata_ordini_multirigaBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
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
            // testata_ordini_multirigaBindingNavigatorSaveItem
            // 
            this.testata_ordini_multirigaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.testata_ordini_multirigaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("testata_ordini_multirigaBindingNavigatorSaveItem.Image")));
            this.testata_ordini_multirigaBindingNavigatorSaveItem.Name = "testata_ordini_multirigaBindingNavigatorSaveItem";
            this.testata_ordini_multirigaBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.testata_ordini_multirigaBindingNavigatorSaveItem.Text = "Salva dati";
            this.testata_ordini_multirigaBindingNavigatorSaveItem.Click += new System.EventHandler(this.testata_ordini_multirigaBindingNavigatorSaveItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(823, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Filter
            // 
            this.Filter.FormattingEnabled = true;
            this.Filter.Items.AddRange(new object[] {
            "codice_articolo",
            "progressivo"});
            this.Filter.Location = new System.Drawing.Point(822, 56);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(140, 24);
            this.Filter.TabIndex = 6;
            this.Filter.Text = "Testata";
            // 
            // Cerca
            // 
            this.Cerca.Location = new System.Drawing.Point(839, 185);
            this.Cerca.Name = "Cerca";
            this.Cerca.Size = new System.Drawing.Size(110, 39);
            this.Cerca.TabIndex = 7;
            this.Cerca.Text = "CERCA";
            this.Cerca.UseVisualStyleBackColor = true;
            this.Cerca.Click += new System.EventHandler(this.Button2_Click);
            // 
            // articoliBCBindingSource
            // 
            this.articoliBCBindingSource.DataMember = "ArticoliBC";
            this.articoliBCBindingSource.DataSource = this.target2021DataSet;
            // 
            // articoliBCTableAdapter
            // 
            this.articoliBCTableAdapter.ClearBeforeFill = true;
            // 
            // articoliBCDataGridView
            // 
            this.articoliBCDataGridView.AutoGenerateColumns = false;
            this.articoliBCDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.articoliBCDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articoliBCDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.articoliBCDataGridView.DataSource = this.articoliBCBindingSource;
            this.articoliBCDataGridView.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.articoliBCDataGridView.Location = new System.Drawing.Point(22, 56);
            this.articoliBCDataGridView.Name = "articoliBCDataGridView";
            this.articoliBCDataGridView.RowTemplate.Height = 24;
            this.articoliBCDataGridView.Size = new System.Drawing.Size(665, 406);
            this.articoliBCDataGridView.TabIndex = 7;
            this.articoliBCDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ArticoliBCDataGridView_RowHeaderMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codice_articolo";
            this.dataGridViewTextBoxColumn1.HeaderText = "codice_articolo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "progressivo";
            this.dataGridViewTextBoxColumn2.HeaderText = "progressivo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "codice_articolo_input";
            this.dataGridViewTextBoxColumn3.HeaderText = "codice_articolo_input";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "descrizione_articolo_bc";
            this.dataGridViewTextBoxColumn4.HeaderText = "descrizione_articolo_bc";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "codice_fornitore_articolo_bc";
            this.dataGridViewTextBoxColumn5.HeaderText = "codice_fornitore_articolo_bc";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "codice_articolo_outout";
            this.dataGridViewTextBoxColumn6.HeaderText = "codice_articolo_outout";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Testata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1004, 474);
            this.Controls.Add(this.articoliBCDataGridView);
            this.Controls.Add(this.Cerca);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.testata_ordini_multirigaBindingNavigator);
            this.Name = "Testata";
            this.Text = "Testata";
            this.Load += new System.EventHandler(this.Testata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testata_ordini_multirigaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testata_ordini_multirigaBindingNavigator)).EndInit();
            this.testata_ordini_multirigaBindingNavigator.ResumeLayout(false);
            this.testata_ordini_multirigaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articoliBCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articoliBCDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Target2021DataSet target2021DataSet;
        private System.Windows.Forms.BindingSource testata_ordini_multirigaBindingSource;
        private Target2021DataSetTableAdapters.testata_ordini_multirigaTableAdapter testata_ordini_multirigaTableAdapter;
        private Target2021DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator testata_ordini_multirigaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton testata_ordini_multirigaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox Filter;
        private System.Windows.Forms.Button Cerca;
        private System.Windows.Forms.BindingSource articoliBCBindingSource;
        private Target2021DataSetTableAdapters.ArticoliBCTableAdapter articoliBCTableAdapter;
        private System.Windows.Forms.DataGridView articoliBCDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}