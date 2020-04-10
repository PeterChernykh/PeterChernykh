using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeworkBlog.Models
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "please input Name")]
        public string Name { get; set; }

        //public IEnumerable<PostViewModel> PostModels { get; set; }
    }
}