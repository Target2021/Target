﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.SelezAna
{
    public partial class SelPrime : Form
    {
        public int ID;
        public string c, v;

        public SelPrime(int idArt, string campo, string valore)
        {
            InitializeComponent();
            ID = idArt;
            c = campo;
            v = valore;
        }

        private void primeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.primeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cod = codiceTextBox.Text;
            String des = descrizioneTextBox.Text;
            AnArticForn artforn = new AnArticForn(cod,des);
            artforn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
        }

        private void assegna(object sender, EventArgs e)
        {
            string codice, descrizione;
            try
            {
                codice = comboBox1.SelectedValue.ToString();
                descrizione = ((DataRowView)comboBox1.SelectedItem).Row["ragione_sociale"].ToString();
                codice_fornitoreTextBox.Text = codice;
                descrizione_fornitoreTextBox.Text = descrizione;
                comboBox1.Visible = false;
            }
            catch { }
        }

        private void SelPrime_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Fornitori'. È possibile spostarla o rimuoverla se necessario.
            this.fornitoriTableAdapter.Fill(this.target2021DataSet.Fornitori);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Prime'. È possibile spostarla o rimuoverla se necessario.
            this.primeTableAdapter.Fill(this.target2021DataSet.Prime);
            if (c == "Codice") primeBindingSource.Filter = "codice='" + v + "'";
            if (c == "Descrizione") primeBindingSource.Filter = "descrizione LIKE '*" + v + "*'";
            primeBindingSource.Position = ID;
        }
    }
}
