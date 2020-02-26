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

            
            var allDetailsController = detailController.GetAll();
            //detailController.Add(null);
            //detailController.Delete(7);
            //var fifthDetail = detailController.GetById(5);
            detailController.Update(null);

            var allCarViewModels = carController.GetAll();
            //carController.Add(null);
            //carController.Delete(4);
            //var secondCar = carController.GetCarById(2);
            //carController.Update(null);

            Console.ReadKey();
        }
    }
}
