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
    public class CategoryController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;

        public CategoryController()
        {

        }

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            var categories = _categoryService.GetAllItems();
            var categoriesModel = _mapper.Map<IEnumerable<CategoryApi>>(categories);
            return View(categoriesModel);
        }

        public ActionResult Details(int id)
        {
            var categoryModel = _categoryService.GetById(id);
            var categoryViewModel = _mapper.Map<CategoryApi>(categoryModel);

            return View(categoryViewModel);
        }
    }
}