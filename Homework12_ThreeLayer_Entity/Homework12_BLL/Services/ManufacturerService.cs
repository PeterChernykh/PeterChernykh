﻿using System;
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
        private readonly IManufacturer _dbManufacturer;

        public ManufacturerService()
        {
            _dbManufacturer = new ManufacturerRepository();

        }

        public IEnumerable<ManufacturerModel> GetAll()
        {
            var manuf = from manufacturer in _dbManufacturer.GetAll()
                        select new ManufacturerModel
                        {
                            Id = manufacturer.Id,
                            Name = manufacturer.Name,
                            CarsModel = manufacturer.Cars.Select(x => new CarModel
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
                            DetailsModel = manufacturer.Details.Select(x => new DetailModel
                            {
                                Id = x.Id,
                                CarId = x.CarId,
                                Name = x.Name,
                                Cost = x.Cost,
                                Type = (DetailTypeEnum)x.DetailTypeId,
                                ManufacturerId = x.ManufacturerId
                            })
                        };
            return manuf;
        }

        public int CheckManufacturer(int id, string name)
        {
            var deniedManufacturer = _dbManufacturer.DeniedManufacturer();

            if (deniedManufacturer.Id == id)
            {
                throw new NotImplementedException();
            }
            else
            {
                try
                {
                    var newManufacturer = GetById(id);

                    return id;
                }
                catch
                {
                    var newManufacturer = CheckName(name);
                    return newManufacturer.Id;
                }
            }
        }

        public ManufacturerModel GetById(int id)
        {
            var manuf = _dbManufacturer.GetById(id);

            var manufModel = new ManufacturerModel
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

        public void Add(ManufacturerModel manufacturerModel)
        {
            var newManufacturer = new Manufacturer
            {
                Id = manufacturerModel.Id,
                Name = manufacturerModel.Name
            };
        }

        public Manufacturer CheckName(string name)
        {
            var allManufacturers = _dbManufacturer.GetAll();
            var manufacturerName = allManufacturers.FirstOrDefault(x => x.Name == name);

            if (manufacturerName == null)
            {
                var newManufacturer = new Manufacturer
                {
                    Name = name
                };

                _dbManufacturer.Insert(newManufacturer);

                manufacturerName = newManufacturer;
            }

            return manufacturerName;
        }

        public ManufacturerModel GetMostExpensive()
        {

            var result = new ManufacturerModel
            {
                //Name = manufWithCar.Name,
                //CarsModel = manufWithCar.CarsModel.Select(x => new CarModel
                //{
                //    Id = x.Id,
                //    Model = x.Model,
                //    ManufacturerId = x.ManufacturerId,
                //    Details = x.Details.Select(y => new DetailModel
                //    {
                //        Id = y.Id,
                //        Cost = y.Cost,
                //        Type = (DetailTypeEnum)y.Type,
                //        ManufacturerId = y.ManufacturerId,
                //    }),
                //}),
                //DetailsModel = manufWithCar.DetailsModel.Select(x => new DetailModel
                //{
                //    Id = x.Id,
                //    Name = x.Name,
                //    Cost = x.Cost,
                //    Type = (DetailTypeEnum)x.Type,
                //    ManufacturerId = x.ManufacturerId
                //})
            };

            return result;
        }
    }
}