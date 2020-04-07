using System;
using System.Collections.Generic;

namespace HomeworkBlog.Models
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PostedOn { get; set; }
        public bool Published { get; set; }

        public int CategoryId { get; set; }
        public virtual CategoryViewModel Category { get; set; }

        public int AuthorId { get; set; }
        public virtual AuthorViewModel Author { get; set; }

        //public virtual ICollection<TagViewModel> Tags { get; set; }
    }
}