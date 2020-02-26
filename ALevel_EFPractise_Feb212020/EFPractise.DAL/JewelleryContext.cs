using System.Data.Entity;
using EFPractise.DAL.Models;

namespace EFPractise.DAL
{
    public class JewelleryContext : DbContext
    {

        public JewelleryContext() : base(@"Data Source=.\SQLEXPRESS;Initial Catalog=EFPratiseJewellery2;Integrated Security=True")
        {      
        }
        public DbSet<Manufacturer> Manufactorers { get; set; }
        public DbSet<Jewellery> Jewelleries { get; set; }
        public DbSet<Gemstone> Gemstones { get; set; }
        public DbSet<GemstoneType> GemstoneTypes { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}