using EFPractise.Common;

namespace EFPractise.PL.ViewModels
{
    public class GemstoneViewModel
    {
        public string Color { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public GemStoneTypeEnum Type { get; set; }
    }
}