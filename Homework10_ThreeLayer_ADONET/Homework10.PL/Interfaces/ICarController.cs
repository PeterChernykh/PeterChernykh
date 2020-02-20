using System.Collections.Generic;
using Homework10.PL.Models;

namespace Homework10.PL.Interfaces
{
    public interface ICarController
    {
        IEnumerable<CarViewModel> GetAll();
        CarViewModel GetCarDetailsById(int id);
        CarViewModel GetDetailCar(int id);
    }
}
