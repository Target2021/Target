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
    public partial class EliminaSC : Form
    {
        int IDSC;

        public EliminaSC()
        {
            InitializeComponent();
        }

        private void superCommessaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.superCommessaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }

        private void EliminaSC_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            this.abbinamentiSuperCommesseTableAdapter.Fill(this.target2021DataSet.AbbinamentiSuperCommesse);
            this.superCommessaTableAdapter.Fill(this.target2021DataSet.SuperCommessa);
            superCommessaBindingSource.Filter = "Stato = 0";
            abbinamentiSuperCommesseBindingSource.Filter = "IdSuperCommessa = null";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Da tutte le righe di Commessa con IDCommessa = ... Stato = 2
            AggiornaStatoCommesse();          
            // Da Tabella SuperCommessa elimina 1 riga con IdSuperCommessa = ...
            EliminaSuperCommessa();
            // Da Tabella AbbinamentiSuperCommessa elimina tutte le righe con IdSuperCommessa = ...
            EliminaAbbinamenti();
            MessageBox.Show("SuperCommessa di stampaggio eliminata correttamente!");
        }

        private void AggiornaStatoCommesse()
        {
            int IdC;
            Target2021DataSet.CommesseRow Riga;
            foreach (DataGridViewRow row in abbinamentiSuperCommesseDataGridView.Rows)
            {
                IdC = Convert.ToInt32(row.Cells[2].Value);
                Riga = target2021DataSet.Commesse.FindByIDCommessa(IdC);
                Riga.Stato = 2;
                Riga.InSupercommessa = 0;
            }
            commesseTableAdapter.Update(target2021DataSet.Commesse);
        }

        private void EliminaSuperCommessa()
        {
            DataRow[] Riga = target2021DataSet.SuperCommessa.Select("IdSuperCommessa = " + IDSC.ToString());
            Riga[0].Delete();
            superCommessaTableAdapter.Update(target2021DataSet.SuperCommessa);
        }

        private void EliminaAbbinamenti()
        {
            DataRow[] Riga = target2021DataSet.AbbinamentiSuperCommesse.Select("IdSuperCommessa = " + IDSC.ToString());
            foreach (DataRow R in Riga)
            {
                R.Delete();
            }
            abbinamentiSuperCommesseTableAdapter.Update(target2021DataSet.AbbinamentiSuperCommesse);
        }

        private void superCommessaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Visualizza tutte le Commesse collegate alla SuperCommessa selezionata
            IDSC = Convert.ToInt32(superCommessaDataGridView.SelectedRows[0].Cells[0].Value);
            abbinamentiSuperCommesseBindingSource.Filter = "IdSuperCommessa = "+IDSC.ToString();
            abbinamentiSuperCommesseDataGridView.ClearSelection();
        }

        private void superCommessaDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            superCommessaDataGridView.ClearSelection();
        }
    }
}
