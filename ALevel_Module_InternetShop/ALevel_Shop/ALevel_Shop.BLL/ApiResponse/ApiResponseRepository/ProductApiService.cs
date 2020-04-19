using ALevel_Shop.BLL.ApiResponse;
using ALevel_Shop.BLL.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_Shop.BLL.Services
{

    public class ProductApiService : IProductApiService
    {
        private readonly RestClient _restClient;
        string urlApi = "api/product";

        public ProductApiService()
        {
            _restClient = new RestClient("http://alevelshop.shop/");
        }

        public IList<ProductModel> GetAllItems()
        {
            var request = new RestRequest(urlApi);
            var resposeData = _restClient.Execute<List<ProductModel>>(request, Method.GET).Data;
            return resposeData;
        }

        public ProductModel GetById(int id)
        {
            StringBuilder urlApiId = new StringBuilder($"{urlApi}"+"/"+$"{id}");

            var request = new RestRequest(urlApi);
            var resposeData = _restClient.Execute<List<ProductModel>>(request, Method.GET).Data;

            var responseItem = resposeData.FirstOrDefault(x => x.Id == id);

            return responseItem;
        }
    }
}
