using System.Collections.Generic;
using Homework10.BLL.Models;

namespace Homework10.BLL.Interfaces
{
    public interface ICarService
    {
        IEnumerable<CarModel> GetAll();
        CarModel GetCarDetailsById(int id);
        CarModel GetDetailCar(int id);
    }
}
