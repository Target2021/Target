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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.commesseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.target2021DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.target2021DataSet = new Target2021.Target2021DataSet();
            this.commesseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new Target2021.Target2021DataSetTableAdapters.TableAdapterManager();
            this.commesseTableAdapter = new Target2021.Target2021DataSetTableAdapters.CommesseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commesseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commesseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(37, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "AGGIORNA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 82);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1716, 545);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clikka);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // commesseBindingSource1
            // 
            this.commesseBindingSource1.DataMember = "Commesse";
            this.commesseBindingSource1.DataSource = this.target2021DataSetBindingSource;
            // 
            // target2021DataSetBindingSource
            // 
            this.target2021DataSetBindingSource.DataSource = this.target2021DataSet;
            this.target2021DataSetBindingSource.Position = 0;
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
            this.tableAdapterManager1.LavorazioniTableAdapter = null;
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
            // commesseTableAdapter
            // 
            this.commesseTableAdapter.ClearBeforeFill = true;
            // 
            // CheckStampaggio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1745, 641);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CheckStampaggio";
            this.Text = "Attività di stampaggio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CheckStampaggio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commesseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commesseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource target2021DataSetBindingSource;
        private Target2021DataSet target2021DataSet;
        private System.Windows.Forms.BindingSource commesseBindingSource;
        private Target2021DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource commesseBindingSource1;
        private Target2021DataSetTableAdapters.CommesseTableAdapter commesseTableAdapter;
    }
}