using AutoMapper;
using HomeworkBlog.Models;
using HomeworkBlog_ALevel.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeworkBlog.App_Start
{
    public class WebAutomapperProfile : Profile
    {
        public WebAutomapperProfile()
        {
            CreateMap<PostViewModel, PostModel>()
                .ForMember(x =>x.AuthorModel, s => s.MapFrom(x => x.Author)) 
                .ReverseMap();
            CreateMap<AuthorViewModel, AuthorModel>().ReverseMap();
            CreateMap<CategoryViewModel, CategoryModel>().ReverseMap();
            CreateMap<TagViewModel, TagModel>().ReverseMap();
        }
    }
}