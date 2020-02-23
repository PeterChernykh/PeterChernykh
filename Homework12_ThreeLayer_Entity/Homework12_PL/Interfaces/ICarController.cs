using Homework12_PL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12_PL.Interfaces
{
    public interface ICarController
    {
        IEnumerable<CarViewModel> GetAllСars();
        void AddNewCar(CarViewModel carModel);
        CarViewModel GetCarById(int id);
        void UpdateCar(CarViewModel carModel);
        void DeleteCar(CarViewModel carModel);
    }
}
