using Homework12_BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12_BLL.Interfaces
{
    public interface ICarService
    {
        IEnumerable<CarModel> GetAllСars();
        void AddNewCar(CarModel carModel);
        CarModel GetCarById(int id);
        void UpdateCar(CarModel carModel);
        void DeleteCar(CarModel carModel);
    }
}
