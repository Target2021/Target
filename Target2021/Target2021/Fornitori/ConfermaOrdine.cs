﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Fornitori
{
    public partial class ConfermaOrdine : Form
    {
        public ConfermaOrdine()
        {
            InitializeComponent();
        }

        private void ordFornTestBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordFornTestBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void ConfermaOrdine_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.OrdFornTest'. È possibile spostarla o rimuoverla se necessario.
            this.ordFornTestTableAdapter.Fill(this.target2021DataSet.OrdFornTest);

        }

        private void Selezionata(object sender, DataGridViewCellEventArgs e)
        {
            int NrOrd;
            NrOrd = Convert.ToInt32(ordFornTestDataGridView.Rows[e.RowIndex].Cells[11].Value);
            DettConsultazione Dettaglio = new DettConsultazione(NrOrd,2);
            Dettaglio.Show();
        }

        private void ordFornTestDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
