using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Homework12_DAL.Models;

namespace Homework12_DAL
{
    public class MyDBContext : DbContext
    {
        public  MyDBContext() : base(@"Data Source=.\SQLEXPRESS;Initial Catalog=EFHomeworkDatabase;Integrated Security=True")
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Detail> Details { get; set; }
    }
}
