using System.Collections.Generic;

namespace EFPractise.DAL.Models
{
    public class Gemstone
    {
        public int Id { get; set; }
        public string Color { get; set; }    
        public int Price { get; set; }
        public string Name { get; set; }

        public virtual ICollection<GemstoneType> GemstoneType { get; set; }
    }
}
