using System.Collections.Generic;

namespace EFPractise.DAL.Models
{
    public class GemstoneType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GemstoneId { get; set; }
        public int Type { get; set; }

        public virtual Gemstone Gemstone { get; set; }
    }
}
