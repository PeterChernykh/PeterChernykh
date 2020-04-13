using HomeworkBlog_ALevel.DAL.Interfaces;
using HomeworkBlog_ALevel.DAL.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HomeworkBlog_ALevel.DAL.Repositories
{
    public class PostRepository : GenericRepository<Post>, IBlogRepository<Post>
    {

        public PostRepository(MyDBContext ctx) : base(ctx)
        {
        }
    }
}
