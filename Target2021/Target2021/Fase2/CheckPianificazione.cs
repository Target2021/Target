using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Target2021
{
    public partial class CheckPianificazione : Form
    {
        DataTable dt = new DataTable("SuperCommesse");

        public CheckPianificazione()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CheckPianificazione_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.AbbinamentiSuperCommesse'. È possibile spostarla o rimuoverla se necessario.
            this.abbinamentiSuperCommesseTableAdapter.Fill(this.target2021DataSet.AbbinamentiSuperCommesse);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.AbbinamentiSuperCommesse'. È possibile spostarla o rimuoverla se necessario.
            this.abbinamentiSuperCommesseTableAdapter.Fill(this.target2021DataSet.AbbinamentiSuperCommesse);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.MacchineStampo'. È possibile spostarla o rimuoverla se necessario.
            this.macchineStampoTableAdapter.Fill(this.target2021DataSet.MacchineStampo);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.SuperCommessa'. È possibile spostarla o rimuoverla se necessario.
            this.superCommessaTableAdapter.Fill(this.target2021DataSet.SuperCommessa);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            WindowState = FormWindowState.Maximized;
            carica();
            CreaTabella();
            comboBox2.SelectedIndex = 0;
        }

        private void carica()
        {
            commesseBindingSource.Filter = "TipoCommessa = 1 AND Stato = 2";
        }

        private void SelezionaRiga(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void commesseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commesseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IdSC, percentuale = 0, NrLastre, NuoveLastre;
            DateTime DataConsegna, DataInTextBox;
            string Cliente;
            if (textBox1.Text == "")
            {
                IdSC = AssegnaIdSuperCommessa();
                IdSC++;
                textBox1.Text = IdSC.ToString();
            }    
            AggiungiRiga();
            percentuale = Convert.ToInt32(textBox3.Text) + Convert.ToInt32(commesseDataGridView.SelectedRows[0].Cells[16].Value);
            textBox3.Text = percentuale.ToString();
            Colora(sender,e);
            NrLastre = Convert.ToInt32(textBox4.Text);
            DataConsegna = Convert.ToDateTime(commesseDataGridView.SelectedRows[0].Cells[7].Value);
            textBox6.Text = commesseDataGridView.SelectedRows[0].Cells[54].Value.ToString();
            DataInTextBox = Convert.ToDateTime(maskedTextBox1.Text);
            if (DataConsegna < DataInTextBox) maskedTextBox1.Text = DataConsegna.ToString();
            NuoveLastre = Convert.ToInt32(commesseDataGridView.SelectedRows[0].Cells[22].Value);
            // Altra logica
            // if (NrLastre > NuoveLastre) NrLastre = NrLastre; else NrLastre = NuoveLastre;
            NrLastre = NrLastre + NuoveLastre;
            textBox4.Text =  NrLastre.ToString();
            Cliente =Convert.ToString(commesseDataGridView.SelectedRows[0].Cells[5].Value);
            textBox5.Text = Cliente;
            if (textBox2.Text=="") 
            {
                textBox2.Text = Convert.ToString(commesseDataGridView.SelectedRows[0].Cells[21].Value);
            }
            if (comboBox2.SelectedIndex == 1)
            {
                commesseBindingSource.Filter = "TipoCommessa = 1 AND Stato = 2 AND IDMateriaPrima = '" + textBox2.Text + "'";
            }
        }

        private int AssegnaIdSuperCommessa()
        {
            int max;
            try
            {
                max = (int)target2021DataSet.SuperCommessa.Compute("MAX([IdSuperCommessa])", "");
            }
            catch
            { max = 0; }
            return max;
        }
        private void CreaTabella()
        {
            dt.Columns.Add ("Id Comm.", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Codice commessa", System.Type.GetType("System.String"));
            dt.Columns.Add("Cliente", System.Type.GetType("System.String"));
            dt.Columns.Add("Data consegna", System.Type.GetType("System.DateTime"));
            dt.Columns.Add("Numero pezzi da produrre", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Codice articolo", System.Type.GetType("System.String"));
            dt.Columns.Add("Macchina stampa", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Percentuale lastra", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Lastra", System.Type.GetType("System.String"));
            dt.Columns.Add("Nr. lastre", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Stampo", System.Type.GetType("System.String"));
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].Width = 100;
            dataGridView1.Columns[8].Width = 100;
            dataGridView1.Columns[9].Width = 100;
            dataGridView1.Columns[9].Width = 100;
        }

        private void AggiungiRiga()
        {
            string CodCommessa, CodArticolo, Lastra, Cliente, Stampo;
            int IdCommessa, NrPezziDaProdurre, MacchinaStampa, PercentualeLastra, NrLastre;
            DateTime DataConsegna;

            foreach (DataGridViewRow riga in commesseDataGridView.SelectedRows)
            {
                IdCommessa = Convert.ToInt32(riga.Cells[0].Value);
                CodCommessa = Convert.ToString(riga.Cells[1].Value);
                Cliente = Convert.ToString(riga.Cells[5].Value);
                DataConsegna = Convert.ToDateTime(riga.Cells[7].Value);
                NrPezziDaProdurre = Convert.ToInt32(riga.Cells[8].Value);
                CodArticolo = Convert.ToString(riga.Cells[9].Value);
                MacchinaStampa = Convert.ToInt32(riga.Cells[14].Value);
                PercentualeLastra = Convert.ToInt32(riga.Cells[16].Value);
                Lastra = Convert.ToString(riga.Cells[21].Value); 
                NrLastre = Convert.ToInt32(riga.Cells[22].Value);
                Stampo = RecuperaStampoCommessa(IdCommessa);
                dt.Rows.Add(new object[] { IdCommessa, CodCommessa, Cliente, DataConsegna, NrPezziDaProdurre, CodArticolo, MacchinaStampa, PercentualeLastra, Lastra, NrLastre, Stampo});
                dataGridView1.DataSource = dt;
            }
        }

        private string RecuperaStampoCommessa(int IdCommessa)
        {
            // Prende dall'IdCommessa passata: NrCommessa e DataCommessa
            // Recupera dalla Tabella Commesse l'IDCommessa che ha quel NrCommessa, quella DataCommessa e TipoCommessa = 2 ù
            // e ritorna l'IdCommessa di quella riga
            int NrCom;
            DateTime DataCom;
            DataRow riga;
            DataTable TabellaCommesse;
            TabellaCommesse = target2021DataSet.Tables["Commesse"];
            riga = TabellaCommesse.Rows.Find(IdCommessa);
            NrCom = Convert.ToInt32(riga["NrCommessa"]);
            DataCom = Convert.ToDateTime(riga["DataCommessa"]);

            string StampoCom;
            DataRow[] righe;
            righe = target2021DataSet.Tables["Commesse"].Select("NrCommessa=" + NrCom + " AND DataCommessa='" + DataCom.ToShortDateString() + "' AND TipoCommessa=2");
            try
            {
                StampoCom = (righe[0]["IDStampo"]).ToString();
                return StampoCom;
            }
            catch { return "NN"; }
        }

        private void Cancella(object sender, EventArgs e)
        {
            int percentuale = 0, totperc = 0, nrighe = 100, NLastre=0, TotLastre=0;
            TotLastre = Convert.ToInt32(textBox4.Text);
            totperc = Convert.ToInt32(textBox3.Text);
            try
            {
                percentuale = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[7].Value);
                NLastre = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[9].Value);
                totperc = totperc - percentuale;
                TotLastre = TotLastre - NLastre;
                textBox3.Text = totperc.ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                nrighe = dataGridView1.RowCount;
                textBox4.Text = TotLastre.ToString();
                textBox3.Text = totperc.ToString();
            }
            catch
            {
                MessageBox.Show("Errore generico");
            }
            if (nrighe == 0)
            {
                textBox2.Text = "";
                commesseBindingSource.RemoveFilter();
                commesseBindingSource.Filter = "TipoCommessa = 1 AND Stato = 2";
            }
            AggiornaData();
        }

        private void Colora(object sender, EventArgs e)
        {
            int percentuale = Convert.ToInt32(textBox3.Text);
            if (percentuale < 100) textBox3.BackColor = Color.LightGreen;
            if (percentuale >= 100 && percentuale < 106) textBox3.BackColor = Color.Yellow;
            if (percentuale > 105) textBox3.BackColor = Color.OrangeRed;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tipo, stato;
            CreaTestataSuperCommessa();
            CreaAbbinamentoSC();
            AggiornaStatoRiga();
            tipo = 1;
            stato = 3;
            CreaSuperCommessa(tipo,stato);
            tipo = 2;
            stato = 10;
            CreaSuperCommessa(tipo, stato);
            MessageBox.Show("SuperCommessa di stampaggio creata correttamente!");
        }

        private void CreaSuperCommessa(int tipo, int stato)
        {
            // qua dentro creo una supercommessa SS (SupercommessaStampaggio)
            // che sia TipoCommessa=1 AND Stato=2?
            // che contenga le informazioni base per chi stampa
            DateTime DataCommesse;
            int Numero = Convert.ToInt32(textBox1.Text);
            Commessa com = new Commessa(Numero);
            com.CodCommessa = "SC" + Numero.ToString();
            DataCommesse = DateTime.Today;
            com.DataCommessa = DataCommesse;
            com.TipoCommessa = tipo;
            com.IDCliente = textBox5.Text;
            com.DataConsegna = PrimaDataConsegna();
            com.NrPezziDaLavorare = Convert.ToInt32(textBox4.Text);
            com.CodArticolo = "VARI";
            com.DescrArticolo = "Vedere dettagli Supercommessa di stampaggio";
            com.IDMachStampa = Convert.ToInt32(comboBox1.SelectedValue);
            com.IDStampo = "Vedi dett.";
            com.PercentualeUtilizzoLastra = Convert.ToInt32(textBox3.Text);
            com.IDMateriaPrima = textBox2.Text;
            com.NrLastreRichieste = Convert.ToInt32(textBox4.Text);
            com.Stato = 10;
            com.ImpegnataMatPrima = Convert.ToInt32(textBox4.Text);
            com.ProgStampa =textBox6.Text;   
            InserisciCommessa(com);
        }

        private void InserisciCommessa(Commessa com)
        {
            Target2021DataSet.CommesseRow riga = target2021DataSet.Commesse.NewCommesseRow();

            riga.CodCommessa = com.CodCommessa;
            riga.NrCommessa = com.NrCommessa;
            riga.DataCommessa = com.DataCommessa;
            riga.TipoCommessa = com.TipoCommessa;
            riga.IDCliente = com.IDCliente;
            riga.OrdCliente = com.OrdCliente;
            riga.DataConsegna = com.DataConsegna;
            riga.NrPezziDaLavorare = com.NrPezziDaLavorare;
            riga.CodArticolo = com.CodArticolo;
            riga.DescrArticolo = com.DescrArticolo;
            riga.IDFornitore = com.IDFornitore;
            riga.IDStampo = com.IDStampo;
            riga.IDDima = com.IDMateriaPrima;
            riga.IDMateriaPrima = com.IDMateriaPrima;
            riga.NrLastreRichieste = com.NrLastreRichieste;
            riga.NrPezziOrdinati = 0;
            riga.NrOrdine = "N";
            riga.Stato = com.Stato;
            riga.ImpegnataMatPrima = com.ImpegnataMatPrima;
            riga.PercentualeUtilizzoLastra = com.PercentualeUtilizzoLastra;
            riga.InSupercommessa = 0;
            riga.NrPezziDaLavorare = com.NrPezziDaLavorare;
            riga.IDMachStampa = com.IDMachStampa;
            riga.ProgStampa = com.ProgStampa;
            riga.PezziOra = com.PezziOra;
            riga.CodArtiDopoStampo = com.CodArtiDopoStampo;
            riga.AttG1 = 0;
            riga.AttG2 = 0;
            riga.AttG3 = 0;
            riga.AttG4 = 0;
            riga.AttG5 = 0;

            target2021DataSet.Commesse.Rows.Add(riga);
            commesseTableAdapter.Update(target2021DataSet.Commesse);
        }

        private DateTime PrimaDataConsegna()
        {
            DateTime d = new DateTime(3000,1,1);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int result = DateTime.Compare(d, Convert.ToDateTime(row.Cells[3].Value));
                if (result > 0) d = Convert.ToDateTime(row.Cells[3].Value);
            }
            return d;
        }

        private void AggiornaData()
        {
            DateTime data;
            data = PrimaDataConsegna();
            maskedTextBox1.Text = data.ToString();
        }

        private void AggiornaStatoRiga()
        {   // metto le righe in stato = 9 e compilo campo 'InSupercommessa' e 'NrPezziResidui'
            Target2021DataSet.CommesseRow Riga;
            int IdC, residui;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                IdC= Convert.ToInt32(row.Cells[0].Value);
                Riga = target2021DataSet.Commesse.FindByIDCommessa(IdC);
                Riga.Stato = 9;
                Riga.InSupercommessa= Convert.ToInt32(textBox1.Text);
                residui = Convert.ToInt32(textBox4.Text) - Convert.ToInt32(row.Cells[9].Value);
                Riga.NrPezziResidui = residui;
            }
            commesseTableAdapter.Update(target2021DataSet.Commesse);
        }


        private void CreaAbbinamentoSC()
        {
            Target2021DataSet.AbbinamentiSuperCommesseRow Riga;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Riga = target2021DataSet.AbbinamentiSuperCommesse.NewAbbinamentiSuperCommesseRow();
                Riga.IdSuperCommessa= Convert.ToInt32(textBox1.Text);
                Riga.IDCommessa = Convert.ToInt32(row.Cells["Id Comm."].Value);
                    //RecuperaIDCommessa(Convert.ToInt32(row.Cells["Id Comm."].Value));
                Riga.NrLastre= Convert.ToInt32(textBox4.Text);
                Riga.CodLastra= textBox2.Text;
                Riga.Stampo = row.Cells["Stampo"].Value.ToString();
                target2021DataSet.AbbinamentiSuperCommesse.Rows.Add(Riga);
            }
            abbinamentiSuperCommesseTableAdapter.Update(target2021DataSet.AbbinamentiSuperCommesse);
        }

        private int RecuperaIDCommessa(int IdCommessa)
        {
            // Prende dall'IdCommessa passata: NrCommessa e DataCommessa
            // Recupera dalla Tabella Commesse l'IDCommessa che ha quel NrCommessa, quella DataCommessa e TipoCommessa = 2 ù
            // e ritorna l'IdCommessa di quella riga
            int NrCom;
            DateTime DataCom;
            DataRow riga;
            DataTable TabellaCommesse;
            TabellaCommesse = target2021DataSet.Tables["Commesse"];
            riga = TabellaCommesse.Rows.Find(IdCommessa);
            NrCom = Convert.ToInt32(riga["NrCommessa"]);
            DataCom = Convert.ToDateTime(riga["DataCommessa"]);

            int IdCom;
            DataRow[] righe;
            righe = target2021DataSet.Tables["Commesse"].Select("NrCommessa=" + NrCom + " AND DataCommessa='"+DataCom.ToShortDateString()+"' AND TipoCommessa=2");
            try
            {
                IdCom = Convert.ToInt32(righe[0]["IDCommessa"]);
                return IdCom;
            }
            catch { return -1; }
        }

        private void CreaTestataSuperCommessa()
        {
            // Create a new row.
            Target2021DataSet.SuperCommessaRow NuovaRiga;
            NuovaRiga = target2021DataSet.SuperCommessa.NewSuperCommessaRow();
            NuovaRiga.IdSuperCommessa = Convert.ToInt32(textBox1.Text);
            NuovaRiga.CodiceSuperCommessa = "SC" + textBox1.Text;
            NuovaRiga.MacchinaStampa = Convert.ToInt32(comboBox1.SelectedValue);
            NuovaRiga.NrLastre = Convert.ToInt32(textBox4.Text);
            NuovaRiga.CodiceLastra = textBox2.Text;
            NuovaRiga.Stato = 0;
            target2021DataSet.SuperCommessa.Rows.Add(NuovaRiga);
            superCommessaTableAdapter.Update(target2021DataSet.SuperCommessa);
        }

        private void CambiaFocus(object sender, EventArgs e)
        {
            button2.Focus();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                commesseBindingSource.Filter = "TipoCommessa = 1 AND Stato = 2";
            }
            if (comboBox2.SelectedIndex == 1 && textBox2.Text !="")
            {
                commesseBindingSource.Filter = "TipoCommessa = 1 AND Stato = 2 AND IDMateriaPrima = '" + textBox2.Text + "'";
            }
        }
    }
}
