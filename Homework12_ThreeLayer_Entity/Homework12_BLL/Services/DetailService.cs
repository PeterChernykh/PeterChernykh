using Homework12_BLL.Interfaces;
using Homework12_BLL.Models;
using Homework12_DAL.Interfaces;
using Homework12_DAL.Models;
using Homework12_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12_BLL.Services
{
    public class DetailService: IDetailService
    {
        private readonly IRepository<Car> _dbCar;
        private readonly IRepository<Detail> _dbDetail;

        public DetailService()
        {
            _dbDetail = new DetailRepository();
            _dbCar = new CarRepository();
        }

        public IEnumerable<DetailModel> GetAll()
        {
            var cars = _dbCar.GetAll();

            var details = from detail in _dbDetail.GetAll()
                          select new DetailModel
                          {
                              DetailName = detail.DetailName,
                              Cost = detail.Cost,
                              CarModel = new CarModel
                              {
                                  Id = detail.Car.Id,
                                  Model = detail.Car.Model
                              },
                              CarId = detail.CarId,
                       };

            return details;
        }
    }
}
