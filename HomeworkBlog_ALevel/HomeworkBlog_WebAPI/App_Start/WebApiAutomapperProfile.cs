using HomeworkBlog_ALevel.BLL.Models;
using HomeworkBlog_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace HomeworkBlog_WebAPI.App_Start
{
    public class WebApiAutomapperProfile: Profile
    {
        public WebApiAutomapperProfile()
        {
            CreateMap<PostApiModel, PostModel>()
                .ForMember(x => x.AuthorModel, s => s.MapFrom(x => x.Author))
                .ForMember(x => x.CategoryModel, s => s.MapFrom(x => x.Category))
                .ReverseMap();
            CreateMap<AuthorApiModel, AuthorModel>().ReverseMap();
            CreateMap<CategoryApiModel, CategoryModel>().ReverseMap();
            CreateMap<TagApiModel, TagModel>().ReverseMap();
        }
    }
}