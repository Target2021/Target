using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Fase3
{
    public partial class SelezionaCommessaDaStampare : Form
    {
        private int nm;

        public SelezionaCommessaDaStampare(int nmach)
        {
            InitializeComponent();
            nm = nmach;
            textBox1.Text = nm.ToString();
        }

        private void SelezionaCommessaDaStampare_Load(object sender, EventArgs e)
        {
            aggiorna();
        }

        private void aggiorna()
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.MacchineStampo'. È possibile spostarla o rimuoverla se necessario.
            this.macchineStampoTableAdapter.Fill(this.target2021DataSet.MacchineStampo);
            string NomeMacchina;
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            DataView CPianifM1 = new DataView(target2021DataSet.Commesse);
            CPianifM1.RowFilter = "Stato = 3 AND SchedMach = " + textBox1.Text;
            commesseDataGridView1.DataSource = CPianifM1;
            NascondiColonne();
            DataRow[] riga;
            riga = target2021DataSet.Tables["MacchineStampo"].Select("IdStampa=" + textBox1.Text);
            try
            {
                NomeMacchina = riga[0]["Descrizione"].ToString();
            }
            catch { NomeMacchina = "Non trovata!"; }
            label2.Text = NomeMacchina;
        }

        private void NascondiColonne()
        {
            foreach (DataGridViewColumn col in commesseDataGridView1.Columns)
            {
                if (col.HeaderText == "NrPezziDaLavorare") col.HeaderText = "Nr Pezzi da stampare";
                if (col.HeaderText == "CodCommessa") col.HeaderText = "Commessa";
                if (col.HeaderText == "DataCommessa") col.HeaderText = "Data Commessa";
                if (col.HeaderText == "SchedData") col.HeaderText = "Data";
                if (col.HeaderText == "ShedOra") col.HeaderText = "Ora";
                if (col.HeaderText == "Ora") col.DefaultCellStyle.Format = "HH:mm:ss tt";
                if (col.HeaderText == "SchedDurata") col.HeaderText = "Durata";
                if (col.HeaderText == "CodArticolo") col.HeaderText = "Articolo";
                if (col.HeaderText == "NrPezziCorretti") col.HeaderText = "Nr. pezzi già stampati";
                if (col.HeaderText == "Commessa" || col.HeaderText== "Data Commessa" || col.HeaderText == "IDCliente" || col.HeaderText == "Articolo" || col.HeaderText == "Nr Pezzi da stampare" || col.HeaderText == "Data" || col.HeaderText == "Ora" || col.HeaderText == "Durata" || col.HeaderText == "Nr. pezzi già stampati")
                    col.Visible = true;
                else
                    col.Visible = false;
            }
        }

        private void commesseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commesseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }

        private void commesseDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int macchina=0;
            int chiave,anno=0;
            string IdCommessa;
            DateTime datac;
            try
            {
                IdCommessa = commesseDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                //MessageBox.Show("Vado a tagliare la commessa: " + IdCommessa.ToString());
                datac = Convert.ToDateTime(commesseDataGridView1.SelectedRows[0].Cells[3].Value);
                anno = datac.Year;
                //MessageBox.Show("Vado anno: " + anno.ToString());
                chiave = Cerca(IdCommessa, anno);
                //MessageBox.Show("Vado chiave: " + chiave.ToString());
                try
                {
                    macchina = Convert.ToInt32(textBox1.Text);
                }
                catch
                {
                    macchina = 0;
                }
                LavoraStampaggio stampa = new LavoraStampaggio(chiave.ToString(), macchina);
                stampa.ShowDialog();
                aggiorna();
            }
            catch { }
        }

        private int Cerca(string idc, int anno)
        {
            DateTime data;
            data = new DateTime(anno, 1, 1);
            idc = idc.Replace("OF", "S");

            //DataRow riga;
            //DataTable Commesse;
            //Commesse = target2021DataSet.Tables["Commesse"];
            //DataTable Filtrata = Commesse.AsEnumerable()
            //.Where(row => row.Field<String>("CodCommessa") == idc
            //       && row.Field<DateTime>("DataCommessa") > data
            //       && row.Field<Int32>("TipoCommessa") == 2)
            //.CopyToDataTable();
            //Object cellValue = Filtrata.Rows[0][0];
            //return Convert.ToInt32(cellValue);
            int ID;
            DataRow[] riga;
            riga = target2021DataSet.Tables["Commesse"].Select("CodCommessa='" + idc + "' AND TipoCommessa=2 AND DataCommessa>'" + data.ToString()+"'");
            try
            {
                ID = Convert.ToInt32(riga[0]["IDCommessa"]);
                return ID;
            }
            catch { return -1; }
        }

        private void commesseDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int IdCommessa;
            //IdCommessa = Convert.ToInt32(commesseDataGridView1.SelectedRows[0].Cells[0].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aggiorna();
            //commesseDataGridView1.Sort
        }
    }
}
