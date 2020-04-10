using HomeworkBlog_ALevel.DAL.Interfaces;
using HomeworkBlog_ALevel.DAL.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HomeworkBlog_ALevel.DAL.Repositories
{
    public class AuthorRepository : IBlogRepository<Author>
    {
        private readonly MyDBContext _ctx;

        public AuthorRepository(MyDBContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(Author author)
        {
            _ctx.Authors.Add(author);
            _ctx.SaveChanges();
        }

        public IEnumerable<Author> GetAll()
        {
            return _ctx.Authors.AsNoTracking();
        }

        public Author GetById(int id)
        {
            var author = GetAll().FirstOrDefault(x => x.Id == id);
            return author;
        }

        public void Remove(int id)
        {
            var category = _ctx.Authors.FirstOrDefault(x => x.Id == id);
            _ctx.Authors.Remove(category);

            //_ctx.Entry(author).State = EntityState.Deleted;
            _ctx.SaveChanges();
        }

        public int TotalModels()
        {
            var allAuthors = GetAll().Count();

            return allAuthors;
        }

        public void Update(Author updatedAuthor)
        {
            _ctx.Entry(updatedAuthor).State = EntityState.Modified;
            _ctx.SaveChanges();
        }
    }
}
