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
    public class TagRepository: IBlogRepository<Tag>
    {
        private readonly MyDBContext _ctx;

        public TagRepository(MyDBContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(Tag tag)
        {
            _ctx.Tags.Add(tag);
            _ctx.SaveChanges();
        }

        public IEnumerable<Tag> GetAll()
        {
            return _ctx.Tags.AsNoTracking();
        }

        public Tag GetById(int id)
        {
            return GetAll().FirstOrDefault(x => x.Id == id);
        }

        public void Remove(int id)
        {
            var tag = _ctx.Tags.FirstOrDefault(x => x.Id == id);
            _ctx.Tags.Remove(tag);
            _ctx.SaveChanges();
        }

        public int TotalModels()
        {
            return GetAll().Count();
        }

        public void Update(Tag tag)
        {
            _ctx.Entry(tag).State = EntityState.Modified;
            _ctx.SaveChanges();
        }
    }
}
