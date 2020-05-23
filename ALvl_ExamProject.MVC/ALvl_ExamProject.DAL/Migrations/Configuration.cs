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
                    Slug = "Basketball is a team sport in which two teams, most commonly of five players each, opposing" +
                    " one another on a rectangular court, compete with the primary objective of shooting a basketball " +
                    "(approximately 9.4 inches (24 cm) in diameter) through the defender's hoop (a basket 18 inches (46 cm) in" +
                    " diameter mounted 10 feet (3.048 m) high to a backboard at each end of the court) while preventing the opposing " +
                    "team from shooting through their own hoop.",
 
                });
                context.Categories.Add(new Category() { 
                    Name = "Powerlifting",
                    Slug = "Powerlifting is a strength sport that consists of three attempts at maximal weight" +
                    " on three lifts: squat, bench press, and deadlift. As in the sport of Olympic weightlifting," +
                    " it involves the athlete attempting a maximal weight single lift of a barbell loaded with weight plates."
                });
                context.Categories.Add(new Category() { 
                    Name = "Football",
                    Slug = "Football is a family of team sports that involve, to varying degrees, kicking a ball" +
                    " to score a goal. Unqualified, the word football normally means the form of football that is the" +
                    " most popular where the word is used."
                });
                context.Categories.Add(new Category() {
                    Name = "Boxing",
                    Slug = "Boxing is a combat sport in which two people, usually wearing protective gloves," +
                    " throw punches at each other for a predetermined amount of time in a boxing ring."
                });
                context.Categories.Add(new Category() { 
                    Name = "Swimming",
                    Slug = "Swimming is an individual or team racing sport that requires the use of one's entire body to move" +
                    " through water. The sport takes place in pools or open water (e.g., in a sea or lake). Competitive swimming" +
                    " is one of the most popular Olympic sports"
                });

                context.SaveChanges();

                context.Products.Add(new Product()
                {
                    Name = "Air Jordan 2 Retro",
                    Price = 22.30,        
                    CategoryId = context.Categories.Single(x => x.Name == "Basketball").Id,
                    Slug = "Featuring bold color-blocking inspired by MJ's most formidable rivals, the" +
                    " Air Jordan 2 Retro for women re-energizes the '86 original. Its luxurious upper uses a clashing" +
                    " mix of textiles and leathers for a unique look and feel."

                });
                context.Products.Add(new Product()
                {
                    Name = "Air Jordan 1 Mid SE",
                    Price = 11.30,
                    CategoryId = context.Categories.Single(x => x.Name == "Basketball").Id,
                    Slug = "The Air Jordan 1 Mid SE maintains the timeless appeal of the OG AJ1, revamped with fresh colors and" +
                    " premium materials. Built with a lightweight Air-Sole unit and classic design lines, it captures the essence" +
                    " of the original through a modern lens."
                });
                context.Products.Add(new Product()
                {
                    Name = "Standard Metal Plates",
                    Price = 110.30,
                    CategoryId = context.Categories.Single(x => x.Name == "Powerlifting").Id,
                    Slug = "Looking for quality and affordability? Experience high quality Olympic 2 plates" +
                    " with rims and radius edges precision - milled for a perfect circular shape and truer dimensions. "
                });
                context.Products.Add(new Product()
                {
                    Name = "Nike Phantom Vision Academy Dynamic Fit MG",
                    Price = 19.90,
                    CategoryId = context.Categories.Single(x => x.Name == "Football").Id,
                    Slug = "Show your creative vision on the pitch and lead your team to victory with the Nike Phantom Vision Academy" +
                    " DF FG/MG football boots. Lightweight, durable, and with an outstanding performance, these boots are ideal for amateur" +
                    " and semi-professional players looking for a model that unlocks their full potential."
                });
                context.Products.Add(new Product()
                {
                    Name = "Adidas Predator Malice Control FG",
                    Price = 139.90,
                    CategoryId = context.Categories.Single(x => x.Name == "Football").Id,
                    Slug = "Engineered for players who see the bigger picture. These rugby boots offer a stable platform" +
                    " for kickers to boss the game. The foot-hugging knit textile upper keeps you cool, comfortable and locked" +
                    " in. A soft leather vamp, rubber pads on the forefoot and asymmetrical lacing all combine for pinpoint accuracy" +
                    " with the ball. The lightweight outsole delivers maximum traction on firm ground."
                });
                context.Products.Add(new Product()
                {
                    Name = "Everlast Elite Pro Style Training Gloves",
                    Price = 2.90,
                    CategoryId = context.Categories.Single(x => x.Name == "Boxing").Id,
                    Slug = "Premium synthetic leather along with superior construction increases durability. " +
                    "Evercool full mesh palm ensures breathability and comfort. " +
                    "Ideal for sparring, heavy bag workouts, and mitt work"
                });
                context.Products.Add(new Product()
                {
                    Name = "Speedo Unisex-Adult Swim Cap Silicone",
                    Price = 9.99,
                    CategoryId = context.Categories.Single(x => x.Name == "Swimming").Id,
                    Slug = "Man made materials. Imported. Amazing stretch for comfort. Resistant to snagging and tearing, Extra durable. " +
                    "Quick and easy to take off without snagging hair"
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
