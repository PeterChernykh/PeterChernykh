using System.Collections.Generic;
using Homework11.DAL.Model;

namespace Homework11.DAL.Interfaces
{
    public interface ICarRepository
    {
        IEnumerable <Car> GetAll();
        void Insert(Car car);
        void Delete(Car car);
        void Update(Car car);
        Car GetDeteils(int id);
    }
}
