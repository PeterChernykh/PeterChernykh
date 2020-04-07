using System.Collections.Generic;

namespace HomeworkBlog_ALevel.DAL.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
