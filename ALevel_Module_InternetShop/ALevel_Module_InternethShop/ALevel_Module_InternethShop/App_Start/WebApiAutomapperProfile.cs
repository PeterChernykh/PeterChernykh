using ALevel_InternetShop.BLL.Models;
using ALevel_Module_InternethShop.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALevel_Module_InternethShop.App_Start
{ 
    public class WebApiAutomapperProfile : Profile
    {
        public WebApiAutomapperProfile()
        {
            CreateMap<ProductApiModel, ProductModel>()
           .ForMember(x => x.CategoryModel, y => y.MapFrom(x => x.CategoryApiModel))
           .ForMember(x => x.CategoryModelId, y => y.MapFrom(x => x.CategoryApiModelId))
           .ReverseMap();

            CreateMap<CategoryApiModel, CategoryModel>().ReverseMap();
        }
    }
}