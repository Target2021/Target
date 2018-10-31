namespace Target2021.Stampe
{
    partial class StampaOrdFor
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
            this.ordFornDettBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.target2021DataSet = new Target2021.Target2021DataSet();
            this.ordFornDettTableAdapter = new Target2021.Target2021DataSetTableAdapters.OrdFornDettTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ordFornDettBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ordFornDettBindingSource
            // 
            this.ordFornDettBindingSource.DataMember = "OrdFornDett";
            this.ordFornDettBindingSource.DataSource = this.target2021DataSet;
            // 
            // target2021DataSet
            // 
            this.target2021DataSet.DataSetName = "Target2021DataSet";
            this.target2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordFornDettTableAdapter
            // 
            this.ordFornDettTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ordFornDettBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Target2021.Report.OrdForn.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // StampaOrdFor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "StampaOrdFor";
            this.Text = "Stampa Ordine a Fornitore";
            this.Load += new System.EventHandler(this.StampaOrdFor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordFornDettBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Target2021DataSet target2021DataSet;
        private System.Windows.Forms.BindingSource ordFornDettBindingSource;
        private Target2021DataSetTableAdapters.OrdFornDettTableAdapter ordFornDettTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}