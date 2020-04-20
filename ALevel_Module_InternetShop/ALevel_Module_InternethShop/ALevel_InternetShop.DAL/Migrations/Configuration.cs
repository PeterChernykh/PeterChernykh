namespace ALevel_InternetShop.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ALevel_InternetShop.DAL.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MyDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        public class MyContextInitializer : DropCreateDatabaseAlways<MyDBContext>
        {
            protected override void Seed(MyDBContext context)
            {
                context.Categories.Add(new Category() { Name = "Category1", Number = 621345 });
                context.Categories.Add(new Category() { Name = "Category2", Number = 345679 });
                context.Categories.Add(new Category() { Name = "Category3", Number = 111232});
                context.Categories.Add(new Category() { Name = "Category4", Number = 332122 });
                context.Categories.Add(new Category() { Name = "Category5", Number = 234322 });

                context.SaveChanges();

                context.Products.Add(new Product() {
                    Name = "Product1",
                    Number = 345243,
                    Price = 22.30,
                    CategoryId = context.Categories.Single(x => x.Name == "Category1").Id
                });
                context.Products.Add(new Product()
                {
                    Name = "Product2",
                    Number = 453234,
                    Price = 11.30,
                    CategoryId = context.Categories.Single(x => x.Name == "Category2").Id
                });
                context.Products.Add(new Product()
                {
                    Name = "Product3",
                    Number = 111223,
                    Price = 110.30,
                    CategoryId = context.Categories.Single(x => x.Name == "Category3").Id
                });
                context.Products.Add(new Product()
                {
                    Name = "Product4",
                    Number = 334212,
                    Price = 19.90,
                    CategoryId = context.Categories.Single(x => x.Name == "Category3").Id
                });
                context.Products.Add(new Product()
                {
                    Name = "Product5",
                    Number = 3424,
                    Price = 139.90,
                    CategoryId = context.Categories.Single(x => x.Name == "Category4").Id
                });
                context.Products.Add(new Product()
                {
                    Name = "Product6",
                    Number = 443231,
                    Price = 2.90,
                    CategoryId = context.Categories.Single(x => x.Name == "Category5").Id
                });
                context.Products.Add(new Product()
                {
                    Name = "Product7",
                    Number = 320000,
                    Price = 9.99,
                    CategoryId = context.Categories.Single(x => x.Name == "Category5").Id
                });
            }
        }
    }
}
