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
        int disponibili, impegnate;
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
            testata();
            dettaglio();
        }

        private void testata()
        {
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
            impegnate = Convert.ToInt32(textBox6.Text);
        }

        private void dettaglio()
        {
            commesseBindingSource.Filter = "IDMateriaPrima = '" +  CodiceLastra + "' AND TipoCommessa=1 AND (Stato=0 OR Stato=1)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commesseBindingSource.EndEdit();
            this.giacenzeMagazziniBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
            MessageBox.Show("Salvataggio effettuato!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int nlastre=0,nrichieste;
            disponibili = disponibili + Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
            impegnate = impegnate - Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
            nrichieste = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
            try
            {
                nlastre = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Quante lastre vuoi impiegare per questa commessa?", "IMPEGNO LASTRE", "0"));
            }
            catch { }
            if (nlastre > disponibili)
            {
                MessageBox.Show("Non hai disponibili tutte quelle lastre!");
                dataGridView1.Rows[e.RowIndex].Cells[8].Value = 0;
            }
            else
            {
                if (nlastre > 0 && nlastre < nrichieste)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[9].Value = true;
                    dataGridView1.Rows[e.RowIndex].Cells[10].Value = 1;
                }
                dataGridView1.Rows[e.RowIndex].Cells[8].Value = nlastre;
                riga[0]["GiacenzaDisponibili"] = disponibili - nlastre;
                riga[0]["GiacenzaImpegnati"] = impegnate + nlastre;
                if (nlastre == nrichieste)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[9].Value = false;
                    dataGridView1.Rows[e.RowIndex].Cells[10].Value = 2;
                }
                if (nlastre == 0)
                { 
                    dataGridView1.Rows[e.RowIndex].Cells[10].Value = 0;
                    dataGridView1.Rows[e.RowIndex].Cells[9].Value = false;
                }
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
            testata();
        }

        private void giacenzeMagazziniBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.giacenzeMagazziniBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }
    }
}
