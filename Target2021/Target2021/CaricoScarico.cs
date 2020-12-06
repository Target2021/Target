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
using Target2021.SelezAna;

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
            int pezzi;
            pezzi = aggiornagiacenza(textBox1.Text);
            textBox7.Text = pezzi.ToString();
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
                    DialogResult risultato=DialogResult.OK;
                    string CodArt, CS="X", BarCode, NrOrdine, Causale;
                    DateTime datamov;

                    IdMagazzino = Convert.ToInt32(comboBox1.SelectedValue);
                    CodArt = textBox1.Text;
                    if (IdMagazzino == 1) risultato=AnaLastre(CodArt);
                    if (risultato == DialogResult.Cancel) return;
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
                    if (IdMagazzino == 1) movimentiMagazzinoTableAdapter.Insert(IdMagazzino,CodArt,"","","","", CS, qta, BarCode, NrOrdine, datamov, peso, prezzo, Causale,0,0,0);
                    if (IdMagazzino == 2) movimentiMagazzinoTableAdapter.Insert(IdMagazzino, "", CodArt, "", "", "", CS, qta, BarCode, NrOrdine, datamov, peso, prezzo, Causale,0,0,0);
                    if (IdMagazzino == 3) movimentiMagazzinoTableAdapter.Insert(IdMagazzino, "", "", CodArt, "", "", CS, qta, BarCode, NrOrdine, datamov, peso, prezzo, Causale,0,0,0);
                    if (IdMagazzino == 4) movimentiMagazzinoTableAdapter.Insert(IdMagazzino, "", "", "", CodArt, "", CS, qta, BarCode, NrOrdine, datamov, peso, prezzo, Causale,0,0,0);
                    if (IdMagazzino == 5) movimentiMagazzinoTableAdapter.Insert(IdMagazzino, "", "", "", "", CodArt, CS, qta, BarCode, NrOrdine, datamov, peso, prezzo, Causale,0,0,0);
                    movimentiMagazzinoTableAdapter.Fill(this.target2021DataSet.MovimentiMagazzino);
                    if (CS=="C")
                    {
                        AggiornaGiacenzeC(qta, CodArt, CS, IdMagazzino);
                        MessageBox.Show("Movimento registrato correttamente!");
                        Pulisci();
                    }

                    if (CS == "S" && qta <= AMagazzino)
                    {
                        AggiornaGiacenzeS(qta, CodArt, CS, IdMagazzino);
                        MessageBox.Show("Movimento registrato correttamente!");
                        Pulisci();
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
        
        private DialogResult AnaLastre(string CodArt)
        {
            string stringaconnessione, sql;
            int num;
            DialogResult risultato = DialogResult.OK;
            stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            sql = "SELECT COUNT(codice) FROM Prime WHERE codice ='" + CodArt + "'";
            SqlCommand comando = new SqlCommand(sql, connessione);
            connessione.Open();
            try
            {
                num =Convert .ToInt32(comando.ExecuteScalar());
            }
            catch
            {
                num = 0;
            }
            connessione.Close();
            if (num==0)
            {
                string nuovo = "-1";
                SelPrime selez = new SelPrime(nuovo);
                risultato=selez.ShowDialog();
            }
            return risultato;
        }

        private void Pulisci()
        {
            textBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox8.Text = "";
            this.giacenzeMagazziniTableAdapter.Fill(this.target2021DataSet.GiacenzeMagazzini);
        }

        private void AggiornaGiacenzeC(int q, string Cod, string cs, int IdMagazzino)
        {
            int numero, disponibili;
            string query1="", query2="";
            DateTime ora;
            SqlCommand comando2;
            SqlConnection conn = new SqlConnection(Properties.Resources.StringaConnessione);
            conn.Open();
            if (IdMagazzino == 1) query1 = "SELECT SUM(GiacenzaComplessiva) FROM GiacenzeMagazzini WHERE idPrime='" + Cod + "'";
            if (IdMagazzino == 2) query1 = "SELECT SUM(GiacenzaComplessiva) FROM GiacenzeMagazzini WHERE idStampi='" + Cod + "'";
            if (IdMagazzino == 3) query1 = "SELECT SUM(GiacenzaComplessiva) FROM GiacenzeMagazzini WHERE idDime='" + Cod + "'";
            if (IdMagazzino == 4) query1 = "SELECT SUM(GiacenzaComplessiva) FROM GiacenzeMagazzini WHERE idSemilavorati='" + Cod + "'";
            if (IdMagazzino == 5) query1 = "SELECT SUM(GiacenzaComplessiva) FROM GiacenzeMagazzini WHERE idArticoli='" + Cod + "'";
            SqlCommand comando1 = new SqlCommand(query1, conn);
            try
            {
                numero = (int) comando1.ExecuteScalar();
                if (IdMagazzino == 1) query2 = "SELECT SUM(GiacenzaDisponibili) FROM GiacenzeMagazzini WHERE idPrime='" + Cod + "'";
                if (IdMagazzino == 2) query2 = "SELECT SUM(GiacenzaDisponibili) FROM GiacenzeMagazzini WHERE idStampi='" + Cod + "'";
                if (IdMagazzino == 3) query2 = "SELECT SUM(GiacenzaDisponibili) FROM GiacenzeMagazzini WHERE idDime='" + Cod + "'";
                if (IdMagazzino == 4) query2 = "SELECT SUM(GiacenzaDisponibili) FROM GiacenzeMagazzini WHERE idSemilavorati='" + Cod + "'";
                if (IdMagazzino == 5) query2 = "SELECT SUM(GiacenzaDisponibili) FROM GiacenzeMagazzini WHERE idArticoli='" + Cod + "'";
                comando2 = new SqlCommand(query2, conn);
                disponibili = (int)comando2.ExecuteScalar();
                numero = numero + q;
                disponibili = disponibili + q;
                // update
                ora = DateTime.Now;
                if (IdMagazzino == 1) query2 = "UPDATE GiacenzeMagazzini SET GiacenzaComplessiva = "+numero.ToString() + ", GiacenzaDisponibili = " + disponibili.ToString() + ", DataUltimoMovimento = '"+ora.ToString()+"' WHERE idPrime='" + Cod + "'";
                if (IdMagazzino == 2) query2 = "UPDATE GiacenzeMagazzini SET GiacenzaComplessiva = " + numero.ToString() + ", GiacenzaDisponibili = " + disponibili.ToString() + ", DataUltimoMovimento = '" + ora.ToString() + "' WHERE idStampi='" + Cod + "'";
                if (IdMagazzino == 3) query2 = "UPDATE GiacenzeMagazzini SET GiacenzaComplessiva = " + numero.ToString() + ", GiacenzaDisponibili = " + disponibili.ToString() + ", DataUltimoMovimento = '" + ora.ToString() + "' WHERE idDime='" + Cod + "'";
                if (IdMagazzino == 4) query2 = "UPDATE GiacenzeMagazzini SET GiacenzaComplessiva = " + numero.ToString() + ", GiacenzaDisponibili = " + disponibili.ToString() + ", DataUltimoMovimento = '" + ora.ToString() + "' WHERE idSemilavorati='" + Cod + "'";
                if (IdMagazzino == 5) query2 = "UPDATE GiacenzeMagazzini SET GiacenzaComplessiva = " + numero.ToString() + ", GiacenzaDisponibili = " + disponibili.ToString() + ", DataUltimoMovimento = '" + ora.ToString() + "' WHERE idArticoli='" + Cod + "'";
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
                if (IdMagazzino == 1) query2 = "INSERT INTO GiacenzeMagazzini (idMagazzino, idPrime, GiacenzaComplessiva, GiacenzaDisponibili, GiacenzaImpegnati, DataUltimoMovimento, GiacenzaOrdinati, GiacImpegnSuOrd) VALUES (1, '" + Cod + "', " + numero.ToString() + ", " + disponibili.ToString() + ", 0, '" + ora.ToString() + "',0 ,0)";
                if (IdMagazzino == 2) query2 = "INSERT INTO GiacenzeMagazzini (idMagazzino, idStampi, GiacenzaComplessiva, GiacenzaDisponibili, GiacenzaImpegnati, DataUltimoMovimento, GiacenzaOrdinati, GiacImpegnSuOrd) VALUES (2, '" + Cod + "', " + numero.ToString() + ", " + disponibili.ToString() + ", 0, '" + ora.ToString() + "',0 ,0)";
                if (IdMagazzino == 3) query2 = "INSERT INTO GiacenzeMagazzini (idMagazzino, idDime, GiacenzaComplessiva, GiacenzaDisponibili, GiacenzaImpegnati, DataUltimoMovimento, GiacenzaOrdinati, GiacImpegnSuOrd) VALUES (3, '" + Cod + "', " + numero.ToString() + ", " + disponibili.ToString() + ", 0, '" + ora.ToString() + "',0 ,0)";
                if (IdMagazzino == 4) query2 = "INSERT INTO GiacenzeMagazzini (idMagazzino, idSemilavorati, GiacenzaComplessiva, GiacenzaDisponibili, GiacenzaImpegnati, DataUltimoMovimento, GiacenzaOrdinati, GiacImpegnSuOrd) VALUES (4, '" + Cod + "', " + numero.ToString() + ", " + disponibili.ToString() + ", 0, '" + ora.ToString() + "',0 ,0)";
                if (IdMagazzino == 5) query2 = "INSERT INTO GiacenzeMagazzini (idMagazzino, idArticoli, GiacenzaComplessiva, GiacenzaDisponibili, GiacenzaImpegnati, DataUltimoMovimento, GiacenzaOrdinati, GiacImpegnSuOrd) VALUES (5, '" + Cod + "', " + numero.ToString() + ", " + disponibili.ToString() + ", 0, '" + ora.ToString() + "',0 ,0)";

                comando2 = new SqlCommand(query2, conn);
                comando2.ExecuteNonQuery();
                MessageBox.Show("Articolo non presente in magazzino. Creato.");
                MessageBox.Show("Articolo: " + Cod + " - Giacenza: " + numero.ToString() + " - Disponibili: " + disponibili.ToString());
            }
            conn.Close();
        }

        private void AggiornaGiacenzeS(int q, string Cod, string cs, int IdMagazzino)
        {
            int numero, disponibili;
            string query1="", query2="";
            DateTime ora;
            SqlCommand comando2;
            SqlConnection conn = new SqlConnection(Properties.Resources.StringaConnessione);
            conn.Open();
            if (IdMagazzino == 1) query1 = "SELECT SUM(GiacenzaComplessiva) FROM GiacenzeMagazzini WHERE idPrime='" + Cod + "'";
            if (IdMagazzino == 2) query1 = "SELECT SUM(GiacenzaComplessiva) FROM GiacenzeMagazzini WHERE idStampi='" + Cod + "'";
            if (IdMagazzino == 3) query1 = "SELECT SUM(GiacenzaComplessiva) FROM GiacenzeMagazzini WHERE idDime='" + Cod + "'";
            if (IdMagazzino == 4) query1 = "SELECT SUM(GiacenzaComplessiva) FROM GiacenzeMagazzini WHERE idSemilavorati='" + Cod + "'";
            if (IdMagazzino == 5) query1 = "SELECT SUM(GiacenzaComplessiva) FROM GiacenzeMagazzini WHERE idArticoli='" + Cod + "'";
            SqlCommand comando1 = new SqlCommand(query1, conn);
            try
            {
                numero = (int)comando1.ExecuteScalar();
                if (numero > 0)   // articolo già presente nelle giacenze
                {
                    if (IdMagazzino == 1) query2 = "SELECT SUM(GiacenzaDisponibili) FROM GiacenzeMagazzini WHERE idPrime='" + Cod + "'";
                    if (IdMagazzino == 2) query2 = "SELECT SUM(GiacenzaDisponibili) FROM GiacenzeMagazzini WHERE idStampi='" + Cod + "'";
                    if (IdMagazzino == 3) query2 = "SELECT SUM(GiacenzaDisponibili) FROM GiacenzeMagazzini WHERE idDime='" + Cod + "'";
                    if (IdMagazzino == 4) query2 = "SELECT SUM(GiacenzaDisponibili) FROM GiacenzeMagazzini WHERE idSemilavorati='" + Cod + "'";
                    if (IdMagazzino == 5) query2 = "SELECT SUM(GiacenzaDisponibili) FROM GiacenzeMagazzini WHERE idArticoli='" + Cod + "'";
                    comando2 = new SqlCommand(query2, conn);
                    disponibili = (int)comando2.ExecuteScalar();
                    numero = numero - q;
                    disponibili = disponibili - q;
                    // update
                    ora = DateTime.Now;
                    if (IdMagazzino == 1) query2 = "UPDATE GiacenzeMagazzini SET GiacenzaComplessiva = " + numero.ToString() + ", GiacenzaDisponibili = " + disponibili.ToString() + ", DataUltimoMovimento = '" + ora.ToString() + "' WHERE idPrime='" + Cod + "'";
                    if (IdMagazzino == 2) query2 = "UPDATE GiacenzeMagazzini SET GiacenzaComplessiva = " + numero.ToString() + ", GiacenzaDisponibili = " + disponibili.ToString() + ", DataUltimoMovimento = '" + ora.ToString() + "' WHERE idStampi='" + Cod + "'";
                    if (IdMagazzino == 3) query2 = "UPDATE GiacenzeMagazzini SET GiacenzaComplessiva = " + numero.ToString() + ", GiacenzaDisponibili = " + disponibili.ToString() + ", DataUltimoMovimento = '" + ora.ToString() + "' WHERE idDime='" + Cod + "'";
                    if (IdMagazzino == 4) query2 = "UPDATE GiacenzeMagazzini SET GiacenzaComplessiva = " + numero.ToString() + ", GiacenzaDisponibili = " + disponibili.ToString() + ", DataUltimoMovimento = '" + ora.ToString() + "' WHERE idSemilavorati='" + Cod + "'";
                    if (IdMagazzino == 5) query2 = "UPDATE GiacenzeMagazzini SET GiacenzaComplessiva = " + numero.ToString() + ", GiacenzaDisponibili = " + disponibili.ToString() + ", DataUltimoMovimento = '" + ora.ToString() + "' WHERE idArticoli='" + Cod + "'";
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
                if (IdMagazzino == 1) query2 = "INSERT INTO GiacenzeMagazzini (idMagazzino, idPrime, GiacenzaComplessiva, GiacenzaDisponibili, GiacenzaImpegnati, DataUltimoMovimento, GiacenzaOrdinati, GiacImpegnSuOrd) VALUES (1, '" + Cod + "', " + numero.ToString() + ", " + disponibili.ToString() + ", 0, '" + ora.ToString() + "',0 ,0)";
                if (IdMagazzino == 2) query2 = "INSERT INTO GiacenzeMagazzini (idMagazzino, idStampi, GiacenzaComplessiva, GiacenzaDisponibili, GiacenzaImpegnati, DataUltimoMovimento, GiacenzaOrdinati, GiacImpegnSuOrd) VALUES (2, '" + Cod + "', " + numero.ToString() + ", " + disponibili.ToString() + ", 0, '" + ora.ToString() + "',0 ,0)";
                if (IdMagazzino == 3) query2 = "INSERT INTO GiacenzeMagazzini (idMagazzino, idDime, GiacenzaComplessiva, GiacenzaDisponibili, GiacenzaImpegnati, DataUltimoMovimento, GiacenzaOrdinati, GiacImpegnSuOrd) VALUES (3, '" + Cod + "', " + numero.ToString() + ", " + disponibili.ToString() + ", 0, '" + ora.ToString() + "',0 ,0)";
                if (IdMagazzino == 4) query2 = "INSERT INTO GiacenzeMagazzini (idMagazzino, idSemilavorati, GiacenzaComplessiva, GiacenzaDisponibili, GiacenzaImpegnati, DataUltimoMovimento, GiacenzaOrdinati, GiacImpegnSuOrd) VALUES (4, '" + Cod + "', " + numero.ToString() + ", " + disponibili.ToString() + ", 0, '" + ora.ToString() + "',0 ,0)";
                if (IdMagazzino == 5) query2 = "INSERT INTO GiacenzeMagazzini (idMagazzino, idArticoli, GiacenzaComplessiva, GiacenzaDisponibili, GiacenzaImpegnati, DataUltimoMovimento, GiacenzaOrdinati, GiacImpegnSuOrd) VALUES (5, '" + Cod + "', " + numero.ToString() + ", " + disponibili.ToString() + ", 0, '" + ora.ToString() + "',0 ,0)";

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
            if (radioButton2.Checked == true)
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
            string selezione = "";
            try
            {
                if (comboBox1.SelectedIndex == 0) selezione = "idPrime = '" + codice + "'";
                if (comboBox1.SelectedIndex == 1) selezione = "idStampi = '" + codice + "'";
                if (comboBox1.SelectedIndex == 2) selezione = "idDime = '" + codice + "'";
                if (comboBox1.SelectedIndex == 3) selezione = "idSemilavorati = '" + codice + "'";
                if (comboBox1.SelectedIndex == 4) selezione = "idArticoli = '" + codice + "'";
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
