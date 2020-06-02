using ALvl_ExamProject.DAL;
using ALvl_ExamProject.DAL.Interfaces;
using ALvl_ExamProject.DAL.Models;
using ALvl_ExamProject.DAL.Repositories;
using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALvl_ExamProject.BL
{
    public class LightInjectConfigBLL
    {
        public static ServiceContainer Configuration(ServiceContainer container)
        {
            container.Register<MyDBContext>(factory => new MyDBContext());

            container.Register<IShopRepository<Product>, ShopRepository<Product>>();
            container.Register<IShopRepository<Category>, ShopRepository<Category>>();
            container.Register<IShopRepository<Page>, ShopRepository<Page>>();
            container.Register<IShopRepository<Sidebar>, ShopRepository<Sidebar>>();
            container.Register<IShopRepository<OrderDetail>, ShopRepository<OrderDetail>>();
            container.Register<IShopRepository<Order>, ShopRepository<Order>>();


            return container;
        }
    }
}
