namespace HomeworkBlog_ALevel.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using HomeworkBlog_ALevel.DAL.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MyDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "HomeworkBlog_ALevel.DAL.MyDBContext";
        }



        public class MyContextInitializer : DropCreateDatabaseAlways<MyDBContext>
        {
            protected override void Seed(MyDBContext context)
            {
                context.Authors.Add(new Author() { Name = "Steven Poll" });
                context.Authors.Add(new Author() { Name = "Rob Devis" });
                context.Authors.Add(new Author() { Name = "Levis Gate" });
                context.Authors.Add(new Author() { Name = "Max Rot" });
                context.Authors.Add(new Author() { Name = "Elvis Mo" });
                context.Authors.Add(new Author() { Name = "Patrik Reigan" });
                context.Authors.Add(new Author() { Name = "Nill Armstrong" });

                context.Categories.Add(new Category
                {
                    Name = "Drama"
                    ,
                    Description = "Dramas are stories composed in verse or prose, usually for theatrical performance," +
                    " where conflicts and emotions are expressed through dialogue and actions."
                });

                context.Categories.Add(new Category
                {
                    Name = "Fantasy"
                    ,
                    Description = "A Book under this genre contains a story set in a fantasy world – a world that is not real and often includes magic," +
                    " magical creatures, and supernatural events."
                });

                context.Categories.Add(new Category
                {
                    Name = "Horror"
                    ,
                    Description = "Horror is a genre that is intended to or has the ability to create the feeling of fear," +
                    " repulsion, fright or terror in the readers. In other words, it creates a frightening and horror atmosphere."
                });

                context.Categories.Add(new Category
                {
                    Name = "Legend"
                    ,
                    Description = "It’s a story, sometimes of a national or folk hero that is considered to be based on facts but also includes imaginative material." +
                    " Narratives in this genre may demonstrate human values, and possess certain qualities that give the readers a reason to believe in the tale."
                });

                context.Categories.Add(new Category
                {
                    Name = "Mythology"
                    ,
                    Description = "These books include a legend or traditional narrative, often based in part on historical events," +
                    " that reveals human behavior and natural phenomena by its symbolism and often pertaining to the actions of the gods."
                });

                context.Categories.Add(new Category
                {
                    Name = "Romance"
                   ,
                    Description = "The primary focus of romance fiction is on the relationship and romantic love between two people." +
                    " These books have an emotionally satisfying and optimistic ending."
                });

                context.Tags.Add(new Tag { Name = "History" });
                context.Tags.Add(new Tag { Name = "Fantasy" });
                context.Tags.Add(new Tag { Name = "World War 2" });
                context.Tags.Add(new Tag { Name = "World War 1" });
                context.Tags.Add(new Tag { Name = "Ancient history" });
                context.Tags.Add(new Tag { Name = "Epik" });
                context.Tags.Add(new Tag { Name = "Battle" });

                context.SaveChanges();

                context.Posts.Add(new Post
                {
                    AuthorId = context.Authors.Single(x => x.Name == "Steven Poll").Id,
                    Category = context.Categories.FirstOrDefault(x => x.Name == "Mythology"),
                    Title = "Little Rock After Brown v. Board",
                    PostedOn = DateTime.Today,
                    Body = "When the Supreme Court ruled in 1954 that separate schools for whites and blacks were unconstitutional and inherently unequal," +
                    " the slow and often violent dismantling of segregation in educational institutions began across the country. Knowing that there would be defiance" +
                    " and resistance toward the Brown v. Board of Education decision, particularly in the South where Jim Crow prevailed, the Supreme Court refrained from" +
                    " setting a specific deadline for schools to begin the desegregation process.But in 1955, in a subsequent ruling that addressed the lagging progress being made" +
                    " by states, the court demanded that integration happen “with all deliberate speed.” The school board of Little Rock, Arkansas, voted to desegregate their high" +
                    " schools starting in 1957, which led to a crisis that catapulted the state’s governor into a showdown with the president of the United States, Dwight D. Eisenhower. ",
                    SubTitle = "Why Eisenhower Sent the 101st Airborne to Little Rock After Brown v.Board"
                });

                context.Posts.Add(new Post
                {
                    AuthorId = context.Authors.Single(x => x.Name == "Rob Devis").Id,
                    Category = context.Categories.FirstOrDefault(x => x.Name == "Romance"),
                    Title = "Black die",
                    PostedOn = DateTime.Today,
                    Body = "The plague ravaged large cities and provincial towns in northern and central Italy from 1629 to 1631, killing more" +
                    " than 45,000 people in Venice alone and wiping out more than half the population of cities like Parma and Verona." +
                    " But strikingly, some communities were spared. In fact, the northern Italian town of Ferrara managed to prevent even a single death" +
                    " from the plague after the year 1576—even as neighboring communities were devastated. How did they do it? Critical in the city's success," +
                    " records suggest, were border controls, sanitary laws and personal hygiene. Starting with the catastrophic arrival of the Black Death in 1347," +
                    " Italian cities gradually began to take proactive public health measures to isolate the sick, quarantine possible carriers and restrict travel from " +
                    "affected regions, says John Henderson, a professor of Italian Renaissance history at Birbeck, University of London, and author of Florence Under" +
                    " Siege: Surviving Plague in an Early Modern City.",
                    SubTitle = "How One 17th-Century Italian City Fended Off the Plague"
                });

                context.Posts.Add(new Post
                {
                    AuthorId = context.Authors.Single(x => x.Name == "Elvis Mo").Id,
                    Category = context.Categories.FirstOrDefault(x => x.Name == "Legend"),
                    Title = "Civil War",
                    PostedOn = DateTime.Today,
                    Body = "The United States has never delayed a presidential election. But there was one instance in which some wondered if the" +
                    " country should: when the nation was embroiled in the Civil War.The 1864 election was the second U.S. presidential election to take" +
                    " place during wartime (the first was during the War of 1812). Still, it wasn’t the logistics of carrying out a wartime election that made" +
                    " some people want to postpone it.Rather, it was the fact that by the spring of 1864, the Union had no clear path to victory, and many feared" +
                    " President Abraham Lincoln wouldn’t win reelection.",
                    SubTitle = "How the Union Pulled Off a Presidential Election During the Civil War"
                });

                context.Posts.Add(new Post
                {
                    AuthorId = context.Authors.Single(x => x.Name == "Patrik Reigan").Id,
                    Category = context.Categories.FirstOrDefault(x => x.Name == "Horror"),
                    Title = "Quarantined",
                    PostedOn = DateTime.Today,
                    Body = "For millennia, a diagnosis of leprosy meant a life sentence of social isolation. People afflicted with the condition" +
                    " now known as Hansen’s disease—a bacterial infection that ravages the skin and nerves and can cause painful deformities—were typically" +
                    " ripped from their families, showered with prejudice and cruelly exiled into life-long quarantine. In the United States, patients were" +
                    " confined to a handful of remote settlements, where over time, a crude existence evolved into one with small touchstones of normalcy." +
                    " But patients were consistently deprived of fundamental civil liberties: to work, to move freely and see loved ones, to vote, to raise " +
                    "families of their own. Some who bore children had their babies forcibly removed. By the 1940s, after a cure emerged for the condition—and" +
                    " science made clear that most of the population had a natural immunity to it—other countries began to abolish compulsory isolation policies." +
                    " But in the U.S., even as leprosy patients' health and conditions improved, old stigmas, fear of contagion and outdated laws kept many confined" +
                    " for decades longer. ",
                    SubTitle = "Quarantined for Life: The Tragic History of US Leprosy Colonies"
                });

                context.Posts.Add(new Post
                {
                    AuthorId = context.Authors.Single(x => x.Name == "Patrik Reigan").Id,
                    Category = context.Categories.FirstOrDefault(x => x.Name == "Horror"),
                    Title = "Quarantined",
                    PostedOn = DateTime.Today,
                    Body = "A tiny number of Hansen’s disease patients still remain at Kalaupapa, a leprosarium established in 1866 on a remote," +
                    " but breathtakingly beautiful spit of land on the Hawaiian island of Molokai. Thousands lived and died there in the intervening" +
                    " years, including a later-canonized saint. But by 2008, the settlement's population had dwindled to 24—and by 2015, only six" +
                    " remained full time, despite having long been cured. Now in their 80s and 90s, many residents first arrived on the island as children." +
                    " They knew no other life. “When they came here, the law guaranteed them a home for life, and that can't be taken away,” doctor Sylvia Haven," +
                    " a doctor at the island’s hospital, told The New York Times in 1971. For some, that “home for life” translated more closely to a prison," +
                    " however picturesque. “You were brought here to die,” said Sister Alicia Damien Lau, who first came to the Molokai in 1965, in a 2016 interview." +
                    " “You were not able to leave the island.”",
                    SubTitle = "Banished to Hawaii"
                });

                context.Posts.Add(new Post
                {
                    AuthorId = context.Authors.Single(x => x.Name == "Max Rot").Id,
                    Category = context.Categories.FirstOrDefault(x => x.Name == "Drama"),
                    Title = "What Language Did Jesus Speak?",
                    PostedOn = DateTime.Today,
                    Body = "While scholars generally agree that Jesus was a real historical figure, debate has long raged around the events" +
                    " and circumstances of his life as depicted in the Bible. In particular, there’s been some confusion in the past about what" +
                    " language Jesus spoke, as a man living during the first century A.D. in the kingdom of Judea, located in what is now the southern" +
                    " part of Palestine.The issue of Jesus’ preferred language memorably came up in 2014, during a public meeting in Jerusalem between" +
                    " Benjamin Netanyahu, the prime minister of Israel, and Pope Francis, during the pontiff’s tour of the Holy Land. Speaking to the pope" +
                    " through an interpreter, Netanyahu declared: “Jesus was here, in this land. He spoke Hebrew. Francis broke in, correcting him. “Aramaic,”" +
                    " he said, referring to the ancient Semitic language, now mostly extinct, that originated among a people known as the Aramaeans around the late" +
                    " 11th century B.C. As reported in the Washington Post, a version of it is still spoken today by communities of Chaldean Christians in Iraq and" +
                    " Syria.",
                    SubTitle = "What Language Did Jesus Speak?e"
                });

                context.SaveChanges();
            }
        }
    }
}
