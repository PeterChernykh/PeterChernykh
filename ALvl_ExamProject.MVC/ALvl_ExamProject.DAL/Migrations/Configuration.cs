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
                    Price = 22.30m,        
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
                    Price = 11.30m,
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
                    Price = 110.30m,
                    CategoryId = context.Categories.Single(x => x.Name == "Powerlifting").Id,
                    Slug = "StandardMP",
                    Description = "Looking for quality and affordability? Experience high quality Olympic 2 plates" +
                    " with rims and radius edges precision - milled for a perfect circular shape and truer dimensions. ",
                    ImagePath = "StandardMetalPlates.jpg"

                });
                context.Products.Add(new Product()
                {
                    Name = "Nike Phantom Vision Academy Dynamic Fit MG",
                    Price = 19.90m,
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
                    Price = 139.90m,
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
                    Name = "Adidas Predator Malice Control FG",
                    Price = 139.90m,
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
                    Name = "Adidas Predator Malice Control FG",
                    Price = 139.90m,
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
                    Price = 2.90m,
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
                    Price = 9.99m,
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
                    Sidebar = false
                }
                );

                context.Pages.Add(new Page()
                {
                    Title = "What do I need to play football?",
                    Body = "Uniform: Most youth soccer leagues require a standard uniform for all players. This might range from a simple T-shirt to a complete soccer uniform with matching jersey, shorts and socks. Some leagues issue the uniform to players, while others require you to order the uniform yourself."+
"-Practice clothes: Uniforms are typically reserved for wear in games only, so your little kicker needs comfortable athletic clothes for soccer practice. Choose clothes that allow a full range of motion.Sweat - wicking material keeps your child cool and dry during sweaty warm - weather practices."+
"-Soccer cleats: When your child plays in an organized league, you likely need soccer - specific cleats.These shoes are designed for the sport to give your soccer player the support and traction necessary in the game."+
"-Shin guards: Protective shin guards are another requirement in most leagues.They rest at the front of the shin to protect from errant kicks and fast - moving balls."+
"-Soccer socks: Just like your child needs special shoes, she also needs special socks designed for soccer.The long socks go up and over the shin guards."+
"-Ball: Your child’s coach may provide balls during practice, but it’s always a good idea to have a quality soccer ball of your own so you can practice at home.Invest in a high - quality ball instead of a cheap foam ball that doesn’t give your player a real feel for soccer play."+
"-Goalkeeper gloves: If your child is interested in playing goalkeeper, consider investing in a pair of goalkeeper gloves.These special gloves are designed to support the wrists while allowing freedom of movement in the fingers. If your child is young, the league may not play with goalies just yet, so hold off on the gloves until you know if your child will actually play the goalkeeper role."+
"-Water bottle: Soccer players spend a lot of time running up and down the field.The soccer season often falls during warm weather. Hydration is important, so outfit your child with her own water bottle.Write her name on the bottle to avoid mix - ups on the bench."+
"-Gear bag: A backpack or tote bag designed for soccer makes it easy to carry all that gear to practices and games.These specialty bags typically include a spot for a soccer ball and all the other gear your child needs.",
                    Slug = "football",
                    Sorting = 100,
                    Sidebar = true
                }
               );
            }
        }
    }
}
