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
            var details = _db.Details;
            var detail = details.Where(x => x.Id == id).FirstOrDefault();
            _db.Details.Remove(detail);
            _db.SaveChanges();
        }

        public IEnumerable <Detail> GetAll()
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
            var newDetail = GetById(detail.Id);

            newDetail.DetailName = detail.DetailName;
            newDetail.Cost = detail.Cost;

            _db.Entry(newDetail);
            _db.SaveChanges();
        }

        public Detail GetById(int id)
        {
            var dets = _db.Details.ToList();
            var detail = _db.Details.Where(x => x.Id == id).AsNoTracking().FirstOrDefault();

            return detail;
        }
    }
}
