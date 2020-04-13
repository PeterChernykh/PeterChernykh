using HomeworkBlog_ALevel.DAL;
using HomeworkBlog_ALevel.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkBlog_ALevel.DAL.Repositories
{
    public abstract class GenericRepository<T>: IBlogRepository<T> where T: class
    {
        private readonly MyDBContext _ctx;
        DbSet<T> _dbSet;

        public GenericRepository (MyDBContext ctx)
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

        public int TotalModels()
        {
            return GetAll().Count();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

    }
}
