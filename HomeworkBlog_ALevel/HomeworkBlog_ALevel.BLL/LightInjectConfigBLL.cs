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

            container.Register<IBlogRepository<Post>, PostRepository>();
            container.Register<IBlogRepository<Tag>, TagRepository>();
            container.Register<IBlogRepository<Author>, AuthorRepository>();
            container.Register<IBlogRepository<Category>, CategoryRepository>();



            //container.Register(typeof(IBlogRepository<>), typeof(GenericRepository<>));

            return container;
        }
    }
}
