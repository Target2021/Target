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

namespace Target2021.Stampe
{
    public partial class SSemilavorati : Form
    {
        string commessa, articolo, descrizione, qta;
        public SSemilavorati(string p1, string p2, string p3, string p4)
        {
            InitializeComponent();
            commessa = p1;
            articolo = p2;
            descrizione = p3;
            qta = p4;
        }

        private void SSemilavorati_Load(object sender, EventArgs e)
        {
            CaricaParametri();
            this.reportViewer1.RefreshReport();
        }

        private void CaricaParametri()
        {
            ReportParameter a = new ReportParameter("p1", commessa);
            ReportParameter b = new ReportParameter("p2", articolo);
            ReportParameter c = new ReportParameter("p3", descrizione);
            ReportParameter d = new ReportParameter("p4", qta);

            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { a, b, c, d });
        }
    }
}
