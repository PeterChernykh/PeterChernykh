using ALevel_InternetShop.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_InternetShop.DAL
{
    public class MyDBContext: DbContext
    {
        public MyDBContext() : base(@"Data Source=.\SQLEXPRESS;Initial Catalog=ALevel_Shop;Integrated Security=True")
        {
            //Database.SetInitializer<MyDBContext>(new MyContextInitializer());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
