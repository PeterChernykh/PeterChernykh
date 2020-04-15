using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeworkBlog_WebAPI.Models
{
    public class TagApiModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please input tag")]
        public string Name { get; set; }
    }
}