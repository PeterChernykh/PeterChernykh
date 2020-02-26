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

        public void Delete(int id)
        {
            var cars = _db.Cars;
            var car = cars.Where(x => x.Id == id).FirstOrDefault();

            _db.Cars.Remove(car);
            _db.SaveChanges();
        }

        public IEnumerable<Car> GetAll()
        {
            return _db.Cars.AsNoTracking().ToList();
        }

        public void Insert(Car car)
        {
            _db.Cars.Add(car);
            _db.SaveChanges();
        }

        public void Update(Car car)
        {
            //var cars = _db.Cars;
            //var car = cars.Where(x => x.Id == id).FirstOrDefault();

            //_db.Entry(car);
            //_db.SaveChanges();
        }
    }
}
