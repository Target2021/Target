using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Target2021.Selezioni;

namespace Target2021
{
    public partial class CaricoScarico : Form
    {
        public CaricoScarico()
        {
            InitializeComponent();
        }

        private void movimentiMagazzinoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movimentiMagazzinoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }

        private void CaricoScarico_Load(object sender, EventArgs e)
        {
            this.anaMagazziniTableAdapter.Fill(this.target2021DataSet.AnaMagazzini);
            this.movimentiMagazzinoTableAdapter.Fill(this.target2021DataSet.MovimentiMagazzino);
            if (comboBox1 .SelectedIndex == 0)
            {
                textBox5.Visible = true;
                textBox6.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
            }
            else
            {
                textBox5.Visible = false;
                textBox6.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }
        }

        private void Seleziona(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)  // Materie prime
            {
                SelezionaLastre SL = new SelezionaLastre();
                SL.ShowDialog();
                string cod = SL.codice;
                textBox1.Text = cod;
            }
            if (comboBox1.SelectedIndex == 1) // Stampi
            {
                SelezionaStampo SS = new SelezionaStampo();
                SS.ShowDialog();
                string cod = SS.codice;
                textBox1.Text = cod;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox5.Visible = true;
                textBox6.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
            }
            else
            {
                textBox5.Visible = false;
                textBox6.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
