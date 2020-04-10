using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HomeworkBlog.Models
{
    public class PostViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, MinimumLength =1, ErrorMessage = "Please input from 1 to 100 characters")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime PostedOn { get; set; }

        [StringLength(5000, MinimumLength = 1, ErrorMessage = "Please input from 1 to 5000 characters")]
        [Required (ErrorMessage = "Please input the main text")]  
        public string Body { get; set; }
        public string SubTitle { get; set; }

        public int CategoryId { get; set; }
        public virtual CategoryViewModel Category { get; set; }

        [Required (ErrorMessage ="Please indicate the author id")]
        public int AuthorId { get; set; }
        public virtual AuthorViewModel Author { get; set; }

        //public virtual ICollection<TagViewModel> Tags { get; set; }
    }
}