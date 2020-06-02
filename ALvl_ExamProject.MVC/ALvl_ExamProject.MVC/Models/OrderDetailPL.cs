
namespace ALvl_ExamProject.MVC.Models
{
    public class OrderDetailPL
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
    }
}