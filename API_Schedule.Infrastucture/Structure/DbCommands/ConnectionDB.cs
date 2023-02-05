using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace API_Schedule.Infrastucture.Structure
{
    public class ConnectionDB : IConnectionDB
    {
        public string connectionString;

        public ConnectionDB(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("ConnectionDB") ;
        }

        public SqlConnection GetConnection() 
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = connectionString;

            connection.Open();

            return connection;
        }
    }
}
