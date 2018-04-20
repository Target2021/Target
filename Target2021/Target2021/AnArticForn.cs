using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target2021
{
    public partial class AnArticForn : Form
    {
        public string cod, des;

        public AnArticForn(string codice, string descrizione)
        {
            InitializeComponent();
            cod = codice;
            des = descrizione;
        }

        private void artFornBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.artFornBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.target2021DataSet);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnArticForn_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'target2021DataSet.ArtForn'. È possibile spostarla o rimuoverla se necessario.
            this.artFornTableAdapter.Fill(this.target2021DataSet.ArtForn);
            textBox1.Text = cod;
            textBox2.Text = des;
            artFornBindingSource .Filter = "CodArticoloTarget = '" + cod + "'";
        }
    }
}
