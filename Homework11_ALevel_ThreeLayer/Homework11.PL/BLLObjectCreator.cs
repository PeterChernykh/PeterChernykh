using System;
using System.Collections.Generic;
using System.Linq;
using Homework11.BLL.Models;
using Homework11.PL.Models;


namespace Homework11.PL
{
    public static class BLLObjectCreator
    {
        public static DetailModel detailModelObject(DetailViewModel detailViewModel)
        {
            DetailModel detailModel = new DetailModel
            {
                Id = detailViewModel.Id,
                CarId = detailViewModel.CarId,
                DetailName = detailViewModel.DetailName

            };

            return detailModel;
        }

        public static CarModel carModelObject(CarViewModel carViewModel)
        {
            CarModel carModel = new CarModel
            {
                Id = carViewModel.Id,
                Model = carViewModel.Model

            };

            return carModel;
        }
    }
}
