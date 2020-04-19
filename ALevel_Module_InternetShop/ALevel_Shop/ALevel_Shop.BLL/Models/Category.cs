using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_Shop.BLL.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
