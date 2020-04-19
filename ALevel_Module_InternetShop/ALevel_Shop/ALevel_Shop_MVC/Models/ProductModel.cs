using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALevel_Shop_MVC.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public int CategoryId { get; set; }
        public virtual CategoryModel CategoryModel { get; set; }
    }
}