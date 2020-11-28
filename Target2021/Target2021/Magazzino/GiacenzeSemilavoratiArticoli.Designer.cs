namespace Target2021.Magazzino
{
    partial class GiacenzeSemilavoratiArticoli
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
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle1 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle2 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle3 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle4 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle5 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle6 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle7 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle8 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            this.gridDataBoundGrid1 = new Syncfusion.Windows.Forms.Grid.GridDataBoundGrid();
            this.gridDataBoundGrid2 = new Syncfusion.Windows.Forms.Grid.GridDataBoundGrid();
            this.giacenzeSemilavoratiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.target2021DataSet = new Target2021.Target2021DataSet();
            this.giacenzaFinitiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giacenzaFinitiTableAdapter = new Target2021.Target2021DataSetTableAdapters.GiacenzaFinitiTableAdapter();
            this.giacenzeSemilavoratiTableAdapter = new Target2021.Target2021DataSetTableAdapters.GiacenzeSemilavoratiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giacenzeSemilavoratiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giacenzaFinitiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDataBoundGrid1
            // 
            this.gridDataBoundGrid1.AllowDragSelectedCols = true;
            this.gridDataBoundGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gridBaseStyle1.Name = "Column Header";
            gridBaseStyle1.StyleInfo.BaseStyle = "Header";
            gridBaseStyle1.StyleInfo.CellType = "ColumnHeaderCell";
            gridBaseStyle1.StyleInfo.Enabled = false;
            gridBaseStyle1.StyleInfo.Font.Bold = false;
            gridBaseStyle1.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle2.Name = "Header";
            gridBaseStyle2.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle2.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle2.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle2.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle2.StyleInfo.CellType = "Header";
            gridBaseStyle2.StyleInfo.Font.Bold = true;
            gridBaseStyle2.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control);
            gridBaseStyle2.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle3.Name = "Standard";
            gridBaseStyle3.StyleInfo.CheckBoxOptions.CheckedValue = "True";
            gridBaseStyle3.StyleInfo.CheckBoxOptions.UncheckedValue = "False";
            gridBaseStyle3.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle4.Name = "Row Header";
            gridBaseStyle4.StyleInfo.BaseStyle = "Header";
            gridBaseStyle4.StyleInfo.CellType = "RowHeaderCell";
            gridBaseStyle4.StyleInfo.Enabled = true;
            gridBaseStyle4.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            this.gridDataBoundGrid1.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle1,
            gridBaseStyle2,
            gridBaseStyle3,
            gridBaseStyle4});
            this.gridDataBoundGrid1.DataSource = this.giacenzaFinitiBindingSource;
            this.gridDataBoundGrid1.Location = new System.Drawing.Point(12, 29);
            this.gridDataBoundGrid1.Name = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.OptimizeInsertRemoveCells = true;
            this.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid1.Size = new System.Drawing.Size(1206, 329);
            this.gridDataBoundGrid1.SmartSizeBox = false;
            this.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.gridDataBoundGrid1.TabIndex = 0;
            this.gridDataBoundGrid1.Text = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.UseListChangedEvent = true;
            this.gridDataBoundGrid1.UseRightToLeftCompatibleTextBox = true;
            // 
            // gridDataBoundGrid2
            // 
            this.gridDataBoundGrid2.AllowDragSelectedCols = true;
            this.gridDataBoundGrid2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gridBaseStyle5.Name = "Column Header";
            gridBaseStyle5.StyleInfo.BaseStyle = "Header";
            gridBaseStyle5.StyleInfo.CellType = "ColumnHeaderCell";
            gridBaseStyle5.StyleInfo.Enabled = false;
            gridBaseStyle5.StyleInfo.Font.Bold = false;
            gridBaseStyle5.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle6.Name = "Header";
            gridBaseStyle6.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle6.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle6.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle6.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle6.StyleInfo.CellType = "Header";
            gridBaseStyle6.StyleInfo.Font.Bold = true;
            gridBaseStyle6.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control);
            gridBaseStyle6.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle7.Name = "Standard";
            gridBaseStyle7.StyleInfo.CheckBoxOptions.CheckedValue = "True";
            gridBaseStyle7.StyleInfo.CheckBoxOptions.UncheckedValue = "False";
            gridBaseStyle7.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle8.Name = "Row Header";
            gridBaseStyle8.StyleInfo.BaseStyle = "Header";
            gridBaseStyle8.StyleInfo.CellType = "RowHeaderCell";
            gridBaseStyle8.StyleInfo.Enabled = true;
            gridBaseStyle8.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            this.gridDataBoundGrid2.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle5,
            gridBaseStyle6,
            gridBaseStyle7,
            gridBaseStyle8});
            this.gridDataBoundGrid2.DataSource = this.giacenzeSemilavoratiBindingSource;
            this.gridDataBoundGrid2.Location = new System.Drawing.Point(13, 365);
            this.gridDataBoundGrid2.Name = "gridDataBoundGrid2";
            this.gridDataBoundGrid2.OptimizeInsertRemoveCells = true;
            this.gridDataBoundGrid2.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid2.Size = new System.Drawing.Size(1200, 222);
            this.gridDataBoundGrid2.SmartSizeBox = false;
            this.gridDataBoundGrid2.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.gridDataBoundGrid2.TabIndex = 1;
            this.gridDataBoundGrid2.Text = "gridDataBoundGrid2";
            this.gridDataBoundGrid2.UseListChangedEvent = true;
            this.gridDataBoundGrid2.UseRightToLeftCompatibleTextBox = true;
            // 
            // giacenzeSemilavoratiBindingSource
            // 
            this.giacenzeSemilavoratiBindingSource.DataMember = "GiacenzeSemilavorati";
            this.giacenzeSemilavoratiBindingSource.DataSource = this.target2021DataSet;
            // 
            // target2021DataSet
            // 
            this.target2021DataSet.DataSetName = "Target2021DataSet";
            this.target2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giacenzaFinitiBindingSource
            // 
            this.giacenzaFinitiBindingSource.DataMember = "GiacenzaFiniti";
            this.giacenzaFinitiBindingSource.DataSource = this.target2021DataSet;
            // 
            // giacenzaFinitiTableAdapter
            // 
            this.giacenzaFinitiTableAdapter.ClearBeforeFill = true;
            // 
            // giacenzeSemilavoratiTableAdapter
            // 
            this.giacenzeSemilavoratiTableAdapter.ClearBeforeFill = true;
            // 
            // GiacenzeSemilavoratiArticoli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 599);
            this.Controls.Add(this.gridDataBoundGrid2);
            this.Controls.Add(this.gridDataBoundGrid1);
            this.Name = "GiacenzeSemilavoratiArticoli";
            this.Text = "GiacenzeSemilavoratiArticoli";
            this.Load += new System.EventHandler(this.GiacenzeSemilavoratiArticoli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giacenzeSemilavoratiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giacenzaFinitiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Grid.GridDataBoundGrid gridDataBoundGrid1;
        private Target2021DataSet target2021DataSet;
        private System.Windows.Forms.BindingSource giacenzaFinitiBindingSource;
        private Target2021DataSetTableAdapters.GiacenzaFinitiTableAdapter giacenzaFinitiTableAdapter;
        private Syncfusion.Windows.Forms.Grid.GridDataBoundGrid gridDataBoundGrid2;
        private System.Windows.Forms.BindingSource giacenzeSemilavoratiBindingSource;
        private Target2021DataSetTableAdapters.GiacenzeSemilavoratiTableAdapter giacenzeSemilavoratiTableAdapter;
    }
}