using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Fase1
{
    public partial class ImpegnaMatPrima : Form
    {
        string CodiceLastra, DescrizioneLastra;
        int disponibili;
        DataRow[] riga;

        public ImpegnaMatPrima(string CodLas, string DesLas)
        {
            InitializeComponent();
            CodiceLastra = CodLas;
            DescrizioneLastra = DesLas;
        }

        private void ImpegnaMatPrima_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.GiacenzeMagazzini'. È possibile spostarla o rimuoverla se necessario.
            this.giacenzeMagazziniTableAdapter.Fill(this.target2021DataSet.GiacenzeMagazzini);
            dataGridView1.KeyPress += OnDataGridView1_KeyPress;
            testata();
            dettaglio();
        }

        private void testata()
        {
            //DataRow[] riga;
            string selezione = "idPrime = '" + CodiceLastra+"'";
            riga=target2021DataSet.Tables["GiacenzeMagazzini"].Select(selezione);
            textBox1.Text = riga[0]["idPrime"].ToString();
            textBox2.Text = DescrizioneLastra;
            textBox3.Text = riga[0]["PosizioneA"].ToString();
            textBox7.Text = riga[0]["PosizioneB"].ToString();
            textBox8.Text = riga[0]["PosizioneC"].ToString();
            textBox4.Text = riga[0]["GiacenzaComplessiva"].ToString();
            textBox5.Text = riga[0]["GiacenzaDisponibili"].ToString();
            disponibili = Convert.ToInt32(textBox5.Text);
            textBox6.Text = riga[0]["GiacenzaImpegnati"].ToString();
        }

        private void dettaglio()
        {
            commesseBindingSource.Filter = "IDMateriaPrima = '" +  CodiceLastra + "' AND TipoCommessa=1 AND Stato=0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commesseBindingSource.EndEdit();
            this.giacenzeMagazziniBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Esci(object sender, DataGridViewCellEventArgs e)
        {
            int numero;
            if (e.RowIndex > -1 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                numero =Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
                if (numero > disponibili)
                {
                    MessageBox.Show("Non hai disponibili tutte quelle lastre!");
                    dataGridView1.Rows[e.RowIndex].Cells[8].Value = 0;
                }
                else
                {
                    if (numero > 0) dataGridView1.Rows[e.RowIndex].Cells[9].Value = true;
                    riga[0]["GiacenzaDisponibili"] = Convert.ToInt32(textBox5.Text) - numero;
                    riga[0]["GiacenzaImpegnati"]= Convert.ToInt32(textBox6.Text) + numero;
                }
            }
            //this.Validate();
            //this.commesseBindingSource.EndEdit();
            //this.giacenzeMagazziniBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.target2021DataSet);
            testata();
        }

        private void OnDataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //Esci(sender, e);
            }
        }

        private void giacenzeMagazziniBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.giacenzeMagazziniBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }
    }
}
