using ALvl_ExamProject.BL.Interfaces;
using ALvl_ExamProject.BL.Models;
using ALvl_ExamProject.MVC.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace ALvl_ExamProject.MVC.Areas.Admin.Controllers
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

        //POST: Admin/Shop
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

        public ActionResult DeleteCategory(int id)
        {
            var category = _categoryService.GetById(id);

            _categoryService.Remove(category.Id);

            TempData["DeletedCatSucces"] = "The category has been deleted.";

            return RedirectToAction("GetAllCategories");
        }

        //POST: Admin/Shop/RenameCategory/Id
        [HttpPost]
        public string RenameCategory(string newCatName, int id)
        {
            if (_categoryService.GetAll().Any(x => x.Name == newCatName))
            {
                return "titletaken";
            }

            var category = _categoryService.GetAll().FirstOrDefault(x => x.Id == id);

            category = new CategoryBL
            {
                Id = category.Id,
                Name = newCatName,
                Slug = category.Slug,
                Sorting = category.Sorting
            };

            _categoryService.Update(category);


            return "Updated";
        }

        [HttpGet]
        public ActionResult CreateProduct()
        {

            ProductPL product = new ProductPL();

            product.Categories = new SelectList(_categoryService.GetAll().ToList(), "Id", "Name");

            return View(product);
        }

        public ActionResult CreateProduct(ProductPL productPL, HttpPostedFileBase imageUpload)
        {
            if (!ModelState.IsValid)
            {
                productPL.Categories = new SelectList(_categoryService.GetAll().ToList(), "Id", "Name");

                return View(productPL);
            }

            if (_productService.GetAll().Any(x => x.Name == productPL.Name))
            {
                productPL.Categories = new SelectList(_categoryService.GetAll().ToList(), "Id", "Name");

                ModelState.AddModelError("", "Such name is already existing in the system");
                return View(productPL);
            };

            var productBL = _mapper.Map<ProductBL>(productPL);

            _productService.Add(productBL);

            TempData["CreateProductSuccess"] = "The product has been added.";

            productBL = _productService.GetAll().FirstOrDefault(x => x.Name == productPL.Name); 

            var imageDirectory = System.Configuration.ConfigurationManager.AppSettings["ImageFolder"];

            var pathToImg = Path.Combine(imageDirectory.ToString(), "Products\\");
            var pathToThumb = Path.Combine(imageDirectory.ToString(), "Products\\Thumbs");


            if (imageUpload != null && imageUpload.ContentLength > 0)
            {
                string extention = imageUpload.ContentType.ToLower();

                if (extention != "image/jpg" &&
                    extention != "image/jpeg" &&
                    extention != "image/pjpeg" &&
                    extention != "image/gif" &&
                    extention != "image/x-png" &&
                    extention != "image/png")
                {
                    productPL.Categories = new SelectList(_categoryService.GetAll().ToList(), "Id", "Name");
                    ModelState.AddModelError("", "The image has incorrect extention");
                    return View(productPL);
                }

                string imageName = imageUpload.FileName;

                productBL.ImagePath = imageName;

                _productService.Update(productBL);

                var originalImgPath = string.Format($"{pathToImg}\\{imageName}");
                var thumbImgPath = string.Format($"{pathToThumb}\\{imageName}");

                imageUpload.SaveAs(originalImgPath); //TODO: replace to Business Logic

                WebImage img = new WebImage(imageUpload.InputStream);
                img.Resize(150, 150);
                img.Save(thumbImgPath);

            }

            return RedirectToAction("CreateProduct");
        }
    }
}