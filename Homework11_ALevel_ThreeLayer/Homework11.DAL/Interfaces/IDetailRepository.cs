using System.Collections.Generic;
using Homework11.DAL.Models;

namespace Homework11.DAL.Interfaces
{
    public interface IDetailRepository
    {
        IEnumerable<Detail> GetAll();
        void Insert(Detail detail);
        void Delete(Detail detail);
        void Update(Detail detail);
        Detail GetCar(int id);
    }
}
