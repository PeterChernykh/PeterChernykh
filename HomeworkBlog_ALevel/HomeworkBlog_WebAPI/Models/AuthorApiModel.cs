using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeworkBlog_WebAPI.Models
{
    public class AuthorApiModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "please input Name")]
        public string Name { get; set; }
    }
}