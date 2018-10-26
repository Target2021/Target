namespace Target2021.Report
{
    partial class WFCaricoLastra
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.MovimentiMagazzinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.target2021DataSet9 = new Target2021.Target2021DataSet9();
            this.target2021DataSet9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.movimentiMagazzinoTableAdapter = new Target2021.Target2021DataSet9TableAdapters.MovimentiMagazzinoTableAdapter();
            this.tableAdapterManager = new Target2021.Target2021DataSet9TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.MovimentiMagazzinoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet9BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MovimentiMagazzinoBindingSource
            // 
            this.MovimentiMagazzinoBindingSource.DataMember = "MovimentiMagazzino";
            this.MovimentiMagazzinoBindingSource.DataSource = this.target2021DataSet9;
            // 
            // target2021DataSet9
            // 
            this.target2021DataSet9.DataSetName = "Target2021DataSet9";
            this.target2021DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // target2021DataSet9BindingSource
            // 
            this.target2021DataSet9BindingSource.DataSource = this.target2021DataSet9;
            this.target2021DataSet9BindingSource.Position = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MovimentiMagazzinoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Target2021.Report.CaricoLastre.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 54);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(835, 431);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomPercent = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // movimentiMagazzinoTableAdapter
            // 
            this.movimentiMagazzinoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MovimentiMagazzinoTableAdapter = this.movimentiMagazzinoTableAdapter;
            this.tableAdapterManager.PrimeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Target2021.Target2021DataSet9TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // WFCaricoLastra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 505);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "WFCaricoLastra";
            this.Text = "Stampa";
            this.Load += new System.EventHandler(this.WFCaricoLastra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MovimentiMagazzinoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet9BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource target2021DataSet9BindingSource;
        private Target2021DataSet9 target2021DataSet9;
        private System.Windows.Forms.BindingSource MovimentiMagazzinoBindingSource;
        private System.Windows.Forms.Button button1;
        private Target2021DataSet9TableAdapters.MovimentiMagazzinoTableAdapter movimentiMagazzinoTableAdapter;
        private Target2021DataSet9TableAdapters.TableAdapterManager tableAdapterManager;
    }
}