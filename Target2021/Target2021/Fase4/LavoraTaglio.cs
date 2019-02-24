using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021
{
    public partial class LavoraTaglio_cs : Form
    {
        public string IDCommessa;
        public LavoraTaglio_cs(string ID)
        {
            InitializeComponent();
            IDCommessa = ID;
        }

        private void LavoraTaglio_cs_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.clienti'. È possibile spostarla o rimuoverla se necessario.
            this.clientiTableAdapter.Fill(this.target2021DataSet.clienti);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            commesseBindingSource.Filter = "CodCommessa = '" + IDCommessa+"'";
        }

        private void commesseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commesseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Scanna scanner = new Scanna();
            scanner.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calcolapezzi();
        }

        private void nrPezziScartatiTextBox_TextChanged(object sender, EventArgs e)
        {
            calcolapezzi();
        }

        private void calcolapezzi()
        {
            int pztagliati, pzscartati, pzcorretti;
            if (textBox1.Text == "") textBox1.Text = "0";
            if (nrPezziScartatiTextBox.Text == "") nrPezziScartatiTextBox.Text = "0";
            pztagliati = Convert.ToInt32(textBox1.Text);
            pzscartati = Convert.ToInt32(nrPezziScartatiTextBox.Text);
            pzcorretti = pztagliati - pzscartati;
            nrPezziCorrettiTextBox.Text = pzcorretti.ToString();
        }

        private void iDCommessaTextBox_TextChanged(object sender, EventArgs e)
        {
            string immagine = fotoTextBox.Text;
            try
            {
                pictureBox1.Image = new Bitmap(immagine);
            }
            catch
            {
                pictureBox1.Image = Properties.Resources.question_mark;
            }
        }

        private void iDClienteTextBox_TextChanged(object sender, EventArgs e)
        {
            DataRow[] riga;
            string NomeCliente, filtro;
            try
            {
                filtro = "codice='" + iDClienteTextBox.Text.Replace(" ", string.Empty) + "'";
                riga = target2021DataSet.Tables["clienti"].Select(filtro);
                NomeCliente = riga[0]["ragione_sociale"].ToString();
            }
            catch { NomeCliente = "Non trovato!"; }
            label2.Text = NomeCliente;
        }
    }
}
