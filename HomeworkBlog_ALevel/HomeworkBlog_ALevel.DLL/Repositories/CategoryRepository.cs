using HomeworkBlog_ALevel.DAL;
using HomeworkBlog_ALevel.DAL.Interfaces;
using HomeworkBlog_ALevel.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkBlog_ALevel.DAL.Repositories
{
    public class CategoryRepository: IBlogRepository<Category>
    {
        private readonly MyDBContext _ctx;

        public CategoryRepository (MyDBContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(Category category)
        {
            _ctx.Categories.Add(category);
            _ctx.SaveChanges();
        }

        public IEnumerable<Category> GetAll()
        {
            return _ctx.Categories.AsNoTracking();
        }

        public Category GetById(int id)
        {
            var category = GetAll().FirstOrDefault(x => x.Id == id);
            return category;
        }

        public void Remove(int id)
        {
            var author = _ctx.Categories.FirstOrDefault(x => x.Id == id);
            _ctx.Categories.Remove(author);
        }

        public int TotalModels()
        {
            var allCategories = GetAll().Count();

            return allCategories;
        }

        public void Update(Category category)
        {
            _ctx.Entry(category).State = EntityState.Modified;
            _ctx.SaveChanges();
        }
    }
}
