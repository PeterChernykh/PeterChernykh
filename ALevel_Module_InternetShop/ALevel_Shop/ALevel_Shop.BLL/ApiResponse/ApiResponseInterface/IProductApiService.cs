using ALevel_Shop.BLL.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_Shop.BLL.ApiResponse
{
    public interface IProductApiService
    {
       IList<ProductModel> GetAllItems();
       ProductModel GetById(int id);
    }
}
