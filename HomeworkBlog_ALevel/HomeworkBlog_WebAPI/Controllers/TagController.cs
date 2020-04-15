using AutoMapper;
using HomeworkBlog_ALevel.BLL.Interfaces;
using HomeworkBlog_ALevel.BLL.Models;
using HomeworkBlog_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HomeworkBlog_WebAPI.Controllers
{
    public class TagController : ApiController
    {
        private readonly ITagService _tagService;
        private readonly IMapper _mapper;

        public TagController()
        {

        }

        public TagController(ITagService tagService, IMapper mapper)
        {
            _tagService = tagService;
            _mapper = mapper;
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var tags = _tagService.GetAll();

            return Ok(tags);
        }

        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var tag = _tagService.GetById(id);

            return Ok(tag);
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody]TagApiModel tagApiModel)
        {
            var tagModel = _mapper.Map<TagModel>(tagApiModel);

            _tagService.Add(tagModel);

            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Update([FromBody]TagApiModel tagApiModel)
        {
            var tagModel = _mapper.Map<TagModel>(tagApiModel);

            _tagService.Update(tagModel);

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _tagService.Remove(id);

            return Ok();
        }
    }
}
