using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Magazzino
{
    public partial class AllineaDDT : Form
    {
        public AllineaDDT()
        {
            InitializeComponent();
        }

        private void dettaglio_ddtBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dettaglio_ddtBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void AllineaDDT_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.MovimentiMagazzino'. È possibile spostarla o rimuoverla se necessario.
            this.movimentiMagazzinoTableAdapter.Fill(this.target2021DataSet.MovimentiMagazzino);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.dettaglio_ddt'. È possibile spostarla o rimuoverla se necessario.
            this.dettaglio_ddtTableAdapter.Fill(this.target2021DataSet.dettaglio_ddt);
            int anno;
            anno = DateTime.Now.Year;
            comboBox1.Text = anno.ToString();
            filtra();
        }

        private void filtra()
        {
            dettaglio_ddtBindingSource.Filter = "data_ddt > '" + comboBox1.Text + "0000'";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtra();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int importato = 0, esito = 0;
            int DataDDT, NumDDT, ProgrDDT, Qta;
            Double Prezzo;
            string CodArt, Causale;
            // Controlla Le nuove importazioni (per ogni riga)
            foreach (DataGridViewRow riga in dettaglio_ddtDataGridView.Rows)
            {
                // Se importato: data_preventivo_prov = 1 altrimenti = 0
                importato = Convert.ToInt32(riga.Cells["Importato"].Value);
                if (importato==0)   // Non è già stato importato in precedenza
                {
                    DataDDT = Convert.ToInt32(riga.Cells["DataDDT"].Value);
                    NumDDT = Convert.ToInt32(riga.Cells["NumDDT"].Value);
                    ProgrDDT = Convert.ToInt32(riga.Cells["ProgrDDT"].Value);
                    CodArt = riga.Cells["CodArt"].Value.ToString();
                    Qta = Convert.ToInt32(riga.Cells["Qta"].Value);
                    Prezzo = Convert.ToDouble(riga.Cells["Prezzo"].Value);
                    Causale = "Ordine cliente nr: " + riga.Cells["NrOrdine"].Value.ToString();
                    // Crea: A) Moviemento di Scarico in 'MovimentiMagazzino' valorizzando Data, Numero e progressivo DDT
                    esito = InserisciMovimento(DataDDT, NumDDT, ProgrDDT, CodArt, Qta, Prezzo, Causale);
                    //       B) Aggiorna GiacenzeMagazzino (se non esiste lo crea)

                    //       C) Aggiorno lo stato 'Importato' a 1 nel MDB e in locale
                }
                else
                {
                // Se è = 1
                // Recupera da 'dettagio_ddt' Codice Articolo, Data, Numero, Progressivo e quantità
                    // Cerca in 'MovimentiMagazzino' se c'è una riga che contiene quei dati (se non c'è nulla)
                    // Se la riga c'è confronta se la quantità della riga è uguale
                        // Se è uguale OK (non fare nulla)
                        // Se è diversa: A) Modificare il valore qta della riga di MovimentiMagazzino
                                       //B) Modificare la giacenza per quell'articolo
                }
            }
            // Visualizza in un messagebox info su attività di importazione effettuate
        }

        private int InserisciMovimento(int DataDDT, int NumDDT, int ProgrDDT, string CodArt, int Qta, double Prezzo, string Causale)
        {
            Target2021DataSet.MovimentiMagazzinoRow riga = target2021DataSet.MovimentiMagazzino.NewMovimentiMagazzinoRow();
            riga.idMagazzino = 5;
            riga.idArticoli = CodArt;
            riga.CarScar = "S";
            riga.Quantita = Qta;
            riga.DataOraMovimento = DateTime.Now;
            riga.PrezzoComplessivoMateriaPrima = Prezzo;
            riga.Causale = Causale;
            riga.DataDDT = DataDDT;
            riga.NumeroDDT = NumDDT;
            riga.ProgressivoRigaDDT = ProgrDDT;
            target2021DataSet.MovimentiMagazzino.Rows.Add(riga);
            movimentiMagazzinoTableAdapter.Update(target2021DataSet.MovimentiMagazzino);
            return 0;
        }
    }
}
