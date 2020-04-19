using ALevel_Shop.BLL.Interfaces;
using ALevel_Shop_MVC.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ALevel_Shop_MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public ProductController()
        {

        }

        public ProductController(IProductService service, IMapper mapper, ICategoryService categoryService)
        {
            _mapper = mapper;
            _productService = service;
            _categoryService = categoryService;
        }

        public ActionResult Index()
        {
              var listProducts = _productService.GetAllItems();
            var productsModel = _mapper.Map<IEnumerable<ProductApi>>(listProducts);
            return View(productsModel);
        }

        public ActionResult Details(int id)
        {
            var products = _productService.GetById(id);
            var productsModel = _mapper.Map<ProductApi>(products);

            return View(productsModel);
        }

        public ActionResult ProductByCategory(int? categoryId)
        {
            var products = _productService.GetAllItems();
            var productsModel = _mapper.Map<IEnumerable<ProductApi>>(products);

            if (categoryId != null&& categoryId != 0)
            {
                productsModel = productsModel.Where(x => x.CategoryApi.Id == categoryId);
            }

            var categories = _categoryService.GetAllItems();
            var categoriesModel = _mapper.Map<IEnumerable<CategoryApi>>(categories);

            ProductsList productsList = new ProductsList
            {
                Products = productsModel,
                Categories = new SelectList(categoriesModel, "Id", "Name ")
            };

            return View(productsList);
        }
    }
}