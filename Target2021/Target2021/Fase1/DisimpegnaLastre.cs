using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Fase1
{
    public partial class DisimpegnaLastre : Form
    {
        public DisimpegnaLastre()
        {
            InitializeComponent();
        }

        private void DisimpegnaLastre_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.GiacenzeMagazzini'. È possibile spostarla o rimuoverla se necessario.
            this.giacenzeMagazziniTableAdapter.Fill(this.target2021DataSet.GiacenzeMagazzini);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            PopolaGridView();
        }

        private void PopolaGridView()
        {
            // Popola il GV con elenco commesse (in qualsiasi stato) con ImpegnataMatPrima > 0 e TipoCommessa = 1
            commesseBindingSource.Filter = "ImpegnataMatPrima > 0 AND TipoCommessa = 1 AND Stato<4";
        }

        private void commesseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commesseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Posizione, NumCom, NrLastreImpegnate, GiacDisp, GiacImp;
            string CodLastra;
            DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler disimpegnare le lastre per la commessa selezionata?", "Disimpegno lastre", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in commesseDataGridView.SelectedRows)
                {
                    Posizione = row.Index;
                    NumCom = (int)commesseDataGridView.Rows[Posizione].Cells[2].Value;
                    // Aggiornare tabella GiacenzeMagazzino
                    NrLastreImpegnate = (int)commesseDataGridView.Rows[Posizione].Cells[49].Value;
                    CodLastra = (string)commesseDataGridView.Rows[Posizione].Cells[22].Value;
                    DataRow[] Giacenze;
                    Giacenze = target2021DataSet.Tables["GiacenzeMagazzini"].Select("idPrime = '" + CodLastra + "'");
                    foreach (DataRow R2 in Giacenze)
                    {
                        GiacDisp = Convert.ToInt32(R2["GiacenzaDisponibili"]);
                        GiacImp = Convert.ToInt32(R2["GiacenzaImpegnati"]);
                        GiacDisp = GiacDisp + NrLastreImpegnate;
                        GiacImp = GiacImp - NrLastreImpegnate;
                        R2["GiacenzaDisponibili"] = GiacDisp;
                        R2["GiacenzaImpegnati"] = GiacImp;
                        giacenzeMagazziniTableAdapter.Update(target2021DataSet.GiacenzeMagazzini);
                    }
                    // Aggiornare tabella Commesse
                    DataRow[] Riga = target2021DataSet.Commesse.Select("TipoCommessa = 1 AND NrCommessa = " + NumCom.ToString());
                    foreach (DataRow R in Riga)
                    {
                        R["Stato"] = 0;
                        R["ImpegnataMatPrima"] = 0;
                        R["EvasoParziale"] = false;
                    }
                    commesseTableAdapter.Update(target2021DataSet.Commesse);
                    MessageBox.Show("Disimpegnate le lastre dalla commessa " + NumCom.ToString());
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            PopolaGridView();
        }
    }

}
