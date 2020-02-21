using System.Collections.Generic;

namespace EFPractise.DAL.Models
{
    public class Jewellery
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }


        public virtual ICollection<Gemstone> Gemstones { get; set; }

        public int ManufactorerId { get; set; }
        public Manufacturer Manufactorer { get; set; }
    }
}
