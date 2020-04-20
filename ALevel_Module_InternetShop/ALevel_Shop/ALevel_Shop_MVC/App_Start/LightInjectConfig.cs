using ALevel_Shop.BLL.ApiResponse;
using ALevel_Shop.BLL.ApiResponse.ApiResponseInterface;
using ALevel_Shop.BLL.ApiResponse.ApiResponseService;
using ALevel_Shop.BLL.Interfaces;
using ALevel_Shop.BLL.Services;
using ALevel_Shop.BLL.Services.ApiResponseService;
using AutoMapper;
using LightInject;
using System.Collections.Generic;
using System.Reflection;

namespace ALevel_Shop_MVC.App_Start
{
    public class LightInjectConfig
    {
        public static void Configurate()
        {
            var container = new ServiceContainer();

            container.RegisterControllers(Assembly.GetExecutingAssembly());

            container.EnablePerWebRequestScope();

            var config = new MapperConfiguration(cfg => cfg.AddProfiles(
                 new List<Profile>() { new WebApiAutomapperProfile()}));

            container.Register(c => config.CreateMapper());

            container.Register<IProductService, ProductService>();
            container.Register<ICategoryService, CategoryService>();
            container.Register<IProductApiService, ProductApiService>();
            container.Register<ICategoryApiService, CategoryApiService>();


            container.EnableMvc();
        }
    }
}