namespace EFPractise.DAL.Migrations
{
    using System.Data.Entity.Migrations;
    using EFPractise.DAL.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<EFPractise.DAL.JewelleryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFPractise.DAL.JewelleryContext context)
        {
            context.GemstoneTypes.Add(new GemstoneType { Name = "Diamont" });
            context.GemstoneTypes.Add(new GemstoneType { Name = "Ametist" });
            context.GemstoneTypes.Add(new GemstoneType { Name = "Emerald" });
        }
    }
}
