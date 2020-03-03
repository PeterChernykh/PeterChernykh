using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12_DAL.Models
{
    public class Detail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }

        public int CarId { get; set; }
        public virtual Car Car { get; set; }

        public int DetailTypeId { get; set; }
        public virtual DetailType DetailType { get; set; }

        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
    }
}
