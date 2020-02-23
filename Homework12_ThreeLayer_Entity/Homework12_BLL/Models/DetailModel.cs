using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12_BLL.Models
{
    public class DetailModel
    {
        public int Id { get; set; }
        public string DetailName { get; set; }
        public int Cost { get; set; }

        public int CarId { get; set; }
        public CarModel CarModel { get; set; }
    }
}
