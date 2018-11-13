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

        public ChiudiDettaglio(int IdDett)
        {
            InitializeComponent();
            ID = IdDett;
        }

        private void ChiudiDettaglio_Load(object sender, EventArgs e)
        {
            this.ordFornDettTableAdapter.Fill(this.target2021DataSet.OrdFornDett);
            ordFornDettBindingSource.Filter = "idOFDett = "+ID.ToString();
            imposta();
        }

        private void imposta()
        {
            statoTextBox.Text = "2";
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
            double PrezzoKg, Qta, PesoTot;
            double PrezzoTot, PrezzoLastra;
            try
            {
                PrezzoKg = Convert.ToDouble(prezzoKgTextBox.Text);
                Qta = Convert.ToDouble(qtaEffettivaTextBox.Text);
                PesoTot = Convert.ToDouble(pesoTotaleTextBox.Text);
                Peso = PesoTot;
                PrezzoTot = PrezzoKg * PesoTot;
                Prezzo = PrezzoTot;
                PrezzoLastra = PrezzoTot / Qta;
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
            risultato = 2;
            this.Validate();
            this.ordFornDettBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
            MessageBox.Show("Riga salvata e chiusa correttamente!");
            this.Close();
        }
    }
}
