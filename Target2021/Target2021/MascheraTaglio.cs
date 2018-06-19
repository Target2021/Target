using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Target2021
{
    public partial class MascheraTaglio : Form
    {
        public MascheraTaglio()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void MascheraTaglio_Load(object sender, EventArgs e)
        {
            Scanna scanner = new Scanna();
            textBox1.Enabled = false;
            timer1.Interval = 1000;
            timer2.Interval = 6000;
            timer1.Stop();
            timer2.Stop();

            // CARICA DATI DI PARTENZA
            string stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            string query = "SELECT CodCommessaSinistra, PezziScartatiSinistra FROM Configurazione WHERE IDAzienda=1";
            SqlCommand cmd = new SqlCommand(query, connessione);
            connessione.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox1.Text = reader[0].ToString();
                textBox4.Text = reader[1].ToString();
            }
            connessione.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string PGTaglioInMacchina,PGTaglioInCommessa;

            //timer1.Stop();
            textBox1.Enabled = false;
            //textBox4.Focus();
            leggiprogrammataglio();
            PGTaglioInMacchina = controllaPGMacchina();
            PGTaglioInCommessa = controllaPGCommessa(textBox1.Text);
            if (PGTaglioInMacchina == PGTaglioInCommessa)
            {
                label6.Visible = false;
                timer1.Stop();
                timer2.Start();
            }
            else
            {
                if (PGTaglioInMacchina == "")
                {
                    label6.Text ="Inserire programma nel MAIN";
                    label6.Visible = true;
                }                      
                else
                {
                    label6.Text ="Il programma selezionato non corrisponde alla Commessa inserita";
                    label6.Visible = true;
                }               
            }
        }

        private void salva(string codcom, int stato)
        {
            int sxPezzi = 0, dxPezzi = 0, sxSecondi = 0, dxSecondi = 0;
            string sxProgramma, dxProgramma;
            try
            {
                sxPezzi = Convert.ToInt32(textBox3.Text);
                sxSecondi = Convert.ToInt32(textBox5.Text);
            }
            catch { }

            sxProgramma = textBox2.Text;
            //dxProgramma = textBox4.Text;

            string stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            string query = "UPDATE Commesse SET ProgrTaglio1='" + sxProgramma + "', SecondiCicloTaglio=" + Convert.ToString(sxSecondi) + ", NrPezziCorretti=" + textBox6.Text + ", NrPezziScartati="+textBox4.Text+", Stato="+stato+" WHERE CodCommessa='"+codcom +"'";
            SqlCommand cmd = new SqlCommand(query, connessione);
            connessione.Open();
            cmd.ExecuteNonQuery();
            connessione.Close();
        }

        private void leggiprogrammataglio()
        {
            List<WinText> windows = new List<WinText>();
            IntPtr subWindow = getSubWindow();

            // Legge i programmi di taglio
            IntPtr sxProgrTaglio = LeggiProgrTaglioSx(subWindow);
            IntPtr dxProgrTaglio = LeggiProgrTaglioDx(subWindow);

            textBox2.Text = GetText(sxProgrTaglio);
        }

        private string controllaPGMacchina()
        {
            return textBox2.Text;
        }

        private string controllaPGCommessa(string Prog)
        {
            string CodCommessa, stringa_connessione, Programma;
            stringa_connessione = Properties.Resources.StringaConnessione;
            SqlConnection conn = new SqlConnection(stringa_connessione);
            string queryCliente = "Select ProgrTaglio1 From Commesse Where CodCommessa='" + Prog+"'";
            SqlCommand comando = new SqlCommand(queryCliente, conn);
            conn.Open();
            Programma = comando.ExecuteScalar().ToString();
            conn.Close();
            Programma = Programma.TrimEnd();
            return Programma;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string  codicecommessa;
            try
            {
                List<WinText> windows = new List<WinText>();
                IntPtr subWindow = getSubWindow();

                IntPtr sxCounterWindow = getSxCounterWindow(subWindow);
                IntPtr dxCounterWindow = getDxCounterWindow(subWindow);
                
                // Legge i secondi dei cicli di taglio
                IntPtr sxSecondiCiclo = LeggiSecondiCicloSx(subWindow);
                IntPtr dxSecondiCiclo = LeggiSecondiCicloDx(subWindow);

                textBox3.Text = GetText(sxCounterWindow);
                //textBox2.Text = GetText(dxCounterWindow);
                textBox5.Text = GetText(sxSecondiCiclo);
                //textBox6.Text = GetText(dxSecondiCiclo);
            }
            catch { }
            codicecommessa = textBox1.Text;
            aggiornacorretti();
            salva(codicecommessa,1);
        }

        private IntPtr getSubWindow()
        {
            IntPtr mainWindow = FindWindow("WindowsForms10.Window.8.app.0.378734a", "CMS Operator Interfacev.5.3.0 - NC Name: 192.168.139.1");
            IntPtr sysTabControlWindow = FindWindowEx(mainWindow, IntPtr.Zero, "WindowsForms10.SysTabControl32.app.0.378734a", null);
            IntPtr programsWindow = FindWindowEx(sysTabControlWindow, IntPtr.Zero, "WindowsForms10.Window.8.app.0.378734a", null);
            IntPtr subWindow = FindWindowEx(programsWindow, IntPtr.Zero, "WindowsForms10.Window.8.app.0.378734a", null);

            return subWindow;
        }

        private IntPtr getSxCounterWindow(IntPtr subWindow)
        {
            IntPtr sxWindow = FindWindowByIndex(subWindow, "WindowsForms10.Window.8.app.0.378734a", 2);
            IntPtr sxCounterWindow = FindWindowByIndex(sxWindow, "WindowsForms10.EDIT.app.0.378734a", 1);

            return sxCounterWindow;
        }

        private IntPtr getDxCounterWindow(IntPtr subWindow)
        {
            IntPtr dxWindow = FindWindowByIndex(subWindow, "WindowsForms10.Window.8.app.0.378734a", 1);
            IntPtr dxCounterWindow = FindWindowByIndex(dxWindow, "WindowsForms10.EDIT.app.0.378734a", 1);

            return dxCounterWindow;
        }

        private IntPtr LeggiProgrTaglioSx(IntPtr subWindow)
        {
            IntPtr sxWindow = FindWindowByIndex(subWindow, "WindowsForms10.Window.8.app.0.378734a", 2);
            IntPtr progTagSx = FindWindowByIndex(sxWindow, "WindowsForms10.COMBOBOX.app.0.378734a", 4);

            return progTagSx;
        }

        private IntPtr LeggiProgrTaglioDx(IntPtr subWindow)
        {
            IntPtr dxWindow = FindWindowByIndex(subWindow, "WindowsForms10.Window.8.app.0.378734a", 1);
            IntPtr progTagDx = FindWindowByIndex(dxWindow, "WindowsForms10.COMBOBOX.app.0.378734a", 4);

            return progTagDx;
        }

        private IntPtr LeggiSecondiCicloSx(IntPtr subWindow)
        {
            IntPtr sxWindow = FindWindowByIndex(subWindow, "WindowsForms10.Window.8.app.0.378734a", 2);
            IntPtr progTagSx = FindWindowByIndex(sxWindow, "WindowsForms10.STATIC.app.0.378734a", 2);

            return progTagSx;
        }

        private IntPtr LeggiSecondiCicloDx(IntPtr subWindow)
        {
            IntPtr dxWindow = FindWindowByIndex(subWindow, "WindowsForms10.Window.8.app.0.378734a", 1);
            IntPtr progTagDx = FindWindowByIndex(dxWindow, "WindowsForms10.STATIC.app.0.378734a", 2);

            return progTagDx;
        }
        // FOR DEBUG ONLY - REMOVE!!
        private void SetText(IntPtr hWnd, string text)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(text);
            SendMessage(hWnd, WM_SETTEXT, 0, sb);
        }

        private string GetText(IntPtr hWnd)
        {
            StringBuilder sb = new System.Text.StringBuilder(255);
            int val = SendMessage(hWnd, WM_GETTEXT, sb.Capacity, sb);

            return sb.ToString();
        }

        static IntPtr FindWindowByIndex(IntPtr hWndParent, String className, int index)
        {
            if (index == 0)
                return hWndParent;
            else
            {
                int ct = 0;
                IntPtr result = IntPtr.Zero;
                do
                {
                    result = FindWindowEx(hWndParent, result, className, null);
                    if (result != IntPtr.Zero)
                        ++ct;
                }
                while (ct < index && result != IntPtr.Zero);
                return result;
            }
        }

        private struct WinText
        {
            public IntPtr hWnd;
            public string Text;
        }

        const int WM_GETTEXT = 0x0D;
        const int WM_GETTEXTLENGTH = 0x0E;

        // FOR DEBUG ONLY - REMOVE!!
        const int WM_SETTEXT = 0x000c;

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int SendMessage(IntPtr hWnd, int msg, int Param, System.Text.StringBuilder text);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        // FOR DEBUG ONLY -- REMOVE!!
        [DllImport("user32.dll")]
        static extern IntPtr GetDlgItem(IntPtr hDlg, int nIDDlgItem);

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void aggiornacorretti()
        {
            int prodotti, scartati=0;
            if (textBox3.Text == "") textBox3.Text = "0";
            prodotti = Convert.ToInt32(textBox3.Text);
            //if (textBox3.Text == "") textBox3.Text =
            try
            {
            scartati = Convert.ToInt32(textBox4.Text);
            }
            catch { }
            textBox6.Text = (prodotti - scartati).ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            aggiornacorretti();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pezzicorretti = 0;
            pezzicorretti = Convert.ToInt32(textBox6.Text);
            DialogResult dialogResult = MessageBox.Show("Sei sicuro?", "Conferma salvataggio", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                timer2.Stop();
                string codicecommessa = textBox1.Text;
                salva(codicecommessa,2);
                salvatemp();
                textBox1.Text = "";
                timer1.Stop();
                textBox4.Text = "0";
                caricamagazzino(codicecommessa,pezzicorretti);
                aggiornagiacenze(codicecommessa, pezzicorretti);
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SalvaDatiParziali(object sender, FormClosedEventArgs e)
        {
            string ccs, ccd;
            int pss, psd;
            ccs = textBox1.Text;
            pss = Convert.ToInt32(textBox4.Text);
            string stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            string query = "UPDATE Configurazione SET CodCommessaSinistra='" + ccs + "', PezziScartatiSinistra=" + Convert.ToString(pss) + " WHERE IDAzienda=1";
            SqlCommand cmd = new SqlCommand(query, connessione);
            connessione.Open();
            cmd.ExecuteNonQuery();
            connessione.Close();
        }

        private void salvatemp()
        {
            string stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            string query = "UPDATE Configurazione SET CodCommessaSinistra=' ', PezziScartatiSinistra=0 WHERE IDAzienda=1";
            SqlCommand cmd = new SqlCommand(query, connessione);
            connessione.Open();
            cmd.ExecuteNonQuery();
            connessione.Close();
        }

        private void caricamagazzino(string ccom, int npez)
        {
            int IDMagazzino = 5, quantita = 0;
            string IDArticoli,BarCode,Ordine;
            DateTime DataMovimento;

            quantita = npez;
            Ordine = ccom;

            DataMovimento = DateTime.Now;
            IDArticoli = RitCodArticolo(ccom);

            // Inserisce movimento in MOVIMENTI DI MAGAZZINO
            string stringa_connessione;
            stringa_connessione = Properties.Resources.StringaConnessione;
            SqlConnection conn = new SqlConnection(stringa_connessione);
            string queryCliente = "INSERT INTO MovimentiMagazzino (idMagazzino, idArticoli, CarScar, Quantita, Barcode, NrOrdine, DataOraMovimento) VALUES (5, @ida, 'C', @q, @bc, @nro, @dtm)";
            SqlCommand comando = new SqlCommand(queryCliente, conn);
            comando.Parameters.AddWithValue("@ida", IDArticoli);
            comando.Parameters.AddWithValue("@q", quantita);
            comando.Parameters.AddWithValue("@bc", "123");
            comando.Parameters.AddWithValue("@nro", Ordine);
            comando.Parameters.AddWithValue("@dtm", DataMovimento);

            conn.Open();
            comando.ExecuteNonQuery();
            conn.Close();
        }

        private string RitCodArticolo(string ccom)
        {
            string stringa_connessione, CodArt;
            stringa_connessione = Properties.Resources.StringaConnessione;
            SqlConnection conn = new SqlConnection(stringa_connessione);
            string queryCliente = "Select CodArticolo From Commesse Where CodCommessa='" + ccom + "'";
            SqlCommand comando = new SqlCommand(queryCliente, conn);
            conn.Open();
            CodArt = comando.ExecuteScalar().ToString();
            conn.Close();
            return CodArt;
        }

        private void aggiornagiacenze(string ccom, int npez)
        {   // SE c'è lo aggiorna, se non c'è lo inserisce
            //int IDMagazzino = 5, quantita = 0;
            //string IDArticoli, BarCode, Ordine;
            //DateTime DataMovimento;

            //quantita = npez;
            //Ordine = ccom;

            //DataMovimento = DateTime.Now;
            //IDArticoli = RitCodArticolo(ccom);

            //Inserisce movimento in MOVIMENTI DI MAGAZZINO
            //string stringa_connessione;
            //stringa_connessione = Properties.Resources.StringaConnessione;
            //SqlConnection conn = new SqlConnection(stringa_connessione);
            //string queryCliente = "INSERT INTO MovimentiMagazzino (idMagazzino, idArticoli, CarScar, Quantita, Barcode, NrOrdine, DataOraMovimento) VALUES (5, @ida, 'C', @q, @bc, @nro, @dtm)";
            //SqlCommand comando = new SqlCommand(queryCliente, conn);
            //comando.Parameters.AddWithValue("@ida", IDArticoli);
            //comando.Parameters.AddWithValue("@q", quantita);
            //comando.Parameters.AddWithValue("@bc", "123");
            //comando.Parameters.AddWithValue("@nro", Ordine);
            //comando.Parameters.AddWithValue("@dtm", DataMovimento);

            //conn.Open();
            //comando.ExecuteNonQuery();
            //conn.Close();
        }
    }
}
