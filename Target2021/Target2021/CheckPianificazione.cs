using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Target2021
{
    public partial class CheckPianificazione : Form
    {
        DataTable dt = new DataTable("SuperCommesse");

        public CheckPianificazione()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CheckPianificazione_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.MacchineStampo'. È possibile spostarla o rimuoverla se necessario.
            this.macchineStampoTableAdapter.Fill(this.target2021DataSet.MacchineStampo);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.SuperCommessa'. È possibile spostarla o rimuoverla se necessario.
            this.superCommessaTableAdapter.Fill(this.target2021DataSet.SuperCommessa);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            carica();
            CreaTabella();
        }

        private void carica()
        {
            commesseBindingSource.Filter = "Stato = 2";
        }

        private void SelezionaRiga(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void commesseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commesseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IdSC, percentuale = 0;
            if (textBox1.Text == "")
            {
                IdSC = AssegnaIdSuperCommessa();
                IdSC++;
                textBox1.Text = IdSC.ToString();
            }    
            AggiungiRiga();
            if (textBox2.Text=="")
            {
                textBox2.Text = Convert.ToString(commesseDataGridView.SelectedRows[0].Cells[21].Value);
                commesseBindingSource.Filter = "IDMateriaPrima = '" + textBox2.Text + "'";
            }
            percentuale = Convert.ToInt32(textBox3.Text) + Convert.ToInt32(commesseDataGridView.SelectedRows[0].Cells[16].Value);
            textBox3.Text = percentuale.ToString();
            Colora(sender,e);
        }

        private int AssegnaIdSuperCommessa()
        {
            int max;
            try
            {
                max = (int)target2021DataSet.SuperCommessa.Compute("MAX([IdSuperCommessa])", "");
            }
            catch
            { max = 0; }
            return max;
        }
        private void CreaTabella()
        {
            dt.Columns.Add("Codice commessa", System.Type.GetType("System.String"));
            dt.Columns.Add("Data consegna", System.Type.GetType("System.DateTime"));
            dt.Columns.Add("Numero pezzi da produrre", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Codice articolo", System.Type.GetType("System.String"));
            dt.Columns.Add("Macchina stampa", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Percentuale lastra", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Lastra", System.Type.GetType("System.String"));
            dt.Columns.Add("Nr. lastre", System.Type.GetType("System.Int32"));
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].Width = 100;
        }

        private void AggiungiRiga()
        {
            string CodCommessa, CodArticolo, Lastra;
            int NrPezziDaProdurre, MacchinaStampa, PercentualeLastra, NrLastre;
            DateTime DataConsegna;

            foreach (DataGridViewRow riga in commesseDataGridView.SelectedRows)
            {
                CodCommessa = Convert.ToString(riga.Cells[1].Value);
                DataConsegna = Convert.ToDateTime(riga.Cells[7].Value);
                NrPezziDaProdurre = Convert.ToInt32(riga.Cells[8].Value);
                CodArticolo = Convert.ToString(riga.Cells[9].Value);
                MacchinaStampa = Convert.ToInt32(riga.Cells[14].Value);
                PercentualeLastra = Convert.ToInt32(riga.Cells[16].Value);
                Lastra = Convert.ToString(riga.Cells[21].Value); 
                NrLastre = Convert.ToInt32(riga.Cells[22].Value);

                dt.Rows.Add(new object[] { CodCommessa, DataConsegna, NrPezziDaProdurre, CodArticolo, MacchinaStampa, PercentualeLastra, Lastra, NrLastre});
                dataGridView1.DataSource = dt;
            }

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Cancella(object sender, EventArgs e)
        {
            int percentuale = 0, totperc = 0, nrighe = 100;
            totperc = Convert.ToInt32(textBox3.Text);
            percentuale = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[5].Value);
            totperc = totperc - percentuale;
            textBox3.Text = totperc.ToString();
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            nrighe = dataGridView1.RowCount;
            if (nrighe == 0) textBox2.Text = "";
        }

        private void Colora(object sender, EventArgs e)
        {
            int percentuale = Convert.ToInt32(textBox3.Text);
            if (percentuale < 100) textBox3.BackColor = Color.Green;
            if (percentuale >= 100 && percentuale < 106) textBox3.BackColor = Color.Yellow;
            if (percentuale > 105) textBox3.BackColor = Color.Red;
        }
    }
}
