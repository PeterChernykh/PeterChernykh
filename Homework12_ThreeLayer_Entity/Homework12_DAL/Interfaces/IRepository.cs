using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework12_DAL.Models;

namespace Homework12_DAL.Interfaces
{
    public interface IRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
        void Insert(T item);
        void Delete(T item);
        void Update(T item);
    }
}
