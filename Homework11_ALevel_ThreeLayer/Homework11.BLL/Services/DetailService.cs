using System.Collections.Generic;
using System.Linq;
using Homework11.BLL.Interfaces;
using Homework11.BLL.Models;
using Homework11.DAL.Interfaces;
using Homework11.DAL.Models;
using Homework11.BLL.Validation;

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
                                 DetailName = detail.DetailName,
                                 Cost = detail.Cost
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

        public DetailModel GetCar(int id)
        {
            Detail detail = detailModelRepo.GetCar(id);

            //if(detail.DetailName == null)
            //{
            //    throw new ValidationException("The detail has been lost, the new detail is required","");
            //}

            var detailsModel = new DetailModel()
            {
                Id = detail.Id,
                CarId = detail.CarId,
                DetailName = detail.DetailName,
                Cost = detail.Cost
            };
            return detailsModel;
        }
    }
}
