using System.Collections.Generic;
using Homework11.DAL.Interfaces;
using Homework11.DAL.Model;
using Dapper;
using System.Data.SqlClient;
using System.Linq;

namespace Homework11.DAL.Repository
{
    public class CarRepository: ICarRepository
    {
        private readonly string _connectionString;
        public CarRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Delete(Car car)
        {
            var sql = $"DELETE FROM Cars WHERE Id = {car.Id}";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var result = connection.Execute(sql);
                connection.Close();
            };
        }

        public Car GetDeteils(int id)
        {
            var sql = $"SELECT * FROM Cars Car INNER JOIN Details Detail on Car.Id = Detail.CarId WHERE Car.Id = {id}";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var result = connection.Query<Car, Detail, Car>(sql, (car, detail) =>
                {
                    car.Details.Add(detail);

                    return car;
                }).ToList();

                var searchResult = result.FirstOrDefault();
                searchResult.Details = result.SelectMany(x => x.Details).ToList();

                connection.Close();

                return searchResult;

            }
        }

        public IEnumerable<Car> GetAll()
        {

            var sql = "SELECT * FROM Cars";
            var result = new List<Car>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
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

        public void Insert(Car car)
        {
            var sql = $"INSERT INTO Cars (Model) OUTPUT INSERTED.Id VALUES ('{car.Model}')";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var insertId = (int)connection.ExecuteScalar(sql);
                connection.Close();

                car.Id = insertId;
            };
        }

        public void Update(Car car)
        {         
                var sql = $"UPDATE Cars SET Model = '{car.Model}' WHERE ID = {car.Id}";

                using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                    connection.Open();
                    var result = connection.Execute(sql);
                    connection.Close();
                };            
        }
    }
}
