using System.Collections.Generic;
using System.Linq;
using Homework11.BLL.Interfaces;
using Homework11.BLL.Models;
using Homework11.DAL.Interfaces;
using Homework11.DAL.Model;

namespace Homework11.BLL.Services
{
    public class DetailService : IDetailService
    {
        IDetailRepository detailModelRepo { get; set; }

        public DetailService(IDetailRepository repository)
        {
            detailModelRepo = repository;
        }

        public IEnumerable<DetailModel> GetAllDetails()
        {
            var detailModels = from detail in detailModelRepo.GetAll()
                             select new DetailModel()
                             {
                                 Id = detail.Id,
                                 CarId = detail.CarId,
                                 DetailName = detail.DetailName
                             };
            return detailModels;
        }

        public void AddNewDetail(DetailModel detailModel)
        {
            var detail = DALObjectCreator.detailObject(detailModel);
            detailModelRepo.Insert(detail);
        }

        public void DeleteDetail(DetailModel detailModel)
        {
            var detail = DALObjectCreator.detailObject(detailModel);
            detailModelRepo.Delete(detail);
        }

        public void UpdateDetail (DetailModel detailModel)
        {
            var detail = DALObjectCreator.detailObject(detailModel);
            detailModelRepo.Update(detail);
        }
    }
}
