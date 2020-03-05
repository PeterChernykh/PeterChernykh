using Homework12_DAL.Interfaces;
using Homework12_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12_DAL.Repositories
{
    public class ManufacturerRepository : IManufacturer
    {
        private readonly MyDBContext _db;

        public ManufacturerRepository()
        {
            _db = new MyDBContext();
        }

        public IEnumerable<Manufacturer> GetAll()
        {
            return _db.Manufacturers.AsNoTracking().ToList();
        }

        public Manufacturer GetById(int id)
        {
            var manufacturer = _db.Manufacturers.FirstOrDefault(x => x.Id == id);
            return manufacturer;
        }
        public Manufacturer DeniedManufacturer()
        {
            var manufacturers = GetAll();

            var deniedManufacturer = manufacturers.FirstOrDefault(x => x.Id == 1);

            return deniedManufacturer;
        }
        public void Insert(Manufacturer manufacturer)
        {
            _db.Manufacturers.Add(manufacturer);
            _db.SaveChanges();
        }
    }
}
