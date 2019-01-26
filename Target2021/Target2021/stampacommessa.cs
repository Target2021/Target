using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Microsoft.Reporting.WinForms;

namespace Target2021
{
    public partial class stampacommessa : Form
    {
        public stampacommessa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numeroToolStripTextBox.Text = textBox1.Text;
            int NrPezzi = 0, NrCommessa=0;          
            string cliente, articolo, stringa_connessione,Narticolo;
            stringa_connessione = Properties.Resources.StringaConnessione;
            SqlConnection conn = new SqlConnection(stringa_connessione);
            NrCommessa = Convert.ToInt32(textBox1.Text);
            string queryCliente = "Select IDCliente From Commesse Where NrCommessa=" + NrCommessa;
            SqlCommand comando = new SqlCommand(queryCliente, conn);
            conn.Open();
            cliente = comando.ExecuteScalar().ToString();
            textBox2.Text = cliente;

            string queryArticolo = "Select CodArticolo From Commesse Where NrCommessa=" + NrCommessa;
            SqlCommand comandoArticolo = new SqlCommand(queryArticolo, conn);
            articolo = comandoArticolo.ExecuteScalar().ToString();
            textBox3.Text = articolo;

            string queryNArticolo = "Select DescrArticolo From Commesse Where NrCommessa=" + NrCommessa;
            SqlCommand comandoDArticolo = new SqlCommand(queryNArticolo, conn);
            Narticolo = comandoDArticolo.ExecuteScalar().ToString();
            label7.Text = Narticolo;

            string queryPezzi = "Select NrPezziDaLavorare From Commesse Where NrCommessa=" + NrCommessa;
            SqlCommand comandoPezzi = new SqlCommand(queryPezzi, conn);
            NrPezzi = Convert .ToInt32 (comandoPezzi.ExecuteScalar());
            textBox4.Text = NrPezzi.ToString(); ;

            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource();
            // Must match the DataSource in the RDLC
            reportDataSource.Name = "RCommessa";
            reportDataSource.Value = CommesseBindingSource;
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.RefreshReport();
            //reportViewer1.bin
        }

        private void stampacommessa_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'Target2021DataSet.MacchineTaglio'. È possibile spostarla o rimuoverla se necessario.
            this.MacchineTaglioTableAdapter.Fill(this.Target2021DataSet.MacchineTaglio);
            // TODO: questa riga di codice carica i dati nella tabella 'Target2021DataSet.MacchineStampo'. È possibile spostarla o rimuoverla se necessario.
            this.MacchineStampoTableAdapter.Fill(this.Target2021DataSet.MacchineStampo);
            // TODO: questa riga di codice carica i dati nella tabella 'Target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.CommesseTableAdapter.Fill(this.Target2021DataSet.Commesse);

            this.reportViewer1.RefreshReport();
        }

        private void fillByNrToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
