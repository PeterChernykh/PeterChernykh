using System.Collections.Generic;

namespace EFPractise.PL.ViewModels
{
    public class JewelleryViewModel
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public  IEnumerable<GemstoneViewModel> Gemstones { get; set; }
        public ManufactorerViewModel ManufactorerViewModel { get; set; }
    }
}
