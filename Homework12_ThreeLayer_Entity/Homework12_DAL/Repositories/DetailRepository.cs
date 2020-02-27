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

<<<<<<< HEAD
            updatedDetail.Name = detail.Name;
=======
            updatedDetail.DetailName = detail.DetailName;
>>>>>>> b314a4ae73474be64f46208452be66b64950d2d2
            updatedDetail.Cost = detail.Cost;

            _db.Entry(updatedDetail);
            _db.SaveChanges();
        }

        public Detail GetById(int id)
        {
            var detail = _db.Details.Where(x => x.Id == id).FirstOrDefault();

            return detail;
        }
    }
}