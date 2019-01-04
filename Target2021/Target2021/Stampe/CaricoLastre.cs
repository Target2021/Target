using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Target2021.Report;

namespace Target2021.Stampe
{
    public partial class CaricoLastre : Form
    {
        public CaricoLastre()
        {
            InitializeComponent();
        }

        private void CaricoLastre_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Prime'. È possibile spostarla o rimuoverla se necessario.
            this.primeTableAdapter.Fill(this.target2021DataSet.Prime);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet9.MovimentiMagazzino'. È possibile spostarla o rimuoverla se necessario.
            this.movimentiMagazzinoTableAdapter.Fill(this.target2021DataSet9.MovimentiMagazzino);
            filtra();
        }

        private void movimentiMagazzinoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movimentiMagazzinoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet9);
        }

        private void filtra()
        {
            DateTime data;
            data = dateTimePicker1.Value;
            data = data.Date;
            movimentiMagazzinoBindingSource.Filter = "DataOraMovimento = '" + data + "'";
            movimentiMagazzinoBindingSource.Filter = string.Format("DataOraMovimento >= '{0:yyyy-MM-dd}' AND DataOraMovimento < '{1:yyyy-MM-dd}'", data, data.AddDays(1));
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            filtra();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nrmov, qta, nrordine;
            double p;
            string[] dimensioni = new string[3];
            string CodLas, Descrizione="";
            DateTime data;
            try
            {
                nrmov = Convert.ToInt32(movimentiMagazzinoDataGridView.SelectedRows[0].Cells[0].Value);
                CodLas = movimentiMagazzinoDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                p = Convert.ToDouble(movimentiMagazzinoDataGridView.SelectedRows[0].Cells[12].Value);
                qta = Convert.ToInt32(movimentiMagazzinoDataGridView.SelectedRows[0].Cells[8].Value);
                data =Convert.ToDateTime( movimentiMagazzinoDataGridView.SelectedRows[0].Cells[11].Value);
                try
                {
                    nrordine = Convert.ToInt32(movimentiMagazzinoDataGridView.SelectedRows[0].Cells[10].Value);
                }
                catch
                {
                    nrordine = 0;
                }
                Descrizione = RecuperaDescrizioneLastra(CodLas);
                dimensioni = RecuperaDimensioniLastra(CodLas);
                
                WFCaricoLastra cl = new WFCaricoLastra(nrmov, CodLas, p, qta, data, nrordine, Descrizione, dimensioni[0], dimensioni[1], dimensioni[2]);
                cl.Show();
            }
            catch { }
        }

        private string[] RecuperaDimensioniLastra(string cod)
        {
            string[] d = new string[3];

            DataRow[] RigaTrovata;
            RigaTrovata = target2021DataSet.Tables["Prime"].Select("codice = '" + cod + "'");

            if (RigaTrovata.Length != 0)
            {
                d[0] = RigaTrovata[0][10].ToString();
                d[1] = RigaTrovata[0][11].ToString();
                d[2] = RigaTrovata[0][12].ToString();
            }
            else
            {
                MessageBox.Show("L'articolo " + cod + " non esiste nelle'anagrafica lastre");
            }
            return d;
        }

        private string RecuperaDescrizioneLastra(string cod)
        {
            string des="";

            DataRow[] RigaTrovata;
            RigaTrovata = target2021DataSet.Tables["Prime"].Select("codice = '" + cod + "'");

            if (RigaTrovata.Length != 0)
            {
                des = RigaTrovata[0][2].ToString();
            }
            else
            {
                MessageBox.Show("L'articolo "+cod+" non esiste nelle'anagrafica lastre");
            }
            return des;
        }
    }
}
