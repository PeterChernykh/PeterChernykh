using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Reflection;
using HomeworkBlog_ALevel.BLL.Interfaces;
using HomeworkBlog_ALevel.BLL.Services;
using AutoMapper;
using HomeworkBlog_ALevel.BLL;
using LightInject.Mvc;

namespace HomeworkBlog.App_Start
{
    public static class LihtInjectConfig
    {
        public static void Configurate()
        {
            var container = new ServiceContainer();

            container.RegisterControllers(Assembly.GetExecutingAssembly());

            container.EnablePerWebRequestScope();

            var config = new MapperConfiguration(cfg => cfg.AddProfiles(
                 new List<Profile>() { new WebAutomapperProfile(), new BLAutomapperProfile() }));

            container.Register(c => config.CreateMapper());

            container = LightInjectConfigBLL.Configuration(container);

            container.Register<IPostService, PostService>();
            container.Register<IAuthorService, AuthorService>();
            container.Register<ICategoryService, CategoryService>();
            container.Register<ITagService, TagService>();

            //DependencyResolver.SetResolver(new LightInjectMvcDependencyResolver(container));

            container.EnableMvc();
        }
    }
}