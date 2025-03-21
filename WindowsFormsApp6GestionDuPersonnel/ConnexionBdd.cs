using System.Data.SqlClient;

namespace WindowsFormsApp6GestionDuPersonnel
{
    internal  class ConnexionBdd 
    { 
            public static SqlConnection GetDBConnexion() 
            {
                string host = "N112-02";
                string database = "gesper";
                string login = "sa";
                string password = "toto";

                string conncString = string.Format(@"Server ={0}; Database = {1}; User ID={2}; Password={3}", host, database, login, password);
                SqlConnection maConnexion = new SqlConnection(conncString);
                return maConnexion;
            }
    }
}

