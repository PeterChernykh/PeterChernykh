using ALevel_InternetShop.BLL;
using ALevel_InternetShop.BLL.Interfaces;
using ALevel_InternetShop.BLL.Services;
using AutoMapper;
using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ALevel_Module_InternethShop.App_Start
{
    public class LightInjectConfig
    {
        public static void Configurate()
        {
            var container = new ServiceContainer();

            container.RegisterApiControllers();

            container.EnablePerWebRequestScope();

            var config = new MapperConfiguration(cfg => cfg.AddProfiles(
                 new List<Profile>() { new WebApiAutomapperProfile(), new BLLAutomapperProfile() }));

            container.Register(c => config.CreateMapper());

            container = BLLLightInjectConfig.Configuration(container);

            container.Register<IProductService, ProductService>();
            container.Register<ICategoryService, CategoryService>();

            container.EnableWebApi(GlobalConfiguration.Configuration);
        }
    }
}