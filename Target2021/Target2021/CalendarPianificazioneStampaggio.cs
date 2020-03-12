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

namespace Target2021
{
    public partial class CalendarPianificazioneStampaggio : Form
    {
        DateTime oggi;
        string stringa_connessione = Properties.Resources.StringaConnessione;
        string query;
        public CalendarPianificazioneStampaggio()
        {
            InitializeComponent();
        }

        

        private void CalendarPianificazioneStampaggio_Load(object sender, EventArgs e)
        {
            this.commesseTableAdapter2.Fill(this.target2021DataSet2.Commesse);
            DayOfWeek dow = DateTime.Now.DayOfWeek;
            oggi = DateTime.Today;
            DateTime giorno;
            if (dow != DayOfWeek.Monday)
            {
                if (dow != DayOfWeek.Sunday)
                {
                    giorno = oggi.AddDays(-1 * Convert.ToInt32(dow) - 1); 
                }
                else
                {
                    giorno = oggi.AddDays(-6);
                }

            }else
            {
                giorno = oggi;
            }

            for (int i = 0; i <= 5; i++)
            {
                switch (giorno.DayOfWeek)
                {
                    case DayOfWeek.Friday:
                        query = "select * from Commesse where TipoCommessa = 1 AND Stato = 3 AND SchedMach = 1 AND SchedData = @Date";
                        visualizzazione(query, dataGridView5);
                        query = "select * from Commesse where TipoCommessa = 1 AND Stato = 3 AND SchedMach = 2 AND SchedData = @Date";
                        visualizzazione(query, dataGridView6);
                        query = "select * from Commesse where TipoCommessa = 1 AND Stato = 3 AND SchedMach = 3 AND SchedData = @Date";
                        visualizzazione(query, dataGridView11);
                        break;
                    case DayOfWeek.Monday:
                        query = "select * from Commesse where TipoCommessa = 1 AND Stato = 3 AND SchedMach = 1 AND SchedData = @Date";
                        visualizzazione(query, dataGridView1);
                        query = "select * from Commesse where TipoCommessa = 1 AND Stato = 3 AND SchedMach = 2 AND SchedData = @Date";
                        visualizzazione(query, dataGridView10);
                        query = "select * from Commesse where TipoCommessa = 1 AND Stato = 3 AND SchedMach = 3 AND SchedData= @Date";
                        visualizzazione(query, dataGridView15);
                        break;
                    case DayOfWeek.Saturday:
                        break;
                    case DayOfWeek.Sunday:
                        break;
                    case DayOfWeek.Thursday:
                        query = "select * from Commesse where TipoCommessa = 1 AND Stato = 3 AND SchedMach = 1 AND SchedData = @Date";
                        visualizzazione(query, dataGridView4);
                        query = "select * from Commesse where TipoCommessa = 1 AND Stato = 3 AND SchedMach = 2 AND SchedData = @Date";
                        visualizzazione(query, dataGridView7);
                        query = "select * from Commesse where TipoCommessa = 1 AND Stato = 3 AND SchedMach = 3 AND SchedData = @Date";
                        visualizzazione(query, dataGridView12);
                        break;
                    case DayOfWeek.Tuesday:
                        query = "select * from Commesse where TipoCommessa = 1 AND Stato = 3 AND SchedMach = 1 AND SchedData = @Date";
                        visualizzazione(query, dataGridView2);
                        query = "select * from Commesse where TipoCommessa = 1 AND Stato = 3 AND SchedMach = 2 AND SchedData = @Date";
                        visualizzazione(query, dataGridView9);
                        query = "select * from Commesse where TipoCommessa = 1 AND Stato = 3 AND SchedMach = 3 AND SchedData = @Date";
                        visualizzazione(query, dataGridView14);
                        //DataView CPianifM1 = new DataView(target2021DataSet2.Commesse);
                        //string dateFormat = oggi.ToString("yyyy/MM/dd");
                        ////CPianifM1.RowFilter = "TipoCommessa = 1 AND Stato = 3 AND SchedMach = 1 AND SchedData = '"dateFormat"'";
                        //dataGridView2.DataSource = CPianifM1;
                        //foreach (DataGridViewColumn col in dataGridView2.Columns)
                        //{
                        //    if (col.HeaderText == "Articolo")
                        //        col.Visible = true;
                        //    else
                        //        col.Visible = false;
                        //}

                        break;
                    case DayOfWeek.Wednesday:
                        query = "select * from Commesse where TipoCommessa = 1 AND Stato = 3 AND SchedMach = 1 AND SchedData = @Date";
                        visualizzazione(query, dataGridView3);
                        query = "select * from Commesse where TipoCommessa = 1 AND Stato = 3 AND SchedMach = 2 AND SchedData = @Date";
                        visualizzazione(query, dataGridView8);
                        query = "select * from Commesse where TipoCommessa = 1 AND Stato = 3 AND SchedMach = 3 AND SchedData = @Date";
                        visualizzazione(query, dataGridView13);
                        break;
                }
                giorno = giorno.AddDays(1);
            }
        }

        private void visualizzazione(string query, DataGridView finestra)
        {
            SqlConnection connessione = new SqlConnection(stringa_connessione);
            SqlCommand comando2 = new SqlCommand(query, connessione);
            comando2.Parameters.Add("@Date", SqlDbType.Date).Value = oggi.Date.ToString("yyyy-MM-dd");
            connessione.Open();
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(comando2);
            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            finestra.DataSource = dtRecord;
            connessione.Close();
        }
    }
}
