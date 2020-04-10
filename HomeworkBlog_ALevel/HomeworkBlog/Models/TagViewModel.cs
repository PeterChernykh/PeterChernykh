using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HomeworkBlog.Models
{
    public class TagViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please input tag")]
        public string Name { get; set; }

        //public virtual ICollection<PostViewModel> Posts { get; set; }
    }
}