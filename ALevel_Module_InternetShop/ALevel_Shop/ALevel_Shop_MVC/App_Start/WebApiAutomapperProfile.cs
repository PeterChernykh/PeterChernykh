using ALevel_Shop.BLL.Models;
using ALevel_Shop_MVC.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALevel_Shop_MVC.App_Start
{
    public class WebApiAutomapperProfile: Profile
    {
        public WebApiAutomapperProfile()
        {
            CreateMap<ProductApi, ProductModel>()
           .ForMember(x => x.CategoryModel, y => y.MapFrom(x => x.CategoryApi))
           .ReverseMap();

            CreateMap<CategoryApi, CategoryModel>().ReverseMap();
        }
    }
}