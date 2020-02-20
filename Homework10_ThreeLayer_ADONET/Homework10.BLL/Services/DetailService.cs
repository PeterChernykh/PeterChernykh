using System.Collections.Generic;
using System.Linq;
using Homework10.DAL.Models;
using Homework10.DAL.Interfaces;
using Homework10.BLL.Interfaces;
using Homework10.BLL.Models;

namespace Homework10.BLL.Services
{
    public class DetailService : IDetailService
    {
        IRepository<Detail> repository { get; set; }

        public DetailService (IRepository<Detail> repository)
        {
            this.repository = repository;
        }

        public IEnumerable<DetailModel> GetAll()
        {
            var allDetail = from detail in repository.GetAll()
                             select new DetailModel
                             {
                                 Id = detail.Id,
                                 CarId = detail.CarId,
                                 DetailName = detail.DetailName,
                                 Cost = detail.Cost
                             };
            return allDetail;
        }
    }
}