using Homework12_BLL.Interfaces;
using Homework12_BLL.Models;
using Homework12_DAL.Interfaces;
using Homework12_DAL.Models;
using Homework12_DAL.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Homework12_BLL.Services
{
    public class DetailService : IDetailService
    {
        private readonly IRepository<Detail> _dbDetail;
        private readonly IRepository<Car> _dbCar;

        public DetailService()
        {
            _dbDetail = new DetailRepository();
            _dbCar = new CarRepository();
        }

        public IEnumerable<DetailModel> GetAll()
        {

            var details = from detail in _dbDetail.GetAll()
                          select new DetailModel
                          {
                              Id = detail.Id,
                              Name = detail.Name,
                              Cost = detail.Cost,
                              CarModel = new CarModel
                              {
                                  Id = detail.Car.Id,
                                  Model = detail.Car.Model
                              },
                              CarId = detail.CarId
                          };


            return details.ToList();
        }

        public void Delete(int id)
        {
            _dbDetail.Delete(id);
        }

        public void Add(DetailModel detailModel)
        {
            var car = _dbCar.GetAll().Where(x => x.Id == detailModel.CarId).FirstOrDefault();

<<<<<<< HEAD
            var detail = new Detail
            {
                Name = detailModel.Name,
                Cost = detailModel.Cost,
                CarId = detailModel.CarId
            };
=======
                var detail = new Detail
                {
                    DetailName = detailModel.DetailName,
                    Cost = detailModel.Cost,
                    CarId = detailModel.CarId
                };
>>>>>>> b314a4ae73474be64f46208452be66b64950d2d2

            _dbDetail.Insert(detail);
        }

        public void Update(DetailModel detailModel)
        {
            var detail = new Detail
            {
                Id = detailModel.Id,
<<<<<<< HEAD

                Name = detailModel.Name,
=======
  
                DetailName = detailModel.DetailName,
>>>>>>> b314a4ae73474be64f46208452be66b64950d2d2
                Cost = detailModel.Cost
            };

            _dbDetail.Update(detail);
        }

        public DetailModel GetById(int id)
        {
            var detail = _dbDetail.GetById(id);

            var detailModel = new DetailModel
            {
                Id = detail.Id,
<<<<<<< HEAD
                Name = detail.Name,
=======
                DetailName = detail.DetailName,
>>>>>>> b314a4ae73474be64f46208452be66b64950d2d2
                Cost = detail.Cost,
                CarModel = new CarModel
                {
                    Id = detail.Car.Id,
                    Model = detail.Car.Model,
                }
            };

            return detailModel;
        }
    }
}