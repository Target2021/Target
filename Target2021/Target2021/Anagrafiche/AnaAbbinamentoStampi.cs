using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Anagrafiche
{
    public partial class AnaAbbinamentoStampi : Form
    {
        public AnaAbbinamentoStampi()
        {
            InitializeComponent();
        }

        private void abbinamentiArticoliBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.abbinamentiArticoliBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void AnaAbbinamentoStampi_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.DettArticoli'. È possibile spostarla o rimuoverla se necessario.
            this.dettArticoliTableAdapter.Fill(this.target2021DataSet.DettArticoli);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.AbbinamentiArticoli'. È possibile spostarla o rimuoverla se necessario.
            this.abbinamentiArticoliTableAdapter.Fill(this.target2021DataSet.AbbinamentiArticoli);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.AbbinamentiArticoli'. È possibile spostarla o rimuoverla se necessario.
            this.abbinamentiArticoliTableAdapter.Fill(this.target2021DataSet.AbbinamentiArticoli);

        }

        private void abbinamentiArticoliBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.abbinamentiArticoliBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Id Abbinamento") abbinamentiArticoliBindingSource.Filter = "IdAbbinamento = " + textBox1.Text;
            }
            catch
            {
                abbinamentiArticoliBindingSource.RemoveFilter();
            }
            if (comboBox1.Text == "Codice Articolo") abbinamentiArticoliBindingSource.Filter = "codice_articolo LIKE '%" + textBox1.Text + "%'";
        }

        private void abbinamentiArticoliDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            abbinamentiArticoliDataGridView.Rows[e.RowIndex].Selected = true;
        }

        private void eliminaRigaToolStripMenuItem_Click(object sender, EventArgs e)
        {       
            Elimina();
        }

        private void Elimina()
        {
            // Imposta nella tabella DettArticoli per l'articolo selezionato il campo AbbinamentoStampo=0
            string CodArt = abbinamentiArticoliDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            DataRow[] RigaTrovata;
            RigaTrovata = target2021DataSet.Tables["DettArticoli"].Select("codice_articolo = '" + CodArt + "'");

            if (RigaTrovata.Length == 0)
            {
                MessageBox.Show("Articolo "+CodArt+" non trovato");
            }
            else
            {
                foreach (DataRow riga in RigaTrovata)
                {
                    riga.BeginEdit();
                    riga["AbbinamentoStampo"] = 0;
                    riga.EndEdit();
                    dettArticoliTableAdapter.Update(target2021DataSet.DettArticoli);
                }
            }
            // Elimina la riga selezionata dalla Tabella AbbinamentiArticoli
            int nriga = abbinamentiArticoliDataGridView.SelectedRows[0].Index;
            target2021DataSet.Tables["AbbinamentiArticoli"].Rows[nriga].Delete();
            abbinamentiArticoliTableAdapter.Update(target2021DataSet.AbbinamentiArticoli);
            MessageBox.Show("Riga eliminata correttamente!");
        }

    }
}
