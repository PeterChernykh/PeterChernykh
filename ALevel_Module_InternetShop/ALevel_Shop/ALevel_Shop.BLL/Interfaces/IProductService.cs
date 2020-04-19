using ALevel_Shop.BLL.ApiResponse;
using ALevel_Shop.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_Shop.BLL.Interfaces
{
    public interface IProductService : IProductApiService
    {
        IEnumerable<ProductModel> GetByCategory(int id);
    }
}
