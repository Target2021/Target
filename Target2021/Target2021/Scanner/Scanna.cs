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
    public partial class Scanna : Form
    {
        public Scanna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bottone1();
        }

        private void bottone1()
        {
            try
            {
                List<WinText> windows = new List<WinText>();

                IntPtr subWindow = getSubWindow();
                IntPtr sxCounterWindow = getSxCounterWindow(subWindow);
                IntPtr dxCounterWindow = getDxCounterWindow(subWindow);
                // Legge i programmi di taglio
                IntPtr sxProgrTaglio = LeggiProgrTaglioSx(subWindow);
                IntPtr dxProgrTaglio = LeggiProgrTaglioDx(subWindow);
                // Legge i secondi dei cicli di taglio
                IntPtr sxSecondiCiclo = LeggiSecondiCicloSx(subWindow);
                IntPtr dxSecondiCiclo = LeggiSecondiCicloDx(subWindow);

                textBox1.Text = GetText(sxCounterWindow);
                textBox2.Text = GetText(dxCounterWindow);
                textBox3.Text = GetText(sxProgrTaglio);
                textBox4.Text = GetText(dxProgrTaglio);
                textBox5.Text = GetText(sxSecondiCiclo);
                textBox6.Text = GetText(dxSecondiCiclo);
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bottone2();
        }

        private void bottone2()
        {
            IntPtr subWindow = getSubWindow();
            IntPtr sxCounterWindow = getSxCounterWindow(subWindow);
            IntPtr dxCounterWindow = getDxCounterWindow(subWindow);

            SetText(sxCounterWindow, textBox1.Text);
            SetText(dxCounterWindow, textBox2.Text);
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

        private void Scanna_Load(object sender, EventArgs e)
        {
            timer1.Interval = 60000;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sxPezzi=0, dxPezzi=0, sxSecondi=0, dxSecondi=0;
            string sxProgramma, dxProgramma;
            try {
            sxPezzi = Convert.ToInt32(textBox1.Text);
            dxPezzi = Convert.ToInt32(textBox2.Text);
            sxSecondi = Convert.ToInt32(textBox5.Text);
            dxSecondi = Convert.ToInt32(textBox6.Text);
            } catch { }

            sxProgramma = textBox3.Text;
            dxProgramma = textBox4.Text;

            string stringaconnessione = Properties.Resources.StringaConnessione;
            SqlConnection connessione = new SqlConnection(stringaconnessione);
            string query = "UPDATE TaglioOnLine SET ProgTaglio1='" + sxProgramma + "', SecondiCiclo1=" + Convert.ToString(sxSecondi) + ", NumPezzi1=" + Convert.ToString(sxPezzi) + ", ProgTaglio2='" + dxProgramma + "', SecondiCiclo2=" + Convert.ToString(dxSecondi) + ", NumPezzi2=" + Convert.ToString(dxPezzi) + " WHERE IDT=1";
            SqlCommand cmd = new SqlCommand(query, connessione);
            connessione.Open();
            cmd.ExecuteNonQuery();
            connessione.Close();
            //MessageBox.Show("Operazione completata con successo");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bottone1();
            bottone2();
        }
    }
}
