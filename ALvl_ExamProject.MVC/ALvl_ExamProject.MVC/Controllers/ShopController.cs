using ALvl_ExamProject.BL.Interfaces;
using ALvl_ExamProject.MVC.Models;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ALvl_ExamProject.MVC.Controllers
{
    [AllowAnonymous]
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

        public ActionResult Category(string name)
        {
            var categoryBL = _categoryService.GetAll().FirstOrDefault(x => x.Slug == name);

            int categoryId = categoryBL.Id;

            var productsBL = _productService.GetAll().Where(x => x.CategoryId == categoryId).ToList();

            var productCategory = _productService.GetAll().FirstOrDefault(x => x.CategoryId == categoryId);

            if (productCategory == null)
            {
                var categoryName = _categoryService.GetAll().FirstOrDefault(x => x.Slug == name);

                ViewBag.CategoryName = categoryName;
            }
            else
            {
                ViewBag.CategoryName = productCategory.CategoryBL.Name;
            }

            var productsPL = _mapper.Map<IEnumerable<ProductPL>>(productsBL);
            return View(productsPL);
        }

        [ActionName("product-details")]
        public ActionResult Product(string name)
        {
            var productsBL = _productService.GetAll();

            if(!productsBL.Any(x => x.Slug == name))
            {
                return RedirectToAction("Index", "Shop");
            }

            var productBL = productsBL.FirstOrDefault(x => x.Slug == name);

            int id = productBL.Id;

            var productPL = _mapper.Map<ProductPL>(productBL);

            return View("Product", productPL);
        }
    }
}