using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework12_BLL.Interfaces;
using Homework12_BLL.Models;
using Homework12_Common;
using Homework12_DAL.Interfaces;
using Homework12_DAL.Models;
using Homework12_DAL.Repositories;

namespace Homework12_BLL.Services
{
    public class ManufacturerService : IManufacturerService
    {
        private readonly IRepository<Manufacturer> _dbManuf;

        public ManufacturerService()
        {
            _dbManuf = new ManufacturerRepository();
        }

        public IEnumerable<ManufacturerModel> GetAll()
        {
            var manuf = from manufacturer in _dbManuf.GetAll()
                        select new ManufacturerModel
                        {
                          Id = manufacturer.Id,
                          Name = manufacturer.Name,
                          CarsModel = manufacturer.Cars.Select(x => new CarModel
                          {
                              Id = x.Id,
                              Model = x.Model,
                              ManufacturerId = x.ManufacturerId,
                              Details = x.Details.Select (y => new DetailModel
                              {
                                  Id = y.Id,
                                  Cost = y.Cost,
                                  Type = (DetailTypeEnum)y.DetailTypeId,
                                  ManufacturerId = y.ManufacturerId,
                              }),
                          }),
                          DetailsModel = manufacturer.Details.Select (x => new DetailModel
                          {
                              Id = x.Id,
                              Name = x.Name,
                              Cost = x.Cost,
                              Type = (DetailTypeEnum)x.DetailTypeId,
                              ManufacturerId = x.ManufacturerId
                          })
                        };
            return manuf;
        }

        public int checkManufactorer(int  id)
        {
            var chosenManuf = _dbManuf.GetById(id);

            var manufacturers = _dbManuf.GetAll();

            var deniedManufacturer = manufacturers.FirstOrDefault(x => x.Id == 1);

            if (chosenManuf == deniedManufacturer)
            {
                throw new NotImplementedException();
            }
            else
            {
                return chosenManuf.Id;
            }
        }

        public ManufacturerModel GetById(int id)
        {
            var manuf = _dbManuf.GetById(id);

            var manufModel =  new ManufacturerModel
                        {
                            Id = manuf.Id,
                            Name = manuf.Name,
                            CarsModel = manuf.Cars.Select(x => new CarModel
                            {
                                Id = x.Id,
                                Model = x.Model,
                                ManufacturerId = x.ManufacturerId,
                                Details = x.Details.Select(y => new DetailModel
                                {
                                    Id = y.Id,
                                    Cost = y.Cost,
                                    Type = (DetailTypeEnum)y.DetailTypeId,
                                    ManufacturerId = y.ManufacturerId,
                                }),
                            }),
                            DetailsModel = manuf.Details.Select(x => new DetailModel
                            {
                                Id = x.Id,
                                Name = x.Name,
                                Cost = x.Cost,
                                Type = (DetailTypeEnum)x.DetailTypeId,
                                ManufacturerId = x.ManufacturerId
                            })
                        };
            return manufModel;
        }
    }
}
