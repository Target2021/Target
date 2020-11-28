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
    public partial class ElencoCommesseInSC : Form
    {
        private string Cod, CodArt, CodCom, DesCom;
        public string CCommessa {get; set;}
        public string CArticolo { get; set; }
        public string DArticolo { get; set; }

        public ElencoCommesseInSC(string Codice)
        {
            InitializeComponent();
            Cod = Codice;
        }

        private void ElencoCommesseInSC_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.VistaSuperCommesse'. È possibile spostarla o rimuoverla se necessario.
            this.vistaSuperCommesseTableAdapter.Fill(this.target2021DataSet.VistaSuperCommesse);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.AbbinamentiSuperCommesse'. È possibile spostarla o rimuoverla se necessario.
            this.abbinamentiSuperCommesseTableAdapter.Fill(this.target2021DataSet.AbbinamentiSuperCommesse);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.SuperCommessa'. È possibile spostarla o rimuoverla se necessario.
            this.superCommessaTableAdapter.Fill(this.target2021DataSet.SuperCommessa);
            int risultato;
            textBox1.Text = Cod.Trim();
            string filtro = "CodiceSuperCommessa = '" + Cod + "'";
            risultato = (int)target2021DataSet.SuperCommessa.Compute("MAX(IdSuperCommessa)", filtro);
            textBox2.Text = risultato.ToString();
            vistaSuperCommesseBindingSource.Filter = "IdSuperCommessa = " + risultato.ToString(); 
        }

        private void vistaSuperCommesseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vistaSuperCommesseDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // recupera il codice articolo della riga selezionata
            CodArt = vistaSuperCommesseDataGridView.Rows[e.RowIndex].Cells["CodArtiDopoStampo"].Value.ToString();
            CodCom = vistaSuperCommesseDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"].Value.ToString();
            DesCom = vistaSuperCommesseDataGridView.Rows[e.RowIndex].Cells["DescrArticolo"].Value.ToString();
            this.CArticolo = CodArt;
            this.CCommessa = CodCom;
            this.DArticolo = DesCom;
            this.Close();
        }

        private void superCommessaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.superCommessaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void vistaSuperCommesseDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // recupera il codice articolo della riga selezionata
            CodArt = vistaSuperCommesseDataGridView.Rows[e.RowIndex].Cells["CodArtiDopoStampo"].Value.ToString();
            CodCom = vistaSuperCommesseDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"].Value.ToString();
            DesCom = vistaSuperCommesseDataGridView.Rows[e.RowIndex].Cells["DescrArticolo"].Value.ToString();
            this.CArticolo = CodArt;
            this.CCommessa = CodCom;
            this.DArticolo = DesCom;
            this.Close();
        }
    }
}
