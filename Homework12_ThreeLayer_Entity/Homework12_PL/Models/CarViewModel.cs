using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12_PL.Models
{
    public class CarViewModel
    {
        public string Model { get; set; }
        public IEnumerable<DetailViewModel> Details { get; set; }
    }
}
