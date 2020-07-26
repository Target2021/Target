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
    public partial class NuovaMinuteria : Form
    {
        public NuovaMinuteria()
        {
            InitializeComponent();
        }

        private void minuterieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.minuterieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void NuovaMinuteria_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Fornitori'. È possibile spostarla o rimuoverla se necessario.
            this.fornitoriTableAdapter.Fill(this.target2021DataSet.Fornitori);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Minuterie'. È possibile spostarla o rimuoverla se necessario.
            this.minuterieTableAdapter.Fill(this.target2021DataSet.Minuterie);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                string Descrizione;
                try
                {
                    Descrizione = comboBox1.SelectedValue.ToString();
                    descrizione_fornitoreTextBox.Text = Descrizione;
                }
                catch
                {

                }
            }
        }

        private void prezzo_acqTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void quantita_riordinoTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void scorta_minimaTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void pesoTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dimXTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dimYTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dimZTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string CodiceMin, Tipo, DescrizioneMin, Unita, CodForn, DescrForn, BarCode, Posizione;
            double Prezzo, Peso;
            int QtaRiordino, ScortaMinima, DimX, DimY, DimZ, Esito;

            CodiceMin = codiceTextBox.Text.Trim();
            if (CodiceMin.Length > 0)
            {
                Tipo = tipoTextBox.Text.Trim();
                DescrizioneMin = descrizioneTextBox.Text.Trim();
                Unita = unita_misuraTextBox.Text.Trim();
                CodForn = comboBox1.Text.Trim();
                DescrForn = descrizione_fornitoreTextBox.Text.Trim();
                BarCode = barcodeTextBox.Text.Trim();
                Posizione = posizioneTextBox.Text.Trim();
                try
                {
                    Prezzo = Convert.ToDouble(prezzo_acqTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Non riesco a leggere correttamente il prezzo");
                    Prezzo = 0;
                }
                try
                {
                    Peso = Convert.ToDouble(pesoTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Non riesco a leggere correttamente il peso");
                    Peso = 0;
                }
                try
                {
                    QtaRiordino = Convert.ToInt32(quantita_riordinoTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Non riesco a leggere correttamente la Quantità");
                    QtaRiordino = 0;
                }
                try
                {
                    ScortaMinima = Convert.ToInt32(scorta_minimaTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Non riesco a leggere correttamente la scorta minima");
                    ScortaMinima = 0;
                }
                try
                {
                    DimX = Convert.ToInt32(dimXTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Non riesco a leggere correttamente la Dimensione X");
                    DimX = 0;
                }
                try
                {
                    DimY = Convert.ToInt32(dimYTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Non riesco a leggere correttamente la Dimensione Y");
                    DimY = 0;
                }
                try
                {
                    DimZ = Convert.ToInt32(dimZTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Non riesco a leggere correttamente la Dimensione Z");
                    DimZ = 0;
                }


                Esito = Salva(CodiceMin, Tipo, DescrizioneMin, Unita, CodForn, DescrForn, BarCode, Posizione, Prezzo, Peso, QtaRiordino, ScortaMinima, DimX, DimY, DimZ);
                if (Esito == 0)
                    MessageBox.Show("Salvataggio completato correttamente");
                else
                    MessageBox.Show("Salvataggio NON completato correttamente");
            }
            else
            {
                MessageBox.Show("Non posso registrare una minuteria se non è stato valorizzato il codice");
            }
        }

        private int Salva(string CodiceMin, string Tipo, string DescrizioneMin, string Unita, string CodForn, string DescrForn, string BarCode, string Posizione, double Prezzo, double Peso, int QtaRiordino, int ScortaMinima, int DimX, int DimY, int DimZ)
        {
            Target2021DataSet.MinuterieRow riga = target2021DataSet.Minuterie.NewMinuterieRow();

            try
            {
                riga.codice = CodiceMin;
                riga.tipo = Tipo;
                riga.descrizione = DescrizioneMin;
                riga.prezzo_acq = Prezzo;
                riga.unita_misura = Unita;
                riga.quantita_riordino = QtaRiordino;
                riga.scorta_minima = ScortaMinima;
                riga.codice_fornitore = CodForn;
                riga.descrizione_fornitore = DescrForn;
                riga.Barcode = BarCode;
                riga.DimX = DimX;
                riga.DimY = DimY;
                riga.DimZ = DimZ;
                riga.Peso = Peso;
                riga.Posizione = Posizione;

                target2021DataSet.Minuterie.Rows.Add(riga);
                minuterieTableAdapter.Update(target2021DataSet.Minuterie);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return 0;
        }
    }
}
