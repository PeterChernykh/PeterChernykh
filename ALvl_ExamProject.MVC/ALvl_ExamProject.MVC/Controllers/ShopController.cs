using ALvl_ExamProject.BL.Interfaces;
using ALvl_ExamProject.MVC.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ALvl_ExamProject.MVC.Controllers
{
    public class ShopController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ShopController()
        {

        }

        public ShopController(ICategoryService categoryService, IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _categoryService = categoryService;
            _mapper = mapper;
        }
        // GET: Shop
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Pages");
        }

        public ActionResult PartialCategoryMenu()
        {
            var categoriesBL = _categoryService.GetAll()
                .OrderBy(x => x.Sorting)
                .ToList();

            var categoriesPL = _mapper.Map<IEnumerable<CategoryPL>>(categoriesBL).ToList();

            return PartialView("_PartialCategoryMenu", categoriesPL);
        }
    }
}