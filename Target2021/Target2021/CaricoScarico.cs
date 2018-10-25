using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                    int IdMagazzino, qta;
                    double peso=0, prezzo=0;
                    string CodArt, CS="X", BarCode, NrOrdine;
                    DateTime datamov;

                    IdMagazzino = Convert.ToInt32(comboBox1.SelectedValue);
                    CodArt = textBox1.Text;
                    if (radioButton1.Checked == true) CS = "C";
                    if (radioButton2.Checked == true) CS = "S";
                    qta = Convert.ToInt32(textBox2.Text);
                    BarCode = textBox3.Text;
                    NrOrdine = textBox4.Text;
                    datamov = dateTimePicker1.Value;
                    if (textBox5.Text != "") peso = Convert.ToDouble(textBox5.Text);
                    if (textBox6.Text != "") prezzo = Convert.ToDouble(textBox6.Text);
                    if (IdMagazzino == 1) movimentiMagazzinoTableAdapter.Insert(IdMagazzino,CodArt,"","","","", CS, qta, BarCode, NrOrdine, datamov, peso, prezzo);
                    if (IdMagazzino == 2) movimentiMagazzinoTableAdapter.Insert(IdMagazzino, "", CodArt, "", "", "", CS, qta, BarCode, NrOrdine, datamov, peso, prezzo);
                    if (IdMagazzino == 3) movimentiMagazzinoTableAdapter.Insert(IdMagazzino, "", "", CodArt, "", "", CS, qta, BarCode, NrOrdine, datamov, peso, prezzo);
                    if (IdMagazzino == 4) movimentiMagazzinoTableAdapter.Insert(IdMagazzino, "", "", "", CodArt, "", CS, qta, BarCode, NrOrdine, datamov, peso, prezzo);
                    if (IdMagazzino == 5) movimentiMagazzinoTableAdapter.Insert(IdMagazzino, "", "", "", "", CodArt, CS, qta, BarCode, NrOrdine, datamov, peso, prezzo);
                    movimentiMagazzinoTableAdapter.Fill(this.target2021DataSet.MovimentiMagazzino);
                    MessageBox.Show("Movimento registrato correttamente!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert Failed");
                }
            }
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
    }
}
