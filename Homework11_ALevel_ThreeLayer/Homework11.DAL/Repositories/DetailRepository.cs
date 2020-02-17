using System.Collections.Generic;
using Homework11.DAL.Interfaces;
using Homework11.DAL.Models;
using Dapper;
using System.Data.SqlClient;
using System.Linq;

namespace Homework11.DAL.Repository
{
    public class DetailRepository : IDetailRepository
    {
        private readonly string _connectionString;
        public DetailRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Delete(Detail detail)
        {
            var sql = $"DELETE FROM Details WHERE Id = {detail.Id}";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var result = connection.Execute(sql);
                connection.Close();
            };
        }

        public Detail GetCar(int id)
        {
            var sql = $"SELECT * FROM Details Detail INNER JOIN Cars Car on Detail.CarId = Car.Id WHERE Detail.Id = {id}";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var result = connection.Query<Detail, Car, Detail>(sql, (detail, car) =>
                {
                    detail.Car = car;

                    return detail;
                });

                connection.Close();

                return result.FirstOrDefault();
            };
        }

        public IEnumerable<Detail> GetAll()
        {
            var sql = $"SELECT * FROM Details";
            var result = new List<Detail>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
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
                            DetailName = (string)reader["DetailName"],
                            CarId = (int) reader ["CarId"],
                            Cost = (int)reader["Cost"]
                        });
                    }
                }
                connection.Close();
            }
            return result;
        }

        public void Insert(Detail detail)
        {
            var sql = $"INSERT INTO Details (CarId, DetailName, Cost) OUTPUT INSERTED.Id VALUES ({detail.CarId}, '{detail.DetailName}',{detail.Cost})";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var insertId = (int)connection.ExecuteScalar(sql);
                connection.Close();

                detail.Id = insertId;
            };
        }

        public void Update(Detail detail)
        {
            var sql = $"UPDATE Details SET DetailName = '{detail.DetailName}', Cost = {detail.Cost} WHERE ID = {detail.Id}";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var result = connection.Execute(sql);
                connection.Close();
            };
        }
    }
}
