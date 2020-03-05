using Homework12_DAL.Interfaces;
using Homework12_DAL.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Homework12_DAL.Repositories
{
    public class DetailRepository : IRepository<Detail>
    {
        private readonly MyDBContext _db;

        public DetailRepository()
        {
            _db = new MyDBContext();
        }

        public void Delete(int id)
        {
            var detail = GetById(id);
            _db.Details.Remove(detail);
            _db.SaveChanges();
        }

        public IEnumerable<Detail> GetAll()
        {
            return _db.Details.AsNoTracking().ToList();
        }

        public void Insert(Detail detail)
        {
            _db.Details.Add(detail);
            _db.SaveChanges();
        }

        public void Update(Detail detail)
        {
            var updatedDetail = GetById(detail.Id);

            updatedDetail.Name = detail.Name;
            updatedDetail.Cost = detail.Cost;

            _db.SaveChanges();
        }

        public Detail GetById(int id)
        {
            var detail = _db.Details.FirstOrDefault(x => x.Id == id);

            return detail;
        }
    }
}