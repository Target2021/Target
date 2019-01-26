using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Anagrafiche
{
    public partial class NuovoArticolo : Form
    {
        public NuovoArticolo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txtPercorso.Text = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Target2021DataSet.articoli_sempliciRow riga = target2021DataSet.articoli_semplici.Newarticoli_sempliciRow();
            riga.codice = txtCodice.Text;
            try
            {
                riga.prezzo_b = Convert .ToDouble(txtPrezzo.Text);
            }
            catch
            {
                MessageBox.Show("Errore nel prezzo dell'articolo!");
                riga.prezzo_b = 0;
            }
            riga.unita_misura = comboUnita.Text;
            try
            {
                riga.costo_standard = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Errore nel costo dell'articolo!");
                riga.costo_standard = 0;
            }
            riga.descrizione = txtDesc.Text;
            riga.note = txtNote.Text;
            riga.indirizzo_immagine = txtPercorso.Text;
            target2021DataSet.articoli_semplici.Rows.Add(riga);
            articoli_sempliciTableAdapter.Update(target2021DataSet.articoli_semplici);
            MessageBox.Show("Articolo inserito correttamente!");
        }

        private void articoli_sempliciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.articoli_sempliciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void NuovoArticolo_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.articoli_semplici'. È possibile spostarla o rimuoverla se necessario.
            this.articoli_sempliciTableAdapter.Fill(this.target2021DataSet.articoli_semplici);

        }
    }
}
