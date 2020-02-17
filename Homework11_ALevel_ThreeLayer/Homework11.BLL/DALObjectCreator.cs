using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework11.DAL.Model;
using Homework11.BLL.Models;

namespace Homework11.BLL
{
    public class DALObjectCreator
    {
        public static Detail detailObject(DetailModel detailModel)
        {
            Detail detail = new Detail
            {
                Id = detailModel.Id,
                CarId = detailModel.CarId,
                DetailName = detailModel.DetailName

            };

            return detail;
        }

        public static Car carObject (CarModel carModel)
        {
            Car car = new Car
            {
                Id = carModel.Id,
                Model = carModel.Model

            };

            return car;
        }
    }
}
