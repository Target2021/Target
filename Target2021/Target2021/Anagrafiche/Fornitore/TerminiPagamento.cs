﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Anagrafiche.Fornitore
{
    public partial class TerminiPagamento : Form
    {
        public TerminiPagamento()
        {
            InitializeComponent();
        }

        private void codTermPagamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.codTermPagamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void TerminiPagamento_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.CodTermPagamento'. È possibile spostarla o rimuoverla se necessario.
            this.codTermPagamentoTableAdapter.Fill(this.target2021DataSet.CodTermPagamento);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.CodTermPagamento'. È possibile spostarla o rimuoverla se necessario.
            this.codTermPagamentoTableAdapter.Fill(this.target2021DataSet.CodTermPagamento);

        }

        private void codTermPagamentoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.codTermPagamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }
    }
}
