using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12_BLL.Models
{
    public class CarModel
    {
            public int Id { get; set; }//TODO:убрать айди
            public string Model { get; set; }
            public IEnumerable<DetailModel> Details { get; set; }
    }
}
