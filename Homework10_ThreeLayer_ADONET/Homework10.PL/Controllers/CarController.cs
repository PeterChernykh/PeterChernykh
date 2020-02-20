using System.Collections.Generic;
using System.Linq;
using Homework10.PL.Interfaces;
using Homework10.BLL.Interfaces;
using Homework10.PL.Models;

namespace Homework10.PL.Controllers
{
    public class CarController : ICarController
    {
        ICarService service { get; set; }

        public CarController (ICarService service)
        {
            this.service = service;
        }

        public IEnumerable<CarViewModel> GetAll()
        {
            var allCar = from carModel in service.GetAll()
                         select new CarViewModel
                         {
                             Id = carModel.Id,
                             Model = carModel.Model
                         };
            return allCar;
        }

        public CarViewModel GetCarDetailsById(int id)
        {
            var carModel = service.GetCarDetailsById(id);

            var carViewModel = new CarViewModel
            {
                Id = carModel.Id,
                Model = carModel.Model,
            };

            foreach(var i in carModel.Details)
            {
                var detailModels = new DetailViewModel
                {
                    Id = i.Id,
                    CarId = i.CarId,
                    DetailName = i.DetailName,
                    Cost = i.Cost
                };
                carViewModel.Details.Add(detailModels);
            }

            return carViewModel;
        }

        public CarViewModel GetDetailCar(int id)
        {
            var carModel = service.GetDetailCar(id);

            var carViewModel = new CarViewModel
            {
                Id = carModel.Id,
                Model = carModel.Model,
            };

            return carViewModel;
        }
    }
}
