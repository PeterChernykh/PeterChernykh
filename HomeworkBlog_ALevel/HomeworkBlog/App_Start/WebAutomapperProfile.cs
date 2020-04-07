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
            .ReverseMap();
            CreateMap<AuthorViewModel, AuthorModel>()
                //.ForMember(dest => dest.PostModels, opt => opt.AllowNull())
                .ReverseMap();
            CreateMap<CategoryViewModel, CategoryModel>().ReverseMap();
            CreateMap<TagViewModel, TagModel>().ReverseMap();
        }
    }
}