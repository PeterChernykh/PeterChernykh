using System.Collections.Generic;

namespace Homework10.BLL.Models
{
    public class CarModel
    {
        public CarModel()
        {
            Details = new List<DetailModel>();
        }
        public int Id { get; set; }
        public string Model { get; set; }

        public ICollection<DetailModel> Details { get; set; }
    }
}
