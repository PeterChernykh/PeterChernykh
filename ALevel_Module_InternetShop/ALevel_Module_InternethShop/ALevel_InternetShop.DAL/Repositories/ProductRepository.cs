using ALevel_InternetShop.DAL.Interfaces;
using ALevel_InternetShop.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_InternetShop.DAL.Repositories
{
    public class ProductRepository: ShopRepository<Product>, IShopRepository<Product>
    {
        public ProductRepository(MyDBContext ctx) : base(ctx)
        {
        }
    }
}
