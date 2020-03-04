using Homework12_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12_DAL.Interfaces
{
    public interface IManufacturer
    {
        Manufacturer DeniedManufacturer();
        IEnumerable<Manufacturer> GetAll();
        Manufacturer GetById(int id);
        void Insert(Manufacturer item);
    }
}
