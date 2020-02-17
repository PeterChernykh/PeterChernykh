using System.Collections.Generic;

namespace Homework11.DAL.Models
{
    public class Car
    {
        public Car()
        {
            Details = new List<Detail>();
        }
        public int Id { get; set; }
        public string Model { get; set; }
        public ICollection <Detail> Details {get;set;}
    }
}