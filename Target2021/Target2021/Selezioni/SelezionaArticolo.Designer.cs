namespace Target2021.Selezioni
{
    partial class SelezionaArticolo
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezzo_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articolisempliciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.articoli_sempliciTableAdapter = new Target2021.Target2021DataSetTableAdapters.articoli_sempliciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articolisempliciBindingSource)).BeginInit();
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
            this.tableAdapterManager.StampiDimeTableAdapter = null;
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.prezzo_b,
            this.dataGridViewTextBoxColumn5});
            this.primeDataGridView.DataSource = this.articolisempliciBindingSource;
            this.primeDataGridView.Location = new System.Drawing.Point(0, 105);
            this.primeDataGridView.MultiSelect = false;
            this.primeDataGridView.Name = "primeDataGridView";
            this.primeDataGridView.ReadOnly = true;
            this.primeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.primeDataGridView.Size = new System.Drawing.Size(697, 267);
            this.primeDataGridView.TabIndex = 1;
            this.primeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Selezionata);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codice";
            this.dataGridViewTextBoxColumn1.HeaderText = "codice";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tipo";
            this.dataGridViewTextBoxColumn2.HeaderText = "tipo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "descrizione";
            this.dataGridViewTextBoxColumn3.HeaderText = "descrizione";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // prezzo_b
            // 
            this.prezzo_b.DataPropertyName = "prezzo_b";
            this.prezzo_b.HeaderText = "prezzo_b";
            this.prezzo_b.Name = "prezzo_b";
            this.prezzo_b.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "unita_misura";
            this.dataGridViewTextBoxColumn5.HeaderText = "unita_misura";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // articolisempliciBindingSource
            // 
            this.articolisempliciBindingSource.DataMember = "articoli_semplici";
            this.articolisempliciBindingSource.DataSource = this.target2021DataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleziona l\'articolo desiderato:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Codice",
            "Descrizione"});
            this.comboBox1.Location = new System.Drawing.Point(89, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filtra per:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(265, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.Filtra);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(568, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "SELEZIONA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // articoli_sempliciTableAdapter
            // 
            this.articoli_sempliciTableAdapter.ClearBeforeFill = true;
            // 
            // SelezionaArticolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.primeDataGridView);
            this.Name = "SelezionaArticolo";
            this.Text = "Seleziona la materia prima";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Chiuso);
            this.Load += new System.EventHandler(this.SelezionaLastre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articolisempliciBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource articolisempliciBindingSource;
        private Target2021DataSetTableAdapters.articoli_sempliciTableAdapter articoli_sempliciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezzo_b;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}