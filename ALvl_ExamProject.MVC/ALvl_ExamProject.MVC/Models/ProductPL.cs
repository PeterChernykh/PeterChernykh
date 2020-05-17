using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ALvl_ExamProject.MVC.Models
{
    public class ProductPL
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Slug { get; set; }

        [Required]
        public string Description { get; set; }

        public double Price { get; set; }

        [DisplayName("Select an image")]
        public string ImagePath { get; set; }

        public CategoryPL CategoryPL { get; set; } // TODO: remove property

        [Required]
        [DisplayName("Category")]
        public int CategoryId { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; }

        public IEnumerable<string> GalleryImage { get; set; }
    }
}