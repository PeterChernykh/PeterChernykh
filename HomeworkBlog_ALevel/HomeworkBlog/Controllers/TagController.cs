using AutoMapper;
using HomeworkBlog.Models;
using HomeworkBlog_ALevel.BLL.Interfaces;
using HomeworkBlog_ALevel.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeworkBlog.Controllers
{
    public class TagController : Controller
    {

        private readonly ITagService _tagService;
        private readonly IMapper _mapper;

        public TagController(ITagService tagService, IMapper mapper)
        {
            _tagService = tagService;
            _mapper = mapper;
        }

        // GET: Tag
        public ActionResult Index()
        {
            var listBLTags = _tagService.GetAll();
            var tags = _mapper.Map<IEnumerable<TagViewModel>>(listBLTags);

            return View(tags);
        }

        // GET: Tag/Details/5
        public ActionResult Details(int id)
        {
            var tagModel = _tagService.GetById(id);
            var tagViewModel = _mapper.Map<TagViewModel>(tagModel);

            return View(tagViewModel);
        }

        // GET: Tag/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TagViewModel tagInfo)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                var tagModel = _mapper.Map<TagModel>(tagInfo);
                _tagService.Add(tagModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // POST: Tag/Create
        [HttpPost]

        // GET: Tag/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tag/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TagViewModel editTag)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                var tagModel = _mapper.Map<TagModel>(editTag);
                _tagService.Add(tagModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tag/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tag/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, TagViewModel tagViewModel)
        {
            try
            {
                _tagService.Remove(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
