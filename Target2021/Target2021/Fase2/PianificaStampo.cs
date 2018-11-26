using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            this.schedulazioneTableAdapter.Fill(this.target2021DataSet.Schedulazione);
            this.superCommessaTableAdapter.Fill(this.target2021DataSet.SuperCommessa);
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            commesseBindingSource.Filter = "Stato = 2";
            superCommessaBindingSource.Filter = "Stato = 0";
            CreaTabellaSchedulazione();
            commesseDataGridView.CurrentCell.Selected = false;
        }

        private void CreaTabellaSchedulazione()
        {
            Schedula.Clear();
            Schedula.Columns.Add("Commessa", typeof(string));
            Schedula.Columns.Add("Macchina", typeof(int));
            Schedula.Columns.Add("Data", typeof(string));
            Schedula.Columns.Add("Ora", typeof(string));
            Schedula.Columns.Add("Durata", typeof(int));
            dataGridView1.DataSource = Schedula;
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
                var riga = commesseDataGridView.Rows[colpito.RowIndex];
                if (riga != null)
                {
                    CodiceCommessa = riga.Cells["dataGridViewTextBoxColumn2"].Value.ToString();
                }
            }
        }

        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataGridViewSelectedRowCollection)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            DataRow Elemento = Schedula.NewRow();
            Elemento["Commessa"] = CodiceCommessa;
            Elemento["Durata"] = 300;
            Schedula.Rows.Add(Elemento);
            dataGridView1.DataSource = Schedula;
            dataGridView1.Refresh();
            //commesseDataGridView.Rows.Remove(row);
        }

        private void commesseDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            commesseDataGridView.ClearSelection();
        }
    }
}
