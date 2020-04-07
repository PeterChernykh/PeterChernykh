using AutoMapper;
using HomeworkBlog.Models;
using HomeworkBlog_ALevel.BLL.Interfaces;
using HomeworkBlog_ALevel.BLL.Models;
using System.Linq;
using System.Collections.Generic;
using System.Web.Mvc;

namespace HomeworkBlog.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public AuthorController()
        {

        }

        public AuthorController(IAuthorService service, IMapper mapper)
        {
            _mapper = mapper;
            _authorService = service;
        }

        public ActionResult Index()
        {
            var listBLAuthors = _authorService.GetAll();
            var authors = _mapper.Map<IEnumerable<AuthorViewModel>>(listBLAuthors);


            return View(authors);
        }

        public ActionResult Details(int id)
        {
            var authorModel = _authorService.GetAll().FirstOrDefault(x => x.Id == id);
            var authorViewModel = _mapper.Map<AuthorViewModel>(authorModel);

            return View(authorViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AuthorViewModel authorInfo)
        {
            try
            {

                var authorModel = _mapper.Map<AuthorModel>(authorInfo);
                _authorService.Add(authorModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, AuthorViewModel updatedAuthorInfo)
        {
            try
            {
                var authorModel = _mapper.Map<AuthorModel>(updatedAuthorInfo);
                _authorService.Update(authorModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                _authorService.Remove(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
