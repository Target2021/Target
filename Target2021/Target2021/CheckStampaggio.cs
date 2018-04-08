﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021
{
    public partial class CheckStampaggio : Form
    {
        private string idcommessa;

        public CheckStampaggio()
        {
            InitializeComponent();
        }

        private void CheckStampaggio_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            LoadStampaggio();
            CheckConsegna();
        }

        private void LoadStampaggio()
        {
            String stringa = Properties.Resources.StringaConnessione;
            string query = "SELECT IDCommessa, CodCommessa,DataCommessa,IDCliente,DataConsegna,NRPezziDaLavorare,DescrArticolo,IDStampo,IDMateriaPrima FROM Commesse WHERE TipoCommessa=2 AND (Stato=0 OR Stato=1) AND CodCommessa LIKE 'S%'";
            SqlConnection con = new SqlConnection(stringa);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            BindingSource source = new BindingSource();
            source.DataSource = dataTable;
            dataGridView1.DataSource = source;
            sda.Update(dataTable);
            con.Close();
        }
        private void CheckConsegna()
        {
            int giorniconsegna = 0;
            int diffmese = 0;
            int diffanno = 0;
            int giornirim = 0;          
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                String stringa = Properties.Resources.StringaConnessione;
                DateTime dataconsegna = Convert.ToDateTime(dataGridView1.Rows[row.Index].Cells["DataConsegna"].Value);
                giorniconsegna = dataconsegna.Day;
                string path=AppDomain.CurrentDomain.BaseDirectory;
                giornirim = DateTime.Now.Day - giorniconsegna;
                diffmese = DateTime.Now.Month - dataconsegna.Month;
                diffanno = DateTime.Now.Year - dataconsegna.Year;
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn.Name = "col";
                imageColumn.Image = null;
                this.dataGridView1.Columns.Add(imageColumn);
                if (giornirim>0&&giornirim<=1&&diffmese==0&&diffanno==0|| diffmese>=1)
                {
                    dataGridView1["col", row.Index].Value = Properties.Resources.arrabiato;
                }
                if (giornirim>1&&giornirim<5&&diffmese==0&&diffanno==0)
                {
                    Bitmap bitmap = new Bitmap("C:\\Users\\krist\\Source\\Repos\\Target4\\Target2021\\Target2021\\Resources\\preoccupato.jpg");
                    DataGridViewImageCell cell = new DataGridViewImageCell();
                    cell.Value = bitmap;
                    dataGridView1.Rows[row.Index].Cells[9].Value = cell;
                }
                if (giornirim<=-1&&diffmese==0&&diffanno==0||diffmese<=-1)
                {
                    dataGridView1["col", row.Index].Value = Properties.Resources.felice;
                }
            }          
        }
        private void CheckGiacenzaTotale()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    int quantita =(int) row.Cells["NRPezziDaLavorare"].Value;
                    string IDMateriaPrima;
                    String stringa = Properties.Resources.StringaConnessione;
                    IDMateriaPrima = row.Cells["IDMateriaPrima"].Value.ToString();
                    string query = "SELECT GiacenzaDisponibili FROM GiacenzeMagazzini WHERE idPrime='" + IDMateriaPrima+ "'";
                    SqlConnection con = new SqlConnection(stringa);
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    int Giacenza = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                    int diff = Giacenza - quantita;
                    if (diff < 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                    if (Enumerable.Range(0, 10).Contains(diff))
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    if (diff > 10)
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CheckGiacenzaRow(int index)
        {
            try
            {
                idcommessa = Convert.ToString(dataGridView1.Rows[index].Cells["IDCommessa"].Value);
                idcommessa.Replace("  ", string.Empty);
                int quantita = Convert.ToInt32(dataGridView1.Rows[index].Cells["NRPezziDaLavorare"].Value);
                String stringa = Properties.Resources.StringaConnessione;
                string query = "SELECT GiacenzaDisponibili FROM GiacenzeMagazzini WHERE idPrime='" + dataGridView1.Rows[index].Cells["IDMateriaPrima"].Value + "'";
                SqlConnection con = new SqlConnection(stringa);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                int Giacenza = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                int diff = Giacenza - quantita;
                if (diff < 0)
                {
                    //dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.Red;
                    MessageBox.Show("Giacenza insufficiente, si prega di effettuare il riordino");
                }
                if (Enumerable.Range(0, 10).Contains(diff))
                {
                    //dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.Yellow;
                    LavoraStampaggio lavoraStampaggio = new LavoraStampaggio(idcommessa);
                    lavoraStampaggio.Show();
                }
                if (diff > 10)
                {
                    //dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.Green;
                    LavoraStampaggio lavoraStampaggio = new LavoraStampaggio(idcommessa);
                    lavoraStampaggio.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadStampaggio();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {            
            CheckGiacenzaTotale();
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==5)
            {
                CheckConsegna();
            }           
            CheckGiacenzaTotale();
            DateTime DataCommessa =Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["DataCommessa"].Value);
            DateTime DataConsegna = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["DataConsegna"].Value);
            String stringa = Properties.Resources.StringaConnessione;
            string query = "UPDATE Commesse SET CodCommessa='" + dataGridView1.Rows[e.RowIndex].Cells["CodCommessa"].Value + "', DataCommessa='" + DataCommessa.ToShortDateString() + "',IDCliente='" + dataGridView1.Rows[e.RowIndex].Cells["IDCliente"].Value + "',DataConsegna='" +DataConsegna.ToShortDateString() + "',NRPezziDaLavorare='" + dataGridView1.Rows[e.RowIndex].Cells["NRPezziDaLavorare"].Value + "',DescrArticolo='" + dataGridView1.Rows[e.RowIndex].Cells["DescrArticolo"].Value + "',IDStampo ='" + dataGridView1.Rows[e.RowIndex].Cells["IDStampo"].Value + "',IDMateriaPrima ='" + dataGridView1.Rows[e.RowIndex].Cells["IDMateriaPrima"].Value + "' WHERE CodCommessa='"+dataGridView1.Rows[e.RowIndex].Cells["CodCommessa"].Value+"'";
            SqlConnection con = new SqlConnection(stringa);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CheckGiacenzaRow(e.RowIndex);
        }

        private void clikka(object sender, DataGridViewCellEventArgs e)
        {
            CheckGiacenzaRow(e.RowIndex);
        }
    }
}