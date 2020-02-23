using System.Collections.Generic;
using System.Data.Entity;
using Homework12_DAL.Interfaces;
using Homework12_DAL.Models;
using System.Linq;

namespace Homework12_DAL.Repositories
{
    public class CarRepository : IRepository<Car>
    {
        private readonly MyDBContext _db;

        public CarRepository()
        {
            _db = new MyDBContext();
        }

        public void Delete(Car car)
        {
            _db.Cars.Remove(car);
            _db.SaveChanges();
        }

        public IEnumerable<Car> GetAll()
        {
            var allCars =  _db.Cars.ToList();
            return allCars;
        }

        public void Insert(Car car)
        {
            _db.Cars.Add(car);
            _db.SaveChanges();
        }

        public void Update(Car car)
        {
            _db.Entry(car).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
