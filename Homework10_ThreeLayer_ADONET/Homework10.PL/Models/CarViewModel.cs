using System.Collections.Generic;
using Homework10.PL.Models;
using Homework10.BLL.Models;

namespace Homework10.PL.Models
{
    public class CarViewModel
    {

        public CarViewModel()
        {
            Details = new List<DetailViewModel>();
        }

        public int Id { get; set; }
        public string Model { get; set; }

        public ICollection<DetailViewModel> Details { get; set; }
    }
}
