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
          Database.SetInitializer<MyDBContext>(new MigrateDatabaseToLatestVersion<MyDBContext, Homework12_DAL.Migrations.Configuration>());
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Detail> Details { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>()
                .ToTable("Cars")
                .HasKey(x => x.Id)
                .Property(x => x.Model)
                .HasMaxLength(20);

            modelBuilder.Entity<Car>()
                .HasMany(x => x.Details)
                .WithRequired(x => x.Car)
                .HasForeignKey(x => x.CarId);

            modelBuilder.Entity<Detail>()
                .ToTable("Details")
                .HasKey(x => x.Id)
                .Property(x => x.Name)
                .HasMaxLength(20);
        }
    }
}
