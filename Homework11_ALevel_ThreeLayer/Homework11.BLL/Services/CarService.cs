using System.Collections.Generic;
using System.Linq;
using Homework11.BLL.Interfaces;
using Homework11.BLL.Models;
using Homework11.DAL.Interfaces;
using Homework11.DAL.Models;

namespace Homework11.BLL.Services
{
    public class CarService : ICarService
    {
        ICarRepository carModelRepo { get; set; }

        public CarService(ICarRepository repository)
        {
            carModelRepo = repository;
        }

        public IEnumerable<CarModel> GetAllСars()
        {
            var carsModels = from car in carModelRepo.GetAll()
                             select new CarModel()
                             {
                                 Id = car.Id,
                                 Model = car.Model
                             };
            return carsModels;
        }

        public void AddNewCar(CarModel carModel)
        {
            var car = DALObjectCreator.carObject(carModel);
            carModelRepo.Insert(car);
        }

        public void DeleteCar(CarModel carModel)
        {
            var car = DALObjectCreator.carObject(carModel);
            carModelRepo.Delete(car);
        }

        public void UpdateCar(CarModel carModel)
        {
            var car = DALObjectCreator.carObject(carModel);
            carModelRepo.Update(car);
        }

        public CarModel GetDetails(int id)
        {

            Car car = carModelRepo.GetDeteils(id);

            var carsModel = new CarModel()
            {
                Id = car.Id,
                Model = car.Model
            };
            return carsModel;
        }
    }
}
