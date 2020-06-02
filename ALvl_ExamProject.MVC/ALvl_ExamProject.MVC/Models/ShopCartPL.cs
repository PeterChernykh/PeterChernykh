
namespace ALvl_ExamProject.MVC.Models
{
    public class ShopCartPL
    {
        public ProductPL ProductPL { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal Total
        {
            get { return Quantity * Price; }
        }

        public string ImagePath { get; set; }
    }
}