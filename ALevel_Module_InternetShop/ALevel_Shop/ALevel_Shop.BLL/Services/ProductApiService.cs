using ALevel_Shop.BLL.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_Shop.BLL.Services
{
    public interface IProductApiService
    {
        Product GetProducts();
    }

    public class ProductApiService : IProductApiService
    {
        private readonly RestClient _restClient;

        public ProductApiService()
        {
            _restClient = new RestClient("https://localhost:44326");
        }

        public Product GetProducts()
        {
            var urlApiProduct = "api/product";
            var request = new RestRequest(urlApiProduct);

            var responseData = _restClient.Execute<Product>(request, Method.GET).Data;

            return responseData;
        }
    }
}
