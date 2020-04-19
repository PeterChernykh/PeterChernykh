using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALevel_Module_InternethShop.Models
{
    public class ProductApiModel
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public int CategoryApiModelId { get; set; }
        public virtual CategoryApiModel CategoryApiModel { get; set; }
    }
}