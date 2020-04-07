using System;
using System.Collections.Generic;

namespace HomeworkBlog_ALevel.DAL.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PostedOn { get; set; }
        public bool Published { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int AythorId { get; set; }
        public virtual Author Author { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }

    }
}
