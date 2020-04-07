using System.Collections.Generic;

namespace HomeworkBlog_ALevel.BLL.Models
{
    public class AuthorModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<PostModel> PostModels { get; set; }
    }
}
