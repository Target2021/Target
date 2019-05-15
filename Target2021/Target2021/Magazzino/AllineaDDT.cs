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
            // Controlla Le nuove importazioni (per ogni riga)
            // Se importato: data_preventivo_prov = 1 altrimenti = 0
            // Se è = 0
                // Crea: A) Moviemento di Scarico in 'MovimentiMagazzino' valorizzando Data, Numero e progressivo DDT
                //       B) Aggiorna GiacenzeMagazzino (se non esiste lo crea)
            // Se è = 1
            // Recupera da 'dettagio_ddt' Codice Articolo, Data, Numero, Progressivo e quantità
                // Cerca in 'MovimentiMagazzino' se c'è una riga che contiene quei dati (se non c'è nulla)
                // Se la riga c'è confronta se la quantità della riga è uguale
                    // Se è uguale OK (non fare nulla)
                    // Se è diversa: A) Modificare il valore qta della riga di MovimentiMagazzino
                                   //B) Modificare la giacenza per quell'articolo
            // Visualizza in un messagebox info su attività di importazione effettuate
        }
    }
}
