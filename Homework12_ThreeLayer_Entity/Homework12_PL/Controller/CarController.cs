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
                Model = "Rover",
                Details = new List<DetailModel>
                {
                    new DetailModel
                    {
                        DetailName = "Chop",
                        Cost = 777,
                    },
                    new DetailModel
                    {
                        DetailName = "Chair",
                        Cost = 1277,
                    },
                    new DetailModel
                    {
                        DetailName = "Stearing wheel",
                        Cost = 77772,
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

            var detailModels = from detail in _dbDetail.GetAll()
                               select new DetailViewModel()
                               {
                                   DetailName = detail.DetailName,
                                   Cost = detail.Cost,
                                   CarId = detail.CarId
                               };

            var carModels = from car in _dbCar.GetAll()
                            select new CarViewModel()
                            {
                                Model = car.Model,
                                Details = detailModels.Where(x => x.CarId == car.Id).ToList()
                            };
            return carModels.ToList();
        }

        public void Update(CarViewModel carViewModel)
        {
            var carModel = new CarModel
            {
                Id = 3,
                Model = "Jaguar"
            };

            _dbCar.Update(carModel);
        }

        public CarViewModel GetCarById(int id)
        {
            var car = GetAll().Where(x => x.Id == id).FirstOrDefault();

            return car;
        }
    }
}
