using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_Shop.BLL.Models
{
    public class CategoryApi //TODO: rename
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public object ProductApi { get; set; }
    }

    public class ProductApi
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryApiID { get; set; }
        public CategoryApi CategoryApi { get; set; }
    }
}
