using ALvl_ExamProject.BL.Interfaces;
using ALvl_ExamProject.BL.Models;
using ALvl_ExamProject.MVC.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ALvl_ExamProject.MVC.Controllers
{
    public class PagesController : Controller
    {
        private readonly IPageService _pageService;
        private readonly IMapper _mapper;
        private readonly ISidebarService _sidebarService;

        public PagesController(IPageService pageService, IMapper mapper, ISidebarService sidebarService)
        {
            _pageService = pageService;
            _mapper = mapper;
            _sidebarService = sidebarService;
        }


        public ActionResult Index(string page = "")
        {
            if (page == "")
                page = "home";

            if (!_pageService.GetAll().Any(x => x.Slug.Equals(page)))
            {
                return RedirectToAction("Index", new { page = "" });
            }

            var pageBL = _pageService.GetAll().FirstOrDefault(x => x.Slug == page);

            ViewBag.PageTitle = pageBL.Title;

            if (pageBL.Sidebar == true)
            {
                ViewBag.Sidebar = "Y";
            }
            else
            {
                ViewBag.Sidebar = "N";
            }

            var pagePL = _mapper.Map<PagePL>(pageBL);

            return View(pagePL);
        }

        public ActionResult PartialPageMenu()
        {
            var pagesBL = _pageService.GetAll()
                .ToArray()
                .OrderBy(x => x.Sorting)
                .Where(x => x.Slug != "home")
                .ToList();

            var pagesPL = _mapper.Map<IEnumerable<PagePL>>(pagesBL);

            return PartialView("_PartialPageMenu", pagesPL);
        }

        public ActionResult SidebarPartial()
        {
           var sidebarBL = _sidebarService.GetById(1);

            var sidebarPL = _mapper.Map<SidebarPL>(sidebarBL);

            return PartialView("_SidebarPartial", sidebarPL);
        }
    }
}