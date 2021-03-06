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
    public partial class AnaStampi : Form
    {
        public AnaStampi()
        {
            InitializeComponent();          
        }

        private void stampiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stampiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);
        }

        private void AnaStampi_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Stampi'. È possibile spostarla o rimuoverla se necessario.
            this.stampiTableAdapter.Fill(this.target2021DataSet.Stampi);
        }

        private void stampiDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch (NoNullAllowedException ex) { MessageBox.Show("La tabella non può essere modificata"); }
        }

        private void stampiBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.stampiBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.target2021DataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Codice") stampiBindingSource.Filter = "codice LIKE '*" + textBox1.Text + "*'";
            if (comboBox1.Text == "Descrizione") stampiBindingSource.Filter = "descrizione LIKE '*" + textBox1.Text + "*'";
        }

        private void stampiDataGridView_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            // If the data source raises an exception when a cell value is 
            // commited, display an error message.
            if (e.Exception != null &&
                e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Il Codice dello Stampo è già presente!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NuovoStampo NS = new NuovoStampo();
            NS.ShowDialog();
            this.stampiTableAdapter.Fill(this.target2021DataSet.Stampi);
        }
    }
}
