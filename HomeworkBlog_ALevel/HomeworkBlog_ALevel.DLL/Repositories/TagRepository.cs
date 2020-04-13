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
    public class TagRepository: GenericRepository<Tag>, IBlogRepository<Tag>
    {

        public TagRepository(MyDBContext ctx) : base(ctx)
        {
        }
    }
}
