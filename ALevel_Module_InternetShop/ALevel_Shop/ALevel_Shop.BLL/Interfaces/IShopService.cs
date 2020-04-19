using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_Shop.BLL.Interfaces
{
    public interface IShopService<ModelBL> where ModelBL : class
    {
        ModelBL GetById(int id);
        IEnumerable<ModelBL> GetAll();
    }
}
