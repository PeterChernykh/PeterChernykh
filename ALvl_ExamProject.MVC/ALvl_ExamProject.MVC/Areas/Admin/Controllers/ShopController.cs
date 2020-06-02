using ALvl_ExamProject.BL.Interfaces;
using ALvl_ExamProject.BL.Models;
using ALvl_ExamProject.MVC.Areas.Admin.Models;
using ALvl_ExamProject.MVC.Models;
using AutoMapper;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using PagedList;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ALvl_ExamProject.MVC.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    public class ShopController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        private readonly IOrderDetailService _orderDetailService;
        private readonly IOrderService _orderService;

        public ShopController(ICategoryService categoryService, IProductService productService, IMapper mapper, IOrderDetailService orderDetailService, IOrderService orderService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _mapper = mapper;
            _orderDetailService = orderDetailService;
            _orderService = orderService;
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

            if (ImageValidation(imageUpload, productPL))
            {
                var imageDirectory = new DirectoryInfo(string.Format($"{Server.MapPath(@"\")}Images\\Uploads"));

                var pathToImg = Path.Combine(imageDirectory.ToString(), "Products\\");
                var pathToThumb = Path.Combine(imageDirectory.ToString(), "Products\\Thumbs");

                if (!Directory.Exists(pathToImg))
                {
                    Directory.CreateDirectory(pathToImg);
                }
                if (!Directory.Exists(pathToThumb))
                {
                    Directory.CreateDirectory(pathToThumb);
                }

                string imageName = imageUpload.FileName;

                productBL.ImagePath = imageName;

                _productService.Update(productBL);

                var originalImgPath = string.Format($"{pathToImg}\\{imageName}");
                var thumbImgPath = string.Format($"{pathToThumb}\\{imageName}");

                imageUpload.SaveAs(originalImgPath);

                WebImage img = new WebImage(imageUpload.InputStream);
                img.Resize(150, 150);
                img.Save(thumbImgPath);
            }
            else
            {
                TempData["ImageWasNotAdded"] = "Please add images with the next extentions: jpg, jpeg, gif, png.";
            }

            return RedirectToAction("CreateProduct");
        }

        [HttpGet]
        public ActionResult GetAllProducts( int? categoryId)
        {

            var ProductsBL = _productService.GetAll();

            var ProductPL = _mapper.Map<IEnumerable<ProductPL>>(ProductsBL);

            var listProducts = ProductPL
                .Where(x => categoryId == null || categoryId == 0 || x.CategoryId == categoryId)
                .ToList();

            ViewBag.Categories = new SelectList(_categoryService.GetAll().ToList(), "Id", "Name");

            ViewBag.ChosenCategory = categoryId.ToString();

            return View(listProducts);
        }

        [ChildActionOnly]
        public ActionResult PaginatedPage(int? page, List<ProductPL> listProducts)
        {
            var pageNo = page ?? 1;

            var singlePage = listProducts.ToPagedList(pageNo, 3);

            return PartialView(singlePage);

        }

        [HttpGet]
        public ActionResult EditProduct(int id)
        {
            var productBL = _productService.GetById(id);

            if (productBL == null)
            {
                return Content("Such product doesn't exist");
            }

            var productPL = _mapper.Map<ProductPL>(productBL);

            productPL.Categories = new SelectList(_categoryService.GetAll(), "Id", "Name");

            productPL.GalleryImage = Directory
                .EnumerateFiles(Server.MapPath("~/Images/Uploads/Products/Thumbs"))
                .Select(fileName => Path.GetFileName(fileName));

            return View(productPL);
        }

        [HttpPost]
        public ActionResult EditProduct(ProductPL productPL, HttpPostedFileBase imageUpload)
        {

            productPL.Categories = new SelectList(_categoryService.GetAll().ToList(), "Id", "Name");

            productPL.GalleryImage = Directory
                .EnumerateFiles(Server.MapPath("~/Images/Uploads/Products/Thumbs/"))
                .Select(x => Path.GetFileName(x));

            if (!ModelState.IsValid)
            {
                return View(productPL);
            }

            if(_productService.GetAll().Where(x => x.Id != productPL.Id).Any(x => x.Name == productPL.Name))
            {
                ModelState.AddModelError("", "Product with such name is already existing in the system");

                return View(productPL);
            }

            var productBL = _mapper.Map<ProductBL>(productPL);

            _productService.Update(productBL);

            TempData["ProductEditedSuccess"] = "The product has been edited";
            if (imageUpload == null)
            {
                TempData["ProductEditedWOImage"] = "Please pay  attention. The image wasn't modified ";
            }
            else if (ImageValidation(imageUpload, productPL))
            {

                var imageDirectory = new DirectoryInfo(string.Format($"{Server.MapPath(@"\")}Images\\Uploads"));

                var pathToImg = Path.Combine(imageDirectory.ToString(), "Products\\");
                var pathToThumb = Path.Combine(imageDirectory.ToString(), "Products\\Thumbs");

                DirectoryInfo ptImg = new DirectoryInfo(pathToImg);
                DirectoryInfo ptThumb = new DirectoryInfo(pathToThumb);

                foreach (var fileImg in ptImg.GetFiles())
                {
                    fileImg.Delete();
                }

                foreach (var fileTmb in ptThumb.GetFiles())
                {
                    fileTmb.Delete();
                }

                string imageName = imageUpload.FileName;

                productBL.ImagePath = imageName;

                _productService.Update(productBL);

                var originalImgPath = string.Format($"{pathToImg}\\{imageName}");
                var thumbImgPath = string.Format($"{pathToThumb}\\{imageName}");

                imageUpload.SaveAs(originalImgPath);

                WebImage img = new WebImage(imageUpload.InputStream);
                img.Resize(150, 150);
                img.Save(thumbImgPath);
            }
            else
            {
                TempData["ProductEditedFailIncImg"] = "Please add images with the next extentions: jpg, jpeg, gif, png.";
            }

            return RedirectToAction("EditProduct");
        }

        public bool ImageValidation(HttpPostedFileBase imageUpload, ProductPL productPL)
        {
            bool result = false;
            if (imageUpload != null && imageUpload.ContentLength > 0)
            {
                string extention = imageUpload.ContentType.ToLower();

                if (extention != "image/jpg" &&
                    extention != "image/jpeg" &&
                    extention != "image/gif" &&
                    extention != "image/gif")
                {
                    productPL.Categories = new SelectList(_categoryService.GetAll().ToList(), "Id", "Name");

                    return result;
                }
                result = true;

                return result;
            }

            return result;
        }


        public ActionResult DeleteProduct(int id)
        {
            var productBL = _productService.GetById(id);

            if (productBL.ImagePath != null)
            {
                var imageDirectory = new DirectoryInfo(string.Format($"{Server.MapPath(@"\")}Images\\Uploads"));

                var pathToImg = Path.Combine(imageDirectory.ToString(), "Products\\" + productBL.ImagePath);
                var pathToThumb = Path.Combine(imageDirectory.ToString(), "Products\\Thumbs" + productBL.ImagePath);

                if (Directory.Exists(pathToThumb))
                {
                    Directory.Delete(pathToThumb);
                }

                if (Directory.Exists(pathToImg))
                {
                    Directory.Delete(pathToImg);
                }
            }

            _productService.Remove(id);

            return RedirectToAction("GetAllProducts");
        }

        // GET: /Admin/Shop/OrdersHistory
        public ActionResult OrdersHistory()
        {
            List<OrdersPLAdmin> ordersHistory = new List<OrdersPLAdmin>();

            var ordersBL = _orderService.GetAll();

            foreach (var order in ordersBL)
            {
                Dictionary<string, int> userOrderHistory = new Dictionary<string, int>();
                    
                var orderList = _orderDetailService.GetAll().Where(x => x.OrderId == order.Id);

                ApplicationUserManager userManager = HttpContext.GetOwinContext()
                                                    .GetUserManager<ApplicationUserManager>();

                ApplicationUser user = userManager.FindById(order.UserId);

                decimal total = 0m;

                foreach (var orderDetails in orderList)
                {
                    var productBL = _productService.GetAll().FirstOrDefault(x => x.Id == orderDetails.ProductId);

                    userOrderHistory.Add(productBL.Name, orderDetails.Amount);

                    total += orderDetails.Amount * productBL.Price;
                    
                }

                ordersHistory.Add(new OrdersPLAdmin
                {
                    OrderNumber = order.Id,
                    UserName = user.UserName,
                    UserOrderHistory = userOrderHistory,
                    OrderDate = order.OrderDate,
                    Total = total
                });
            }

            return View(ordersHistory);
        }
    }
}