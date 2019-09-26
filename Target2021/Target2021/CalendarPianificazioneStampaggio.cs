using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021
{
    public partial class CalendarPianificazioneStampaggio : Form
    {
        public CalendarPianificazioneStampaggio()
        {
            InitializeComponent();
        }

        

        private void CalendarPianificazioneStampaggio_Load(object sender, EventArgs e)
        {
            this.commesseTableAdapter2.Fill(this.target2021DataSet2.Commesse);
            DayOfWeek dow = DateTime.Now.DayOfWeek;

            switch (dow)
            {
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Monday:
                    break;
                case DayOfWeek.Saturday:
                    break;
                case DayOfWeek.Sunday:
                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Tuesday:
                    DataView CPianifM1 = new DataView(target2021DataSet2.Commesse);
                    CPianifM1.RowFilter = "TipoCommessa = 1 AND Stato = 3 AND SchedMach = 1";  
                    dataGridView2.DataSource = CPianifM1;
                    foreach (DataGridViewColumn col in dataGridView2.Columns)
                    {
                        if ( col.HeaderText == "Articolo")
                            col.Visible = true;
                        else
                            col.Visible = false;
                    }
                    break;
                case DayOfWeek.Wednesday:
                    break;
            }
        }
    }
}
