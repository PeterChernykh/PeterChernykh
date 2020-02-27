using Homework12_BLL.Interfaces;
using Homework12_BLL.Models;
using Homework12_BLL.Services;
using Homework12_PL.Interfaces;
using Homework12_PL.Models;
using System.Collections.Generic;
using System.Linq;

namespace Homework12_PL.Controller
{
    public class CarController : ICarController
    {
        private readonly ICarService _dbCar;
        private readonly IDetailService _dbDetail;

        public CarController()
        {
            _dbCar = new CarService();
            _dbDetail = new DetailService();
        }

        public void Add(CarViewModel carViewModel)
        {
            var car = new CarModel
            {
                Model = "NotPetercar",
                Details = new List<DetailModel>
                {
                    new DetailModel
                    {
                        Name = "Mirror",
                        Cost = 1111,
                    },
                    new DetailModel
                    {
                        Name = "Door",
                        Cost = 2222,
                    },
                    new DetailModel
                    {
                        Name = "Glass",
                        Cost = 3333,
                    }
                }
            };
            _dbCar.Add(car);
        }

        public void Delete(int id)
        {
            _dbCar.Delete(id);
        }

        public IEnumerable<CarViewModel> GetAll()
        {

            var carViewModels = from car in _dbCar.GetAll()
                                select new CarViewModel()
                                {
                                    Id = car.Id,
                                    Model = car.Model,
                                    Details = car.Details.Select(x => new DetailViewModel
                                    {
                                        Id = x.Id,
                                        Name = x.Name,
                                        Cost = x.Cost,
                                        CarId = x.CarId
                                    })
                                };
            return carViewModels;
        }

        public void Update(CarViewModel carViewModel)
        {
            var carModel = new CarModel
            {
                Id = 1,
                Model = "PeterCar"
            };

            _dbCar.Update(carModel);
        }

        public CarViewModel GetCarById(int id)
        {
            var carModel = _dbCar.GetById(id);

            var carViewModel = new CarViewModel
            {
                Id = carModel.Id,
                Model = carModel.Model,
                Details = carModel.Details.Select(x => new DetailViewModel
                {
                    Name = x.Name,
                    Cost = x.Cost
                })
            };

            return carViewModel;
        }
    }
}