using HomeworkBlog_ALevel.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using HomeworkBlog.Models;
using HomeworkBlog_ALevel.BLL.Models;

namespace HomeworkBlog.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        // GET: Category
        public ActionResult Index()
        {
            var listBLCategory = _categoryService.GetAll();
            var categories = _mapper.Map<IEnumerable<CategoryViewModel>>(listBLCategory);
            return View();
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            var categoryModel = _categoryService.GetById(id);
            var categoryViewModel = _mapper.Map<CategoryViewModel>(categoryModel);

            return View(categoryViewModel);
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(CategoryViewModel categoryInfo)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var categoryModel = _mapper.Map<CategoryModel>(categoryInfo);
                _categoryService.Add(categoryModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CategoryViewModel categoryUpdate)
        {
            
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                var categoryModel = _mapper.Map<CategoryModel>(categoryUpdate);
                _categoryService.Update(categoryModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete()
        {
            return View();
        }

        // POST: Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                _categoryService.Remove(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
