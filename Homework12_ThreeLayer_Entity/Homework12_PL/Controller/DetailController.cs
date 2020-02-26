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
                DetailName = "Diamond Stering Wheel",
                Cost = 1000000,
                CarId = 1
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
                                      DetailName = detail.DetailName,
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
                DetailName = "Rolls",
                Cost = 436743,
            };

            _dbDetail.Update(detailModel);
        }

        public DetailViewModel GetById(int id)
        {
            var detail = GetAll().Where(x => x.Id == id).FirstOrDefault();

            return detail;
        }
    }
}
