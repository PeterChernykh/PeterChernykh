using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HomeworkBlog_ALevel.DAL.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime PostedOn { get; set; }

        public string Body { get; set; }
        public string SubTitle {get;set;}

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }

    }
}
