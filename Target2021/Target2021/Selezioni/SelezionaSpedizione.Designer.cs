namespace Target2021.Selezioni
{
    partial class SelezionaSpedizione
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
            this.target2021DataSet = new Target2021.Target2021DataSet();
            this.primeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.primeTableAdapter = new Target2021.Target2021DataSetTableAdapters.PrimeTableAdapter();
            this.tableAdapterManager = new Target2021.Target2021DataSetTableAdapters.TableAdapterManager();
            this.primeDataGridView = new System.Windows.Forms.DataGridView();
            this.idCodSpedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codiceIncotermDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrizioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codSpedizioniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.codSpedizioniTableAdapter = new Target2021.Target2021DataSetTableAdapters.CodSpedizioniTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codSpedizioniBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // target2021DataSet
            // 
            this.target2021DataSet.DataSetName = "Target2021DataSet";
            this.target2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // primeBindingSource
            // 
            this.primeBindingSource.DataMember = "Prime";
            this.primeBindingSource.DataSource = this.target2021DataSet;
            // 
            // primeTableAdapter
            // 
            this.primeTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.MovimentiMagazzinoTableAdapter = null;
            this.tableAdapterManager.OrdFornDettTableAdapter = null;
            this.tableAdapterManager.OrdFornTestTableAdapter = null;
            this.tableAdapterManager.PesiSpecificiTableAdapter = null;
            this.tableAdapterManager.PosizioniDimeStampiTableAdapter = null;
            this.tableAdapterManager.PrimeTableAdapter = this.primeTableAdapter;
            this.tableAdapterManager.StampiTableAdapter = null;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.TaglioOnLineTableAdapter = null;
            this.tableAdapterManager.testata_ordini_multirigaTableAdapter = null;
            this.tableAdapterManager.TipoCommessaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Target2021.Target2021DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtentiTableAdapter = null;
            // 
            // primeDataGridView
            // 
            this.primeDataGridView.AutoGenerateColumns = false;
            this.primeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.primeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCodSpedDataGridViewTextBoxColumn,
            this.codiceIncotermDataGridViewTextBoxColumn,
            this.descrizioneDataGridViewTextBoxColumn});
            this.primeDataGridView.DataSource = this.codSpedizioniBindingSource;
            this.primeDataGridView.Location = new System.Drawing.Point(0, 79);
            this.primeDataGridView.MultiSelect = false;
            this.primeDataGridView.Name = "primeDataGridView";
            this.primeDataGridView.ReadOnly = true;
            this.primeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.primeDataGridView.Size = new System.Drawing.Size(522, 215);
            this.primeDataGridView.TabIndex = 1;
            this.primeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Selezionata);
            // 
            // idCodSpedDataGridViewTextBoxColumn
            // 
            this.idCodSpedDataGridViewTextBoxColumn.DataPropertyName = "idCodSped";
            this.idCodSpedDataGridViewTextBoxColumn.HeaderText = "idCodSped";
            this.idCodSpedDataGridViewTextBoxColumn.Name = "idCodSpedDataGridViewTextBoxColumn";
            this.idCodSpedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codiceIncotermDataGridViewTextBoxColumn
            // 
            this.codiceIncotermDataGridViewTextBoxColumn.DataPropertyName = "CodiceIncoterm";
            this.codiceIncotermDataGridViewTextBoxColumn.HeaderText = "CodiceIncoterm";
            this.codiceIncotermDataGridViewTextBoxColumn.Name = "codiceIncotermDataGridViewTextBoxColumn";
            this.codiceIncotermDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descrizioneDataGridViewTextBoxColumn
            // 
            this.descrizioneDataGridViewTextBoxColumn.DataPropertyName = "Descrizione";
            this.descrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione";
            this.descrizioneDataGridViewTextBoxColumn.Name = "descrizioneDataGridViewTextBoxColumn";
            this.descrizioneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codSpedizioniBindingSource
            // 
            this.codSpedizioniBindingSource.DataMember = "CodSpedizioni";
            this.codSpedizioniBindingSource.DataSource = this.target2021DataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleziona la modalità di spedizione desiderata:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(185, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "SELEZIONA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // codSpedizioniTableAdapter
            // 
            this.codSpedizioniTableAdapter.ClearBeforeFill = true;
            // 
            // SelezionaSpedizione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.primeDataGridView);
            this.Name = "SelezionaSpedizione";
            this.Text = "Seleziona la SPEDIZIONE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Chiuso);
            this.Load += new System.EventHandler(this.SelezionaLastre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codSpedizioniBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Target2021DataSet target2021DataSet;
        private System.Windows.Forms.BindingSource primeBindingSource;
        private Target2021DataSetTableAdapters.PrimeTableAdapter primeTableAdapter;
        private Target2021DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView primeDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource codSpedizioniBindingSource;
        private Target2021DataSetTableAdapters.CodSpedizioniTableAdapter codSpedizioniTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCodSpedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codiceIncotermDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrizioneDataGridViewTextBoxColumn;
    }
}