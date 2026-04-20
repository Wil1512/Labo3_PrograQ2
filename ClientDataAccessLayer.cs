using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Labo4_PrograQ2
{
    internal class ClientDataAccessLayer
    {

        private string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Labo_SQL ;Integrated Security=True;TrustServerCertificate=True";

        public List<Client> LireTout()
        {
            List<Client> liste = new List<Client>();

            using (SqlConnection cnx = new SqlConnection(connectionString))
            {

                string query = "SELECT NumCli, Nom, Prenom FROM Client";
                SqlCommand cmd = new SqlCommand(query, cnx);

                cnx.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        liste.Add(new Client
                        {
                            NumCli = Convert.ToInt32(reader["NumCli"]),
                            Nom = reader["Nom"].ToString(),
                            Prenom = reader["Prenom"].ToString()
                        });
                    }
                }
            }
            return liste;
        }
    }
}
