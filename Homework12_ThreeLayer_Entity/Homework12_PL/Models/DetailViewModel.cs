using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12_PL.Models
{
    public class DetailViewModel
    {
        public string DetailName { get; set; }
        public int Cost { get; set; }

        public int CarId { get; set; }
        public CarViewModel CarViewModel { get; set; }
    }
}
