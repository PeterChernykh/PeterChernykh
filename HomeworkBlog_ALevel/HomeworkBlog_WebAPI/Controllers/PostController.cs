using AutoMapper;
using HomeworkBlog_ALevel.BLL.Interfaces;
using HomeworkBlog_ALevel.BLL.Models;
using HomeworkBlog_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace HomeworkBlog_WebAPI.Controllers
{
    public class PostController : ApiController
    {
        private readonly IPostService _postService;
        private readonly IMapper _mapper;

        public PostController()
        {

        }

        public PostController(IPostService postService, IMapper mapper)
        {
            _postService = postService;
            _mapper = mapper;
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {

            var posts = _postService.GetAll();
            return Ok(posts);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            return Ok(_postService.GetById(id));
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody]PostApiModel postApiModel)
        {
            var postModel = _mapper.Map<PostModel>(postApiModel);

            _postService.Add(postModel);

            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Update([FromBody] PostApiModel postApiModel)
        {
            var postModel = _mapper.Map<PostModel>(postApiModel);

            _postService.Update(postModel);

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _postService.Remove(id);

            return Ok();
        }
    }
}