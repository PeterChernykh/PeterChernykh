using HomeworkBlog_ALevel.DAL.Repositories;
using HomeworkBlog_ALevel.DAL.Interfaces;
using LightInject;
using HomeworkBlog_ALevel.DAL;
using HomeworkBlog_ALevel.DAL.Models;

namespace HomeworkBlog_ALevel.BLL
{
    public static class LightInjectConfigBLL
    {
        public static ServiceContainer Configuration(ServiceContainer container)
        {
            container.Register<MyDBContext> (factory => new MyDBContext());
            container.Register<IBlogRepository<Author>, AuthorRepository>();

            return container;
        }
    }
}
