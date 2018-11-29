using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Fase3
{
    public partial class SelezionaCommessaDaStampare : Form
    {
        private int nm;

        public SelezionaCommessaDaStampare(int nmach)
        {
            InitializeComponent();
            nm = nmach;
            textBox1.Text = nm.ToString();
        }

        private void SelezionaCommessaDaStampare_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            DataView CPianifM1 = new DataView(target2021DataSet.Commesse);
            CPianifM1.RowFilter = "Stato = 3 AND SchedMach = 1";
            commesseDataGridView1.DataSource = CPianifM1;
            NascondiColonne();
        }


        private void NascondiColonne()
        {
            foreach (DataGridViewColumn col in commesseDataGridView1.Columns)
            {
                if (col.HeaderText == "NrPezziDaLavorare") col.HeaderText = "Nr Pezzi";
                if (col.HeaderText == "CodCommessa" || col.HeaderText == "IDCliente" || col.HeaderText == "CodArticolo" || col.HeaderText == "Nr Pezzi" || col.HeaderText == "SchedData" || col.HeaderText == "ShedOra" || col.HeaderText == "SchedDurata")
                    col.Visible = true;
                else
                    col.Visible = false;
            }
        }

        private void commesseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commesseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void commesseDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //IDSC = Convert.ToInt32(superCommessaDataGridView.SelectedRows[0].Cells[0].Value);
            //abbinamentiSuperCommesseBindingSource.Filter = "IdSuperCommessa = " + IDSC.ToString();
            //abbinamentiSuperCommesseDataGridView.ClearSelection();
        }
    }
}
