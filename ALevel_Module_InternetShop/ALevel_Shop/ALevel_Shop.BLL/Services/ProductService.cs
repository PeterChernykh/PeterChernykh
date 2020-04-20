using ALevel_Shop.BLL.ApiResponse;
using ALevel_Shop.BLL.Interfaces;
using ALevel_Shop.BLL.Models;
using ALevel_Shop.BLL.Services.ApiResponseService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_Shop.BLL.Services
{
    public class ProductService : ProductApiService, IProductService
    {
        public ProductService(IProductApiService apiService)
        {

        }

        public IEnumerable<ProductModel> GetByCategory(int id)
        {
            var products = GetAllItems().Where(x => x.CategoryModel.Id == id);

            return products;
        }
    }
}
