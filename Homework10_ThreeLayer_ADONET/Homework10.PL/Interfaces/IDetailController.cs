using System.Collections.Generic;
using Homework10.PL.Models;

namespace Homework10.PL.Interfaces
{
    public interface IDetailController
    {
        IEnumerable<DetailViewModel> GetAll();
    }
}
