namespace Target2021
{
    partial class MonitoraTaglio
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
            System.Windows.Forms.Label progTaglio1Label;
            System.Windows.Forms.Label secondiCiclo1Label;
            System.Windows.Forms.Label numPezzi1Label;
            System.Windows.Forms.Label progTaglio2Label;
            System.Windows.Forms.Label secondiCiclo2Label;
            System.Windows.Forms.Label numPezzi2Label;
            this.target2021DataSet = new Target2021.Target2021DataSet();
            this.taglioOnLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taglioOnLineTableAdapter = new Target2021.Target2021DataSetTableAdapters.TaglioOnLineTableAdapter();
            this.tableAdapterManager = new Target2021.Target2021DataSetTableAdapters.TableAdapterManager();
            this.progTaglio1TextBox = new System.Windows.Forms.TextBox();
            this.secondiCiclo1TextBox = new System.Windows.Forms.TextBox();
            this.numPezzi1TextBox = new System.Windows.Forms.TextBox();
            this.progTaglio2TextBox = new System.Windows.Forms.TextBox();
            this.secondiCiclo2TextBox = new System.Windows.Forms.TextBox();
            this.numPezzi2TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            progTaglio1Label = new System.Windows.Forms.Label();
            secondiCiclo1Label = new System.Windows.Forms.Label();
            numPezzi1Label = new System.Windows.Forms.Label();
            progTaglio2Label = new System.Windows.Forms.Label();
            secondiCiclo2Label = new System.Windows.Forms.Label();
            numPezzi2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taglioOnLineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // target2021DataSet
            // 
            this.target2021DataSet.DataSetName = "Target2021DataSet";
            this.target2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taglioOnLineBindingSource
            // 
            this.taglioOnLineBindingSource.DataMember = "TaglioOnLine";
            this.taglioOnLineBindingSource.DataSource = this.target2021DataSet;
            // 
            // taglioOnLineTableAdapter
            // 
            this.taglioOnLineTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.MacchineTaglioTableAdapter = null;
            this.tableAdapterManager.MinuterieTableAdapter = null;
            this.tableAdapterManager.MovimentiMagazzinoTableAdapter = null;
            this.tableAdapterManager.PrimeTableAdapter = null;
            this.tableAdapterManager.StampiTableAdapter = null;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.TaglioOnLineTableAdapter = this.taglioOnLineTableAdapter;
            this.tableAdapterManager.testata_ordini_multirigaTableAdapter = null;
            this.tableAdapterManager.TipoCommessaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Target2021.Target2021DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtentiTableAdapter = null;
            // 
            // progTaglio1Label
            // 
            progTaglio1Label.AutoSize = true;
            progTaglio1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            progTaglio1Label.Location = new System.Drawing.Point(61, 56);
            progTaglio1Label.Name = "progTaglio1Label";
            progTaglio1Label.Size = new System.Drawing.Size(96, 18);
            progTaglio1Label.TabIndex = 3;
            progTaglio1Label.Text = "Prog Taglio1:";
            // 
            // progTaglio1TextBox
            // 
            this.progTaglio1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taglioOnLineBindingSource, "ProgTaglio1", true));
            this.progTaglio1TextBox.Enabled = false;
            this.progTaglio1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progTaglio1TextBox.Location = new System.Drawing.Point(180, 53);
            this.progTaglio1TextBox.Name = "progTaglio1TextBox";
            this.progTaglio1TextBox.Size = new System.Drawing.Size(100, 24);
            this.progTaglio1TextBox.TabIndex = 4;
            // 
            // secondiCiclo1Label
            // 
            secondiCiclo1Label.AutoSize = true;
            secondiCiclo1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            secondiCiclo1Label.Location = new System.Drawing.Point(61, 82);
            secondiCiclo1Label.Name = "secondiCiclo1Label";
            secondiCiclo1Label.Size = new System.Drawing.Size(112, 18);
            secondiCiclo1Label.TabIndex = 5;
            secondiCiclo1Label.Text = "Secondi Ciclo1:";
            // 
            // secondiCiclo1TextBox
            // 
            this.secondiCiclo1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taglioOnLineBindingSource, "SecondiCiclo1", true));
            this.secondiCiclo1TextBox.Enabled = false;
            this.secondiCiclo1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondiCiclo1TextBox.Location = new System.Drawing.Point(180, 79);
            this.secondiCiclo1TextBox.Name = "secondiCiclo1TextBox";
            this.secondiCiclo1TextBox.Size = new System.Drawing.Size(100, 24);
            this.secondiCiclo1TextBox.TabIndex = 6;
            // 
            // numPezzi1Label
            // 
            numPezzi1Label.AutoSize = true;
            numPezzi1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numPezzi1Label.Location = new System.Drawing.Point(61, 108);
            numPezzi1Label.Name = "numPezzi1Label";
            numPezzi1Label.Size = new System.Drawing.Size(93, 18);
            numPezzi1Label.TabIndex = 7;
            numPezzi1Label.Text = "Num Pezzi1:";
            // 
            // numPezzi1TextBox
            // 
            this.numPezzi1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taglioOnLineBindingSource, "NumPezzi1", true));
            this.numPezzi1TextBox.Enabled = false;
            this.numPezzi1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPezzi1TextBox.Location = new System.Drawing.Point(180, 105);
            this.numPezzi1TextBox.Name = "numPezzi1TextBox";
            this.numPezzi1TextBox.Size = new System.Drawing.Size(100, 24);
            this.numPezzi1TextBox.TabIndex = 8;
            // 
            // progTaglio2Label
            // 
            progTaglio2Label.AutoSize = true;
            progTaglio2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            progTaglio2Label.Location = new System.Drawing.Point(318, 56);
            progTaglio2Label.Name = "progTaglio2Label";
            progTaglio2Label.Size = new System.Drawing.Size(96, 18);
            progTaglio2Label.TabIndex = 9;
            progTaglio2Label.Text = "Prog Taglio2:";
            // 
            // progTaglio2TextBox
            // 
            this.progTaglio2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taglioOnLineBindingSource, "ProgTaglio2", true));
            this.progTaglio2TextBox.Enabled = false;
            this.progTaglio2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progTaglio2TextBox.Location = new System.Drawing.Point(437, 53);
            this.progTaglio2TextBox.Name = "progTaglio2TextBox";
            this.progTaglio2TextBox.Size = new System.Drawing.Size(100, 24);
            this.progTaglio2TextBox.TabIndex = 10;
            // 
            // secondiCiclo2Label
            // 
            secondiCiclo2Label.AutoSize = true;
            secondiCiclo2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            secondiCiclo2Label.Location = new System.Drawing.Point(318, 82);
            secondiCiclo2Label.Name = "secondiCiclo2Label";
            secondiCiclo2Label.Size = new System.Drawing.Size(112, 18);
            secondiCiclo2Label.TabIndex = 11;
            secondiCiclo2Label.Text = "Secondi Ciclo2:";
            // 
            // secondiCiclo2TextBox
            // 
            this.secondiCiclo2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taglioOnLineBindingSource, "SecondiCiclo2", true));
            this.secondiCiclo2TextBox.Enabled = false;
            this.secondiCiclo2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondiCiclo2TextBox.Location = new System.Drawing.Point(437, 79);
            this.secondiCiclo2TextBox.Name = "secondiCiclo2TextBox";
            this.secondiCiclo2TextBox.Size = new System.Drawing.Size(100, 24);
            this.secondiCiclo2TextBox.TabIndex = 12;
            // 
            // numPezzi2Label
            // 
            numPezzi2Label.AutoSize = true;
            numPezzi2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numPezzi2Label.Location = new System.Drawing.Point(318, 108);
            numPezzi2Label.Name = "numPezzi2Label";
            numPezzi2Label.Size = new System.Drawing.Size(93, 18);
            numPezzi2Label.TabIndex = 13;
            numPezzi2Label.Text = "Num Pezzi2:";
            // 
            // numPezzi2TextBox
            // 
            this.numPezzi2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taglioOnLineBindingSource, "NumPezzi2", true));
            this.numPezzi2TextBox.Enabled = false;
            this.numPezzi2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPezzi2TextBox.Location = new System.Drawing.Point(437, 105);
            this.numPezzi2TextBox.Name = "numPezzi2TextBox";
            this.numPezzi2TextBox.Size = new System.Drawing.Size(100, 24);
            this.numPezzi2TextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(224, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "AGGIORNA";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MonitoraTaglio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 195);
            this.Controls.Add(this.button1);
            this.Controls.Add(progTaglio1Label);
            this.Controls.Add(this.progTaglio1TextBox);
            this.Controls.Add(secondiCiclo1Label);
            this.Controls.Add(this.secondiCiclo1TextBox);
            this.Controls.Add(numPezzi1Label);
            this.Controls.Add(this.numPezzi1TextBox);
            this.Controls.Add(progTaglio2Label);
            this.Controls.Add(this.progTaglio2TextBox);
            this.Controls.Add(secondiCiclo2Label);
            this.Controls.Add(this.secondiCiclo2TextBox);
            this.Controls.Add(numPezzi2Label);
            this.Controls.Add(this.numPezzi2TextBox);
            this.Name = "MonitoraTaglio";
            this.Text = "MonitoraTaglio";
            this.Load += new System.EventHandler(this.MonitoraTaglio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taglioOnLineBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Target2021DataSet target2021DataSet;
        private System.Windows.Forms.BindingSource taglioOnLineBindingSource;
        private Target2021DataSetTableAdapters.TaglioOnLineTableAdapter taglioOnLineTableAdapter;
        private Target2021DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox progTaglio1TextBox;
        private System.Windows.Forms.TextBox secondiCiclo1TextBox;
        private System.Windows.Forms.TextBox numPezzi1TextBox;
        private System.Windows.Forms.TextBox progTaglio2TextBox;
        private System.Windows.Forms.TextBox secondiCiclo2TextBox;
        private System.Windows.Forms.TextBox numPezzi2TextBox;
        private System.Windows.Forms.Button button1;
    }
}