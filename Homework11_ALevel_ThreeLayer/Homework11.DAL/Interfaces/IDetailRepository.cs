using System.Collections.Generic;
using Homework11.DAL.Model;

namespace Homework11.DAL.Interfaces
{
    public interface IDetailRepository
    {
        IEnumerable<Detail> GetAll();
        void Insert(Detail detail);
        void Delete(Detail detail);
        void Update(Detail detail);
        Detail Get(int id);
    }
}
