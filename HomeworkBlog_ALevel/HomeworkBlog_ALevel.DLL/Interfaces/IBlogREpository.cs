using System.Collections.Generic;

namespace HomeworkBlog_ALevel.DAL.Interfaces
{
    public interface IBlogRepository<T> where T: class
    {
        void Add(T model);
        void Remove(int id);
        void Update(T model);
        int TotalPost();
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
