using System.Collections.Generic;
using Homework11.BLL.Models;

namespace Homework11.BLL.Interfaces
{
    public interface IDetailService
    {
        IEnumerable<DetailModel> GetAllDetails();
        void AddNewDetail(DetailModel detail);
        void UpdateDetail(DetailModel detail);
        void DeleteDetail(DetailModel detail);
        DetailModel GetCar(int id);
    }
}
