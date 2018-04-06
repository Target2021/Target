﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Target2021
{
    public partial class Dettaglio_Articoli : Form
    {
        public Dettaglio_Articoli()
        {
            InitializeComponent();
        }

        private void Dettaglio_Load(object sender, EventArgs e)
        {
            this.dettArticoliTableAdapter.Fill(this.target2021DataSet.DettArticoli);
        }

        private void dettArticoliBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.dettArticoliBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }

        private void SelezionaRiga(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = dettArticoliBindingSource.Position;
            RigaCompleta rigaCompleta = new RigaCompleta(id, Filter.Text, textBox1.Text);
            rigaCompleta.MdiParent = this.MdiParent;
            rigaCompleta.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Filter.Text == "Codice articolo") dettArticoliBindingSource.Filter = "codice_articolo='" + textBox1.Text+"'";
            if (Filter.Text == "Descrizione") dettArticoliBindingSource.Filter = "descrizionePrimaStampoDima LIKE '*" + textBox1.Text + "*'";
        }
    }
}
