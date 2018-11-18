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
        int disponibili_o, impegnate_o, ordinati;
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
            textBox9.Text= riga[0]["GiacenzaOrdinati"].ToString();
            ordinati = Convert.ToInt32(textBox9.Text);
            textBox10.Text = riga[0]["GiacImpegnSuOrd"].ToString();
            impegnate_o = Convert.ToInt32(textBox10.Text);
            disponibili_o = ordinati - impegnate_o;
            textBox11.Text = disponibili_o.ToString();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int evento = e.ColumnIndex;  // 8 su magazzino - 9 su ordinato
            int IdCommessa, NumCommessa;
            int nlastre = 0, nlastreord = 0, nrichieste;
            if (e.RowIndex == -1) return;
            disponibili = disponibili + Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
            impegnate = impegnate - Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
            disponibili_o = disponibili_o + Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
            impegnate_o = impegnate_o - Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[9].Value);

            nrichieste = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
            try
            {
                if (evento == 8) nlastre = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Quante lastre vuoi impiegare per questa commessa dal MAGAZZINO?", "IMPEGNO LASTRE MAGAZZINO", "0"));
                //if (evento == 9) nlastreord = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Quante lastre vuoi impiegare per questa commessa dall'ORDINATO?", "IMPEGNO LASTRE ORDINATE", "0"));

            }
            catch { }
            if (evento==8)
            {
                if (nlastre > disponibili)
                {
                    MessageBox.Show("Non hai disponibili tutte quelle lastre!");
                    dataGridView1.Rows[e.RowIndex].Cells[8].Value = 0;
                }
                else
                {
                    if (nlastre > 0 && nlastre < nrichieste)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[10].Value = true;
                        dataGridView1.Rows[e.RowIndex].Cells[11].Value = 1;
                    }
                    dataGridView1.Rows[e.RowIndex].Cells[8].Value = nlastre;
                    riga[0]["GiacenzaDisponibili"] = disponibili - nlastre;
                    riga[0]["GiacenzaImpegnati"] = impegnate + nlastre;
                    if (nlastre == nrichieste)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[10].Value = false;
                        dataGridView1.Rows[e.RowIndex].Cells[11].Value = 2;
                    }
                    if (nlastre == 0)
                    { 
                        dataGridView1.Rows[e.RowIndex].Cells[10].Value = false;
                        dataGridView1.Rows[e.RowIndex].Cells[11].Value = 0;
                    }
                    this.SelectNextControl(this.ActiveControl, true, true, true, true);
                }
            }
            if (evento == 9)
            {
                IdCommessa = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[12].Value);
                NumCommessa = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                nlastreord= QualiLastre(textBox1.Text, IdCommessa, NumCommessa);
                dataGridView1.Rows[e.RowIndex].Cells[9].Value = nlastreord;
                riga[0]["GiacImpegnSuOrd"] = impegnate_o + nlastreord;
            }
            testata();
        }

        private int QualiLastre(string CodLas, int IdC, int NumC)
        {
            int NrL;
            ElencoLastreOrdinate Elenco = new ElencoLastreOrdinate(CodLas, IdC, NumC);
            Elenco.ShowDialog();
            NrL = Elenco.NrLastreImpegnate;
            return NrL;
        }

        private void giacenzeMagazziniBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.giacenzeMagazziniBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }
    }
}
