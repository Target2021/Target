﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Target2021.Selezioni;

namespace Target2021.Fornitori
{
    public partial class NuovoOrdineForn : Form
    {
        DataTable dt = new DataTable("Articoli");

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
            Nr = target2021DataSet.Tables["OrdFornTest"].AsEnumerable().Max(x => x.Field<int>("NrOrdine"));
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
            string descrizione="Non trovato nessun articolo";
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
                    std = target2021DataSet.Tables["Prime"].Select("codice= '" + textBox10.Text + "'");
                    ris = std[0];
                    descrizione = ris[2].ToString();
                }
            }
            textBox11.Text = descrizione;
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
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 400;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 200;
        }

        private void AggiungiRiga()
        {
            dt.Rows.Add(new object[]{textBox10.Text, textBox11.Text, Convert.ToInt32(textBox12.Text), dateTimePicker2.Text});
            dataGridView1.DataSource = dt;
        }

        private void SoloNumeri(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
