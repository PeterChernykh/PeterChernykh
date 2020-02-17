using System.Collections.Generic;
using Homework11.BLL.Models;

namespace Homework11.BLL.Interfaces
{
    public interface ICarService
    {
        IEnumerable<CarModel> GetAllСars();
        void AddNewCar(CarModel car);
        //CarModel GetCar(int? id);
        void UpdateCar(CarModel car);
        void DeleteCar(CarModel car);
    }
}
