namespace Target2021.Fornitori
{
    partial class NuovoOrdineForn
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.codTermPagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.target2021DataSet = new Target2021.Target2021DataSet();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.codModPagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.codSpedizioniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.fornitoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fornitoriTableAdapter = new Target2021.Target2021DataSetTableAdapters.FornitoriTableAdapter();
            this.tableAdapterManager = new Target2021.Target2021DataSetTableAdapters.TableAdapterManager();
            this.codModPagamentoTableAdapter = new Target2021.Target2021DataSetTableAdapters.CodModPagamentoTableAdapter();
            this.codSpedizioniTableAdapter = new Target2021.Target2021DataSetTableAdapters.CodSpedizioniTableAdapter();
            this.codTermPagamentoTableAdapter = new Target2021.Target2021DataSetTableAdapters.CodTermPagamentoTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordFornDettBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordFornDettTableAdapter = new Target2021.Target2021DataSetTableAdapters.OrdFornDettTableAdapter();
            this.idOFDettDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOFTestataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCodiceArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrizioneArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitaRichDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataConsegnaRichiestaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataConsegnaConfermataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezzoKgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtaEffettivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoTotaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezzoALastraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codTermPagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codModPagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codSpedizioniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornitoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordFornDettBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Testata ordine";
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.codTermPagamentoBindingSource, "Descrizione", true));
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(556, 139);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(312, 29);
            this.textBox9.TabIndex = 15;
            // 
            // codTermPagamentoBindingSource
            // 
            this.codTermPagamentoBindingSource.DataMember = "CodTermPagamento";
            this.codTermPagamentoBindingSource.DataSource = this.target2021DataSet;
            // 
            // target2021DataSet
            // 
            this.target2021DataSet.DataSetName = "Target2021DataSet";
            this.target2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.codModPagamentoBindingSource, "Descrizione", true));
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(255, 139);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(291, 29);
            this.textBox8.TabIndex = 14;
            // 
            // codModPagamentoBindingSource
            // 
            this.codModPagamentoBindingSource.DataMember = "CodModPagamento";
            this.codModPagamentoBindingSource.DataSource = this.target2021DataSet;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.codSpedizioniBindingSource, "Descrizione", true));
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(10, 139);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(235, 29);
            this.textBox7.TabIndex = 13;
            // 
            // codSpedizioniBindingSource
            // 
            this.codSpedizioniBindingSource.DataMember = "CodSpedizioni";
            this.codSpedizioniBindingSource.DataSource = this.target2021DataSet;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornitoriBindingSource, "ragione_sociale", true));
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(247, 35);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(487, 29);
            this.textBox6.TabIndex = 12;
            // 
            // fornitoriBindingSource
            // 
            this.fornitoriBindingSource.DataMember = "Fornitori";
            this.fornitoriBindingSource.DataSource = this.target2021DataSet;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornitoriBindingSource, "tipo_pagamento", true));
            this.textBox5.Location = new System.Drawing.Point(705, 109);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(163, 29);
            this.textBox5.TabIndex = 11;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SelezTermPag);
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornitoriBindingSource, "codice_tipo_pagamento", true));
            this.textBox4.Location = new System.Drawing.Point(383, 109);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(163, 29);
            this.textBox4.TabIndex = 10;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SelezModPag);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornitoriBindingSource, "CodTrasporto", true));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(113, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 29);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SelezSpediz);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Termini pagam.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mod. pagam.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Spedizione:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(599, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 29);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nr. ordine:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(286, 29);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data ordine:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 29);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SelezForn);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fornitore:";
            // 
            // fornitoriTableAdapter
            // 
            this.fornitoriTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.CodModPagamentoTableAdapter = this.codModPagamentoTableAdapter;
            this.tableAdapterManager.CodSpedizioniTableAdapter = this.codSpedizioniTableAdapter;
            this.tableAdapterManager.CodTermPagamentoTableAdapter = this.codTermPagamentoTableAdapter;
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
            this.tableAdapterManager.FornitoriTableAdapter = this.fornitoriTableAdapter;
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
            this.tableAdapterManager.PrimeTableAdapter = null;
            this.tableAdapterManager.StampiDimeTableAdapter = null;
            this.tableAdapterManager.StampiTableAdapter = null;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.TaglioOnLineTableAdapter = null;
            this.tableAdapterManager.testata_ordini_multirigaTableAdapter = null;
            this.tableAdapterManager.TipoCommessaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Target2021.Target2021DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtentiTableAdapter = null;
            // 
            // codModPagamentoTableAdapter
            // 
            this.codModPagamentoTableAdapter.ClearBeforeFill = true;
            // 
            // codSpedizioniTableAdapter
            // 
            this.codSpedizioniTableAdapter.ClearBeforeFill = true;
            // 
            // codTermPagamentoTableAdapter
            // 
            this.codTermPagamentoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOFDettDataGridViewTextBoxColumn,
            this.idOFTestataDataGridViewTextBoxColumn,
            this.idCodiceArtDataGridViewTextBoxColumn,
            this.descrizioneArtDataGridViewTextBoxColumn,
            this.quantitaRichDataGridViewTextBoxColumn,
            this.dataConsegnaRichiestaDataGridViewTextBoxColumn,
            this.dataConsegnaConfermataDataGridViewTextBoxColumn,
            this.statoDataGridViewTextBoxColumn,
            this.prezzoKgDataGridViewTextBoxColumn,
            this.qtaEffettivaDataGridViewTextBoxColumn,
            this.pesoTotaleDataGridViewTextBoxColumn,
            this.prezzoALastraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordFornDettBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(867, 183);
            this.dataGridView1.TabIndex = 1;
            // 
            // ordFornDettBindingSource
            // 
            this.ordFornDettBindingSource.DataMember = "OrdFornDett";
            this.ordFornDettBindingSource.DataSource = this.target2021DataSet;
            // 
            // ordFornDettTableAdapter
            // 
            this.ordFornDettTableAdapter.ClearBeforeFill = true;
            // 
            // idOFDettDataGridViewTextBoxColumn
            // 
            this.idOFDettDataGridViewTextBoxColumn.DataPropertyName = "idOFDett";
            this.idOFDettDataGridViewTextBoxColumn.HeaderText = "idOFDett";
            this.idOFDettDataGridViewTextBoxColumn.Name = "idOFDettDataGridViewTextBoxColumn";
            this.idOFDettDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idOFTestataDataGridViewTextBoxColumn
            // 
            this.idOFTestataDataGridViewTextBoxColumn.DataPropertyName = "idOFTestata";
            this.idOFTestataDataGridViewTextBoxColumn.HeaderText = "idOFTestata";
            this.idOFTestataDataGridViewTextBoxColumn.Name = "idOFTestataDataGridViewTextBoxColumn";
            // 
            // idCodiceArtDataGridViewTextBoxColumn
            // 
            this.idCodiceArtDataGridViewTextBoxColumn.DataPropertyName = "idCodiceArt";
            this.idCodiceArtDataGridViewTextBoxColumn.HeaderText = "idCodiceArt";
            this.idCodiceArtDataGridViewTextBoxColumn.Name = "idCodiceArtDataGridViewTextBoxColumn";
            // 
            // descrizioneArtDataGridViewTextBoxColumn
            // 
            this.descrizioneArtDataGridViewTextBoxColumn.DataPropertyName = "DescrizioneArt";
            this.descrizioneArtDataGridViewTextBoxColumn.HeaderText = "DescrizioneArt";
            this.descrizioneArtDataGridViewTextBoxColumn.Name = "descrizioneArtDataGridViewTextBoxColumn";
            // 
            // quantitaRichDataGridViewTextBoxColumn
            // 
            this.quantitaRichDataGridViewTextBoxColumn.DataPropertyName = "QuantitaRich";
            this.quantitaRichDataGridViewTextBoxColumn.HeaderText = "QuantitaRich";
            this.quantitaRichDataGridViewTextBoxColumn.Name = "quantitaRichDataGridViewTextBoxColumn";
            // 
            // dataConsegnaRichiestaDataGridViewTextBoxColumn
            // 
            this.dataConsegnaRichiestaDataGridViewTextBoxColumn.DataPropertyName = "DataConsegnaRichiesta";
            this.dataConsegnaRichiestaDataGridViewTextBoxColumn.HeaderText = "DataConsegnaRichiesta";
            this.dataConsegnaRichiestaDataGridViewTextBoxColumn.Name = "dataConsegnaRichiestaDataGridViewTextBoxColumn";
            // 
            // dataConsegnaConfermataDataGridViewTextBoxColumn
            // 
            this.dataConsegnaConfermataDataGridViewTextBoxColumn.DataPropertyName = "DataConsegnaConfermata";
            this.dataConsegnaConfermataDataGridViewTextBoxColumn.HeaderText = "DataConsegnaConfermata";
            this.dataConsegnaConfermataDataGridViewTextBoxColumn.Name = "dataConsegnaConfermataDataGridViewTextBoxColumn";
            // 
            // statoDataGridViewTextBoxColumn
            // 
            this.statoDataGridViewTextBoxColumn.DataPropertyName = "Stato";
            this.statoDataGridViewTextBoxColumn.HeaderText = "Stato";
            this.statoDataGridViewTextBoxColumn.Name = "statoDataGridViewTextBoxColumn";
            // 
            // prezzoKgDataGridViewTextBoxColumn
            // 
            this.prezzoKgDataGridViewTextBoxColumn.DataPropertyName = "PrezzoKg";
            this.prezzoKgDataGridViewTextBoxColumn.HeaderText = "PrezzoKg";
            this.prezzoKgDataGridViewTextBoxColumn.Name = "prezzoKgDataGridViewTextBoxColumn";
            // 
            // qtaEffettivaDataGridViewTextBoxColumn
            // 
            this.qtaEffettivaDataGridViewTextBoxColumn.DataPropertyName = "QtaEffettiva";
            this.qtaEffettivaDataGridViewTextBoxColumn.HeaderText = "QtaEffettiva";
            this.qtaEffettivaDataGridViewTextBoxColumn.Name = "qtaEffettivaDataGridViewTextBoxColumn";
            // 
            // pesoTotaleDataGridViewTextBoxColumn
            // 
            this.pesoTotaleDataGridViewTextBoxColumn.DataPropertyName = "PesoTotale";
            this.pesoTotaleDataGridViewTextBoxColumn.HeaderText = "PesoTotale";
            this.pesoTotaleDataGridViewTextBoxColumn.Name = "pesoTotaleDataGridViewTextBoxColumn";
            // 
            // prezzoALastraDataGridViewTextBoxColumn
            // 
            this.prezzoALastraDataGridViewTextBoxColumn.DataPropertyName = "PrezzoALastra";
            this.prezzoALastraDataGridViewTextBoxColumn.HeaderText = "PrezzoALastra";
            this.prezzoALastraDataGridViewTextBoxColumn.Name = "prezzoALastraDataGridViewTextBoxColumn";
            // 
            // NuovoOrdineForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 399);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "NuovoOrdineForn";
            this.Text = "Nuovo ordine a FORNITORE";
            this.Load += new System.EventHandler(this.NuovoOrdineForn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codTermPagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codModPagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codSpedizioniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornitoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordFornDettBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private Target2021DataSet target2021DataSet;
        private System.Windows.Forms.BindingSource fornitoriBindingSource;
        private Target2021DataSetTableAdapters.FornitoriTableAdapter fornitoriTableAdapter;
        private Target2021DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Target2021DataSetTableAdapters.CodSpedizioniTableAdapter codSpedizioniTableAdapter;
        private System.Windows.Forms.BindingSource codSpedizioniBindingSource;
        private Target2021DataSetTableAdapters.CodModPagamentoTableAdapter codModPagamentoTableAdapter;
        private System.Windows.Forms.BindingSource codModPagamentoBindingSource;
        private Target2021DataSetTableAdapters.CodTermPagamentoTableAdapter codTermPagamentoTableAdapter;
        private System.Windows.Forms.BindingSource codTermPagamentoBindingSource;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ordFornDettBindingSource;
        private Target2021DataSetTableAdapters.OrdFornDettTableAdapter ordFornDettTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOFDettDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOFTestataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCodiceArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrizioneArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitaRichDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataConsegnaRichiestaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataConsegnaConfermataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezzoKgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtaEffettivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoTotaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezzoALastraDataGridViewTextBoxColumn;
    }
}