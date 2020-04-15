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
    public class AuthorController : ApiController
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public AuthorController(IAuthorService authorService, IMapper mapper)
        {
            _mapper = mapper;
            _authorService = authorService;
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(_authorService.GetAll());
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            return Ok(_authorService.GetById(id));
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody]AuthorApiModel authorApiModel)
        {
            var authorModel = _mapper.Map<AuthorModel>(authorApiModel);

            _authorService.Add(authorModel);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Put([FromBody]AuthorApiModel authorApiModel)
        {
            var authorModel = _mapper.Map<AuthorModel>(authorApiModel);

            _authorService.Update(authorModel);

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _authorService.Remove(id);

            return Ok();
        }
    }
}
