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
        string CodLas;

        public WFCaricoLastra(int nr, string CL, double p, int qt, DateTime data, int nro)
        {
            InitializeComponent();
            numero = nr;
            CodLas = CL;
            peso = p;
            qta = qt;
            datacarico = data;
            nrordine = nro;
        }

        private void WFCaricoLastra_Load(object sender, EventArgs e)
        {
            this.primeTableAdapter.Fill(this.target2021DataSet.Prime);
            this.movimentiMagazzinoTableAdapter.Fill(this.target2021DataSet9.MovimentiMagazzino);
            this.reportViewer1.RefreshReport();
            imposta();
        }

        private void imposta()
        {
            ReportParameter id = new ReportParameter("idMovimento", numero.ToString());
            ReportParameter CL = new ReportParameter("CodLas", CodLas);
            ReportParameter p = new ReportParameter("peso", peso.ToString());
            ReportParameter q = new ReportParameter("qta", qta.ToString());
            ReportParameter d = new ReportParameter("data", datacarico.ToString());
            ReportParameter n = new ReportParameter("nrordine", nrordine.ToString());
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { id, CL, p, q, d, n });
            this.reportViewer1.RefreshReport();
        }
    }
}
