﻿using System;
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
using Target2021.Fase1;
using Target2021.Fornitori;
using System.Threading;

namespace Target2021
{
    public partial class CheckImpiegato : Form
    {
        int finito = 0;
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
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.GiacenzeMagazzini'. È possibile spostarla o rimuoverla se necessario.
            this.giacenzeMagazziniTableAdapter.Fill(this.target2021DataSet.GiacenzeMagazzini);
            inserimento_iniziale();
            verifica_commesse();
            WindowState = FormWindowState.Maximized;
            finito = 1;            
        }

        private void Colora()
        {
            int richieste=0, disponibilitot=0, disponibilimagaz=0, disponibiliord = 0;
            if (finito==1)
            {
                foreach (DataGridViewRow riga in dataGridView1.Rows)
                {
                    try
                    {
                        richieste = Convert.ToInt32(riga.Cells["Lastre Richieste"].Value);
                        disponibilimagaz = Convert.ToInt32(riga.Cells["Disponibilità Lastre Magazzino"].Value);
                        disponibiliord = Convert.ToInt32(riga.Cells["Disponibilità Lastre Ordinato"].Value);
                        disponibilitot = disponibilimagaz + disponibiliord;
                        if (richieste > disponibilitot)
                            riga.DefaultCellStyle.BackColor = Color.Orange;
                        else
                            riga.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    catch
                    {
                        // Non ci sono dei valori
                    }
                }
            }
        }

        public void inserimento_iniziale()
        {
            string query = "Select IDMateriaPrima AS [Materia Prima],SUM(NrLastreRichieste) as [Lastre Richieste] FROM Commesse WHERE TipoCommessa=1 AND (Stato=0 OR Stato=1) GROUP BY IDMateriaPrima";
            SqlConnection connessione = new SqlConnection(stringa_connessione);
            SqlCommand comando = new SqlCommand(query, connessione);
            connessione.Open();
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.SelectCommand = comando;
            SDA.Fill(dataTable);
            dataTable.Columns.Add("Disponibilità Lastre Magazzino", typeof(Int32));
            dataTable.Columns.Add("Disponibilità Lastre Ordinato", typeof(Int32));
            dataTable.Columns.Add("Descrizione materia prima", typeof(String));
            dataTable.Columns.Add("Codice fornitore", typeof(String));
            dataTable.Columns.Add("Descrizione fornitore", typeof(String));
            dataTable.Columns.Add("Lastre già impegnate su altre commesse", typeof(Int32));
            BindingSource source = new BindingSource();
            source.DataSource = dataTable;
            dataGridView1.DataSource = source;
            dataGridView1.Columns["Descrizione fornitore"].Visible = false;
            SDA.Update(dataTable);
            connessione.Close();
        }

        public void verifica_commesse()
        {
            SqlConnection conn = new SqlConnection(stringa_connessione);
            BindingSource source = new BindingSource();
            DataGridViewRow riga;
            int Pezzi = 0, PezziRichiesti = 0, nriga = 0, nrighe;
            string des_for;
            nrighe =dataGridView1.RowCount;
            for (nriga=0;nriga<nrighe;nriga++)
            {
                riga = dataGridView1.Rows[nriga];
                string query1 = "Select GiacenzaDisponibili From GiacenzeMagazzini Where idPrime='" + Convert.ToString(riga.Cells[0].Value) + "'";
                string query5 = "Select GiacenzaOrdinati From GiacenzeMagazzini Where idPrime='" + Convert.ToString(riga.Cells[0].Value) + "'";
                string query6 = "Select GiacImpegnSuOrd From GiacenzeMagazzini Where idPrime='" + Convert.ToString(riga.Cells[0].Value) + "'";
                string query2 = "Select descrizione From Prime Where codice='" + Convert.ToString(riga.Cells[0].Value) + "'";
                string query3 = "Select codice_fornitore From Prime Where codice='" + Convert.ToString(riga.Cells[0].Value) + "'";       
                string query7 = "SELECT GiacenzaImpegnati+GiacImpegnSuOrd FROM GiacenzeMagazzini WHERE idPrime='" + Convert.ToString(riga.Cells[0].Value) + "'";
                SqlCommand comando1 = new SqlCommand(query1, conn);
                SqlCommand comando2 = new SqlCommand(query2, conn);
                SqlCommand comando3 = new SqlCommand(query3, conn);
                SqlCommand comando5 = new SqlCommand(query5, conn);
                SqlCommand comando6 = new SqlCommand(query6, conn);
                SqlCommand comando7 = new SqlCommand(query7, conn);
                conn.Open();
                int giacenza = Convert.ToInt32(comando1.ExecuteScalar());
                int ordinati = Convert.ToInt32(comando5.ExecuteScalar());
                int ImpSuOrd = Convert.ToInt32(comando6.ExecuteScalar());
                int Impegnati = Convert.ToInt32(comando7.ExecuteScalar());
                int LiberiOrdinati = ordinati - ImpSuOrd;
                string descrizione = comando2.ExecuteScalar().ToString();
                string cod_for= comando3.ExecuteScalar().ToString();
                string query4 = "Select ragione_sociale From Fornitori Where codice='" + cod_for + "'";
                SqlCommand comando4 = new SqlCommand(query4, conn);
                try
                {
                    des_for = comando4.ExecuteScalar().ToString();
                }
                catch {
                    MessageBox.Show("Manca il codice fornitore della lastra " + Convert.ToString(riga.Cells[0].Value) +" in anagrafica");
                    des_for = "Assente";
                }
                dataTable.Rows[nriga]["Disponibilità Lastre Magazzino"]=giacenza;
                dataTable.Rows[nriga]["Disponibilità Lastre Ordinato"] = LiberiOrdinati;
                dataTable.Rows[nriga]["Descrizione materia prima"] = descrizione;
                dataTable.Rows[nriga]["Codice fornitore"] = cod_for;
                dataTable.Rows[nriga]["Descrizione fornitore"] = des_for;
                dataTable.Rows[nriga]["Lastre già impegnate su altre commesse"] = Impegnati;
                PezziRichiesti = Convert.ToInt32(riga.Cells[1].Value);
                //if (giacenza < PezziRichiesti)
                int mancanti = PezziRichiesti - giacenza - LiberiOrdinati;
                if (mancanti>0)
                {
                    richTextBox1.Text = richTextBox1.Text + "PROPOSTA DI ORDINE A FORNITORE";
                    richTextBox1.Text = richTextBox1.Text + "\r" + "Ordinare materia prima codice: " + Convert.ToString(riga.Cells[0].Value)+" - "+ Convert.ToString(riga.Cells[4].Value);
                    richTextBox1.Text = richTextBox1.Text + "\r" + "Fornitore: " + Convert.ToString(riga.Cells[5].Value) + " - " + Convert.ToString(riga.Cells[6].Value);
                    richTextBox1.Text = richTextBox1.Text + "\r" + "Quantità da ordinare: " + mancanti.ToString();
                    richTextBox1.Text = richTextBox1.Text + "\r\r";
                }
                conn.Close();
            }
            source.DataSource = dataTable;
            dataGridView1.DataSource = source;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aggiorna();
            Colora();
        }

        private void aggiorna()
        {
            dataTable.Columns.Remove("Disponibilità Lastre Magazzino");
            dataTable.Columns.Remove("Disponibilità Lastre Ordinato");
            dataTable.Columns.Remove("Descrizione materia prima");
            dataTable.Columns.Remove("Codice fornitore");
            dataTable.Columns.Remove("Descrizione fornitore");
            dataTable.Columns.Remove("Lastre già impegnate su altre commesse");
            dataTable.Clear();
            richTextBox1.Text = "";
            inserimento_iniziale();
            verifica_commesse();
        }

        private void Selezi(object sender, DataGridViewCellEventArgs e)
        {
            string CodiceLastra="",DescrizioneLastra="";

            if (e.RowIndex > -1 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                CodiceLastra = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                DescrizioneLastra = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            ImpegnaMatPrima Impegna = new ImpegnaMatPrima(CodiceLastra,DescrizioneLastra);
            Impegna.ShowDialog();
            aggiorna();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            NuovoOrdineForn NOF = new NuovoOrdineForn();
            NOF.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisimpegnaLastre DL = new DisimpegnaLastre();
            DL.Show();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
            Colora();
        }
    }
}
