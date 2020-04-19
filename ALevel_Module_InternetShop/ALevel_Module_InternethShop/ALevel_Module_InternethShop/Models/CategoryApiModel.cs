using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALevel_Module_InternethShop.Models
{
    public class CategoryApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }

        public ICollection<ProductApiModel> ProductModels { get; set; }
    }
}