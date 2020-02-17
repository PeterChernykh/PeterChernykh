using System.Collections.Generic;
using Homework11.PL.Models;

namespace Homework11.PL.Interfaces
{
    public interface IDetailController
    {
        IEnumerable<DetailViewModel> GetAllDetails();
        void AddNewDetail(DetailViewModel detailViewModel);
        void UpdateDetail(DetailViewModel detailViewModel);
        void DeleteDetail(DetailViewModel detailViewModel);
        DetailViewModel GetCar(int id);
    }
}
