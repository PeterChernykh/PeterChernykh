using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALevel_Shop_MVC.Models
{
    public class ProductApi
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public int CategoryApiId { get; set; }
        public virtual CategoryApi CategoryApi { get; set; }
    }
}