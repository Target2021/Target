namespace Target2021.Anagrafiche
{
    partial class AnaMTaglio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaMTaglio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.target2021DataSet = new Target2021.Target2021DataSet();
            this.macchineTaglioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.macchineTaglioTableAdapter = new Target2021.Target2021DataSetTableAdapters.MacchineTaglioTableAdapter();
            this.tableAdapterManager = new Target2021.Target2021DataSetTableAdapters.TableAdapterManager();
            this.macchineTaglioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.macchineTaglioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.macchineTaglioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macchineTaglioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macchineTaglioBindingNavigator)).BeginInit();
            this.macchineTaglioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.macchineTaglioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // target2021DataSet
            // 
            this.target2021DataSet.DataSetName = "Target2021DataSet";
            this.target2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // macchineTaglioBindingSource
            // 
            this.macchineTaglioBindingSource.DataMember = "MacchineTaglio";
            this.macchineTaglioBindingSource.DataSource = this.target2021DataSet;
            // 
            // macchineTaglioTableAdapter
            // 
            this.macchineTaglioTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.DettArticoliTableAdapter = null;
            this.tableAdapterManager.DimeTableAdapter = null;
            this.tableAdapterManager.FasiTableAdapter = null;
            this.tableAdapterManager.FornitoriTableAdapter = null;
            this.tableAdapterManager.GiacenzeMagazziniTableAdapter = null;
            this.tableAdapterManager.LavorazioniTableAdapter = null;
            this.tableAdapterManager.LivelliUtenzaTableAdapter = null;
            this.tableAdapterManager.MacchineStampoTableAdapter = null;
            this.tableAdapterManager.MacchineTaglioTableAdapter = this.macchineTaglioTableAdapter;
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
            // macchineTaglioBindingNavigator
            // 
            this.macchineTaglioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.macchineTaglioBindingNavigator.BindingSource = this.macchineTaglioBindingSource;
            this.macchineTaglioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.macchineTaglioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.macchineTaglioBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.macchineTaglioBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.macchineTaglioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.macchineTaglioBindingNavigatorSaveItem});
            this.macchineTaglioBindingNavigator.Location = new System.Drawing.Point(0, 527);
            this.macchineTaglioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.macchineTaglioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.macchineTaglioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.macchineTaglioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.macchineTaglioBindingNavigator.Name = "macchineTaglioBindingNavigator";
            this.macchineTaglioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.macchineTaglioBindingNavigator.Size = new System.Drawing.Size(630, 27);
            this.macchineTaglioBindingNavigator.TabIndex = 0;
            this.macchineTaglioBindingNavigator.Text = "bindingNavigator1";
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
            // macchineTaglioBindingNavigatorSaveItem
            // 
            this.macchineTaglioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.macchineTaglioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("macchineTaglioBindingNavigatorSaveItem.Image")));
            this.macchineTaglioBindingNavigatorSaveItem.Name = "macchineTaglioBindingNavigatorSaveItem";
            this.macchineTaglioBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.macchineTaglioBindingNavigatorSaveItem.Text = "Salva dati";
            this.macchineTaglioBindingNavigatorSaveItem.Click += new System.EventHandler(this.macchineTaglioBindingNavigatorSaveItem_Click);
            // 
            // macchineTaglioDataGridView
            // 
            this.macchineTaglioDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.macchineTaglioDataGridView.AutoGenerateColumns = false;
            this.macchineTaglioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.macchineTaglioDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.macchineTaglioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.macchineTaglioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.macchineTaglioDataGridView.DataSource = this.macchineTaglioBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.macchineTaglioDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.macchineTaglioDataGridView.Location = new System.Drawing.Point(0, 49);
            this.macchineTaglioDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.macchineTaglioDataGridView.Name = "macchineTaglioDataGridView";
            this.macchineTaglioDataGridView.Size = new System.Drawing.Size(627, 470);
            this.macchineTaglioDataGridView.TabIndex = 1;
            this.macchineTaglioDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.macchineTaglioDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDTaglio";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDTaglio";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 89;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descrizione";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrizione";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 111;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CostoMinuto";
            this.dataGridViewTextBoxColumn3.HeaderText = "CostoMinuto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 115;
            // 
            // AnaMTaglio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(630, 554);
            this.Controls.Add(this.macchineTaglioDataGridView);
            this.Controls.Add(this.macchineTaglioBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnaMTaglio";
            this.Text = "Anagrafica Macchine di Taglio";
            this.Load += new System.EventHandler(this.AnaMTaglio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macchineTaglioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macchineTaglioBindingNavigator)).EndInit();
            this.macchineTaglioBindingNavigator.ResumeLayout(false);
            this.macchineTaglioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.macchineTaglioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Target2021DataSet target2021DataSet;
        private System.Windows.Forms.BindingSource macchineTaglioBindingSource;
        private Target2021DataSetTableAdapters.MacchineTaglioTableAdapter macchineTaglioTableAdapter;
        private Target2021DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator macchineTaglioBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton macchineTaglioBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView macchineTaglioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}