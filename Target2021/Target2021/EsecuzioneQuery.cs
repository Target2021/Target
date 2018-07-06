using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target2021
{
    class EsecuzioneQuery
    {
        public string query { get; set; }
        public static string connection =Properties.Resources.StringaConnessione;
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        public EsecuzioneQuery(string Q)
        {
            this.query = Q;
            sqlConnection.ConnectionString = connection;
            sqlCommand.Connection = sqlConnection;
        }
        public object EseguiQuery(int type) //0= Scalar, 1= ExecuteNonQuery, 2=Reader,3= con SqlDataAdapter
        {
            switch(type)
            {
                case 0:
                    sqlCommand.CommandText = query;
                    sqlConnection.Open();
                    return sqlCommand.ExecuteScalar();
                case 1:
                    sqlCommand.CommandText = query;
                    sqlConnection.Open();
                    return sqlCommand.ExecuteNonQuery();
                case 2:
                    sqlCommand.CommandText = query;
                    sqlConnection.Open();
                    return sqlCommand.ExecuteReader();
            }
            sqlConnection.Close();
            return 0;
        }
    }
}
