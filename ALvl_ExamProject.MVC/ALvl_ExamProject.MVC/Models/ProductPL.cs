using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALvl_ExamProject.MVC.Models
{
    public class ProductPL
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public int CategoryId { get; set; }
        public CategoryPL CategoryPL { get; set; }
    }
}