using System.ComponentModel.DataAnnotations;

namespace ALvl_ExamProject.MVC.Models
{
    public class SidebarPL
    {
        public int Id { get; set; }

        [Required]
        public string Body { get; set; }
    }
}