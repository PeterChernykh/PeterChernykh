﻿using Homework12_BLL.Interfaces;
using Homework12_BLL.Models;
using Homework12_DAL.Interfaces;
using Homework12_DAL.Models;
using Homework12_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void AddNewCar(CarModel carModel)
        {
            var car = new Car
            {
                Model = carModel.Model,
                Details = carModel.Details.Select(x => new Detail
                {
                    DetailName = x.DetailName,
                    Cost = x.Cost,
                    CarId = x.CarId
                }
                ).ToList(),
            };

            _dbCar.Insert(car);
        }

        public void DeleteCar(CarModel carModel)
        {
            var car = new Car
            {
                Model = carModel.Model,
                Details = carModel.Details.Select(x => new Detail
                {
                    DetailName = x.DetailName,//TODO: check caskad removing
                    Cost = x.Cost,
                    CarId = x.CarId
                }
               ).ToList(),
            };
            _dbCar.Delete(car);
        }

        public IEnumerable<CarModel> GetAllСars()
        {
            var detailModels = from detail in _dbDetail.GetAll()
                               select new DetailModel()
                               {
                                   Id = detail.Id,
                                   DetailName = detail.DetailName,
                                   Cost = detail.Cost,
                                   CarId = detail.CarId
                               };


            var carModels = from car in _dbCar.GetAll()
                           select new CarModel()
                           {
                               Id = car.Id,
                               Model = car.Model,
                               Details = detailModels.Where(x => x.CarId == car.Id).ToList()
                           };
            return carModels;
        }

        public CarModel GetCarById(int id)
        {
            var cars = GetAllСars();

            var car = cars.Where(x => x.Id == id).FirstOrDefault();

            return car;
        }

        public void UpdateCar(CarModel carModel)
        {
            var car = new Car
            {
                Model = carModel.Model,
                Details = carModel.Details.Select(x => new Detail
                {
                    DetailName = x.DetailName,
                    Cost = x.Cost,
                    CarId = x.CarId
                }
                ).ToList(),
            };

            _dbCar.Update(car);
        }
    }
}
