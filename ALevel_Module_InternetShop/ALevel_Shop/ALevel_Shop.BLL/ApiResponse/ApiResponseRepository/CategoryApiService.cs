using ALevel_Shop.BLL.ApiResponse.ApiResponseInterface;
using ALevel_Shop.BLL.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_Shop.BLL.ApiResponse.ApiResponseRepository
{
    public class CategoryApiService : ICategoryApiService
    {
        private readonly RestClient _restClient;
        string urlApi = "api/category";

        public CategoryApiService()
        {
            _restClient = new RestClient("http://alevelshop.shop/");
        }

        public IList<CategoryModel> GetAllItems()
        {
            var request = new RestRequest(urlApi);
            var resposeData = _restClient.Execute<List<CategoryModel>>(request, Method.GET).Data;
            return resposeData;
        }

        public CategoryModel GetById(int id)
        {
            StringBuilder urlApiId = new StringBuilder($"{urlApi}" + "/" + $"{id}");

            var request = new RestRequest(urlApi);
            var resposeData = _restClient.Execute<List<CategoryModel>>(request, Method.GET).Data;

            var responseItem = resposeData.FirstOrDefault(x => x.Id == id);

            return responseItem;
        }
    }
}
