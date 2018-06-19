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
            textBox1.Enabled = false;
            timer1.Interval = 500;
            timer2.Interval = 60000;
            timer1.Stop();
            timer2.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string PGTaglioInMacchina,PGTaglioInCommessa;

            timer1.Stop();
            textBox1.Enabled = false;
            textBox4.Focus();
            leggiprogrammataglio();
            PGTaglioInMacchina = controllaPGMacchina();
            PGTaglioInCommessa = controllaPGCommessa(textBox1.Text);
            if (PGTaglioInMacchina == PGTaglioInCommessa)
            {
                timer2.Start();
            }
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
            return Programma;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
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

    }
}
