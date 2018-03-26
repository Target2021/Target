namespace Target2021
{
    partial class CheckStampaggio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckStampaggio));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.target2021DataSet = new Target2021.Target2021DataSet();
            this.target2021DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commesseBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.tableAdapterManager1 = new Target2021.Target2021DataSetTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commesseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commesseBindingNavigator)).BeginInit();
            this.commesseBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(860, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "LAVORA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(860, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "AGGIORNA";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // target2021DataSet
            // 
            this.target2021DataSet.DataSetName = "Target2021DataSet";
            this.target2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // target2021DataSetBindingSource
            // 
            this.target2021DataSetBindingSource.DataSource = this.target2021DataSet;
            this.target2021DataSetBindingSource.Position = 0;
            // 
            // commesseBindingSource
            // 
            this.commesseBindingSource.DataMember = "Commesse";
            this.commesseBindingSource.DataSource = this.target2021DataSet;
            // 
            // commesseBindingNavigator
            // 
            this.commesseBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.commesseBindingNavigator.BindingSource = this.commesseBindingSource;
            this.commesseBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.commesseBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.commesseBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.commesseBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.commesseBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.commesseBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.commesseBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.commesseBindingNavigator.Name = "commesseBindingNavigator";
            this.commesseBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.commesseBindingNavigator.Size = new System.Drawing.Size(1067, 27);
            this.commesseBindingNavigator.TabIndex = 5;
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
            // commesseBindingNavigatorSaveItem
            // 
            this.commesseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.commesseBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("commesseBindingNavigatorSaveItem.Image")));
            this.commesseBindingNavigatorSaveItem.Name = "commesseBindingNavigatorSaveItem";
            this.commesseBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.commesseBindingNavigatorSaveItem.Text = "Salva dati";
            this.commesseBindingNavigatorSaveItem.Click += new System.EventHandler(this.commesseBindingNavigatorSaveItem_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AnaMagazziniTableAdapter = null;
            this.tableAdapterManager1.articoli_sempliciTableAdapter = null;
            this.tableAdapterManager1.ArticoliBCTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.clientiTableAdapter = null;
            this.tableAdapterManager1.CommesseTableAdapter = null;
            this.tableAdapterManager1.CompatibStampaTableAdapter = null;
            this.tableAdapterManager1.CompatibTaglioTableAdapter = null;
            this.tableAdapterManager1.ConfigurazioneTableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.dettaglio_ordini_multirigaTableAdapter = null;
            this.tableAdapterManager1.DettArticoliTableAdapter = null;
            this.tableAdapterManager1.DimeTableAdapter = null;
            this.tableAdapterManager1.FasiTableAdapter = null;
            this.tableAdapterManager1.FornitoriTableAdapter = null;
            this.tableAdapterManager1.GiacenzeMagazziniTableAdapter = null;
            this.tableAdapterManager1.LivelliUtenzaTableAdapter = null;
            this.tableAdapterManager1.MacchineStampoTableAdapter = null;
            this.tableAdapterManager1.MacchineTaglioTableAdapter = null;
            this.tableAdapterManager1.MinuterieTableAdapter = null;
            this.tableAdapterManager1.MovimentiMagazzinoTableAdapter = null;
            this.tableAdapterManager1.PrimeTableAdapter = null;
            this.tableAdapterManager1.StampiTableAdapter = null;
            this.tableAdapterManager1.sysdiagramsTableAdapter = null;
            this.tableAdapterManager1.testata_ordini_multirigaTableAdapter = null;
            this.tableAdapterManager1.TipoCommessaTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Target2021.Target2021DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UtentiTableAdapter = null;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(808, 540);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // CheckStampaggio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 644);
            this.Controls.Add(this.commesseBindingNavigator);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CheckStampaggio";
            this.Text = "CheckStampaggio";
            this.Load += new System.EventHandler(this.CheckStampaggio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commesseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commesseBindingNavigator)).EndInit();
            this.commesseBindingNavigator.ResumeLayout(false);
            this.commesseBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource target2021DataSetBindingSource;
        private Target2021DataSet target2021DataSet;
        private System.Windows.Forms.BindingSource commesseBindingSource;
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
        private Target2021DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}