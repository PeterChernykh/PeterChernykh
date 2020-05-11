using ALvl_ExamProject.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALvl_ExamProject.DAL.Repositories
{
    public class ShopRepository<T> : IShopRepository<T> where T : class
    {
        private readonly MyDBContext _ctx;
        DbSet<T> _dbSet;

        public ShopRepository(MyDBContext ctx)
        {
            _ctx = ctx;
            _dbSet = _ctx.Set<T>();
        }

        public void Add(T model)
        {
            _dbSet.Add(model);
            _ctx.SaveChanges();
        }

        public void Remove(int id)
        {
            var model = _dbSet.Find(id);
            _dbSet.Remove(model);
            _ctx.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.AsNoTracking();
        }

        public void Update(T model)
        {
            _ctx.Entry(model).State = EntityState.Modified;
            _ctx.SaveChanges();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }
    }
}
