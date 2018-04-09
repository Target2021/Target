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
    public partial class ScaricoCaricoMagazzini : Form
    {
        public ScaricoCaricoMagazzini()
        {
            InitializeComponent();
        }

        private void movimentiMagazzinoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void ScaricoCaricoMagazzini_Load(object sender, EventArgs e)
        {
            String stringa = Properties.Resources.StringaConnessione;
            string query = "SELECT MAX(idMovimento) FROM MovimentiMagazzino";
            SqlConnection con = new SqlConnection(stringa);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int id = Convert.ToInt32(cmd.ExecuteScalar())+1;
            con.Close();
            textBox1.Text = Convert.ToString(id);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sicuro di voler apportare le seguenti modifiche?", "Modifiche", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if(Carico.Checked)
                {
                    carico(this.comboBox1.GetItemText(this.comboBox1.SelectedItem));                  
                }
            }
        }
        private void carico(string oggetto)
        {
            String stringa = Properties.Resources.StringaConnessione;
            string query = null, queryup = null, queryins = null,querydiff=null;
            int quantità = 0;
            if (oggetto == "Materia Prima")
            {
                query = "SELECT GiacenzaComplessiva FROM GiacenzeMagazzini WHERE idPrime='" + textBox3.Text + "'";
            }
            if(oggetto=="Stampo")
            {
                query = "SELECT GiacenzaComplessiva FROM GiacenzeMagazzini WHERE idStampi='" + textBox3.Text + "'";
            }
            if(oggetto=="Dima")
            {
                query = "SELECT GiacenzaComplessiva FROM GiacenzeMagazzini WHERE idDime='" + textBox3.Text + "'";
            }
            if (oggetto == "Semi lavorato")
            {
                query = "SELECT GiacenzaComplessiva FROM GiacenzeMagazzini WHERE idSemilavorati='" + textBox3.Text + "'";
            }
            if (oggetto == "Articolo")
            {
                query = "SELECT GiacenzaComplessiva FROM GiacenzeMagazzini WHERE idArticoli='" + textBox3.Text + "'";
            }
            SqlConnection con = new SqlConnection(stringa);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            quantità = Convert.ToInt32(cmd.ExecuteScalar()) + Convert.ToInt32(textBox4.Text);
            if (oggetto == "Materia Prima")
            {
                queryup = "UPDATE GiacenzeMagazzini SET GiacenzaComplessiva='" + quantità + "' WHERE idPrime='" + textBox3.Text + "'";
                queryins = "INSERT INTO MovimentiMagazzino (idMovimento,idMagazzino,idPrime,CarScar,Quantita,NrOrdine,DataOraMovimento) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','C','" + textBox4.Text + "','" + textBox5.Text + "','" + DateTime.Now + "')";
                querydiff = "UPDATE GiacenzeMagazzini SET GiacenzaDisponibili=GiacenzaComplessiva-GiacenzaImpegnati WHERE idPrime='"+textBox3.Text+"'";
            }
            if(oggetto=="Stampo")
            {
                queryup = "UPDATE GiacenzeMagazzini SET GiacenzaComplessiva='" + quantità + "' WHERE idStampi='" + textBox3.Text + "'";
                queryins = "INSERT INTO MovimentiMagazzino (idMovimento,idMagazzino,idStampi,CarScar,Quantita,NrOrdine,DataOraMovimento) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','C','" + textBox4.Text + "','" + textBox5.Text + "','" + DateTime.Now + "')";
                querydiff = "UPDATE GiacenzeMagazzini SET GiacenzaDisponibili=GiacenzaComplessiva-GiacenzaImpegnati WHERE idStampi='" + textBox3.Text + "'";

            }
            if (oggetto == "Dima")
            {
                queryup = "UPDATE GiacenzeMagazzini SET GiacenzaComplessiva='" + quantità + "' WHERE idDime='" + textBox3.Text + "'";
                queryins = "INSERT INTO MovimentiMagazzino (idMovimento,idMagazzino,idDime,CarScar,Quantita,NrOrdine,DataOraMovimento) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','C','" + textBox4.Text + "','" + textBox5.Text + "','" + DateTime.Now + "')";
                querydiff = "UPDATE GiacenzeMagazzini SET GiacenzaDisponibili=GiacenzaComplessiva-GiacenzaImpegnati WHERE idDime='" + textBox3.Text + "'";

            }
            if (oggetto == "Semi lavorato")
            {
                queryup = "UPDATE GiacenzeMagazzini SET GiacenzaComplessiva='" + quantità + "' WHERE idSemilavorati='" + textBox3.Text + "'";
                queryins = "INSERT INTO MovimentiMagazzino (idMovimento,idMagazzino,idSemilavorati,CarScar,Quantita,NrOrdine,DataOraMovimento) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','C','" + textBox4.Text + "','" + textBox5.Text + "','" + DateTime.Now + "')";
                querydiff = "UPDATE GiacenzeMagazzini SET GiacenzaDisponibili=GiacenzaComplessiva-GiacenzaImpegnati WHERE idSemilavorati='" + textBox3.Text + "'";
            }
            if (oggetto == "Articolo")
            {
                queryup = "UPDATE GiacenzeMagazzini SET GiacenzaComplessiva='" + quantità + "' WHERE idArticoli='" + textBox3.Text + "'";
                queryins = "INSERT INTO MovimentiMagazzino (idMovimento,idMagazzino,idArticoli,CarScar,Quantita,NrOrdine,DataOraMovimento) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','C','" + textBox4.Text + "','" + textBox5.Text + "','" + DateTime.Now + "')";
                querydiff = "UPDATE GiacenzeMagazzini SET GiacenzaDisponibili=GiacenzaComplessiva-GiacenzaImpegnati WHERE idArticoli='" + textBox3.Text + "'";

            }
            cmd = new SqlCommand(queryup, con);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(queryins, con);
            int count= cmd.ExecuteNonQuery();
            cmd = new SqlCommand(querydiff, con);
            cmd.ExecuteNonQuery();
            if(count>0)
            {
                MessageBox.Show("Operazione effettuata con successo");
            }
            else
            {
                MessageBox.Show("Errore!");
            }
            con.Close();
            this.Close();
        }
    }
}
