
namespace Homework12_PL.Models
{
    public class DetailViewModel
    {
        public int Id { get; set; }
        public string DetailName { get; set; }
        public int Cost { get; set; }

        public int CarId { get; set; }
        public CarViewModel CarViewModel { get; set; }
    }
}
