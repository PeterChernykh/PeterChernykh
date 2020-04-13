using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeworkBlog.Models
{
    public class ListViewModels
    {
        public IEnumerable<CategoryViewModel> Category { get; set; }
        public IEnumerable<AuthorViewModel> Authors { get; set; }
        public IEnumerable<TagViewModel> Tags { get; set; }
        public IEnumerable<PostViewModel> Posts { get; set; }

    }
}