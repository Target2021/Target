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
    public partial class EliminaAbbinamento : Form
    {
        DataGridViewRow riga;
        int PercUnitaria;

        public EliminaAbbinamento(DataGridViewRow R)
        {
            InitializeComponent();
            riga = R;
        }

        private void EliminaAbbinamento_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.DettArticoli'. È possibile spostarla o rimuoverla se necessario.
            this.dettArticoliTableAdapter.Fill(this.target2021DataSet.DettArticoli);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.AbbinamentiArticoli'. È possibile spostarla o rimuoverla se necessario.
            this.abbinamentiArticoliTableAdapter.Fill(this.target2021DataSet.AbbinamentiArticoli);
            int perc, qta;
            textBox1.Text = riga.Cells[2].Value.ToString();
            textBox2.Text = riga.Cells[4].Value.ToString();
            textBox3.Text = riga.Cells[3].Value.ToString();
            textBox4.Text = riga.Cells[5].Value.ToString();
            label7.Text = riga.Cells[0].Value.ToString();
            perc = Convert.ToInt32(textBox4.Text);
            qta = Convert.ToInt32(textBox3.Text);
            PercUnitaria = perc / qta;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void aggiorna()
        {
            int qta, perc;
            try
            {
                qta = Convert.ToInt32(textBox3.Text);
            }
            catch
            {
                qta = 0;
            }
            perc = PercUnitaria * qta;
            textBox4.Text = perc.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            aggiorna();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow riga;
            int ID;
            ID = Convert.ToInt32(label7.Text);
            DataTable TabellaAbbinamenti;
            TabellaAbbinamenti = target2021DataSet.Tables["AbbinamentiArticoli"];

            riga = TabellaAbbinamenti.Rows.Find(ID);
            riga.BeginEdit();
            riga["Qta"] = textBox3.Text;
            riga["Percentualelastra"] = textBox4.Text;
            riga.EndEdit();

            abbinamentiArticoliTableAdapter.Update(target2021DataSet.AbbinamentiArticoli);
            this.Close();
        }

        private void abbinamentiArticoliBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.abbinamentiArticoliBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AggiornaTAbbinamenti();
            AggiornaTDettArticoli();
            this.Close();
        }

        private void AggiornaTAbbinamenti()
        {
            int ID = Convert.ToInt32(label7.Text);
            DataRow Riga = target2021DataSet.AbbinamentiArticoli.Rows.Find(ID);
            Riga.Delete();
            abbinamentiArticoliTableAdapter.Update(target2021DataSet.AbbinamentiArticoli);
        }

        private void AggiornaTDettArticoli()
        {
            DataRow[] riga;
            riga = target2021DataSet.Tables["DettArticoli"].Select("codice_articolo='" + textBox1.Text+"'");
            foreach (DataRow r in riga)
            {
                r.BeginEdit();
                r["AbbinamentoStampo"] = 0;
                r.EndEdit();
            }
            dettArticoliTableAdapter.Update(target2021DataSet.DettArticoli);
        }
    }
}
