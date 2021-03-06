﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Split
{
    public partial class Splitta : Form
    {
        private DataRow Riga, Riga1, Riga2, Riga3, RigaOF1, RigaOF2, RigaOF3;

        public Splitta(DataRow r)
        {
            InitializeComponent();
            Riga = r;
        }

        private void Splitta_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            string CodiceCommessa;
            int NrPezzi, NrLastre;
            CodiceCommessa = Riga.Field<string>(target2021DataSet.Commesse.Columns.IndexOf(target2021DataSet.Commesse.CodCommessaColumn)); 
            //CodiceCommessa = Riga.Field<string>(target2021DataSet.Commesse.CodCommessaColumn);
            NrPezzi = Riga.Field<int>(target2021DataSet.Commesse.Columns.IndexOf(target2021DataSet.Commesse.NrPezziDaLavorareColumn));
            NrLastre = Riga.Field<int>(target2021DataSet.Commesse.Columns.IndexOf(target2021DataSet.Commesse.NrLastreRichiesteColumn));
            textBox1.Text = CodiceCommessa;
            textBox2.Text = NrPezzi.ToString();
            textBox5.Text = NrLastre.ToString();
            PopolaCodCommessaOF();
        }

        private void PopolaCodCommessaOF()
        {
            int NrCommessa;
            string CodCommessa;
            NrCommessa = Riga.Field<int>(target2021DataSet.Commesse.Columns.IndexOf(target2021DataSet.Commesse.NrCommessaColumn));
            CodCommessa = "OF" + NrCommessa.ToString();
            textBox17.Text = CodCommessa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Originali, Nuove;
            string CodCommessa;
            DateTime DataCommessa;

            Originali = Convert.ToInt32(textBox2.Text);
            Nuove = Convert.ToInt32(textBox7.Text);
            if (Originali == Nuove)
            {
                // Spli: 1. mettere l'originale in uno stato (7) non utilizzato da altro. Mettere le due/tre nuove in stato = 0
                int IDCommessa;
                IDCommessa = Riga.Field<int>(target2021DataSet.Commesse.Columns.IndexOf(target2021DataSet.Commesse.IDCommessaColumn));
                DataCommessa = Riga.Field<DateTime>(target2021DataSet.Commesse.Columns.IndexOf(target2021DataSet.Commesse.DataCommessaColumn));
                CodCommessa = textBox17.Text;
                // *******  AGGIORNO LA FASE DI STAMPAGGIO
                string stringaconnessione, sql;
                stringaconnessione = Properties.Resources.StringaConnessione;
                SqlConnection connessione = new SqlConnection(stringaconnessione);
                sql = "UPDATE Commesse SET Stato = 7 WHERE IDCommessa = " + IDCommessa;
                SqlCommand comando = new SqlCommand(sql, connessione);
                connessione.Open();
                try
                {
                    comando.ExecuteScalar();
                }
                catch
                {
                    MessageBox.Show("Errore nell'aggiornamento dello stato della commessa fase stampaggio");
                }
                connessione.Close();
                // *******  AGGIORNO LA FASE DI REPERIMENTO LASTRE
                string sql1;
                SqlConnection connessione1 = new SqlConnection(stringaconnessione);
                sql1 = "UPDATE Commesse SET Stato = 7 WHERE CodCommessa = '" + CodCommessa + "' AND DataCommessa = '" + DataCommessa.ToShortDateString() + "'";
                SqlCommand comando1 = new SqlCommand(sql1, connessione1);
                connessione1.Open();
                try
                {
                    comando1.ExecuteScalar();
                }
                catch
                {
                    MessageBox.Show("Errore nell'aggiornamento dello stato della commessa fase OF");
                }
                connessione.Close();
                // *******
                if (textBox3.Text!="0")
                {
                    Riga1 = target2021DataSet.Commesse.NewRow();
                    Riga1.ItemArray = Riga.ItemArray.Clone() as object[];
                    Riga1["IDCommessa"] = -1;
                    Riga1["CodCommessa"] = textBox4.Text;
                    Riga1["NrPezziDaLavorare"] = Convert.ToInt32(textBox3.Text);
                    Riga1["NrLastreRichieste"] = Convert.ToInt32(textBox6.Text);
                    target2021DataSet.Commesse.Rows.Add(Riga1);
                    this.commesseTableAdapter.Update(target2021DataSet.Commesse);
                    RigaOF1 = target2021DataSet.Commesse.NewRow();
                    RigaOF1.ItemArray = Riga.ItemArray.Clone() as object[];
                    RigaOF1["IDCommessa"] = -1;
                    RigaOF1["CodCommessa"] = textBox14.Text;
                    RigaOF1["TipoCommessa"] = 1;
                    RigaOF1["NrPezziDaLavorare"] = Convert.ToInt32(textBox3.Text);
                    RigaOF1["NrLastreRichieste"] = Convert.ToInt32(textBox6.Text);
                    target2021DataSet.Commesse.Rows.Add(RigaOF1);
                    this.commesseTableAdapter.Update(target2021DataSet.Commesse);
                }
                if (textBox10.Text != "0")
                {
                    Riga2 = target2021DataSet.Commesse.NewRow();
                    Riga2.ItemArray = Riga.ItemArray.Clone() as object[];
                    Riga2["IDCommessa"] = -1;
                    Riga2["CodCommessa"] = textBox9.Text;
                    Riga2["NrPezziDaLavorare"] = Convert.ToInt32(textBox10.Text);
                    Riga2["NrLastreRichieste"] = Convert.ToInt32(textBox8.Text);
                    target2021DataSet.Commesse.Rows.Add(Riga2);
                    this.commesseTableAdapter.Update(target2021DataSet.Commesse);
                    RigaOF2 = target2021DataSet.Commesse.NewRow();
                    RigaOF2.ItemArray = Riga.ItemArray.Clone() as object[];
                    RigaOF2["IDCommessa"] = -1;
                    RigaOF2["CodCommessa"] = textBox15.Text;
                    RigaOF2["TipoCommessa"] = 1;
                    RigaOF2["NrPezziDaLavorare"] = Convert.ToInt32(textBox10.Text);
                    RigaOF2["NrLastreRichieste"] = Convert.ToInt32(textBox8.Text);
                    target2021DataSet.Commesse.Rows.Add(RigaOF2);
                    this.commesseTableAdapter.Update(target2021DataSet.Commesse);
                }
                if (textBox13.Text != "0")
                {
                    Riga3 = target2021DataSet.Commesse.NewRow();
                    Riga3.ItemArray = Riga.ItemArray.Clone() as object[];
                    Riga3["IDCommessa"] = -1;
                    Riga3["CodCommessa"] = textBox12.Text;
                    Riga3["NrPezziDaLavorare"] = Convert.ToInt32(textBox13.Text);
                    Riga3["NrLastreRichieste"] = Convert.ToInt32(textBox11.Text);
                    target2021DataSet.Commesse.Rows.Add(Riga3);
                    this.commesseTableAdapter.Update(target2021DataSet.Commesse);
                    RigaOF3 = target2021DataSet.Commesse.NewRow();
                    RigaOF3.ItemArray = Riga.ItemArray.Clone() as object[];
                    RigaOF3["IDCommessa"] = -1;
                    RigaOF3["CodCommessa"] = textBox16.Text;
                    RigaOF3["TipoCommessa"] = 1;
                    RigaOF3["NrPezziDaLavorare"] = Convert.ToInt32(textBox13.Text);
                    RigaOF3["NrLastreRichieste"] = Convert.ToInt32(textBox11.Text);
                    target2021DataSet.Commesse.Rows.Add(RigaOF3);
                    this.commesseTableAdapter.Update(target2021DataSet.Commesse);
                }
                commesseDataGridView.Refresh();
                MessageBox.Show("Split avvenuto correttamente!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Il numero totale dei pezzi delle sottocommesse non coincide con quello della commessa di partenza!");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int NumeroPezziNew, NrLastreNew, NrPezziOrig, NrLastreOrig;
            double Rapporto;
            string Codice;

            NrPezziOrig = Convert.ToInt32(Riga.Field<int>(target2021DataSet.Commesse.Columns.IndexOf(target2021DataSet.Commesse.NrPezziDaLavorareColumn)));
            NrLastreOrig = Convert.ToInt32(Riga.Field<int>(target2021DataSet.Commesse.Columns.IndexOf(target2021DataSet.Commesse.NrLastreRichiesteColumn)));
            try
            {
                NumeroPezziNew = Convert.ToInt32(textBox3.Text);
            }
            catch
            {
                NumeroPezziNew = 0;
                textBox3.Text = "0";
            }
            if (NumeroPezziNew!=0)
            {
                Codice = textBox1.Text + ".1";
                Rapporto = (double) NumeroPezziNew / (double) NrPezziOrig;
                NrLastreNew = (int) Math.Ceiling((double) NrLastreOrig * Rapporto);
                textBox4.Text = Codice;
                textBox14.Text = textBox17.Text + ".1";
                textBox6.Text = NrLastreNew.ToString();
            }
            else
            {
                textBox4.Text = "";
                textBox14.Text = "";
                textBox6.Text = "0";
            }
            AggiornaTotali();
        }

        private void AggiornaTotali()
        {
            int S1=0, S2=0, S3=0, totale;
            S1 = Convert.ToInt32(textBox3.Text);
            S2 = Convert.ToInt32(textBox10.Text);
            S3 = Convert.ToInt32(textBox13.Text);

            totale = S1 + S2 + S3;
            textBox7.Text = totale.ToString();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            int NumeroPezziNew, NrLastreNew, NrPezziOrig, NrLastreOrig;
            double Rapporto;
            string Codice;

            NrPezziOrig = Convert.ToInt32(Riga.Field<int>(target2021DataSet.Commesse.Columns.IndexOf(target2021DataSet.Commesse.NrPezziDaLavorareColumn)));
            NrLastreOrig = Convert.ToInt32(Riga.Field<int>(target2021DataSet.Commesse.Columns.IndexOf(target2021DataSet.Commesse.NrLastreRichiesteColumn)));
            try
            {
                NumeroPezziNew = Convert.ToInt32(textBox10.Text);
            }
            catch
            {
                NumeroPezziNew = 0;
                textBox10.Text = "0";
            }
            if (NumeroPezziNew != 0)
            {
                Codice = textBox1.Text + ".2";
                Rapporto = (double)NumeroPezziNew / (double)NrPezziOrig;
                NrLastreNew = (int)Math.Ceiling((double)NrLastreOrig * Rapporto);
                textBox9.Text = Codice;
                textBox15.Text = textBox17 .Text +".2";
                textBox8.Text = NrLastreNew.ToString();
            }
            else
            {
                textBox9.Text = "";
                textBox15.Text = "";
                textBox8.Text = "0";
            }
            AggiornaTotali();
        }

        private void commesseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commesseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void commesseBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.commesseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            int NumeroPezziNew, NrLastreNew, NrPezziOrig, NrLastreOrig;
            double Rapporto;
            string Codice;

            NrPezziOrig = Convert.ToInt32(Riga.Field<int>(target2021DataSet.Commesse.Columns.IndexOf(target2021DataSet.Commesse.NrPezziDaLavorareColumn)));
            NrLastreOrig = Convert.ToInt32(Riga.Field<int>(target2021DataSet.Commesse.Columns.IndexOf(target2021DataSet.Commesse.NrLastreRichiesteColumn)));
            try
            {
                NumeroPezziNew = Convert.ToInt32(textBox13.Text);
            }
            catch
            {
                NumeroPezziNew = 0;
                textBox13.Text = "0";
            }
            if (NumeroPezziNew != 0)
            {
                Codice = textBox1.Text + ".3";
                Rapporto = (double)NumeroPezziNew / (double)NrPezziOrig;
                NrLastreNew = (int)Math.Ceiling((double)NrLastreOrig * Rapporto);
                textBox12.Text = Codice;
                textBox16.Text = textBox17.Text + ".3";
                textBox11.Text = NrLastreNew.ToString();
            }
            else
            {
                textBox12.Text = "";
                textBox16.Text = "";
                textBox11.Text = "0";
            }
            AggiornaTotali();
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                // Verify that the pressed key isn't CTRL or any non-numeric digit
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
