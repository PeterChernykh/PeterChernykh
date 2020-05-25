namespace ALvl_ExamProject.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ALvl_ExamProject.DAL.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MyDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "ALvl_ExamProject.DAL.MyDBContext";
        }

        public class MyContextInitializer : DropCreateDatabaseAlways<MyDBContext>
        {
            protected override void Seed(MyDBContext context)
            {
                context.Sidebars.Add(new Sidebar()
                {
                    Body = "Sidebar1"
                });        
                context.Categories.Add(new Category() { 
                    Name = "Basketball",
                    Slug = "basketball",
 
                });
                context.Categories.Add(new Category() { 
                    Name = "Powerlifting",
                    Slug = "powerlifting"
                });
                context.Categories.Add(new Category() { 
                    Name = "Football",
                    Slug = "football"
                });
                context.Categories.Add(new Category() {
                    Name = "Boxing",
                    Slug = "boxing"
                });
                context.Categories.Add(new Category() { 
                    Name = "Swimming",
                    Slug = "swimming"
                });

                context.SaveChanges();

                context.Products.Add(new Product()
                {
                    Name = "Air Jordan 2 Retro",
                    Price = 22.30,        
                    CategoryId = context.Categories.Single(x => x.Name == "Basketball").Id,
                    Slug = "AirJordan2R",
                    Description = "The Air Jordan 1 Mid SE maintains the timeless appeal of the OG AJ1, revamped with fresh colors and" +
                    " premium materials. Built with a lightweight Air-Sole unit and classic design lines, it captures the essence" +
                    " of the original through a modern lens.",
                    ImagePath = "AirJordan2Retro.jpg"

                });
                context.Products.Add(new Product()
                {
                    Name = "Air Jordan 1 Mid SE",
                    Price = 11.30,
                    CategoryId = context.Categories.Single(x => x.Name == "Basketball").Id,
                    Slug = "AirJordan1MidSE",
                    Description = "The Air Jordan 1 Mid SE maintains the timeless appeal of the OG AJ1, revamped with fresh colors and" +
                    " premium materials. Built with a lightweight Air-Sole unit and classic design lines, it captures the essence" +
                    " of the original through a modern lens.",
                    ImagePath = "AirJordan1MidSE.jpg"
                });
                context.Products.Add(new Product()
                {
                    Name = "Standard Metal Plates",
                    Price = 110.30,
                    CategoryId = context.Categories.Single(x => x.Name == "Powerlifting").Id,
                    Slug = "StandardMP",
                    Description = "Looking for quality and affordability? Experience high quality Olympic 2 plates" +
                    " with rims and radius edges precision - milled for a perfect circular shape and truer dimensions. ",
                    ImagePath = "StandardMetalPlates.jpg"

                });
                context.Products.Add(new Product()
                {
                    Name = "Nike Phantom Vision Academy Dynamic Fit MG",
                    Price = 19.90,
                    CategoryId = context.Categories.Single(x => x.Name == "Football").Id,
                    Slug = "NikePVADFMG",
                    Description = "Show your creative vision on the pitch and lead your team to victory with the Nike Phantom Vision Academy" +
                    " DF FG/MG football boots. Lightweight, durable, and with an outstanding performance, these boots are ideal for amateur" +
                    " and semi-professional players looking for a model that unlocks their full potential.",
                    ImagePath = "NikePhantomVisionAcademyDynamicFitMG.jpg"
                });
                context.Products.Add(new Product()
                {
                    Name = "Adidas Predator Malice Control FG",
                    Price = 139.90,
                    CategoryId = context.Categories.Single(x => x.Name == "Football").Id,
                    Slug = "AdidasPMCFG",
                    Description = "Engineered for players who see the bigger picture. These rugby boots offer a stable platform" +
                    " for kickers to boss the game. The foot-hugging knit textile upper keeps you cool, comfortable and locked" +
                    " in. A soft leather vamp, rubber pads on the forefoot and asymmetrical lacing all combine for pinpoint accuracy" +
                    " with the ball. The lightweight outsole delivers maximum traction on firm ground.",
                    ImagePath = "AdidasPredatorMaliceControlFG.jpg"
                });
                context.Products.Add(new Product()
                {
                    Name = "Everlast Elite Pro Style Training Gloves",
                    Price = 2.90,
                    CategoryId = context.Categories.Single(x => x.Name == "Boxing").Id,
                    Slug = "EverlastEPSTG",
                    Description= "Premium synthetic leather along with superior construction increases durability. " +
                    "Evercool full mesh palm ensures breathability and comfort. " +
                    "Ideal for sparring, heavy bag workouts, and mitt work",
                    ImagePath= "EverlastEliteProStyleTrainingGloves.jpg"
                });
                context.Products.Add(new Product()
                {
                    Name = "Speedo Unisex-Adult Swim Cap Silicone",
                    Price = 9.99,
                    CategoryId = context.Categories.Single(x => x.Name == "Swimming").Id,
                    Slug = "SpeedoUASCS",
                    Description = "Man made materials. Imported. Amazing stretch for comfort. Resistant to snagging and tearing, Extra durable. " +
                    "Quick and easy to take off without snagging hair",
                    ImagePath = "SpeedoUnisex-AdultSwimCapSilicone.jpg"
                });

                context.SaveChanges();

                context.Pages.Add(new Page()
                {
                    Title = "TestPage1",
                    Body = "TestPage1TestPage1TestPage1TestPage1TestPage1TestPage1TestPage1TestPage1" +
                    "TestPage1TestPage1TestPage1TestPage1TestPage1TestPage1TestPage1TestPage1TestPage1" +
                    "TestPage1TestPage1TestPage1TestPage1TestPage1TestPage1TestPage1TestPage1TestPage1",
                    Slug = "home",
                    Sorting = 100,
                    Sidebar = true
                }
                );

                context.Pages.Add(new Page()
                {
                    Title = "TestPage2",
                    Body = "TestPage2TestPage2TestPage2TestPage2TestPage2TestPage2TestPage2TestPage2" +
                    "TestPage2TestPage2TestPage2TestPage2TestPage2TestPage2TestPage2TestPage2TestPage2" +
                    "TestPage2TestPage2TestPage2TestPage2TestPage2TestPage2TestPage2TestPage2TestPage2TestPage2",
                    Slug = "TestPage2",
                    Sorting = 100,
                    Sidebar = false
                }
               );
            }
        }
    }
}
