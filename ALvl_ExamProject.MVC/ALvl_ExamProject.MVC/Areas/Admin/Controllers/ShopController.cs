using ALvl_ExamProject.BL.Interfaces;
using ALvl_ExamProject.BL.Models;
using ALvl_ExamProject.MVC.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ALvl_ExamProject.MVC.Areas.Admin.Controllers
{
    public class ShopController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public ShopController()
        {

        }



        public ShopController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/Shop
        public ActionResult GetAllCategories()
        {
            var categoriesBL = _categoryService.GetAll();

            var categoriesPL = _mapper.Map<IEnumerable<CategoryPL>>(categoriesBL);

            return View(categoriesPL);
        }

        [HttpPost]
        public string AddNewCategory(string catName)
        {

            if (_categoryService.GetAll().Any(x => x.Name == catName))
            {
                return "titletaken";
            }

            CategoryPL categoryPL = new CategoryPL()
            {
                Name = catName,
                Slug = catName.Replace(" ", "-").ToLower(),
                Sorting = 100
            };

            var categoryBL = _mapper.Map<CategoryBL>(categoryPL);

            _categoryService.Add(categoryBL);

            var addedcategory = _categoryService.GetAll().FirstOrDefault(x => x.Name == categoryBL.Name);

            return addedcategory.Id.ToString();
        }

        public void ReorderCategories(int[] id)
        {
            int count = 1;

            CategoryBL neededCategory;

            foreach (var neededId in id)
            {
               neededCategory = _categoryService.GetAll().FirstOrDefault(x => x.Id == neededId);
               neededCategory.Sorting = count;

                _categoryService.Update(neededCategory);

                count++;
            }
        }
    }
}