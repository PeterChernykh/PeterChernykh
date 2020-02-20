using System.Collections.Generic;
using Homework10.DAL.Interfaces;
using Homework10.DAL.Models;
using System.Data.SqlClient;

namespace Homework10.DAL.Repositories
{
    public class CarRepository : IRepository<Car>
    {
        public IEnumerable<Car> GetAll()
        {
            SqlConnection connection = AdoNetConnection.DatabaseConnect();

            var sql = $"SELECT * FROM Cars";
            var result = new List<Car>();

            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result.Add(new Car
                        {
                            Id = (int)reader["Id"],
                            Model = (string)reader["Model"]
                        });
                    }
                }
                connection.Close();
            }
            return result;
        }
    }
}
