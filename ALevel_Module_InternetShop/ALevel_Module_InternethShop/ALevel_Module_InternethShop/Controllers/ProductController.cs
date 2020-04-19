using ALevel_InternetShop.BLL.Interfaces;
using ALevel_InternetShop.BLL.Models;
using ALevel_Module_InternethShop.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ALevel_Module_InternethShop.Controllers
{
    public class ProductController : ApiController
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService authorService, IMapper mapper)
        {
            _mapper = mapper;
            _productService = authorService;
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(_productService.GetAll());
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            return Ok(_productService.GetById(id));
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody]ProductApiModel productApiModel)
        {
            var productModel = _mapper.Map<ProductModel>(productApiModel);

            _productService.Add(productModel);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Put([FromBody]ProductApiModel productApiModel)
        {
            var productModel = _mapper.Map<ProductModel>(productApiModel);

            _productService.Update(productModel);

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _productService.Remove(id);

            return Ok();
        }


    }
}
