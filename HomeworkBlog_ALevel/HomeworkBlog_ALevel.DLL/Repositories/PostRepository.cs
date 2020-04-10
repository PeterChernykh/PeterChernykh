using HomeworkBlog_ALevel.DAL.Interfaces;
using HomeworkBlog_ALevel.DAL.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HomeworkBlog_ALevel.DAL.Repositories
{
    public class PostRepository : IBlogRepository<Post>
    {
        private readonly MyDBContext _ctx;

        public PostRepository(MyDBContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(Post post)
        {
            _ctx.Posts.Add(post);
            _ctx.SaveChanges();
        }

        public void Remove(int id)
        {
            var post = _ctx.Posts.FirstOrDefault(x => x.Id == id);
            _ctx.Posts. Remove(post);
            _ctx.SaveChanges();
        }

        public IEnumerable<Post> GetAll()
        {
            return _ctx.Posts.AsNoTracking();
        }

        public void Update(Post post)
        {
            _ctx.Entry(post).State = EntityState.Modified;
            _ctx.SaveChanges();
        }

        public int TotalModels()
        {
           return GetAll().Count();
        }

        public Post GetById(int id)
        {
            return GetAll().FirstOrDefault(x => x.Id == id);
        }
    }
}
