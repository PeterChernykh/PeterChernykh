using HomeworkBlog_ALevel.DAL.Models;
using System.Data.Entity;


namespace HomeworkBlog_ALevel.DAL
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base(@"Data Source=.\SQLEXPRESS;Initial Catalog=HomeworkBlog;Integrated Security=True")
        {
            Database.SetInitializer<MyDBContext>(new MigrateDatabaseToLatestVersion<MyDBContext, HomeworkBlog_ALevel.DAL.Migrations.Configuration>());
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
               .HasMany(p => p.Posts)
               .WithRequired(p => p.Author);

            modelBuilder.Entity<Category>()
                .HasMany(x => x.Posts)
                .WithRequired(x => x.Category)
                .HasForeignKey(x => x.CategoryId);

            modelBuilder.Entity<Author>()
                .HasMany(x => x.Posts)
                .WithRequired(x => x.Author)
                .HasForeignKey(x => x.AuthorId);
        }
    }
}

