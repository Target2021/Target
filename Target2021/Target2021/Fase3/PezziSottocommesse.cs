﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021.Fase3
{
    public partial class PezziSottocommesse : Form
    {
        private string Cod;

        public PezziSottocommesse(string C)
        {
            InitializeComponent();
            Cod = C;
        }

        private void PezziSottocommesse_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.Commesse'. È possibile spostarla o rimuoverla se necessario.
            this.commesseTableAdapter.Fill(this.target2021DataSet.Commesse);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.AbbinamentiSuperCommesse'. È possibile spostarla o rimuoverla se necessario.
            this.abbinamentiSuperCommesseTableAdapter.Fill(this.target2021DataSet.AbbinamentiSuperCommesse);
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.SuperCommessa'. È possibile spostarla o rimuoverla se necessario.
            this.superCommessaTableAdapter.Fill(this.target2021DataSet.SuperCommessa);
            textBox1.Text = Cod;
            int Id = Cerca(Cod);
            abbinamentiSuperCommesseBindingSource.Filter="IdSuperCommessa = " + Id.ToString();
            commesseBindingSource.Filter="InSupercommessa = " + Id.ToString();
        }

        private int Cerca(string Cod)
        {
            int ID;
            DataRow[] riga;
            riga = target2021DataSet.Tables["SuperCommessa"].Select("CodiceSuperCommessa='" + Cod + "'"); 
            try
            {
                ID = Convert.ToInt32(riga[0]["IDSuperCommessa"]);
                return ID;
            }
            catch { return -1; }
        }

        private void superCommessaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.superCommessaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }
    }
}