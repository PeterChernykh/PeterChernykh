using EFPractise.BLL.Interfaces;
using EFPractise.BLL.Models;
using EFPractise.DAL.IRepositories;
using EFPractise.DAL.Models;
using EFPractise.DAL.Repositories;
using System;
using System.Linq;
namespace EFPractise.BLL.Repositories
{
    public class JewelleryService: IJewelleryService
    {
        private readonly IJewelleryRepository _jewelleryRepository;

        public JewelleryService()
        {
            _jewelleryRepository = new JewelleryRepository();
        }

        public void Create (JewelleryModel model)
        {
            var jewellery = new Jewellery
            {
                Name = model.Name,
                Price = model.Price,
                Manufactorer = new Manufacturer
                {
                    ContryId = model.ManufacturerModel.ContryId,
                    Name = model.ManufacturerModel.Name,
                    DataCreated = DateTime.Now,
                    LicenseNumber = model.ManufacturerModel.LicenseNumber

                },
                ManufactorerId = model.ManufacturerModel.Id,
                Gemstones = model.Gemstones.Select(x => new Gemstone
                {
                    Color = x.Color,
                    Name = x.Name,
                    GemstoneTypeId = (int)x.Type,
                    Price = x.Price
                }).ToList()

            };

            _jewelleryRepository.Create(jewellery);

        }
    }
}
