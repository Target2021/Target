using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.NuovePagine
{
    public partial class NuovoStampo : Form
    {
        public NuovoStampo()
        {
            InitializeComponent();
        }

        private void NuovoStampo_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Stampi'. È possibile spostarla o rimuoverla se necessario.
            this.stampiTableAdapter.Fill(this.target2021DataSet.Stampi);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Fornitori'. È possibile spostarla o rimuoverla se necessario.
            this.fornitoriTableAdapter.Fill(this.target2021DataSet.Fornitori);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Descrizione;
            try
            {
                Descrizione = comboBox1.SelectedValue.ToString();
                textBox5.Text = Descrizione;
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CodStampo, Tipo, DescrizioneStampo, CodFornitore, DescrFornitore, Corsia, Campata, BarCode;
            int Posizione, Esito;
            double Prezzo;

            CodStampo = textBox1.Text;
            if (CodStampo.Length>0)
            {
                Tipo = textBox2.Text.Trim();
                DescrizioneStampo = textBox3.Text.Trim();
                try
                {
                    Prezzo = Convert.ToDouble(textBox4.Text);
                }
                catch
                {
                    MessageBox.Show("Non riesco a leggere correttamente il prezzo");
                    Prezzo = 0;
                }
                CodFornitore = comboBox1.Text.Trim();
                DescrFornitore = textBox5.Text.Trim();
                Corsia = textBox6.Text.Trim();
                Campata = textBox7.Text.Trim();
                try
                {
                    Posizione = Convert.ToInt32(textBox8.Text);
                }
                catch
                {
                    MessageBox.Show("Non riesco a leggere correttamente la posizione");
                    Posizione = 0;
                }
                BarCode = textBox9.Text.Trim();

                Esito = Salva(CodStampo, Tipo, DescrizioneStampo, Prezzo, CodFornitore, DescrFornitore, BarCode, Corsia, Campata, Posizione);
                if (Esito==0)
                    MessageBox.Show("Salvataggio completato correttamente");
                else
                    MessageBox.Show("Salvataggio NON completato correttamente");
            }
            else
            {
                MessageBox.Show("Non posso registrare uno stampo se non è stato valorizzato il codice");
            }
        }

        private int Salva(string CodStampo, string Tipo, string DescrizioneStampo, double Prezzo, string CodFornitore, string DescrFornitore, string BarCode, string Corsia, string Campata, int Posizione)
        {
            Target2021DataSet.StampiRow riga = target2021DataSet.Stampi.NewStampiRow();

            try
            {
                riga.codice = CodStampo;
                riga.tipo = Tipo;
                riga.descrizione = DescrizioneStampo;
                riga.prezzo_acq = Prezzo;
                riga.codice_fornitore = CodFornitore;
                riga.descrizione_fornitore = DescrFornitore;
                riga.Barcode = BarCode;
                riga.Corsia = Corsia;
                riga.Campata = Campata;
                riga.Posizione = Posizione;

                target2021DataSet.Stampi.Rows.Add(riga);
                stampiTableAdapter.Update(target2021DataSet.Stampi);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return 0;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
