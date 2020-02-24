using Homework12_BLL.Interfaces;
using Homework12_BLL.Models;
using Homework12_DAL.Interfaces;
using Homework12_DAL.Models;
using Homework12_DAL.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Homework12_BLL.Services
{
    public class DetailService: IDetailService
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
                              DetailName = detail.DetailName,
                              Cost = detail.Cost,
                              CarModel = new CarModel
                              {
                                  Id = detail.Car.Id,
                                  Model = detail.Car.Model
                              },
                              CarId = detail.CarId,
                       };

            return details.ToList();
        }

        public void Delete (int id)
        {
            _dbDetail.Delete(id);
        }

        public void Add(DetailModel detailModel)
        {
            var car = _dbCar.GetAll().Where(x => x.Id == detailModel.CarId).FirstOrDefault();

            var detail = new Detail 
            {
                DetailName = detailModel.DetailName,
                Cost = detailModel.Cost,
                CarId = car.Id
            };

            _dbDetail.Insert(detail);
        }

        public void Update(DetailModel detailModel)
        {
            var detail = _dbDetail.GetAll().Where(x => x.Id == detailModel.Id).FirstOrDefault(); ;

            detail.DetailName = detailModel.DetailName;
            detail.Cost = detailModel.Cost;

            _dbDetail.Update(detail);
        }

        public DetailModel GetById(int id)
        {
            var detail = GetAll().Where(x => x.Id == id).FirstOrDefault();

            return detail;
        }
    }
}
