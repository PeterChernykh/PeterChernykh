
namespace Homework12_PL.Models
{
    public class DetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }

        public int CarId { get; set; }
        public CarViewModel CarViewModel { get; set; }
    }
}
