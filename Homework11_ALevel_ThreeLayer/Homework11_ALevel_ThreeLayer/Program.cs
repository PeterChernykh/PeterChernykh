using System;
using Homework11.DAL.Repository;
using Homework11.BLL.Services;
using Homework11.DAL.Interfaces;
using Homework11.BLL.Interfaces;
using Homework11.DAL.Models;
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

            var detaildetail = detailViewModel.GetCar(3);

            var carCar = carViewModel.GetDetails(1);

            Console.ReadKey();
        }
    }
}
