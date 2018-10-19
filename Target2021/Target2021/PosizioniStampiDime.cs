using DgvFilterPopup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;

namespace Target2021
{
    public partial class PosizioniStampiDime : Form
    {
        public PosizioniStampiDime()
        {
            InitializeComponent();
        }

        private void stampiDimeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stampiDimeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void PosizioniStampiDime_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.StampiDime'. È possibile spostarla o rimuoverla se necessario.
            this.stampiDimeTableAdapter.Fill(this.target2021DataSet.StampiDime);
            //DgvFilterManager filterManager = new DgvFilterManager(stampiDimeDataGridView);
        }

        private void stampiDimeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.stampiDimeDataGridView.Sort(this.stampiDimeDataGridView.Columns[e.ColumnIndex], ListSortDirection.Ascending);
        }

        private void copyAlltoClipboard()
        {
            stampiDimeDataGridView.SelectAll();
            DataObject dataObj = stampiDimeDataGridView.GetClipboardContent();
            if (dataObj != null)
            Clipboard.SetDataObject(dataObj);
        }

        private void button1_Click(object sender, EventArgs e)
        {
                copyAlltoClipboard();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Microsoft.Office.Interop.Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}
