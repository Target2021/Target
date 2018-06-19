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
            cell11.AddElement(new Paragraph("COMMESSA"));
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

        private void stampacommessa_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'Target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.CommesseTableAdapter.Fill(this.Target2021DataSet.Commesse);

            this.reportViewer1.RefreshReport();
        }
    }
}
