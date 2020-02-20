using System.Collections.Generic;
using System.Linq;
using Homework10.PL.Interfaces;
using Homework10.BLL.Interfaces;
using Homework10.PL.Models;

namespace Homework10.PL.Controllers
{
    public class DetailController : IDetailController
    {
        IDetailService service { get; set; }

        public DetailController(IDetailService service)
        {
            this.service = service;
        }
        
        public IEnumerable<DetailViewModel> GetAll()
        {
            var allDetail = from detailModel in service.GetAll()
                            select new DetailViewModel
                            {
                                Id = detailModel.Id,
                                CarId = detailModel.CarId,
                                DetailName = detailModel.DetailName,
                                Cost = detailModel.Cost
                            };
            return allDetail;
        }
    }
}
