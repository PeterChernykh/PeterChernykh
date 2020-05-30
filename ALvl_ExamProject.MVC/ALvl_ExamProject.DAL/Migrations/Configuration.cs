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
                    Body = "Get Speedo Unisex-Adult Swim Cap Silicone for only $9.99"
                });
                context.Sidebars.Add(new Sidebar()
                {
                    Body = "Get Air Jordan 1 Mid SE for only $11.30"
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
                    Title = "Sport Shop",
                    Body = "Sportshop.com is the online specialist for everybody who loves to sport, wants to feel fit or enjoys" +
                    " working out. Our large collection, specialist products and our excellent service are just a few things that are of huge importance for us." +
                    "he employees of Sportshop.com work out every day just for you. They are ready to answer all your difficult questions and they are happy to give you advice. " +
                    "When your order arrives we run as fast as we can to collect the items and ship them to you. Some of our colleagues are continuously looking to find the best products just for you!"+
                    "We have almost 20 years of experience and our team exists out of more than 60 people with experience in all types of sports. "+
                    "With our sport specific online shops, we offer products for both beginners and advanced players in every age category. Do you want to experience our products," +
                    " service, advice and specialism, we can only say..... Ready, Set, GOOOO!",
                    Slug = "home",
                    Sorting = 100,
                    Sidebar = true
                }
                );

                context.Pages.Add(new Page()
                {
                    Title = "Delivery",
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
