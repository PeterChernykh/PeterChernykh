using EFPractise.Common;

namespace EFPractise.BLL.Models
{
    public class GemstoneModel
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public GemStoneTypeEnum Type { get; set; }
    }
}
