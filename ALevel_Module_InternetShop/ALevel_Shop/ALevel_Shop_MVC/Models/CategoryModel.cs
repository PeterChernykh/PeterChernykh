using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALevel_Shop_MVC.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }

        public ICollection<ProductModel> ProductModels { get; set; }
    }
}