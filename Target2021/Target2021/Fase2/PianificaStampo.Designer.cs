namespace Target2021.Fase2
{
    partial class PianificaStampo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.commesseDataGridView = new System.Windows.Forms.DataGridView();
            this.superCommessaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.target2021DataSet = new Target2021.Target2021DataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.commesseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commesseTableAdapter = new Target2021.Target2021DataSetTableAdapters.CommesseTableAdapter();
            this.tableAdapterManager = new Target2021.Target2021DataSetTableAdapters.TableAdapterManager();
            this.superCommessaTableAdapter = new Target2021.Target2021DataSetTableAdapters.SuperCommessaTableAdapter();
            this.schedulazioneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schedulazioneTableAdapter = new Target2021.Target2021DataSetTableAdapters.SchedulazioneTableAdapter();
            this.commesseDataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.commesseDataGridView2 = new System.Windows.Forms.DataGridView();
            this.commesseDataGridView3 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.commesseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superCommessaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commesseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulazioneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commesseDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commesseDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commesseDataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Commesse non pianificate:";
            // 
            // commesseDataGridView
            // 
            this.commesseDataGridView.AllowDrop = true;
            this.commesseDataGridView.AllowUserToAddRows = false;
            this.commesseDataGridView.AllowUserToDeleteRows = false;
            this.commesseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commesseDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.commesseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.commesseDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.commesseDataGridView.Location = new System.Drawing.Point(6, 49);
            this.commesseDataGridView.MultiSelect = false;
            this.commesseDataGridView.Name = "commesseDataGridView";
            this.commesseDataGridView.ReadOnly = true;
            this.commesseDataGridView.RowHeadersVisible = false;
            this.commesseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.commesseDataGridView.Size = new System.Drawing.Size(565, 527);
            this.commesseDataGridView.TabIndex = 3;
            this.commesseDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.commesseDataGridView_CellContentClick);
            this.commesseDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.commesseDataGridView_DataBindingComplete);
            this.commesseDataGridView.DragEnter += new System.Windows.Forms.DragEventHandler(this.Effetto);
            this.commesseDataGridView.DragOver += new System.Windows.Forms.DragEventHandler(this.Effetto);
            this.commesseDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Copia);
            // 
            // superCommessaBindingSource
            // 
            this.superCommessaBindingSource.DataMember = "SuperCommessa";
            this.superCommessaBindingSource.DataSource = this.target2021DataSet;
            // 
            // target2021DataSet
            // 
            this.target2021DataSet.DataSetName = "Target2021DataSet";
            this.target2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(813, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Macchina di stampaggio: 1 - M05";
            // 
            // commesseBindingSource
            // 
            this.commesseBindingSource.DataMember = "Commesse";
            this.commesseBindingSource.DataSource = this.target2021DataSet;
            // 
            // commesseTableAdapter
            // 
            this.commesseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AbbinamentiArticoliTableAdapter = null;
            this.tableAdapterManager.AbbinamentiSuperCommesseTableAdapter = null;
            this.tableAdapterManager.AnaMagazziniTableAdapter = null;
            this.tableAdapterManager.ArtFornTableAdapter = null;
            this.tableAdapterManager.articoli_sempliciTableAdapter = null;
            this.tableAdapterManager.ArticoliBCTableAdapter = null;
            this.tableAdapterManager.AvvisiAbbinamentiTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientiTableAdapter = null;
            this.tableAdapterManager.CodModPagamentoTableAdapter = null;
            this.tableAdapterManager.CodSpedizioniTableAdapter = null;
            this.tableAdapterManager.CodTermPagamentoTableAdapter = null;
            this.tableAdapterManager.CommesseTableAdapter = this.commesseTableAdapter;
            this.tableAdapterManager.CompatibStampaTableAdapter = null;
            this.tableAdapterManager.CompatibTaglioTableAdapter = null;
            this.tableAdapterManager.ConfigurazioneTableAdapter = null;
            this.tableAdapterManager.dettaglio_ddtTableAdapter = null;
            this.tableAdapterManager.dettaglio_ordini_acquistoTableAdapter = null;
            this.tableAdapterManager.dettaglio_ordini_multirigaTableAdapter = null;
            this.tableAdapterManager.DettArticoliTableAdapter = null;
            this.tableAdapterManager.dimensioniTableAdapter = null;
            this.tableAdapterManager.DimeTableAdapter = null;
            this.tableAdapterManager.FasiTableAdapter = null;
            this.tableAdapterManager.FornitoriTableAdapter = null;
            this.tableAdapterManager.GiacenzeMagazziniTableAdapter = null;
            this.tableAdapterManager.ImpegnateOrdinatoTableAdapter = null;
            this.tableAdapterManager.LavorazioniTableAdapter = null;
            this.tableAdapterManager.LivelliUtenzaTableAdapter = null;
            this.tableAdapterManager.MacchineStampoTableAdapter = null;
            this.tableAdapterManager.MacchineTaglioTableAdapter = null;
            this.tableAdapterManager.MinuterieTableAdapter = null;
            this.tableAdapterManager.MovimentiMagazzinoTableAdapter = null;
            this.tableAdapterManager.OrdFornDettTableAdapter = null;
            this.tableAdapterManager.OrdFornTestTableAdapter = null;
            this.tableAdapterManager.OrdiniEsclusiTableAdapter = null;
            this.tableAdapterManager.OrdiniImportatiTableAdapter = null;
            this.tableAdapterManager.PesiSpecificiTableAdapter = null;
            this.tableAdapterManager.PosizioniDimeStampiTableAdapter = null;
            this.tableAdapterManager.PrimeTableAdapter = null;
            this.tableAdapterManager.SchedulazioneTableAdapter = null;
            this.tableAdapterManager.StampiTableAdapter = null;
            this.tableAdapterManager.SuperCommessaTableAdapter = this.superCommessaTableAdapter;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.TaglioOnLineTableAdapter = null;
            this.tableAdapterManager.TempStampTableAdapter = null;
            this.tableAdapterManager.TempTableAdapter = null;
            this.tableAdapterManager.testata_ordini_multirigaTableAdapter = null;
            this.tableAdapterManager.TipoCommessaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Target2021.Target2021DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtentiTableAdapter = null;
            // 
            // superCommessaTableAdapter
            // 
            this.superCommessaTableAdapter.ClearBeforeFill = true;
            // 
            // schedulazioneBindingSource
            // 
            this.schedulazioneBindingSource.DataMember = "Schedulazione";
            this.schedulazioneBindingSource.DataSource = this.target2021DataSet;
            // 
            // schedulazioneTableAdapter
            // 
            this.schedulazioneTableAdapter.ClearBeforeFill = true;
            // 
            // commesseDataGridView1
            // 
            this.commesseDataGridView1.AllowDrop = true;
            this.commesseDataGridView1.AllowUserToAddRows = false;
            this.commesseDataGridView1.AllowUserToDeleteRows = false;
            this.commesseDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commesseDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.commesseDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.commesseDataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.commesseDataGridView1.Location = new System.Drawing.Point(577, 49);
            this.commesseDataGridView1.MultiSelect = false;
            this.commesseDataGridView1.Name = "commesseDataGridView1";
            this.commesseDataGridView1.ReadOnly = true;
            this.commesseDataGridView1.RowHeadersVisible = false;
            this.commesseDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.commesseDataGridView1.Size = new System.Drawing.Size(781, 157);
            this.commesseDataGridView1.TabIndex = 7;
            this.commesseDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.commesseDataGridView1_CellClick);
            this.commesseDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.commesseDataGridView1_CellContentClick);
            this.commesseDataGridView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.commesseDataGridView1_DragDrop);
            this.commesseDataGridView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.commesseDataGridView1_DragEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(573, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Commesse pianificate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(813, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Macchina di stampaggio: 2 - Perros";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(813, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Macchina di stampaggio: 3 - Cannon";
            // 
            // commesseDataGridView2
            // 
            this.commesseDataGridView2.AllowDrop = true;
            this.commesseDataGridView2.AllowUserToAddRows = false;
            this.commesseDataGridView2.AllowUserToDeleteRows = false;
            this.commesseDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commesseDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.commesseDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.commesseDataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            this.commesseDataGridView2.Location = new System.Drawing.Point(577, 252);
            this.commesseDataGridView2.Name = "commesseDataGridView2";
            this.commesseDataGridView2.ReadOnly = true;
            this.commesseDataGridView2.RowHeadersVisible = false;
            this.commesseDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.commesseDataGridView2.Size = new System.Drawing.Size(781, 162);
            this.commesseDataGridView2.TabIndex = 10;
            this.commesseDataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.commesseDataGridView2_CellClick);
            this.commesseDataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.commesseDataGridView2_CellContentClick);
            this.commesseDataGridView2.DragDrop += new System.Windows.Forms.DragEventHandler(this.commesseDataGridView2_DragDrop);
            this.commesseDataGridView2.DragEnter += new System.Windows.Forms.DragEventHandler(this.commesseDataGridView2_DragEnter);
            // 
            // commesseDataGridView3
            // 
            this.commesseDataGridView3.AllowDrop = true;
            this.commesseDataGridView3.AllowUserToAddRows = false;
            this.commesseDataGridView3.AllowUserToDeleteRows = false;
            this.commesseDataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commesseDataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.commesseDataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.commesseDataGridView3.DefaultCellStyle = dataGridViewCellStyle8;
            this.commesseDataGridView3.Location = new System.Drawing.Point(577, 466);
            this.commesseDataGridView3.Name = "commesseDataGridView3";
            this.commesseDataGridView3.ReadOnly = true;
            this.commesseDataGridView3.RowHeadersVisible = false;
            this.commesseDataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.commesseDataGridView3.Size = new System.Drawing.Size(781, 160);
            this.commesseDataGridView3.TabIndex = 10;
            this.commesseDataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.commesseDataGridView3_CellClick);
            this.commesseDataGridView3.DragDrop += new System.Windows.Forms.DragEventHandler(this.commesseDataGridView3_DragDrop);
            this.commesseDataGridView3.DragEnter += new System.Windows.Forms.DragEventHandler(this.commesseDataGridView3_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "(Tasto destro per dettaglio supercommessa)";
            // 
            // PianificaStampo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1370, 598);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.commesseDataGridView3);
            this.Controls.Add(this.commesseDataGridView2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.commesseDataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.commesseDataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PianificaStampo";
            this.Text = "Pianificazione fase di Stampaggio";
            this.Load += new System.EventHandler(this.PianificaStampo_Load);
            this.Resize += new System.EventHandler(this.dimensiona);
            ((System.ComponentModel.ISupportInitialize)(this.commesseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superCommessaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commesseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulazioneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commesseDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commesseDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commesseDataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Target2021DataSet target2021DataSet;
        private System.Windows.Forms.BindingSource commesseBindingSource;
        private Target2021DataSetTableAdapters.CommesseTableAdapter commesseTableAdapter;
        private Target2021DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView commesseDataGridView;
        private Target2021DataSetTableAdapters.SuperCommessaTableAdapter superCommessaTableAdapter;
        private System.Windows.Forms.BindingSource superCommessaBindingSource;
        private System.Windows.Forms.BindingSource schedulazioneBindingSource;
        private Target2021DataSetTableAdapters.SchedulazioneTableAdapter schedulazioneTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView commesseDataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView commesseDataGridView2;
        private System.Windows.Forms.DataGridView commesseDataGridView3;
        private System.Windows.Forms.Label label2;
    }
}