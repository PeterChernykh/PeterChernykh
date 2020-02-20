using System;
using Homework10.DAL.Models;
using Homework10.DAL.Repositories;
using Homework10.DAL.Interfaces;
using Homework10.BLL.Services;
using Homework10.BLL.Interfaces;
using Homework10.PL.Controllers;
using Homework10.PL.Interfaces;



namespace Homework10_ThreeLayer_ADONET
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository<Car> car = new CarRepository();
            IRepository<Detail> detail = new DetailRepository();

            ICarService carService = new CarService(car);
            IDetailService detailService = new DetailService(detail);

            ICarController carController = new CarController(carService);
            IDetailController detailController = new DetailController(detailService);

            var allCars = carController.GetAll();

            var carDetails = carController.GetCarDetailsById(1);

            var detailCar = carController.GetDetailCar(1);

            var allDetails = detailController.GetAll();

            Console.ReadKey();
        }
    }
}
