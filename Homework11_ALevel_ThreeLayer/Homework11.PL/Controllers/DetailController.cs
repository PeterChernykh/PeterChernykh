using System;
using System.Linq;
using System.Collections.Generic;
using Homework11.PL.Interfaces;
using Homework11.PL.Models;
using Homework11.BLL.Interfaces;
using Homework11.BLL.Models;
using Homework11.BLL.Validation;

namespace Homework11.PL.Controller
{
    public class DetailController : IDetailController
    {
        IDetailService detailViewModelRepo { get; set; }

        public DetailController(IDetailService repository)
        {
            detailViewModelRepo = repository;
        }

        public void AddNewDetail(DetailViewModel detailViewModel)
        {
            var detailModel = BLLObjectCreator.detailModelObject(detailViewModel);
            detailViewModelRepo.AddNewDetail(detailModel);
        }

        public void DeleteDetail(DetailViewModel detailViewModel)
        {
            var detailModel = BLLObjectCreator.detailModelObject(detailViewModel);
            detailViewModelRepo.DeleteDetail(detailModel);
        }

        public IEnumerable<DetailViewModel> GetAllDetails()
        {
            var carsModels = from detailModel in detailViewModelRepo.GetAllDetails()
                             select new DetailViewModel()
                             {
                                 Id = detailModel.Id,
                                 CarId = detailModel.CarId,
                                 DetailName = detailModel.DetailName,
                                 Cost = detailModel.Cost
                             };
            return carsModels;
        }

        public void UpdateDetail(DetailViewModel detailViewModel)
        {
            var detailModel = BLLObjectCreator.detailModelObject(detailViewModel);
            detailViewModelRepo.UpdateDetail(detailModel);
        }

        public DetailViewModel GetCar(int id)
        {
            DetailModel detailModel = detailViewModelRepo.GetCar(id);

            var detailViewModel = new DetailViewModel()
            {
                Id = detailModel.Id,
                CarId = detailModel.CarId,
                DetailName = detailModel.DetailName,
                Cost = detailModel.Cost
            };
            return detailViewModel;
        }
    }
}
