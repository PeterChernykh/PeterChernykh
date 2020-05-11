using ALvl_ExamProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ALvl_ExamProject.DAL.Migrations.Configuration;

namespace ALvl_ExamProject.DAL
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base(@"Data Source=.\SQLEXPRESS;Initial Catalog=Shop_ALvl_Exam;Integrated Security=True")
        {
            Database.SetInitializer<MyDBContext>(new MyContextInitializer());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Sidebar> Sidebars { get; set; }

    }
}
