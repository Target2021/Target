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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.target2021DataSet9 = new Target2021.Target2021DataSet9();
            this.target2021DataSet9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MovimentiMagazzinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet9BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovimentiMagazzinoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MovimentiMagazzinoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Target2021.Report.CaricoLastre.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(835, 375);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
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
            // MovimentiMagazzinoBindingSource
            // 
            this.MovimentiMagazzinoBindingSource.DataMember = "MovimentiMagazzino";
            this.MovimentiMagazzinoBindingSource.DataSource = this.target2021DataSet9;
            // 
            // WFCaricoLastra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "WFCaricoLastra";
            this.Text = "WFCaricoLastra";
            this.Load += new System.EventHandler(this.WFCaricoLastra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet9BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovimentiMagazzinoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource MovimentiMagazzinoBindingSource;
        private Target2021DataSet9 target2021DataSet9;
        private System.Windows.Forms.BindingSource target2021DataSet9BindingSource;
    }
}