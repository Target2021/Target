using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Fornitori
{
    public partial class ArrivoMerce : Form
    {
        public ArrivoMerce()
        {
            InitializeComponent();
        }

        private void ordFornTestBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordFornTestBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void ArrivoMerce_Load(object sender, EventArgs e)
        {
            this.ordFornTestTableAdapter.Fill(this.target2021DataSet.OrdFornTest);
            filtra();
        }

        private void filtra()
        {
            ordFornTestBindingSource.Filter = "StatoOrdine = 0 OR StatoOrdine = 1";
        }

        private void selezionata(object sender, DataGridViewCellEventArgs e)
        {
            int NrOrd;
            NrOrd = Convert.ToInt32(ordFornTestDataGridView.Rows[e.RowIndex].Cells[11].Value);
            //MessageBox.Show(NrOrd.ToString());
            dettaglio(NrOrd);
        }

        private void dettaglio(int NrOrdine)
        {
            this.ordFornDettTableAdapter.Fill(this.target2021DataSet.OrdFornDett);
            ordFornDettBindingSource.Filter = "Stato=0 AND idOFTestata = " + NrOrdine.ToString();

        }

        private void SelezionataRigaOrdine(object sender, DataGridViewCellEventArgs e)
        {
            int IdDettaglio= Convert.ToInt32(ordFornDettDataGridView.Rows[e.RowIndex].Cells[11].Value);
            // Arrivano 300 lastre dell'ordine a fornitore nr. 1
            // 220 erano impegnate su ordinato sulla commessa con ID = 1
            // Quindi: a) 300-220 = movimento automatico di carico a magazzino
            //      b) OrdFornDett chiudo la riga e:
            //          b1) Stato=2
            //          b2) Registro prezzo al kg?
            //          b3) Registro quantità effettiva?
            //          b4) Registro la data di arrivo? (serve creare campo ne DB)
            //          b5) Calcolo il prezzo a lastra?
            //      c) OrdFornTest
            //          c1) Incremento tutti gli importi?
            //          c2) Imposto lo stato = 1 se altre righe e 2 se unica riga?
            //      d) ImpegnateOrdinato -> Io non lo toccherei
            //      e) GiacenzeMagazzini
            //          e1) aggiorno i 5 valori delle giacenze (in sostanza tolgo 220 da giacenzesuordinato
            //              e aggiunto 300 su giacenzacomplessiva, 220 su giacenzaimpegnata e 80 su giacenzadisponibile 
            //      f) MovimentiMagazzino
            //          f1) Creo un movimento automatico di carico di 300 pz
            //          f2) Barcode del Bancale? NrOrdine a Fornitore, datamov e peso e prezzo
        }
    }
}
