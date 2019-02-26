﻿using System;
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
    public partial class AnaOrdiniImportati : Form
    {
        public AnaOrdiniImportati()
        {
            InitializeComponent();
        }

        private void ordiniImportatiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordiniImportatiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void AnaOrdiniImportati_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.OrdiniImportati'. È possibile spostarla o rimuoverla se necessario.
            this.ordiniImportatiTableAdapter.Fill(this.target2021DataSet.OrdiniImportati);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Posizione, NumOrd;
            DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler eliminare l'importazione  degli ordini selezionati?", "Eliminazione importazione ordine", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in ordiniImportatiDataGridView.SelectedRows)
                {
                    Posizione = row.Index;
                    textBox1.AppendText("Riga: " + Posizione.ToString() + Environment.NewLine);
                    NumOrd = (int)ordiniImportatiDataGridView.Rows[Posizione].Cells[3].Value;
                    textBox1.AppendText("Ordine numero: " + row.Index.ToString() + Environment .NewLine);
                    int risultato;
                    string filtro = "NrCommessa = " + NumOrd;
                    risultato = (int)target2021DataSet.Commesse.Compute("MAX(Stato)", filtro);
                    if (risultato>0)
                    {
                        MessageBox.Show("Impossibile eliminare l'importazione dell'ordine " + NumOrd.ToString() + "! Non tutte le righe sono in Stato 0!");
                    }
                    else
                    {
                        // Prima elimino le righe della tabella Commesse
                        DataRow[] Riga = target2021DataSet.Commesse.Select("NrCommessa = " + NumOrd.ToString());
                        foreach (DataRow R in Riga)
                        {
                            R.Delete();
                        }
                        commesseTableAdapter.Update(target2021DataSet.Commesse);
                        // Poi elimino la riga dalla tabella OrdiniImportati
                        DataRow[] Riga2 = target2021DataSet.OrdiniImportati.Select("Numero = " + NumOrd.ToString());
                        foreach (DataRow R in Riga2)
                        {
                            R.Delete();
                        }
                        ordiniImportatiTableAdapter.Update(target2021DataSet.OrdiniImportati);
                        MessageBox.Show("Importazione ordine "+NumOrd .ToString()+" eliminata con successo!");
                    }
                    
                }              
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
