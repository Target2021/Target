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

namespace Target2021.Fase3
{
    public partial class PezziSottocommesse : Form
    {
        private string Cod;

        public List<Int64> IDCommesse= new List<Int64>();


        public PezziSottocommesse(string C)
        {
            InitializeComponent();
            Cod = C;
        }

        private void PezziSottocommesse_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.AbbinamentiSuperCommesse'. È possibile spostarla o rimuoverla se necessario.
            this.abbinamentiSuperCommesseTableAdapter.Fill(this.target2021DataSet.AbbinamentiSuperCommesse);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.SuperCommessa'. È possibile spostarla o rimuoverla se necessario.
            this.superCommessaTableAdapter.Fill(this.target2021DataSet.SuperCommessa);
            textBox1.Text = Cod;
            int Id = Cerca(Cod);
            abbinamentiSuperCommesseBindingSource.Filter="IdSuperCommessa = " + Id.ToString();
            commesseBindingSource.Filter="InSupercommessa = " + Id.ToString();
        }

        private int Cerca(string Cod)
        {
            int ID;
            DataRow[] riga;
            riga = target2021DataSet.Tables["SuperCommessa"].Select("CodiceSuperCommessa='" + Cod + "'"); 
            try
            {
                ID = Convert.ToInt32(riga[0]["IDSuperCommessa"]);
                return ID;
            }
            catch { return -1; }
        }

        private async Task Salva()
        {
            this.Validate();
            this.commesseBindingSource.EndEdit();
            var result= await Task.Run(()=> commesseTableAdapter.Update(target2021DataSet.Commesse));
            MessageBox.Show("Salvataggio effettuato!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Controlla che siano state compilate le quantità
            int NrPezziCorretti=0, NrPezziScartati = 0, Corretto = 0;
            foreach (DataGridViewRow row in commesseDataGridView.Rows)
            {

                int IDCommessa = Convert.ToInt32(row.Cells["IDCommessa"].Value);

                try
                {
                    NrPezziCorretti = Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn36"].Value);
                }
                catch
                {
                    NrPezziCorretti = -1;
                    Corretto = -1;
                }
                try
                {
                    NrPezziScartati = Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn37"].Value);
                }
                catch
                {
                    NrPezziScartati = -1;
                    Corretto = -1;
                }

                UpdateRow(IDCommessa, NrPezziCorretti, NrPezziScartati);
            }

            if (Corretto == -1) MessageBox.Show("Non tutte le quantità sono state compilate correttamente!");
            else
            {
                Salva();
                this.Hide();
            }
        }

        private void UpdateRow(int iDCommessa, int nrPezziCorretti, int nrPezziScartati)
        {
            //MessageBox.Show("IDCOMMEESSAA:" + iDCommessa);
            this.IDCommesse.Add(iDCommessa);
            //MessageBox.Show("IDCOMMEESSAA:"+ IDCommesse);
            string sql = " UPDATE dbo.Commesse SET NrPezziCorretti="+nrPezziCorretti+ ", NrPezziScartati="+nrPezziScartati+" WHERE IDCommessa="+iDCommessa+" ";
            string stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            connessione.Open();
            SqlCommand cmdSelect = new SqlCommand(sql,connessione );
            cmdSelect.ExecuteScalar();
            connessione.Close();
        }
    }
}
