using System.Collections.Generic;

namespace EFPractise.BLL.Models
{
    public class JewelleryModel
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public IEnumerable<GemstoneModel> Gemstones { get; set; }

        public int ManufacturerModelId { get; set; }
        public ManufactorerModel ManufacturerModel { get; set; }
    }
}
