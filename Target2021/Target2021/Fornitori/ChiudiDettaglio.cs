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
    public partial class ChiudiDettaglio : Form
    {
        private int ID;
        public int risultato { get; set; }
        public double Peso { get; set; }
        public double Prezzo { get; set; }
        private int Origine;
        public int PezziArrivati;

        public ChiudiDettaglio(int IdDett, int o)
        {
            InitializeComponent();
            ID = IdDett;
            Origine = o;
        }

        private void ChiudiDettaglio_Load(object sender, EventArgs e)
        {
            this.ordFornDettTableAdapter.Fill(this.target2021DataSet.OrdFornDett);
            ordFornDettBindingSource.Filter = "idOFDett = "+ID.ToString();
            if (Origine==5)   // CHiudere riga
            {
                imposta();
            }
            if (Origine==2)   // Conferma d'ordine
            {
                button1.Visible = false;
                qtaEffettivaTextBox.Enabled = false;
                pesoTotaleTextBox.Enabled = false;
                dataConsegnaRichiestaDateTimePicker.Enabled = true;
                dataConsegnaConfermataDateTimePicker.Enabled = true;
                dataConsegnaEffettivaDateTimePicker.Enabled = false;
                button2.Visible = true;
                button2.Enabled = true;
            }
        }

        private void imposta()
        {
            dataConsegnaEffettivaDateTimePicker.Text = DateTime.Today.ToString();
            risultato = 1;
        }

        private void ordFornDettBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordFornDettBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void AggiornaPrezzoLastra(object sender, EventArgs e)
        {
            double PrezzoKg, Qta, PesoTot, Qt;
            double PrezzoTot, PrezzoLastra;
            try
            {
                PrezzoKg = Convert.ToDouble(prezzoKgTextBox.Text);
                Qta = Convert.ToDouble(qtaEffettivaTextBox.Text);
                Qt = Convert.ToDouble(quantitaRichTextBox.Text);
                PesoTot = Convert.ToDouble(pesoTotaleTextBox.Text);
                Peso = PesoTot;
                PrezzoTot = PrezzoKg * PesoTot;
                Prezzo = PrezzoTot;
                if (Origine == 5) PrezzoLastra = PrezzoTot / Qta;
                else PrezzoLastra = PrezzoTot / Qt;
                prezzoALastraTextBox.Text = PrezzoLastra.ToString();
                risultato = 2; // tutto ok
            }
            catch
            {
                risultato = 1; // errore
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            statoTextBox.Text = "2";
            risultato = 2;
            PezziArrivati = Convert.ToInt32(qtaEffettivaTextBox.Text);
            this.Validate();
            this.ordFornDettBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
            MessageBox.Show("Riga salvata e chiusa correttamente!");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(IdOrdFornDett.ToString());
            int num;
            num = Convert.ToInt32(idOFDettTextBox.Text);
            CommesseCollegate Dettaglio = new CommesseCollegate(num);
            Dettaglio.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            risultato = 1;
            this.Validate();
            this.ordFornDettBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
            MessageBox.Show("Riga aggiornata correttamente!");
            this.Close();
        }

        private void Calcolo(object sender, MouseEventArgs e)
        {
            CalcoloPrezzoKg calcola = new CalcoloPrezzoKg();
            calcola.ShowDialog();
            prezzoKgTextBox.Text = calcola.prezzo.ToString();
        }
    }
}
