using AutoMapper;
using HomeworkBlog_ALevel.BLL;
using HomeworkBlog_ALevel.BLL.Interfaces;
using HomeworkBlog_ALevel.BLL.Services;
using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace HomeworkBlog_WebAPI.App_Start
{
    public class LightInjectConfig
    {
        public static void Configurate()
        {
            var container = new ServiceContainer();

            container.RegisterApiControllers();

            container.EnablePerWebRequestScope();

            var config = new MapperConfiguration(cfg => cfg.AddProfiles(
                 new List<Profile>() { new WebApiAutomapperProfile(), new BLAutomapperProfile() }));

            container.Register(c => config.CreateMapper());

            container = LightInjectConfigBLL.Configuration(container);

            container.Register<IPostService, PostService>();
            container.Register<IAuthorService, AuthorService>();
            container.Register<ICategoryService, CategoryService>();
            container.Register<ITagService, TagService>();

            container.EnableWebApi(GlobalConfiguration.Configuration);
        }
    }
}