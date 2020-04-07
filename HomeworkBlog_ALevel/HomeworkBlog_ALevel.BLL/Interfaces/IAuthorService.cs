using HomeworkBlog_ALevel.BLL.Models;

namespace HomeworkBlog_ALevel.BLL.Interfaces
{
    public interface IAuthorService: IService<AuthorModel>
    {
        AuthorModel GetById(int id);
    }
}
