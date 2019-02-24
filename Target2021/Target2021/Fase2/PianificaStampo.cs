using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Fase2
{
    public partial class PianificaStampo : Form
    {
        DataTable Schedula = new DataTable();
        string CodiceCommessa;

        public PianificaStampo()
        {
            InitializeComponent();
        }

        private void PianificaStampo_Load(object sender, EventArgs e)
        {
            AssociaDGV();
            this.schedulazioneTableAdapter.Fill(this.target2021DataSet.Schedulazione);
            this.superCommessaTableAdapter.Fill(this.target2021DataSet.SuperCommessa);
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            superCommessaBindingSource.Filter = "Stato = 0";
            WindowState = FormWindowState.Maximized;
        }

        private void AssociaDGV()
        {
            DataView CNonPianif = new DataView(target2021DataSet.Commesse);
            DataView CPianifM1 = new DataView(target2021DataSet.Commesse);
            DataView CPianifM2 = new DataView(target2021DataSet.Commesse);
            DataView CPianifM3 = new DataView(target2021DataSet.Commesse);
            CNonPianif.RowFilter = "Stato = 2";
            CPianifM1.RowFilter = "Stato = 3 AND SchedMach = 1"; // AND TipoCommessa = 2";
            CPianifM2.RowFilter = "Stato = 3 AND SchedMach = 2";
            CPianifM3.RowFilter = "Stato = 3 AND SchedMach = 3";
            commesseDataGridView.DataSource = CNonPianif;
            commesseDataGridView1.DataSource = CPianifM1;
            commesseDataGridView1.Columns["ShedOra"].DefaultCellStyle.Format = "HH:mm:ss";
            commesseDataGridView2.DataSource = CPianifM2;
            commesseDataGridView3.DataSource = CPianifM3;
            NascondiColonne();
        }

        private void NascondiColonne()
        {
            foreach (DataGridViewColumn col in commesseDataGridView.Columns)
            {
                if (col.HeaderText == "NrPezziDaLavorare") col.HeaderText = "Nr Pezzi";
                if (col.HeaderText == "IDMachStampa") col.HeaderText = "Macchina";
                if (col.HeaderText == "CodCommessa") col.HeaderText = "Comm.";
                if (col.HeaderText == "Comm." || col.HeaderText == "IDCliente" || col.HeaderText == "CodArticolo" || col.HeaderText == "Nr Pezzi" || col.HeaderText == "Macchina")
                    col.Visible = true;
                else
                    col.Visible = false;
            }

            foreach (DataGridViewColumn col in commesseDataGridView1.Columns)
            {
                if (col.HeaderText == "NrPezziDaLavorare") col.HeaderText = "Nr Pezzi";
                if (col.HeaderText == "CodCommessa" || col.HeaderText == "IDCliente" || col.HeaderText == "CodArticolo" || col.HeaderText == "Nr Pezzi" || col.HeaderText == "SchedData" || col.HeaderText == "ShedOra" || col.HeaderText == "SchedDurata")
                    col.Visible = true;
                else
                    col.Visible = false;
            }

            foreach (DataGridViewColumn col in commesseDataGridView2.Columns)
            {
                if (col.HeaderText == "NrPezziDaLavorare") col.HeaderText = "Nr Pezzi";
                if (col.HeaderText == "CodCommessa" || col.HeaderText == "IDCliente" || col.HeaderText == "CodArticolo" || col.HeaderText == "Nr Pezzi" || col.HeaderText == "SchedData" || col.HeaderText == "ShedOra" || col.HeaderText == "SchedDurata")
                    col.Visible = true;
                else
                    col.Visible = false;
            }

            foreach (DataGridViewColumn col in commesseDataGridView3.Columns)
            {
                if (col.HeaderText == "NrPezziDaLavorare") col.HeaderText = "Nr Pezzi";
                if (col.HeaderText == "CodCommessa" || col.HeaderText == "IDCliente" || col.HeaderText == "CodArticolo" || col.HeaderText == "Nr Pezzi" || col.HeaderText == "SchedData" || col.HeaderText == "ShedOra" || col.HeaderText == "SchedDurata")
                    col.Visible = true;
                else
                    col.Visible = false;
            }
        }

        private void Effetto(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Copia(object sender, MouseEventArgs e)
        {
            var colpito = commesseDataGridView.HitTest(e.X, e.Y);
            commesseDataGridView.DoDragDrop(commesseDataGridView.SelectedRows, DragDropEffects.Move);
            if (colpito.RowIndex != -1 && colpito.ColumnIndex != -1)
            {
                try
                {
                    var riga = commesseDataGridView.Rows[colpito.RowIndex];
                    if (riga != null)
                    {
                        CodiceCommessa = riga.Cells[0].Value.ToString();
                    }
                }
                catch { }
            }
        }

        private void commesseDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            commesseDataGridView.ClearSelection();
        }

        private void superCommessaDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            var colpito = superCommessaDataGridView.HitTest(e.X, e.Y);
            if (e.Clicks == 1)
            {
                superCommessaDataGridView.DoDragDrop(superCommessaDataGridView.SelectedRows, DragDropEffects.Move);
                if (colpito.RowIndex != -1 && colpito.ColumnIndex != -1)
                {
                    var riga = superCommessaDataGridView.Rows[colpito.RowIndex];
                    if (riga != null)
                    {
                        CodiceCommessa = riga.Cells[1].Value.ToString();
                    }
                }
            }
        }

        private void commesseDataGridView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataGridViewSelectedRowCollection)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void commesseDataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            DraggaEDroppa(e,1);
        }

        private void DraggaEDroppa(DragEventArgs e, int macchina)
        {
            int IdC;
            IdC = Convert.ToInt32(CodiceCommessa);
            if (e.Effect == DragDropEffects.Move && CodiceCommessa != null)
            {
                Target2021DataSet.CommesseRow Riga;
                Riga = target2021DataSet.Commesse.FindByIDCommessa(IdC);
                Riga.Stato = 3;
                Riga.SchedMach = macchina;
                commesseTableAdapter.Update(target2021DataSet.Commesse);
            }
            Aggiorna();
        }

        private void Aggiorna()
        {
            commesseDataGridView.Refresh();
            commesseDataGridView1.Refresh();
        }

        private void superCommessaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = superCommessaDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = superCommessaDataGridView.Rows[selectedrowindex];
            int Id = Convert.ToInt32(selectedRow.Cells["dataGridViewTextBoxColumn56"].Value);
            DettaglioSC Dett = new DettaglioSC(Id);
            Dett.Show();
        }

        private void commesseDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AggiornaValori(sender);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void commesseDataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AggiornaValori(sender);
        }

        private void AggiornaValori (object mittente)
        {

            DateTime ora;
            int durata;
            DateTime data;
            DataGridView Griglia = mittente as DataGridView;

            if (Griglia != null)
            {
                try
                {
                    data = Convert.ToDateTime(Griglia.SelectedCells[57].Value);
                }
                catch
                {
                    data = Convert.ToDateTime("1/1/2019");
                }

                //ora = DateTime.ParseExact(Griglia.SelectedCells[58].Value.ToString(), "HH:mm:ss", CultureInfo.InvariantCulture);
                try
                {
                    ora = Convert.ToDateTime(Griglia.SelectedCells[58].Value);
                }
                catch
                {
                    ora = DateTime.Now;
                }

                try
                {
                    durata = Convert.ToInt32(Griglia.SelectedCells[59].Value);
                }
                catch
                {
                    durata = 0;
                }

                DettPianifica DP = new DettPianifica(data, ora, durata);
                DP.ShowDialog();
                Griglia.SelectedCells[57].Value = DP.data;
                Griglia.SelectedCells[58].Value = DP.ora;
                Griglia.SelectedCells[59].Value = DP.durata;
                Griglia.SelectedCells[61].Value = DP.dataf;
                Griglia.SelectedCells[62].Value = DP.oraf;
                if (DP.elimina == 1)
                {
                    Griglia.SelectedCells[56].Value = 0;
                    Griglia.SelectedCells[57].Value = "1/1/2019";
                    Griglia.SelectedCells[58].Value = "00:00";
                    Griglia.SelectedCells[59].Value = 0;
                    Griglia.SelectedCells[49].Value = 2;
                }
            }
            this.commesseDataGridView1.Sort(commesseDataGridView1.Columns[57], ListSortDirection.Ascending);
            this.commesseDataGridView2.Sort(commesseDataGridView2.Columns[57], ListSortDirection.Ascending);
            this.commesseDataGridView3.Sort(commesseDataGridView3.Columns[57], ListSortDirection.Ascending);
            commesseTableAdapter.Update(target2021DataSet.Commesse);
            Aggiorna();
        }

        private void commesseDataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AggiornaValori(sender);
        }

        private void commesseDataGridView2_DragDrop(object sender, DragEventArgs e)
        {
            DraggaEDroppa(e,2);
        }

        private void commesseDataGridView3_DragDrop(object sender, DragEventArgs e)
        {
            DraggaEDroppa(e,3);
        }

        private void commesseDataGridView2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataGridViewSelectedRowCollection)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void commesseDataGridView3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataGridViewSelectedRowCollection)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void commesseDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void commesseDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
