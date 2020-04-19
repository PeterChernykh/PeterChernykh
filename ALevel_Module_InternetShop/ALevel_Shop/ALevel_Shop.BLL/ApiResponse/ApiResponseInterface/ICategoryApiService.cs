using ALevel_Shop.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_Shop.BLL.ApiResponse.ApiResponseInterface
{
    public interface ICategoryApiService
    {
        IList<CategoryModel> GetAllItems();
        CategoryModel GetById(int id);
    }
}
