using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALevel_InternetShop.DAL;
using ALevel_InternetShop.DAL.Interfaces;
using ALevel_InternetShop.DAL.Models;
using ALevel_InternetShop.DAL.Repositories;
using LightInject;

namespace ALevel_InternetShop.BLL
{
    public static class BLLLightInjectConfig
    {
        public static ServiceContainer Configuration(ServiceContainer container)
        {
            container.Register<MyDBContext>(factory => new MyDBContext());

            container.Register<IShopRepository<Product>, ProductRepository>();
            container.Register<IShopRepository<Category>, CategoryRepository>();

            return container;
        }
    }
}
