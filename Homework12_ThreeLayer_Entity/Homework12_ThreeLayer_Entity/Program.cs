using Homework12_PL.Controller;
using System;

namespace Homework12_ThreeLayer_Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            var carController = new CarController();
            var detailController = new DetailController();


            //var allDetailsController = detailController.GetAll();
            //detailController.Add(null);
            //detailController.Delete(24);
            //var fifthDetail = detailController.GetById(9);
            //detailController.Update(null);

            //var allCarViewModels = carController.GetAll();
            //carController.Add(null);
            //carController.Delete(6);
            //var secondCar = carController.GetCarById(1);
            //carController.Update(null);

            Console.ReadKey();
        }
    }
}
