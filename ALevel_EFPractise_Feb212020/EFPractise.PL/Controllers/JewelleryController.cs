using EFPractise.BLL.Interfaces;
using EFPractise.BLL.Models;
using EFPractise.BLL.Repositories;
using EFPractise.PL.Interfaces;
using System.Collections.Generic;

namespace EFPractise.PL.Controllers
{
    public class JewelleryController : IJewelleryController
    {
        private readonly IJewelleryService _jewelleryService;

        public JewelleryController()
        {
            _jewelleryService = new JewelleryService();
        }

        public void Create(JewelleryController model)
        {
            var jewelleryModel = new JewelleryModel
            {
                Name = "Igor",
                Price = 1999,
                ManufacturerModel = new ManufactorerModel
                {
                    ContryId = 1,
                    Name = "Igor and Co",
                    LicenseNumber = 947593475,
                },

                Gemstones = new List<GemstoneModel>
                {
                    new GemstoneModel 
                    {
                    Color = "BLACK",
                    Name = "VLAD BLACK",
                    Price = 665,
                    Type = Common.GemStoneTypeEnum.Diamond
                    },
                    new GemstoneModel
                    {
                    Color = "RED",
                    Name = "VLAD RED",
                    Price = 695,
                    Type = Common.GemStoneTypeEnum.Diamond
                    },
                    new GemstoneModel
                    {
                    Color = "GREEN",
                    Name = "VLAD GREEN",
                    Price = 365,
                    Type = Common.GemStoneTypeEnum.Diamond
                    },
                }
            };
            _jewelleryService.Create(jewelleryModel);
        }
    }
}
