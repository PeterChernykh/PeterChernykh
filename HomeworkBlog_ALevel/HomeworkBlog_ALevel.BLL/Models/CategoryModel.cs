using System.Collections.Generic;

namespace HomeworkBlog_ALevel.BLL.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<PostModel> PostModels { get; set; }
    }
}
