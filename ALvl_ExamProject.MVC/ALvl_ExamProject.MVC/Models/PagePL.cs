using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ALvl_ExamProject.MVC.Models
{
    public class PagePL
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        public string Slug { get; set; }

        [Required]
        [StringLength(int.MaxValue, MinimumLength = 10)]
        [AllowHtml]
        public string Body { get; set; }

        public int Sorting { get; set; }

        public bool Sidebar { get; set; }
    }
}