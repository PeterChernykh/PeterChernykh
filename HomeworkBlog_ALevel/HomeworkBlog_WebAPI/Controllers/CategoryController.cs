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
    public class CategoryController : ApiController
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryServoce, IMapper mapper)
        {
            _categoryService = categoryServoce;
            _mapper = mapper;
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(_categoryService.GetAll());
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            return Ok(_categoryService.GetById(id));
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody]CategoryApiModel categoryApiModel)
        {
            var categoryModel = _mapper.Map<CategoryModel>(categoryApiModel);

            _categoryService.Add(categoryModel);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Put([FromBody]CategoryApiModel authorApiModel)
        {
            var categoryModel = _mapper.Map<CategoryModel>(authorApiModel);

            _categoryService.Update(categoryModel);

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _categoryService.Remove(id);

            return Ok();
        }
    }
}
