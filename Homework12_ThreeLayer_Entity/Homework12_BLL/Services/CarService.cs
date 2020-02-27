using Homework12_BLL.Interfaces;
using Homework12_BLL.Models;
using Homework12_DAL.Interfaces;
using Homework12_DAL.Models;
using Homework12_DAL.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Homework12_BLL.Services
{
    public class CarService : ICarService
    {
        private readonly IRepository<Car> _dbCar;
        private readonly IRepository<Detail> _dbDetail;

        public CarService()
        {
            _dbCar = new CarRepository();
            _dbDetail = new DetailRepository();

        }

        public void Add(CarModel carModel)
        {
            var car = new Car
            {
                Model = carModel.Model,
                Details = carModel.Details.Select(x => new Detail
                {
                    Name = x.Name,
                    Cost = x.Cost,
                    CarId = x.CarId
                }
                ).ToList(),
            };

            _dbCar.Insert(car);
        }

        public void Delete(int id)
        {
            _dbCar.Delete(id);
        }

        public IEnumerable<CarModel> GetAll()
        {

            var carModels = from car in _dbCar.GetAll()
                            select new CarModel()
                            {
                                Id = car.Id,
                                Model = car.Model,
                                Details = car.Details.Select(x => new DetailModel
                                {
                                    Id = x.Id,
                                    Name = x.Name,
                                    Cost = x.Cost,
                                    CarId = x.CarId

                                })
                            };
            return carModels;
        }

        public void Update(CarModel carModel)
        {
            var car = new Car
            {
                Id = carModel.Id,
                Model = carModel.Model
            };

            car.Model = carModel.Model;

            _dbCar.Update(car);
        }

        public CarModel GetById(int id)
        {
            var car = _dbCar.GetById(id);

            var carModel = new CarModel
            {
                Id = car.Id,
                Model = car.Model,
                Details = car.Details.Select(x => new DetailModel
                {
                    Name = x.Name,
                    Cost = x.Cost
                })
            };

            return carModel;
        }
    }
}