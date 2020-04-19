using ALevel_Shop.BLL.ApiResponse;
using ALevel_Shop.BLL.ApiResponse.ApiResponseInterface;
using ALevel_Shop.BLL.ApiResponse.ApiResponseRepository;
using ALevel_Shop.BLL.Interfaces;
using ALevel_Shop.BLL.Models;
using ALevel_Shop.BLL.Services;
using AutoMapper;
using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

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