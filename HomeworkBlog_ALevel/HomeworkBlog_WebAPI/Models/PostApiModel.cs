using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeworkBlog_WebAPI.Models
{
    public class PostApiModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Please input from 1 to 100 characters")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime PostedOn { get; set; }

        public string SubTitle { get; set; }

        [Required(ErrorMessage = "Please indicate the category id")]
        public int CategoryId { get; set; }
        public CategoryApiModel Category { get; set; }

        [Required(ErrorMessage = "Please indicate the author id")]
        public int AuthorId { get; set; }
        public AuthorApiModel Author { get; set; }


        [StringLength(5000, MinimumLength = 1, ErrorMessage = "Please input from 1 to 5000 characters")]
        [Required(ErrorMessage = "Please input text")]
        public string Body { get; set; }
    }
}