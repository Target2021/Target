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
    public partial class ValorizzaMagazzini : Form
    {
        public ValorizzaMagazzini()
        {
            InitializeComponent();
        }

        private void giacenzeMagazziniBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.giacenzeMagazziniBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void ValorizzaMagazzini_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Prime'. È possibile spostarla o rimuoverla se necessario.
            this.primeTableAdapter.Fill(this.target2021DataSet.Prime);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.GiacenzeMagazzini'. È possibile spostarla o rimuoverla se necessario.
            this.giacenzeMagazziniTableAdapter.Fill(this.target2021DataSet.GiacenzeMagazzini);
            dataGridView1.ColumnCount = 4;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10.75F, FontStyle.Bold);
            dataGridView1.Columns[0].Name = "Codice Articolo";
            dataGridView1.Columns[1].Name = "Costo unitario";
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[2].Name = "Quantità";
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[3].Name = "Valore";
            dataGridView1.Columns[3].ValueType = typeof(double);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CodiceLastraGiacente;
            int Giacenza;
            double ValoreLastra, ValoreTotale, Totale=0;

            foreach (DataGridViewRow row in giacenzeMagazziniDataGridView.Rows)
            {
                try
                {
                    CodiceLastraGiacente = row.Cells[2].Value.ToString();
                    Giacenza = Convert.ToInt32(row.Cells[7].Value);
                    DataRow[] RigaTrovata;
                    RigaTrovata = target2021DataSet.Tables["Prime"].Select("codice = '" + CodiceLastraGiacente + "'");
                    try
                    {
                        ValoreLastra =Convert.ToDouble(RigaTrovata[0][3]);
                    }
                    catch
                    {
                        ValoreLastra = 0;
                    }
                    //MessageBox.Show("Lastra: " + CodiceLastraGiacente + " - Valore: " + ValoreLastra.ToString());
                    ValoreTotale = ValoreLastra * Giacenza;
                    Totale = Totale + ValoreTotale;
                    this.dataGridView1.Rows.Add(CodiceLastraGiacente, ValoreLastra.ToString(), Giacenza.ToString(), ValoreTotale);
                }
                catch { }
            }
            dataGridView1.Columns[3].DefaultCellStyle.Format = "0.##";
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            textBox1.Text = Totale.ToString("#.##")+" €";
        }
    }
}
