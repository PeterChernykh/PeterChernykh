using HomeworkBlog_ALevel.BLL.Models;

namespace HomeworkBlog_ALevel.BLL.Interfaces
{
    public interface IPostService: IService<PostModel>
    {
        int TotalPost();
        PostModel GetById(int id);
    }
}
