using ALvl_ExamProject.BL;
using ALvl_ExamProject.BL.Interfaces;
using ALvl_ExamProject.BL.Services;
using AutoMapper;
using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace ALvl_ExamProject.MVC.App_Start
{
    public class LightInjectConfig
    {
        public static void Configurate()
        {
            var container = new ServiceContainer();

            container.RegisterControllers(Assembly.GetExecutingAssembly());

            container.EnablePerWebRequestScope();

            var config = new MapperConfiguration(cfg => cfg.AddProfiles
            (
                new List<Profile>() { new WebAutomapperProfile(), new BLLAutomapperProfile() }
            ));

            container.Register(c => config.CreateMapper());

            container = LightInjectConfigBLL.Configuration(container);

            container.Register<IProductService, ProductService>();
            container.Register<ICategoryService, CategoryService>();
            container.Register<IPageService, PageService>();
            container.Register<ISidebarService, SidebarService>();

            container.EnableMvc();
        }
    }
}