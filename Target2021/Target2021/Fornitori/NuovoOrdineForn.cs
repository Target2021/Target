using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Target2021.Selezioni;
using Target2021.Stampe;

namespace Target2021.Fornitori
{
    public partial class NuovoOrdineForn : Form
    {
        DataTable dt = new DataTable("Articoli");
        int IdTestata;

        public NuovoOrdineForn()
        {
            InitializeComponent();
        }

        private void SelezForn(object sender, MouseEventArgs e)
        {
            SelezionaFornitore SF = new SelezionaFornitore();
            SF.ShowDialog();
            string cod = SF.codice;
            textBox1.Text = cod;
        }

        private void fornitoriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornitoriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }

        private void NuovoOrdineForn_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.GiacenzeMagazzini'. È possibile spostarla o rimuoverla se necessario.
            this.giacenzeMagazziniTableAdapter.Fill(this.target2021DataSet.GiacenzeMagazzini);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.GiacenzeMagazzini'. È possibile spostarla o rimuoverla se necessario.
            this.giacenzeMagazziniTableAdapter.Fill(this.target2021DataSet.GiacenzeMagazzini);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.ArtForn'. È possibile spostarla o rimuoverla se necessario.
            this.artFornTableAdapter.Fill(this.target2021DataSet.ArtForn);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.OrdFornTest'. È possibile spostarla o rimuoverla se necessario.
            this.ordFornTestTableAdapter.Fill(this.target2021DataSet.OrdFornTest);
            this.primeTableAdapter.Fill(this.target2021DataSet.Prime);
            this.ordFornDettTableAdapter.Fill(this.target2021DataSet.OrdFornDett);
            this.codTermPagamentoTableAdapter.Fill(this.target2021DataSet.CodTermPagamento);
            this.codModPagamentoTableAdapter.Fill(this.target2021DataSet.CodModPagamento);
            this.codSpedizioniTableAdapter.Fill(this.target2021DataSet.CodSpedizioni);
            this.fornitoriTableAdapter.Fill(this.target2021DataSet.Fornitori);
            AggiornaNrOrdine();
            CreaTabella();
        }

        private void AggiornaNrOrdine()
        {
            int Nr=0;
            try
            {
                Nr = target2021DataSet.Tables["OrdFornTest"].AsEnumerable().Max(x => x.Field<int>("NrOrdine"));
            }
            catch { Nr = 0; }
            textBox2.Text = (Nr+1).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fornitoriBindingSource.Filter = "codice = '" + textBox1.Text+"'";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                codSpedizioniBindingSource.Filter = "idCodSped = '" + textBox3.Text + "'";
            }
            catch
            {
                textBox7.Text = "Non definito";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                codModPagamentoBindingSource.Filter = "IdCodModPag = '" + textBox4.Text + "'";
            }
            catch
            {
                textBox8.Text = "Non definito";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                codTermPagamentoBindingSource.Filter = "idCodTermPag = '" + textBox5.Text + "'";
            }
            catch
            {
                textBox9.Text = "Non definito";
            }
        }

        private void SelezSpediz(object sender, MouseEventArgs e)
        {
            SelezionaSpedizione SS = new SelezionaSpedizione();
            SS.ShowDialog();
            string cod = SS.codice;
            textBox3.Text = cod;
        }

        private void SelezModPag(object sender, MouseEventArgs e)
        {
            SelezionaModalitaPagamento SMP = new SelezionaModalitaPagamento();
            SMP.ShowDialog();
            string cod = SMP.codice;
            textBox4.Text = cod;
        }

        private void SelezTermPag(object sender, MouseEventArgs e)
        {
            SelezionaTerminiPagamento STP = new SelezionaTerminiPagamento();
            STP.ShowDialog();
            string cod = STP.codice;
            textBox5.Text = cod;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            string descrizione="Non trovato nessun articolo", peso="";
            DataRow[] risultato, std;
            DataRow ris;
            if (comboBox1.Text == "Lastre")
            {
                try
                {                    
                    risultato = target2021DataSet.Tables["ArtForn"].Select("CodArticoloTarget = '" + textBox10.Text + "' AND CodFornitore = '" + textBox1.Text + "'");
                    ris = risultato[0];
                    descrizione = ris[3].ToString();
                }
                catch 
                {
                    try
                    {
                        std = target2021DataSet.Tables["Prime"].Select("codice= '" + textBox10.Text + "'");
                        ris = std[0];
                        descrizione = ris[2].ToString();
                    }
                    catch { }
                }
                try
                {
                    std = target2021DataSet.Tables["Prime"].Select("codice= '" + textBox10.Text + "'");
                    ris = std[0];
                    peso = ris[13].ToString();
                }
                catch { }
            }
            textBox11.Text = descrizione;
            label12.Text = peso;
        }

        private void Seleziona(object sender, MouseEventArgs e)
        {
            SelezionaLastre SL= new SelezionaLastre();
            SL.ShowDialog();
            string cod = SL.codice;
            textBox10.Text = cod;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox10.Text =="")
            {
                MessageBox.Show("Devi indicare il codice articolo che vuoi ordinare!");
            }
            if (textBox12.Text == "")
            {
                MessageBox.Show("Devi indicare la quantità che vuoi ordinare!");
            }
            AggiungiRiga();
            //MessageBox.Show("Riga aggiunta all'ordine!");
        }

        private void CreaTabella()
        {
            dt.Columns.Add("Codice Articolo",System.Type.GetType("System.String"));
            dt.Columns.Add("Descrizione",System.Type.GetType("System.String"));
            dt.Columns.Add("Quantità",System.Type.GetType("System.Int32"));
            dt.Columns.Add("Data consegna", System.Type.GetType("System.DateTime"));
            dt.Columns.Add("Peso unitario", System.Type.GetType("System.String"));
            dt.Columns.Add("Peso complessivo", System.Type.GetType("System.String"));
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 400;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
        }

        private void AggiungiRiga()
        {
            double pesos, pesot;
            int numero;
            pesos = Double.Parse(label12.Text);
            //pesos = Convert.ToDouble(label12.Text);
            numero = Convert.ToInt32(textBox12.Text);
            pesot = pesos * numero;
            dt.Rows.Add(new object[]{textBox10.Text, textBox11.Text, Convert.ToInt32(textBox12.Text), dateTimePicker2.Text, label12.Text,pesot.ToString()});
            dataGridView1.DataSource = dt;
        }

        private void SoloNumeri(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalvaTestataOF();
            SalvaDettaglioOF();
            SalvaGiacenzeMagazzino();
            MessageBox.Show("Ordine registrato correttamente");
            Disabilita();
        }

        private void Disabilita()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            dateTimePicker1.Enabled = false;
            button1.Enabled = false;
            dataGridView1.Enabled = false;
        }

        private void SalvaTestataOF()
        {
            string IDF;
            DateTime DataOrdine;
            int NrOrdine, CodSped, CodModPag, CodTermPag;

            IDF = textBox1.Text;
            DataOrdine = dateTimePicker1.Value;
            NrOrdine = Convert.ToInt32(textBox2.Text);
            CodSped= Convert.ToInt32(textBox3.Text);
            CodModPag = Convert.ToInt32(textBox4.Text);
            CodTermPag = Convert.ToInt32(textBox5.Text);

            ordFornTestTableAdapter.Insert(IDF,DataOrdine,NrOrdine,0,0,0,0,0,CodSped,CodModPag,CodTermPag);
            ordFornTestTableAdapter.Fill(target2021DataSet.OrdFornTest);
            ImpostaIdTestata();
        }

        private void ImpostaIdTestata()
        {
            SqlConnection connessione = new SqlConnection(Properties.Resources.StringaConnessione);
            connessione.Open();
            string query = "SELECT MAX(idOFTestata) FROM OrdFornTest";
            SqlCommand comando = new SqlCommand(query, connessione);
            IdTestata=Convert.ToInt32(comando.ExecuteScalar());
            connessione.Close();
        }

        private void SalvaDettaglioOF()
        {
            int NrOrdine, Qta;
            string CodArt, Descr;
            DateTime DataCons;
            double Peso;
            NrOrdine = IdTestata;

            foreach (DataGridViewRow riga in dataGridView1.Rows)
            {
                CodArt =Convert.ToString(riga.Cells[0].Value);
                Descr = Convert.ToString(riga.Cells[1].Value);
                Qta = Convert.ToInt32(riga.Cells[2].Value);
                DataCons = Convert.ToDateTime(riga.Cells[3].Value);
                Peso = Convert.ToDouble(riga.Cells[4].Value);
                Peso = Peso * Qta;
                ordFornDettTableAdapter.Insert(NrOrdine, CodArt, Descr, Qta, DataCons, DataCons, 0, 0, 0, Peso, 0, 0,DataCons, null, DataCons, "Note:");
                ordFornDettTableAdapter.Fill(target2021DataSet.OrdFornDett);
            }
        }

        private void SalvaGiacenzeMagazzino()
        {
            string CodArt;
            int QtaRiga, QtaOrdinato;

            foreach (DataGridViewRow riga in dataGridView1.Rows)
            {
                CodArt = Convert.ToString(riga.Cells[0].Value);
                SeNonEsisteCrea(CodArt);
                QtaRiga = Convert.ToInt32(riga.Cells[2].Value);
                try { 
                        QtaOrdinato = Convert.ToInt32 ((target2021DataSet.Tables["GiacenzeMagazzini"].Select("idPrime = '" + CodArt + "'"))[0]["GiacenzaOrdinati"]);
                    }
                catch
                    {
                        QtaOrdinato = 0;
                    }
                QtaOrdinato = QtaOrdinato + QtaRiga;

                SqlConnection connessione = new SqlConnection(Properties.Resources.StringaConnessione);
                connessione.Open();
                string query = "UPDATE GiacenzeMagazzini SET GiacenzaOrdinati = "+ QtaOrdinato.ToString() + " WHERE idPrime = '" + CodArt + "'";
                SqlCommand comando = new SqlCommand(query, connessione);
                comando.ExecuteNonQuery();
                connessione.Close();
            }
        }

        private void SeNonEsisteCrea(string Cod)
        {
            DataRow[] RigaTrovata;
            RigaTrovata = target2021DataSet.Tables["GiacenzeMagazzini"].Select("idPrime = '" + Cod + "'");

            if (RigaTrovata.Length != 0)
            {
                //MessageBox.Show("L'articolo "+Cod+" esiste nelle giacenze");
            }
            else
            {
                //MessageBox.Show("L'articolo "+Cod+" va creato nelle giacenze!");
                Target2021DataSet.GiacenzeMagazziniRow riga = target2021DataSet.GiacenzeMagazzini.NewGiacenzeMagazziniRow();
                riga.idMagazzino = 1;
                riga.idPrime = Cod;
                riga.GiacenzaComplessiva = 0;
                riga.GiacenzaDisponibili = 0;
                riga.GiacenzaImpegnati = 0;
                riga.DataUltimoMovimento = DateTime.Today;
                riga.GiacenzaOrdinati = 0;
                riga.GiacImpegnSuOrd = 0;
                target2021DataSet.GiacenzeMagazzini.Rows.Add(riga);
                giacenzeMagazziniTableAdapter.Update(target2021DataSet.GiacenzeMagazzini);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string NrO = textBox2.Text;
            string dto = dateTimePicker1.Text;
            string p3 = textBox7.Text;
            string p4 = textBox8.Text;
            string p5 = textBox9.Text;
            string p6 = textBox1.Text;
            string p7 = IdTestata.ToString();

            StampaOrdFor stampa = new StampaOrdFor(NrO,dto,p3,p4,p5,p6,p7);
            stampa.Show();
        }
    }
}
