using System;
using System.Collections.Generic;
using System.Linq;
using Homework10.BLL.Interfaces;
using Homework10.BLL.Models;
using Homework10.DAL.Interfaces;
using Homework10.DAL.Models;
using Homework10.DAL.Repositories;

namespace Homework10.BLL.Services
{
    public class CarService : ICarService
    {
        IRepository<Detail> detailRepo = new DetailRepository();

        IRepository<Car> repository { get; set; }

        public CarService(IRepository<Car> repository)
        {
            this.repository = repository;
        }

        public IEnumerable<CarModel> GetAll()
        {
            var allCar = from car in repository.GetAll()
                         select new CarModel
                         {
                             Id = car.Id,
                             Model = car.Model
                         };
            return allCar;
        }

        public CarModel GetCarDetailsById(int id)
        {
            var car = (from carObj in GetAll()
                       where carObj.Id == id
                       select new CarModel
                       {
                           Id = carObj.Id,
                           Model = carObj.Model

                       }).FirstOrDefault();

            var allDetails = detailRepo.GetAll();

            var details = from detailObj in allDetails
                          where detailObj.CarId == id
                          select detailObj;


            foreach (var i in details)
            {
                var detailModels = new DetailModel
                {
                    Id = i.Id,
                    CarId = i.CarId,
                    DetailName = i.DetailName,
                    Cost = i.Cost
                };
                car.Details.Add(detailModels);
            }
            return car;
        }

        public CarModel GetDetailCar(int id)
        {
            var detailCar = from car in GetAll()
                            where car.Id == id
                            select new CarModel
                            {
                                Id = car.Id,
                                Model = car.Model
                            };
            return detailCar.FirstOrDefault();

        }
    }
}
