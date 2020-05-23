using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Fase2
{
    public partial class DettPianifica : Form
    {
        // Modificare facendo partire le date dal primo del mese corrente
        public DateTime datai;
        public DateTime dataf;
        public DateTime orai = new DateTime(2020, 1, 1,0,0,0);
        public DateTime oraf = new DateTime(2020, 1, 1,0,0,0);
        public int durata;
        public int elimina = 0;

        public DettPianifica(DateTime d, DateTime o, int du)
        {
            InitializeComponent();
            datai = d;
            orai = o;
            durata = du;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DettPianifica_Load(object sender, EventArgs e)
        {
            datai = DateTime.Today;
            dataf = DateTime.Today;
            imposta();
        }

        private void imposta()
        {
            dateTimePicker1.Value = datai;
            dateTimePicker4.Value = orai;
            textBox1.Text = durata.ToString();
        }

        private void dateTimePicker1_DropDown(object sender, EventArgs e)
        {
            //dateTimePicker1.Value = DateTime.Today;
            //dateTimePicker1.Update();
            //dateTimePicker1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datai = dateTimePicker1.Value;
            orai = dateTimePicker4.Value;
            durata = Convert.ToInt32(textBox1.Text);
            dataf = dateTimePicker2.Value;
            oraf = dateTimePicker3.Value;
            this.Dispose();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            elimina = 1;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Ipotizza data e ora di fine
            DateTime datainizio, orainizio, datafine, orafine;
            int durata, giorni, ore, minuti;
            datainizio = dateTimePicker1.Value;
            orainizio = dateTimePicker4.Value;
            durata = Convert.ToInt32(textBox1.Text);
            ore = durata / 60;
            giorni = ore / 8;
            ore = ore % 8;
            minuti = durata % 60;
            datafine = datainizio.AddDays(giorni);
            orafine = orainizio.AddHours(ore);
            orafine = orafine.AddMinutes(minuti);
            dateTimePicker2.Value = datafine;
            dateTimePicker3.Value = orafine;
        }
    }
}
