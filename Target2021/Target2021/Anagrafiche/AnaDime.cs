﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Target2021.NuovePagine;

namespace Target2021.Anagrafiche
{
    public partial class AnaDime : Form
    {
        public AnaDime()
        {
            InitializeComponent();
        }

        private void Filtra(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Codice") dimeBindingSource.Filter = "codice LIKE '*" + textBox1.Text + "*'";
            if (comboBox1.Text == "Descrizione") dimeBindingSource.Filter = "descrizione LIKE '*" + textBox1.Text + "*'";
        }

        private void dimeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dimeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void AnaDime_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Dime'. È possibile spostarla o rimuoverla se necessario.
            this.dimeTableAdapter.Fill(this.target2021DataSet.Dime);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Dime'. È possibile spostarla o rimuoverla se necessario.
            this.dimeTableAdapter.Fill(this.target2021DataSet.Dime);

        }

        private void dimeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.dimeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NuovaDima ND = new NuovaDima();
            ND.ShowDialog();
            this.dimeTableAdapter.Fill(this.target2021DataSet.Dime);
        }
    }
}
