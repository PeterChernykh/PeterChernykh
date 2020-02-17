using System.Collections.Generic;

namespace Homework11.DAL.Model
{
    public class Detail
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string DetailName { get; set; }
        public Car Car { get; set; }
    }
}
