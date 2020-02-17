using System.Linq;
using System.Collections.Generic;
using Homework11.PL.Interfaces;
using Homework11.PL.Models;
using Homework11.BLL.Interfaces;
using Homework11.BLL.Models;

namespace Homework11.PL.Controller
{
    public class CarController : ICarController
    {

        ICarService carViewModelRepo { get; set; }

        public CarController(ICarService repository)
        {
            carViewModelRepo = repository;
        }

        public void AddNewCar(CarViewModel carViewModel)
        {
            var carModel = BLLObjectCreator.carModelObject(carViewModel);
            carViewModelRepo.AddNewCar(carModel);

        }

        public void DeleteCar(CarViewModel carViewModel)
        {
            var carModel = BLLObjectCreator.carModelObject(carViewModel);
            carViewModelRepo.DeleteCar(carModel);
        }

        public IEnumerable<CarViewModel> GetAllСars()
        {
            var carsModels = from car in carViewModelRepo.GetAllСars()
                             select new CarViewModel()
                             {
                                 Id = car.Id,
                                 Model = car.Model
                             };
            return carsModels;
        }

        public void UpdateCarDetail(CarViewModel carViewModel)
        {
            var carModel = BLLObjectCreator.carModelObject(carViewModel);
            carViewModelRepo.UpdateCar(carModel);
        }

        public CarViewModel GetDetails(int id)
        {
            CarModel carModel = carViewModelRepo.GetDetails(id);

            var carViewModel = new CarViewModel()
            {
                Id = carModel.Id,
                Model = carModel.Model
            };
            return carViewModel;
        }
    }
}
