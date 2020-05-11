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
    public class PageController : Controller
    {
        private readonly IPageService _pageService;
        private readonly IMapper _mapper;
        private readonly ISidebarService _sidebarService;

        public PageController()
        {

        }

        public PageController(IPageService pageService, IMapper mapper, ISidebarService sidebarService)
        {
            _pageService = pageService;
            _mapper = mapper;
            _sidebarService = sidebarService;
        }

        // GET: Admin/Page
        public ActionResult Index()
        {
            var pages = _pageService.GetAll();
            var pagesPL = _mapper.Map<IEnumerable<PagePL>>(pages);

            return View(pagesPL);
        }

        public ActionResult AddPage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPage(PagePL pagePL)
        {
            if (!ModelState.IsValid)
            {
                return View(pagePL);
            }

            var allPages = _pageService.GetAll();


            SlugNullOrWhiteSpaceChecker(pagePL);

            //TODO: Возможно стоит заменить на часть Body. Найти как 

            if (IsTitleOrSlugUnique(pagePL).Equals(false))
            {
                return View(pagePL);
            }
            IsTitleOrSlugUnique(pagePL);


            var pageBL = _mapper.Map<PageBL>(pagePL);

            _pageService.Add(pageBL);

            //TODO: Add message about successful creation

            TempData["CreatedSucces"] = "New page has been added.";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {

            var currentPageInfo = _pageService.GetById(id);
            var pagePL = _mapper.Map<PagePL>(currentPageInfo);

            return View(pagePL);
        }

        [HttpPost]
        public ActionResult Edit(PagePL pagePL)
        {
            if (!ModelState.IsValid)
            {
                return View(pagePL);
            }

            if (pagePL.Slug != "home")
            {
                SlugNullOrWhiteSpaceChecker(pagePL);
            }

            if (IsTitleOrSlugUnique(pagePL).Equals(false))
            {
                return View(pagePL);
            }
            IsTitleOrSlugUnique(pagePL);

            var pageBL = _mapper.Map<PageBL>(pagePL);

            _pageService.Update(pageBL);

            TempData["EditedSucces"] = "The page has been edited.";

            return RedirectToAction("Edit");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var requiredPage = _pageService.GetById(id);

            var pagePL = _mapper.Map<PagePL>(requiredPage);

            return View(pagePL);
        }

        [HttpGet]

        public ActionResult Delete(int id)
        {
            var pageToDelete = _pageService.GetById(id);
            var pagePL = _mapper.Map<PagePL>(pageToDelete);
            return View(pagePL);
        }

        [HttpPost]
        public ActionResult Delete(PagePL pagePL)
        {
            _pageService.Remove(pagePL.Id);

            TempData["DeletedSucces"] = "The page has been deleted.";

            return RedirectToAction("Index");
        }


        private void SlugNullOrWhiteSpaceChecker(PagePL pagePL)
        {
            if (string.IsNullOrWhiteSpace(pagePL.Slug))
            {
                pagePL.Slug = pagePL.Title.Replace(" ", "-").ToLower();
            }
            else
            {
                pagePL.Slug = pagePL.Slug.Replace(" ", "-").ToLower();
            }
        }

        private bool IsTitleOrSlugUnique(PagePL pagePL)
        {

            bool unique = true;
            var allPages = _pageService.GetAll().Where(x => x.Id != pagePL.Id);

            if (allPages.Any(x => x.Title == pagePL.Title))
            {
                ModelState.AddModelError("", "Such title aready exists in the system");

                unique = false;
            }

            if (allPages.Any(x => x.Slug == pagePL.Slug))
            {
                ModelState.AddModelError("", "Such slug aready exists in the system");

                unique = false;
            }

            return unique;
        }

        [HttpPost]

        public void ReorderPages(int[] id)
        {
            int count = 1;
            

            PageBL neededPage;

            foreach (var neededId in id)
            {
                neededPage = _pageService.GetById(neededId);
                neededPage.Sorting = count;

                _pageService.Update(neededPage);

                count++;
            }
        }

        [HttpGet]
        public ActionResult EditSidebar()
        {
            var modelBL = _sidebarService.GetAll().FirstOrDefault();
            var modelPL = _mapper.Map<SidebarPL>(modelBL);

            return View(modelPL);
        }

        [HttpPost]
        public ActionResult EditSidebar (SidebarPL modelPL)
        {
            var modelBL = _mapper.Map<SidebarBL>(modelPL);

            _sidebarService.Update(modelBL);

            TempData["SB_Edited"] = "Sidebar edited successfully";

            return RedirectToAction("EditSidebar");
        }
    }
}