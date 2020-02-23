using Homework12_BLL.Services;
using Homework12_PL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework12_DAL.Repositories;

namespace Homework12_ThreeLayer_Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            var carRepository = new CarRepository();
            var carService = new CarService();
            var carController = new CarController();


           carRepository.GetAll();
           carService.GetAllСars();
           // carController.GetAllСars();

            Console.ReadKey();
        }
    }
}
