using System;
using Homework11.DAL.Repository;
using Homework11.BLL.Services;
using Homework11.DAL.Interfaces;
using Homework11.BLL.Interfaces;
using Homework11.DAL.Model;
using Homework11.BLL.Models;
using Homework11.DAL;
using Homework11.PL.Interfaces;
using Homework11.PL.Models;
using Homework11.PL.Controller;

namespace Homework11_ALevel_ThreeLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = Connection.DetabaseConnection();

            ICarRepository car = new CarRepository(connection);
            IDetailRepository detail = new DetailRepository(connection);

            ICarService carModel = new CarService(car);
            IDetailService detailModel = new DetailService(detail);

            ICarController carViewModel = new CarController(carModel);
            IDetailController detailViewModel = new DetailController(detailModel);

            var detaildetail = detail.Get(3);

            var carCar = car.GetDeteils(1);


            //var newCar = new CarViewModel
            //{
            //    Id = 10,
            //    Model = "poupoupou"
            //};

            //carViewModel.AddNewCar(newCar);

            //var newCar2 = new CarViewModel
            //{
            //    Id = 10,
            //    Model = "boolbul"
            //};

            //carViewModel.UpdateCarDetail(newCar2);

            //var allCars = carViewModel.GetAllСars();

            //carViewModel.DeleteCar(newCar2);

            Console.ReadKey();

            //TODO: Car can get info about all the details
            //TODO: Add search by ID
        }
    }
}
