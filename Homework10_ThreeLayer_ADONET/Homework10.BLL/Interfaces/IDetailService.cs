using System.Collections.Generic;
using Homework10.BLL.Models;

namespace Homework10.BLL.Interfaces
{
    public interface IDetailService
    {
        IEnumerable<DetailModel> GetAll();
    }
}
