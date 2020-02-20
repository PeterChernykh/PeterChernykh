using System.Collections.Generic;

namespace Homework10.DAL.Interfaces
{
    public interface IRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
    }
}