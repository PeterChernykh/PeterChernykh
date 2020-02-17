using System.Collections.Generic;
using Homework11.PL.Models;

namespace Homework11.PL.Interfaces
{
    public interface ICarController
    {
            IEnumerable<CarViewModel> GetAllСars();
            void AddNewCar(CarViewModel carViewModel);
            CarViewModel GetDetails(int id);
            void UpdateCarDetail(CarViewModel carViewModel);
            void DeleteCar(CarViewModel carViewModel);
    }
}
