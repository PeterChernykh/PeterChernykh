using System.Collections.Generic;

namespace Homework12_BLL.Models
{
    public class CarModel
    {
            public int Id { get; set; }
            public string Model { get; set; }
            public IEnumerable<DetailModel> Details { get; set; }
    }
}
