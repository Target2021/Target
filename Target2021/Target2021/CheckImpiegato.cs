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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Target2021
{
    public partial class CheckImpiegato : Form
    {
        string stringa_connessione = Properties.Resources.StringaConnessione;
        DataTable dataTable = new DataTable();

        public CheckImpiegato()
        {
            InitializeComponent();
        }

        private void commesseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commesseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }

        private void CheckImpiegato_Load(object sender, EventArgs e)
        {
            inserimento_iniziale();
            verifica_commesse();
        }

        public void inserimento_iniziale()
        {
            string query = "Select IDMateriaPrima,SUM(NrLastreRichieste) as LastreRichieste FROM Commesse WHERE TipoCommessa=1 AND Stato=0 GROUP BY IDMateriaPrima";
            SqlConnection connessione = new SqlConnection(stringa_connessione);
            SqlCommand comando = new SqlCommand(query, connessione);
            connessione.Open();
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.SelectCommand = comando;
            SDA.Fill(dataTable);
            dataTable.Columns.Add("Disponibilità Lastre", typeof(Int32));
            dataTable.Columns.Add("Descrizione materia prima", typeof(String));
            dataTable.Columns.Add("Codice fornitore", typeof(String));
            dataTable.Columns.Add("Descrizione fornitore", typeof(String));
            BindingSource source = new BindingSource();
            source.DataSource = dataTable;
            dataGridView1.DataSource = source;
            SDA.Update(dataTable);
            connessione.Close();
        }

        public void verifica_commesse()
        {
            SqlConnection conn = new SqlConnection(stringa_connessione);
            BindingSource source = new BindingSource();
            DataGridViewRow riga;
            int Pezzi = 0, PezziOrdinati = 0, nriga = 0, nrighe;
            nrighe=dataGridView1.RowCount;
            for (nriga=0;nriga<nrighe;nriga++)
            {
                riga = dataGridView1.Rows[nriga];
                string query1 = "Select GiacenzaDisponibili From GiacenzeMagazzini Where idPrime='" + Convert.ToString(riga.Cells[0].Value) + "'";
                string query2 = "Select descrizione From Prime Where codice='" + Convert.ToString(riga.Cells[0].Value) + "'";
                string query3 = "Select codice_fornitore From Prime Where codice='" + Convert.ToString(riga.Cells[0].Value) + "'";                
                SqlCommand comando1 = new SqlCommand(query1, conn);
                SqlCommand comando2 = new SqlCommand(query2, conn);
                SqlCommand comando3 = new SqlCommand(query3, conn);
                conn.Open();
                int giacenza = Convert.ToInt32(comando1.ExecuteScalar());
                string descrizione = comando2.ExecuteScalar().ToString();
                string cod_for= comando3.ExecuteScalar().ToString();
                string query4 = "Select ragione_sociale From Fornitori Where codice='" + cod_for + "'";
                SqlCommand comando4 = new SqlCommand(query4, conn);
                string des_for = comando4.ExecuteScalar().ToString();
                dataTable.Rows[nriga]["Disponibilità Lastre"]=giacenza;
                dataTable.Rows[nriga]["Descrizione materia prima"] = descrizione;
                dataTable.Rows[nriga]["Codice fornitore"] = cod_for;
                dataTable.Rows[nriga]["Descrizione fornitore"] = des_for;
                PezziOrdinati = Convert.ToInt32(riga.Cells[1].Value);
                if (giacenza < PezziOrdinati)
                {
                    richTextBox1.Text = richTextBox1.Text + "PROPOSTA DI ORDINE A FORNITORE";
                    richTextBox1.Text = richTextBox1.Text + "\r" + "Ordinare materia prima codice: " + Convert.ToString(riga.Cells[0].Value)+" - "+ Convert.ToString(riga.Cells[3].Value);
                    richTextBox1.Text = richTextBox1.Text + "\r" + "Fornitore: " + Convert.ToString(riga.Cells[4].Value) + " - " + Convert.ToString(riga.Cells[5].Value);
                    richTextBox1.Text = richTextBox1.Text + "\r" + "Quantità da ordinare: " + (PezziOrdinati-giacenza).ToString();
                    richTextBox1.Text = richTextBox1.Text + "\r\r";
                }
                conn.Close();
            }
            source.DataSource = dataTable;
            dataGridView1.DataSource = source;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //verifica_commesse();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataTable.Columns.Remove("Disponibilità Lastre");
            dataTable.Clear();
            richTextBox1.Text = "";
            inserimento_iniziale();
            verifica_commesse();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Document doc = new Document(PageSize.A4);
            var output = new FileStream(("C:\\temp\\OrdineAFornitore.pdf"), FileMode.Create);
            var writer = PdfWriter.GetInstance(doc, output);
            doc.Open();
            var logo = iTextSharp.text.Image.GetInstance("c://temp//logo.png");
            logo.SetAbsolutePosition(430, 770);
            logo.ScaleAbsoluteHeight(50);
            logo.ScaleAbsoluteWidth(70);
            doc.Add(logo);
            PdfPTable table1 = new PdfPTable(2);
            table1.DefaultCell.Border = 0;
            table1.WidthPercentage = 80;
            PdfPCell cell11 = new PdfPCell();
            cell11.Colspan = 1;
            cell11.AddElement(new Paragraph("Target S.P.A."));
            cell11.AddElement(new Paragraph("ORDINE A FORNITORE"));
            cell11.VerticalAlignment = Element.ALIGN_LEFT;
            PdfPCell cell12 = new PdfPCell();
            cell12.VerticalAlignment = Element.ALIGN_CENTER;
            table1.AddCell(cell11);
            table1.AddCell(cell12);
            PdfPTable table2 = new PdfPTable(3);
            //One row added
            PdfPCell cell21 = new PdfPCell();
            cell21.AddElement(new Paragraph("Photo Type"));
            PdfPCell cell22 = new PdfPCell();
            cell22.AddElement(new Paragraph("No. of Copies"));
            PdfPCell cell23 = new PdfPCell();
            cell23.AddElement(new Paragraph("Amount"));
            table2.AddCell(cell21);
            table2.AddCell(cell22);
            table2.AddCell(cell23);
            //New Row Added
            PdfPCell cell31 = new PdfPCell();
            cell31.AddElement(new Paragraph("Safe"));
            cell31.FixedHeight = 300.0f;
            PdfPCell cell32 = new PdfPCell();
            cell32.AddElement(new Paragraph("2"));
            cell32.FixedHeight = 300.0f;
            PdfPCell cell33 = new PdfPCell();
            cell33.AddElement(new Paragraph("20.00 * " + "2" + " = " + (20 * Convert.ToInt32("2")) + ".00"));
            cell33.FixedHeight = 300.0f;
            table2.AddCell(cell31);
            table2.AddCell(cell32);
            table2.AddCell(cell33);
            PdfPCell cell2A = new PdfPCell(table2);
            cell2A.Colspan = 2;
            table1.AddCell(cell2A);
            PdfPCell cell41 = new PdfPCell();
            cell41.AddElement(new Paragraph("Name : " + "ABC"));
            cell41.AddElement(new Paragraph("Advance : " + "advance"));
            cell41.VerticalAlignment = Element.ALIGN_LEFT;
            PdfPCell cell42 = new PdfPCell();
            cell42.AddElement(new Paragraph("Customer ID : " + "011"));
            cell42.AddElement(new Paragraph("Balance : " + "3993"));
            cell42.VerticalAlignment = Element.ALIGN_RIGHT;
            table1.AddCell(cell41);
            table1.AddCell(cell42);
            doc.Add(table1);
            doc.Close();
            System.Diagnostics.Process.Start(@"c:\temp\OrdineAFornitore.pdf");
        }
    }
}
