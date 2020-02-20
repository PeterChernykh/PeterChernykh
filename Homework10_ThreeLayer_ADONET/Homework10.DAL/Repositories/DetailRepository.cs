using System.Collections.Generic;
using Homework10.DAL.Interfaces;
using Homework10.DAL.Models;
using System.Data.SqlClient;

namespace Homework10.DAL.Repositories
{
    public class DetailRepository : IRepository<Detail>
    {
        public IEnumerable<Detail> GetAll()
        {
            SqlConnection connection = AdoNetConnection.DatabaseConnect();

            var sql = "SELECT * FROM Details";
            var result = new List<Detail>();

            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result.Add(new Detail
                        {
                            Id = (int)reader["Id"],
                            CarId = (int)reader["CarId"],
                            DetailName = (string)reader["DetailName"],
                            Cost = (int)reader["Cost"]
                        });
                    }
                    connection.Close();
                }
                return result;
            }
        }
    }
}
