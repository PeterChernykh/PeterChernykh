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
        public ActionResult Categories()
        {
            var categoriesBL = _categoryService.GetAll();

            var categoriesPL = _mapper.Map<IEnumerable<CategoryPL>>(categoriesBL);

            return View(categoriesPL);
        }

        [HttpPost]
        public string AddNewCategory(string catName)
        {
            string id;

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

            id = categoryBL.Id.ToString();

            return id;
        }

        public void ReorderPages(int[] id)
        {
            int count = 1;
            //Реализовать дефолтный список 
            //сортировка для кажд стр
            CategoryBL neededCategory;

            foreach (var neededId in id)
            {
               neededCategory = _categoryService.GetById(neededId);
               neededCategory.Sorting = count;

                _categoryService.Update(neededCategory);

                count++;
            }
        }
    }
}