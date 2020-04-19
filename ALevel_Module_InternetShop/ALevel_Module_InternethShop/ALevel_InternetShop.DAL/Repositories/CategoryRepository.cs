using ALevel_InternetShop.DAL.Interfaces;
using ALevel_InternetShop.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_InternetShop.DAL.Repositories
{
    public class CategoryRepository : ShopRepository<Category>, IShopRepository<Category>
    {
        public CategoryRepository(MyDBContext ctx) : base(ctx)
        {
        }
    }
}
