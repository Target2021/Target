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
    public partial class CopiaArticolo : Form
    {

        public string CodiceArticolo;

        public CopiaArticolo(string CodArt)
        {
            InitializeComponent();
            CodiceArticolo = CodArt;
        }

        private void CopiaArticolo_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.DettArticoli'. È possibile spostarla o rimuoverla se necessario.
            this.dettArticoliTableAdapter.Fill(this.target2021DataSet.DettArticoli);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.articoli_semplici'. È possibile spostarla o rimuoverla se necessario.
            this.articoli_sempliciTableAdapter.Fill(this.target2021DataSet.articoli_semplici);
            textBox1.Text = CodiceArticolo;
            // Prima controllo che il codice articolo che mi è arrivato esista effettivamente
            int testate, righe;
            testate = target2021DataSet.articoli_semplici.Select("codice = '" + CodiceArticolo + "'").Length;
            textBox3.Text = testate.ToString();
            righe = target2021DataSet.DettArticoli.Select("codice_articolo = '" + CodiceArticolo + "'").Length;
            textBox4.Text = righe.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NewCodice;

            // Controllo che ci sia qualcosa da copiare altrimenti esco
            if (textBox3.Text == "0")
            {
                MessageBox.Show("Non trovo la testata dell'articolo");
                this.Close();
            }
            if (textBox4.Text == "0")
            {
                MessageBox.Show("Articolo senza righe. Nulla da copiare");
                this.Close();
            }
            // Poi controllo che il codice scelto non esista già
            NewCodice = textBox2.Text;
            int testate, righe;
            testate = target2021DataSet.articoli_semplici.Select("codice = '" + NewCodice + "'").Length;
            righe = target2021DataSet.DettArticoli.Select("codice_articolo = '" + NewCodice + "'").Length;
            if (testate>0)
            {
                MessageBox.Show("Articolo già presente come testata");
                this.Close();
            }
            if (righe > 0)
            {
                MessageBox.Show("Articolo già presente come dettaglio");
                this.Close();
            }
            // Quindi duplico l'articolo cambiando il codice
            // Copio prima l'articolo semplice - testata
            var tabella = target2021DataSet.articoli_semplici.Select("codice = '" + CodiceArticolo + "'");
            DataRow riga = target2021DataSet.articoli_semplici.NewRow();
            riga.ItemArray = tabella[0].ItemArray;
            riga["codice"] = NewCodice;
            target2021DataSet.articoli_semplici.Rows.Add(riga);
            articoli_sempliciTableAdapter.Update(target2021DataSet.articoli_semplici);

            // Poi copio i dettagli delle righe dell'articolo - manca loop
            var tabella2 = target2021DataSet.DettArticoli.Select("codice_articolo = '" + CodiceArticolo + "'");
            int MaxID = 0;
            MaxID = target2021DataSet.DettArticoli.Max(u => u.IDDettaglioArticolo);

            foreach (DataRow rigo in tabella2)
            {
                DataRow riga2 = target2021DataSet.DettArticoli.NewRow();
                riga2.ItemArray =rigo.ItemArray;
                riga2["codice_articolo"] = NewCodice;
                riga2["IDDettaglioArticolo"] = ++MaxID;
                target2021DataSet.DettArticoli.Rows.Add(riga2);
            }
            dettArticoliTableAdapter.Update(target2021DataSet.DettArticoli);

            MessageBox.Show("Articolo clonato");
            this.Close();
        }

        private void articoli_sempliciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.articoli_sempliciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }
    }
}
