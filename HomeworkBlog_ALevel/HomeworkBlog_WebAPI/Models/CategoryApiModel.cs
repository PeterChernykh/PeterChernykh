using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeworkBlog_WebAPI.Models
{
    public class CategoryApiModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please input category name")]
        public string Name { get; set; }

        [StringLength(300, MinimumLength = 5, ErrorMessage = "Please input from 5 to 300 characters")]
        public string Description { get; set; }
    }
}