using Homework12_BLL.Interfaces;
using Homework12_BLL.Models;
using Homework12_BLL.Services;
using Homework12_DAL.Repositories;
using Homework12_PL.Interfaces;
using Homework12_PL.Models;
using System.Collections.Generic;
using System.Linq;

namespace Homework12_PL.Controller
{
    public class DetailController : IDetailController
    {
        private readonly IDetailService _dbDetail;

        public DetailController()
        {
            _dbDetail = new DetailService();
        }

        public void Add(DetailViewModel detailViewModel)
        {
            var detail = new DetailModel
            {
<<<<<<< HEAD
                Name = "Boom Wheel",
=======
                DetailName = "Boom Wheel",
>>>>>>> b314a4ae73474be64f46208452be66b64950d2d2
                Cost = 45454,
                CarId = 3
            };
            _dbDetail.Add(detail);
        }

        public void Delete(int id)
        {
            _dbDetail.Delete(id);
        }

        public IEnumerable<DetailViewModel> GetAll()
        {
            var detailViewModel = from detail in _dbDetail.GetAll()
                                  select new DetailViewModel
                                  {
                                      Name = detail.Name,
                                      Cost = detail.Cost,
                                      CarViewModel = new CarViewModel
                                      {
                                          Id = detail.CarModel.Id,
                                          Model = detail.CarModel.Model,
                                      },
                                      CarId = detail.CarId
                                  };
            return detailViewModel.ToList();
        }

        public void Update(DetailViewModel detailViewModel)
        {
            var detailModel = new DetailModel
            {
                Id = 1,
<<<<<<< HEAD
                Name = "PeterDetail",
=======
                DetailName = "PeterDetail",
>>>>>>> b314a4ae73474be64f46208452be66b64950d2d2
                Cost = 000000,
            };

            _dbDetail.Update(detailModel);
        }

        public DetailViewModel GetById(int id)
        {
            var detailModel = _dbDetail.GetById(id);

            var detailViewModel = new DetailViewModel
            {
                Id = detailModel.Id,
<<<<<<< HEAD
                Name = detailModel.Name,
=======
                DetailName = detailModel.DetailName,
>>>>>>> b314a4ae73474be64f46208452be66b64950d2d2
                Cost = detailModel.Cost,
                CarViewModel = new CarViewModel
                {
                    Id = detailModel.CarModel.Id,
                    Model = detailModel.CarModel.Model,
<<<<<<< HEAD
                }
=======
                }    
>>>>>>> b314a4ae73474be64f46208452be66b64950d2d2
            };

            return detailViewModel;
        }
    }
}