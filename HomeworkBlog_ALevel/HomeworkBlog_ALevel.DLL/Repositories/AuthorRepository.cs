using HomeworkBlog_ALevel.DAL.Interfaces;
using HomeworkBlog_ALevel.DAL.Models;
using HomeworkBlog_ALevel.DAL.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HomeworkBlog_ALevel.DAL.Repositories
{
    public class AuthorRepository : GenericRepository<Author>, IBlogRepository<Author>
    {

        public AuthorRepository(MyDBContext ctx) : base(ctx)
        {
        }
    }
}
