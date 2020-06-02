using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

        public decimal Price { get; set; }

        [DisplayName("Select an image")]
        public string ImagePath { get; set; }

        public CategoryPL CategoryPL { get; set; }

        [Required]
        [DisplayName("Category")]
        public int CategoryId { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; }

        public IEnumerable<string> GalleryImage { get; set; }

        public ProductPL()
        {
            ImagePath = "~/App_Files/Images/noimage.png";
        }
    }
}