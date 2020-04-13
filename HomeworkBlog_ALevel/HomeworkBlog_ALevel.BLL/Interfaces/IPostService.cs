using HomeworkBlog_ALevel.BLL.Models;
using System.Collections.Generic;

namespace HomeworkBlog_ALevel.BLL.Interfaces
{
    public interface IPostService: IService<PostModel>
    {
        PostModel GetById(int id);
        IEnumerable<PostModel> Posts(int pageNo, int pageSize);
        int TotalPosts();
    }
}
