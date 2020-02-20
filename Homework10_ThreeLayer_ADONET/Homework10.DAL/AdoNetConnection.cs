using System.Data.SqlClient;

namespace Homework10.DAL
{
    public static class AdoNetConnection
    {
        public static SqlConnection DatabaseConnect()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Homework11DB;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }
    }
}
