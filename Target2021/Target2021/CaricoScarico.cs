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
using Target2021.Selezioni;

namespace Target2021
{
    public partial class CaricoScarico : Form
    {
        public CaricoScarico()
        {
            InitializeComponent();
        }

        private void movimentiMagazzinoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movimentiMagazzinoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }

        private void CaricoScarico_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Prime'. È possibile spostarla o rimuoverla se necessario.
            this.primeTableAdapter.Fill(this.target2021DataSet.Prime);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.GiacenzeMagazzini'. È possibile spostarla o rimuoverla se necessario.
            this.giacenzeMagazziniTableAdapter.Fill(this.target2021DataSet.GiacenzeMagazzini);
            this.anaMagazziniTableAdapter.Fill(this.target2021DataSet.AnaMagazzini);
            this.movimentiMagazzinoTableAdapter.Fill(this.target2021DataSet.MovimentiMagazzino);
            if (comboBox1 .SelectedIndex == 0)
            {
                textBox5.Visible = true;
                textBox6.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
            }
            else
            {
                textBox5.Visible = false;
                textBox6.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }
        }

        private void Seleziona(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)  // Materie prime
            {
                SelezionaLastre SL = new SelezionaLastre();
                SL.ShowDialog();
                string cod = SL.codice;
                textBox1.Text = cod;
            }
            if (comboBox1.SelectedIndex == 1) // Stampi
            {
                SelezionaStampo SS = new SelezionaStampo();
                SS.ShowDialog();
                string cod = SS.codice;
                textBox1.Text = cod;
            }
            if (comboBox1.SelectedIndex == 2) // Dime
            {
                SelezionaDime SD = new SelezionaDime();
                SD.ShowDialog();
                string cod = SD.codice;
                textBox1.Text = cod;
            }
            if (comboBox1.SelectedIndex == 3 || comboBox1.SelectedIndex == 4) // Semilavorati e prodotti finiti
            {
                SelezionaArticolo SA = new SelezionaArticolo();
                SA.ShowDialog();
                string cod = SA.codice;
                textBox1.Text = cod;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox5.Visible = true;
                textBox6.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
            }
            else
            {
                textBox5.Visible = false;
                textBox6.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2 .Checked == false)
            {
                MessageBox.Show("Devi selezionare se è un operazione di CARICO o di SCARICO!");
                radioButton1.Focus();
            }
            else
            {
                try
                {
                    int IdMagazzino, qta, AMagazzino=0;
                    double peso=0, prezzo=0;
                    string CodArt, CS="X", BarCode, NrOrdine, Causale;
                    DateTime datamov;

                    IdMagazzino = Convert.ToInt32(comboBox1.SelectedValue);
                    CodArt = textBox1.Text;
                    Causale = textBox8.Text;
                    if (radioButton1.Checked == true) CS = "C";
                    if (radioButton2.Checked == true) CS = "S";
                    qta = Convert.ToInt32(textBox2.Text);
                    BarCode = textBox3.Text;
                    NrOrdine = textBox4.Text;
                    if (textBox7.Visible==true) AMagazzino = Convert.ToInt32(textBox7.Text);
                    datamov = dateTimePicker1.Value;
                    if (textBox5.Text != "") peso = Convert.ToDouble(textBox5.Text);
                    if (textBox6.Text != "") prezzo = Convert.ToDouble(textBox6.Text);
                    if (IdMagazzino == 1) movimentiMagazzinoTableAdapter.Insert(IdMagazzino,CodArt,"","","","", CS, qta, BarCode, NrOrdine, datamov, peso, prezzo, Causale);
                    if (IdMagazzino == 2) movimentiMagazzinoTableAdapter.Insert(IdMagazzino, "", CodArt, "", "", "", CS, qta, BarCode, NrOrdine, datamov, peso, prezzo, Causale);
                    if (IdMagazzino == 3) movimentiMagazzinoTableAdapter.Insert(IdMagazzino, "", "", CodArt, "", "", CS, qta, BarCode, NrOrdine, datamov, peso, prezzo, Causale);
                    if (IdMagazzino == 4) movimentiMagazzinoTableAdapter.Insert(IdMagazzino, "", "", "", CodArt, "", CS, qta, BarCode, NrOrdine, datamov, peso, prezzo, Causale);
                    if (IdMagazzino == 5) movimentiMagazzinoTableAdapter.Insert(IdMagazzino, "", "", "", "", CodArt, CS, qta, BarCode, NrOrdine, datamov, peso, prezzo, Causale);
                    movimentiMagazzinoTableAdapter.Fill(this.target2021DataSet.MovimentiMagazzino);
                    if (CS=="C")
                    {
                        AggiornaGiacenzeC(qta, CodArt, CS);
                        MessageBox.Show("Movimento registrato correttamente!");
                    }

                    if (CS == "S" && qta <= AMagazzino)
                    {
                        AggiornaGiacenzeS(qta, CodArt, CS);
                        MessageBox.Show("Movimento registrato correttamente!");
                    }
                    if (CS == "S" && qta > AMagazzino)
                        MessageBox.Show("Non hai disponibili la quantità richiesta!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert Failed");
                }
            }
        }

        private void AggiornaGiacenzeC(int q, string Cod, string cs)
        {
            int numero, disponibili;
            string query2, query3;
            DateTime ora;
            SqlCommand comando2, comando3;
            SqlConnection conn = new SqlConnection(Properties.Resources.StringaConnessione);
            conn.Open();
            string query1 = "SELECT SUM(GiacenzaComplessiva) FROM GiacenzeMagazzini WHERE idPrime='" + Cod + "'";
            SqlCommand comando1 = new SqlCommand(query1, conn);
            try
            {
                numero = (int) comando1.ExecuteScalar();
                query2 = "SELECT SUM(GiacenzaDisponibili) FROM GiacenzeMagazzini WHERE idPrime='" + Cod + "'";
                comando2 = new SqlCommand(query2, conn);
                disponibili = (int)comando2.ExecuteScalar();
                numero = numero + q;
                disponibili = disponibili + q;
                // update
                ora = DateTime.Now;
                query2 = "UPDATE GiacenzeMagazzini SET GiacenzaComplessiva = "+numero.ToString() + ", GiacenzaDisponibili = " + disponibili.ToString() + ", DataUltimoMovimento = '"+ora.ToString()+"' WHERE idPrime='" + Cod + "'";
                comando2 = new SqlCommand(query2, conn);
                comando2.ExecuteNonQuery();
                MessageBox.Show("Articolo: " + Cod + " - Giacenza: " + numero.ToString() + " - Disponibili: " + disponibili.ToString());
            }
            catch
            {
                numero = q;
                disponibili = q;
                // insert
                ora = DateTime.Now;
                query2 = "INSERT INTO GiacenzeMagazzini (idMagazzino, idPrime, GiacenzaComplessiva, GiacenzaDisponibili, GiacenzaImpegnati, DataUltimoMovimento, GiacenzaOrdinati, GiacImpegnSuOrd) VALUES (1, '" + Cod + "', " + numero.ToString() + ", " + disponibili.ToString() + ", 0, '" + ora.ToString() + "',0 ,0)";   
                comando2 = new SqlCommand(query2, conn);
                comando2.ExecuteNonQuery();
                MessageBox.Show("Materia prima non presente in magazzino. Creata.");
                MessageBox.Show("Articolo: " + Cod + " - Giacenza: " + numero.ToString() + " - Disponibili: " + disponibili.ToString());
            }
            conn.Close();
        }

        private void AggiornaGiacenzeS(int q, string Cod, string cs)
        {
            int numero, disponibili;
            string query2, query3;
            DateTime ora;
            SqlCommand comando2, comando3;
            SqlConnection conn = new SqlConnection(Properties.Resources.StringaConnessione);
            conn.Open();
            string query1 = "SELECT SUM(GiacenzaComplessiva) FROM GiacenzeMagazzini WHERE idPrime='" + Cod + "'";
            SqlCommand comando1 = new SqlCommand(query1, conn);
            try
            {
                numero = (int)comando1.ExecuteScalar();
                if (numero > 0)   // articolo già presente nelle giacenze
                {
                    query2 = "SELECT SUM(GiacenzaDisponibili) FROM GiacenzeMagazzini WHERE idPrime='" + Cod + "'";
                    comando2 = new SqlCommand(query2, conn);
                    disponibili = (int)comando2.ExecuteScalar();
                    numero = numero - q;
                    disponibili = disponibili - q;
                    // update
                    ora = DateTime.Now;
                    query2 = "UPDATE GiacenzeMagazzini SET GiacenzaComplessiva = " + numero.ToString() + ", GiacenzaDisponibili = " + disponibili.ToString() + ", DataUltimoMovimento = '" + ora.ToString() + "' WHERE idPrime='" + Cod + "'";
                    comando2 = new SqlCommand(query2, conn);
                    comando2.ExecuteNonQuery();
                    MessageBox.Show("Articolo: " + Cod + " - Giacenza: " + numero.ToString() + " - Disponibili: " + disponibili.ToString());
                }
            }
            catch
            {
                numero = 0;
                disponibili = 0;
                // insert
                ora = DateTime.Now;
                query2 = "INSERT INTO GiacenzeMagazzini (idMagazzino, idPrime, GiacenzaComplessiva, GiacenzaDisponibili, GiacenzaImpegnati, DataUltimoMovimento, GiacenzaOrdinati, GiacImpegnSuOrd) VALUES (1, '" + Cod + "', " + numero.ToString() + ", " + disponibili.ToString() + ", 0, '" + ora.ToString() + "',0 ,0)";
                comando2 = new SqlCommand(query2, conn);
                comando2.ExecuteNonQuery();
                MessageBox.Show("Materia prima non presente in magazzino. Creata. Scarico = 0!");
                MessageBox.Show("Articolo: " + Cod + " - Giacenza: " + numero.ToString() + " - Disponibili: " + disponibili.ToString());
            }
            conn.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label6.Visible = false;
                textBox7.Visible = false;
            }
            if (radioButton1.Checked == false)
            {
                label6.Visible = true;
                textBox7.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int pezzi;

            if (radioButton2.Checked == true)
            {
                label6.Visible = true;
                textBox7.Visible = true;
                pezzi=aggiornagiacenza(textBox1.Text);
                textBox7.Text = pezzi.ToString();
            }
            if (radioButton2.Checked == false)
            {
                label6.Visible = false;
                textBox7.Visible = false;
            }
        }

        private int aggiornagiacenza(string codice)
        {
            DataRow[] riga;
            int numero=0;
            try
            {
                string selezione = "idPrime = '" + codice + "'";
                riga = target2021DataSet.Tables["GiacenzeMagazzini"].Select(selezione);
                numero = Convert.ToInt32(riga[0]["GiacenzaComplessiva"]);
            }
            catch { }
            return numero;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double PesoSingolaLastra, PesoComplessivo;
            int qta;
            string codice;
            codice = textBox1.Text;
            PesoSingolaLastra = RecuperaPesoLastra(codice);
            try
            {
                qta = Convert.ToInt32(textBox2.Text);
            }
            catch
            {
                qta = 0;
            }

            PesoComplessivo = PesoSingolaLastra * qta;
            textBox5.Text = PesoComplessivo.ToString();
        }

        private double RecuperaPesoLastra(string cod)
        {
            DataRow riga;
            double peso;
            DataTable TabellaLastre;
            TabellaLastre = target2021DataSet.Tables["Prime"];

            try
            {
                riga = TabellaLastre.Rows.Find(cod);
                peso = Convert.ToDouble(riga["Peso"]);
            }
            catch
            {
                peso = 0;
            }

            return peso;
        }
    }
}
