using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Report
{
    public partial class WFCaricoLastra : Form
    {
        int numero, qta, nrordine;
        double peso;
        DateTime datacarico;
        string CodLas, Descrizione, x2, y2, z2;

        public WFCaricoLastra(int nr, string CL, double p, int qt, DateTime data, int nro, string Des, string x1, string y1, string z1)
        {
            InitializeComponent();
            numero = nr;
            CodLas = CL;
            peso = p;
            qta = qt;
            datacarico = data;
            nrordine = nro;
            Descrizione = Des;
            x2 = x1;
            y2 = y1;
            z2 = z1;
        }

        private void WFCaricoLastra_Load(object sender, EventArgs e)
        {
            this.primeTableAdapter.Fill(this.target2021DataSet.Prime);
            this.movimentiMagazzinoTableAdapter.Fill(this.target2021DataSet.MovimentiMagazzino);
            this.reportViewer1.RefreshReport();
            imposta();
        }

        private void imposta()
        {
            int anno;
            string no;
            anno = datacarico.Year;
            no = nrordine.ToString() + "/" + anno.ToString();

            ReportParameter id = new ReportParameter("idMovimento", numero.ToString());
            ReportParameter CL = new ReportParameter("CodLas", CodLas);
            ReportParameter p = new ReportParameter("peso", peso.ToString());
            ReportParameter q = new ReportParameter("qta", qta.ToString());
            ReportParameter d = new ReportParameter("data", datacarico.ToString());
            ReportParameter n = new ReportParameter("nrordine", no);
            ReportParameter des = new ReportParameter("des", Descrizione);
            ReportParameter x = new ReportParameter("x", x2);
            ReportParameter y = new ReportParameter("y", y2);
            ReportParameter z = new ReportParameter("z", z2);

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { id, CL, p, q, d, n, des, x, y, z });
            this.reportViewer1.RefreshReport();
        }
    }
}
