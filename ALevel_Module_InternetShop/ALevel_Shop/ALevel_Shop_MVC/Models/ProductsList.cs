using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ALevel_Shop_MVC.Models
{
    public class ProductsList
    {
            public IEnumerable<ProductApi> Products { get; set; }
            public SelectList Categories { get; set; }
    }
}