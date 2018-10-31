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
    public partial class StampaOrdFor : Form
    {
        private string num, DtO, par3,par4,par5;

        public StampaOrdFor(string Nr, string dt, string p3, string p4, string p5)
        {
            InitializeComponent();
            num = Nr;
            DtO = dt;
            par3 = p3;  // spedizione
            par4 = p4;  // mod pagam
            par5 = p5;  // term pagam
        }

        private void StampaOrdFor_Load(object sender, EventArgs e)
        {
            this.ordFornDettTableAdapter.Fill(this.target2021DataSet.OrdFornDett);
            prova();
        }

        private void prova()
        {
            ReportParameter p1 = new ReportParameter("Param1", num);
            ReportParameter p2 = new ReportParameter("Param2", DtO);
            ReportParameter p3 = new ReportParameter("Param3", par3);
            ReportParameter p4 = new ReportParameter("Param4", par4);
            ReportParameter p5 = new ReportParameter("Param5", par5);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1,p2,p3,p4,p5 });
            this.reportViewer1.RefreshReport();
        }
    }
}
