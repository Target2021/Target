﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Target2021.Anagrafiche
{
    public partial class CheckAssemblaggio : Form
    {
        public CheckAssemblaggio()
        {
            InitializeComponent();
        }

        private void CheckAssemblaggio_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Fase4'. È possibile spostarla o rimuoverla se necessario.
            this.fase4TableAdapter.Fill(this.target2021DataSet.Fase4);
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            commesseBindingSource.Filter="TipoCommessa=4";
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
