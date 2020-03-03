using Homework12_DAL.Interfaces;
using Homework12_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12_DAL.Repositories
{
    public class ManufacturerRepository : IRepository<Manufacturer>
    {
        private readonly MyDBContext _db;

        public ManufacturerRepository()
        {
            _db = new MyDBContext();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Manufacturer> GetAll()
        {
            return _db.Manufacturers.ToList();
        }

        public Manufacturer GetById(int id)
        {
            var manufacturer = _db.Manufacturers.Where(x => x.Id == id).FirstOrDefault();
            return manufacturer;
        }

        public void Insert(Manufacturer item)
        {
            throw new NotImplementedException();
        }

        public void Update(Manufacturer item)
        {
            throw new NotImplementedException();
        }
    }
}
