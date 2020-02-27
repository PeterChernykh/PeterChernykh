using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12_DAL.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public virtual ICollection<Detail> Details { get; set; }
    }
}
