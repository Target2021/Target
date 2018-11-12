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
        private string num, DtO, par3,par4,par5, par6;

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private string ragsoc, ind, cap, loc, prov, IdT;

        public StampaOrdFor(string Nr, string dt, string p3, string p4, string p5, string CodFor, string p7)
        {
            InitializeComponent();
            num = Nr;
            DtO = dt;
            par3 = p3;  // spedizione
            par4 = p4;  // mod pagam
            par5 = p5;  // term pagam
            par6 = CodFor; // Codice Fornitore
            IdT = p7;
        }

        private void StampaOrdFor_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Fornitori'. È possibile spostarla o rimuoverla se necessario.
            this.fornitoriTableAdapter.Fill(this.target2021DataSet.Fornitori);
            this.ordFornDettTableAdapter.Fill(this.target2021DataSet.OrdFornDett);
            recuperaAnaForn();
            prova();
        }

        private void recuperaAnaForn()
        {
            RecAnaForn recupera = new RecAnaForn(par6);
            ragsoc = recupera.RagSoc;
            ind = recupera.Indirizzo;
            cap = recupera.Cap;
            loc = recupera.Localita;
            prov = recupera.Provincia;
        }

        private void prova()
        {
            ReportParameter p1 = new ReportParameter("Param1", num);
            ReportParameter p2 = new ReportParameter("Param2", DtO);
            ReportParameter p3 = new ReportParameter("Param3", par3);
            ReportParameter p4 = new ReportParameter("Param4", par4);
            ReportParameter p5 = new ReportParameter("Param5", par5);
            ReportParameter p6 = new ReportParameter("PRagSoc", ragsoc);
            ReportParameter p7 = new ReportParameter("PInd", ind);
            ReportParameter p8 = new ReportParameter("PCap", cap);
            ReportParameter p9 = new ReportParameter("PLoc", loc);
            ReportParameter p10 = new ReportParameter("PProv", prov);
            ReportParameter p11 = new ReportParameter("Param6", IdT);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1,p2,p3,p4,p5,p6,p7,p8,p9,p10,p11 });
            this.reportViewer1.RefreshReport();
        }
    }
}
