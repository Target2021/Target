using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target2021
{
    public class RecAnaForn
    {
        string CodF;
        public string RagSoc, Indirizzo, Cap, Localita, Provincia;

        public RecAnaForn(string Codice)
        {
            CodF = Codice;
            SqlConnection connessione = new SqlConnection(Target2021.Properties.Resources.StringaConnessione);
            connessione.Open();

            string query = "SELECT ragione_sociale FROM Fornitori WHERE codice = '" + CodF + "'";
            SqlCommand comando = new SqlCommand(query, connessione);
            RagSoc = Convert.ToString(comando.ExecuteScalar());

            query = "SELECT indirizzo FROM Fornitori WHERE codice = '" + CodF + "'";
            comando = new SqlCommand(query, connessione);
            Indirizzo = Convert.ToString(comando.ExecuteScalar());

            query = "SELECT cap FROM Fornitori WHERE codice = '" + CodF + "'";
            comando = new SqlCommand(query, connessione);
            Cap = Convert.ToString(comando.ExecuteScalar());

            query = "SELECT localita FROM Fornitori WHERE codice = '" + CodF + "'";
            comando = new SqlCommand(query, connessione);
            Localita = Convert.ToString(comando.ExecuteScalar());

            query = "SELECT Provincia FROM Fornitori WHERE codice = '" + CodF + "'";
            comando = new SqlCommand(query, connessione);
            Provincia = Convert.ToString(comando.ExecuteScalar());

            connessione.Close();
        }
    }
}
