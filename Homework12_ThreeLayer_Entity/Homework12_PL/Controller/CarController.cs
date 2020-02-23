using Homework12_BLL.Interfaces;
using Homework12_BLL.Models;
using Homework12_BLL.Services;
using Homework12_PL.Interfaces;
using Homework12_PL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void AddNewCar(CarViewModel carViewModel)
        {
            var car = new CarModel
            {
                Model = "Opel",
                Details = new List<DetailModel>
                {
                    new DetailModel
                    {
                        DetailName = "Wheel",
                        Cost = 1500,
                    },
                    new DetailModel
                    {
                        DetailName = "Door",
                        Cost = 1500,
                    },
                    new DetailModel
                    {
                        DetailName = "Stearing wheel",
                        Cost = 1500,
                    }
                }
            };
            _dbCar.AddNewCar(car);
        }

        public void DeleteCar(CarViewModel carViewModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CarViewModel> GetAllСars()
        {
            var allDetails = _dbDetail.GetAll();
            
            var detailViewModels = from detail in allDetails
                               select new DetailViewModel()
                               {
                                   DetailName = detail.DetailName,
                                   Cost = detail.Cost,
                                   CarViewModel = new CarViewModel
                                   {
                                       Model = detail.CarModel.Model,
                                   },
                                   CarId = detail.CarId
                               };


            var carViewModels = from car in _dbCar.GetAllСars()
                            select new CarViewModel()
                            {
                                Model = car.Model,
                                Details = detailViewModels.Where(x => x.CarId == car.Id).ToList()
                            };

            return carViewModels;
        }

        public CarViewModel GetCarById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCar(CarViewModel carViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
