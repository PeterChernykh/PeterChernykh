using System;
using System.Collections.Generic;

namespace HomeworkBlog_ALevel.BLL.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PostedOn { get; set; }
        public string Body { get; set; }
        public string SubTitle { get; set; }

        public int CategoryId { get; set; }
        public CategoryModel CategoryModel { get; set; }

        public int AuthorId { get; set; }
        public AuthorModel AuthorModel { get; set; }

        public ICollection<TagModel> TagModels { get; set; }
    }
}
