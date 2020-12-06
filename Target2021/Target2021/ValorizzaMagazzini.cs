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
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.articoli_semplici'. È possibile spostarla o rimuoverla se necessario.
            this.articoli_sempliciTableAdapter.Fill(this.target2021DataSet.articoli_semplici);
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
            int magazzino=0; // Magazzino: 1=lastre, 4=semilavorati, 5=finiti
            double Totale=0;

            if (comboBox1.SelectedIndex == 0) magazzino = 1;
            if (comboBox1.SelectedIndex == 1) magazzino = 4;
            if (comboBox1.SelectedIndex == 2) magazzino = 5;
            if (comboBox1.SelectedIndex == -1) return;

            if (magazzino == 1) Totale = CalcolaLastre();
            if (magazzino == 4) Totale = CalcolaSemilavorati();
            if (magazzino == 5) Totale = CalcolaFiniti();

            textBox1.Text = Totale.ToString("#.##")+" €";
        }

        private double CalcolaLastre()
        {
            double Totale = 0, ValoreLastra, ValoreTotale;
            string CodiceLastraGiacente;
            int Giacenza, NrMagazzino=0;

            foreach (DataGridViewRow row in giacenzeMagazziniDataGridView.Rows)
            {
                try
                {
                    NrMagazzino = Convert .ToInt32(row.Cells[1].Value);
                    if (NrMagazzino == 1)
                    {
                        CodiceLastraGiacente = row.Cells[2].Value.ToString();
                        Giacenza = Convert.ToInt32(row.Cells[7].Value);
                        DataRow[] RigaTrovata;
                        RigaTrovata = target2021DataSet.Tables["Prime"].Select("codice = '" + CodiceLastraGiacente + "'");
                        try
                        {
                            ValoreLastra = Convert.ToDouble(RigaTrovata[0][3]);
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
                }
                catch { }
            }
            dataGridView1.Columns[3].DefaultCellStyle.Format = "0.##";
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            return Totale;
        }

        private double CalcolaSemilavorati()
        {
            double Totale = 0, ValoreLastra, ValoreTotale;
            string CodiceLastraGiacente;
            int Giacenza, NrMagazzino = 0;

            foreach (DataGridViewRow row in giacenzeMagazziniDataGridView.Rows)
            {
                try
                {
                    NrMagazzino = Convert.ToInt32(row.Cells[1].Value);
                    if (NrMagazzino == 4)
                    {
                        CodiceLastraGiacente = row.Cells[5].Value.ToString();
                        Giacenza = Convert.ToInt32(row.Cells[7].Value);
                        DataRow[] RigaTrovata;
                        RigaTrovata = target2021DataSet.Tables["articoli_semplici"].Select("codice = '" + CodiceLastraGiacente + "'");
                        try
                        {
                            ValoreLastra = Convert.ToDouble(RigaTrovata[0][18]);
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
                }
                catch { }
            }
            dataGridView1.Columns[3].DefaultCellStyle.Format = "0.##";
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            return Totale;
        }

        private double CalcolaFiniti()
        {
            double Totale = 0, ValoreLastra, ValoreTotale;
            string CodiceLastraGiacente;
            int Giacenza, NrMagazzino = 0;

            foreach (DataGridViewRow row in giacenzeMagazziniDataGridView.Rows)
            {
                try
                {
                    NrMagazzino = Convert.ToInt32(row.Cells[1].Value);
                    if (NrMagazzino == 5)
                    {
                        CodiceLastraGiacente = row.Cells[6].Value.ToString();
                        Giacenza = Convert.ToInt32(row.Cells[7].Value);
                        DataRow[] RigaTrovata;
                        RigaTrovata = target2021DataSet.Tables["articoli_semplici"].Select("codice = '" + CodiceLastraGiacente + "'");
                        try
                        {
                            ValoreLastra = Convert.ToDouble(RigaTrovata[0][18]);
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
                }
                catch { }
            }
            dataGridView1.Columns[3].DefaultCellStyle.Format = "0.##";
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            return Totale;
        }
    }
}
