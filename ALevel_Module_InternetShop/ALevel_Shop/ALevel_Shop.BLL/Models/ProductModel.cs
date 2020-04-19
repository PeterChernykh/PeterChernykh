using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_Shop.BLL.Models
{
    public class ProductModel
    {
            public int Id { get; set; }
            public int Number { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public int CategoryModelId { get; set; }
            public CategoryModel CategoryModel { get; set; }
    }
}
