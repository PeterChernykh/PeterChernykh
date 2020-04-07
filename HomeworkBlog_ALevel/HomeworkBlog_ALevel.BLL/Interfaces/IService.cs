using System.Collections.Generic;

namespace HomeworkBlog_ALevel.BLL.Interfaces
{
    public interface IService<ModelBL> where ModelBL: class
    {
        void Add(ModelBL model);
        void Remove(int id);
        void Update(ModelBL model);
        IEnumerable<ModelBL> GetAll();
    }
}
