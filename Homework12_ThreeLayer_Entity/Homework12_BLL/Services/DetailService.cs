using Homework12_BLL.Interfaces;
using Homework12_BLL.Models;
using Homework12_DAL.Interfaces;
using Homework12_DAL.Models;
using Homework12_DAL.Repositories;
using System.Collections.Generic;
using System.Linq;
using Homework12_Common;

namespace Homework12_BLL.Services
{
    public class DetailService : IDetailService
    {
        private readonly IRepository<Detail> _dbDetail;

        public DetailService()
        {
            _dbDetail = new DetailRepository();
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
                              CarId = detail.CarId,
                              Type = (DetailTypeEnum)detail.DetailTypeId,
                              Manufacturer = new ManufacturerModel
                              {
                                  Id = detail.Manufacturer.Id,
                                  Name = detail.Manufacturer.Name
                              }
                          };


            return details.ToList();
        }

        public void Delete(int id)
        {
            _dbDetail.Delete(id);
        }

        public void Add(DetailModel detailModel)
        {

            var detail = new Detail
            {
                Name = detailModel.Name,
                Cost = detailModel.Cost,
                CarId = detailModel.CarId,
                Manufacturer = new Manufacturer
                { 
                    Id = detailModel.ManufacturerId
                }  
            };

            _dbDetail.Insert(detail);
        }

        public void Update(DetailModel detailModel)
        {
            var detail = new Detail
            {
                Id = detailModel.Id,

                Name = detailModel.Name,
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
                Name = detail.Name,
                Cost = detail.Cost,
                CarModel = new CarModel
                {
                    Id = detail.Car.Id,
                    Model = detail.Car.Model,
                },
                Type = (DetailTypeEnum)detail.DetailTypeId,
                Manufacturer = new ManufacturerModel
                {
                    Id = detail.Manufacturer.Id,
                    Name = detail.Manufacturer.Name
                }
            };

            return detailModel;
        }
    }
}