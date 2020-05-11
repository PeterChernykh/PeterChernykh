using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ALvl_ExamProject.MVC.Models
{
    public class CategoryPL
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Name { get; set; }

        public string Slug { get; set; }

        public int Sorting { get; set; }

        public ICollection<ProductPL> ProductsPL { get; set; }
    }
}