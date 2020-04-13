using AutoMapper;
using HomeworkBlog.Models;
using HomeworkBlog_ALevel.BLL.Interfaces;
using HomeworkBlog_ALevel.BLL.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace HomeworkBlog.Controllers
{
    public class PostController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IPostService _postService;

        public PostController()
        {

        }

        public PostController(IPostService service, IMapper mapper)
        {
            _mapper = mapper;
            _postService = service;
        }

        public ActionResult Index()
        {
            var listBLPost = _postService.GetAll();
            var posts = _mapper.Map<IEnumerable<PostViewModel>>(listBLPost);
            return View(posts);
        }

        public ActionResult Details(int id)
        {
            var postModel = _postService.GetById(id);
            var postViewModel = _mapper.Map<PostViewModel>(postModel);

            return View(postViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PostViewModel postInfo)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                var postModel = _mapper.Map<PostModel>(postInfo);
                _postService.Add(postModel);

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
        public ActionResult Edit(int id, PostViewModel postViewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                var postModel = _mapper.Map<PostModel>(postViewModel);
                _postService.Update(postModel);

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
                _postService.Remove(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult PostPage(int page = 1)
        {

            int pageSize = 5;

            var posts = _postService.Posts(page - 1, pageSize);

            var postsModel = _mapper.Map<IEnumerable<PostViewModel>>(posts);

            

            var totalPosts = _postService.TotalPosts();

            PaheInformation pageInfo = new PaheInformation
            {
                PageNo = page,
                PageSize = pageSize,
                TotalItems = totalPosts
            };

            var listViewModel = new PostsPaginationModel()
            {
                Posts = postsModel,
                PageInfo = pageInfo
            };

            return View(listViewModel);
        }
    }
}
