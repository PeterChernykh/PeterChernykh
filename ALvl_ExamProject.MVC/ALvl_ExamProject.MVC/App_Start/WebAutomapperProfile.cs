using ALvl_ExamProject.BL.Models;
using ALvl_ExamProject.MVC.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALvl_ExamProject.MVC.App_Start
{
    public class WebAutomapperProfile: Profile
    {
        public WebAutomapperProfile()
        {
            CreateMap<PagePL, PageBL>().ReverseMap();
            CreateMap<CategoryPL, CategoryBL>().ReverseMap();
            CreateMap<ProductPL, ProductBL>()
                .ForMember(x => x.CategoryBL, y => y.MapFrom(x => x.CategoryPL))
                .ForMember(x => x.CategoryId, y => y.MapFrom(x => x.CategoryId))
                .ReverseMap();

            CreateMap<SidebarPL, SidebarBL>().ReverseMap();

            CreateMap<OrderDetailPL, OrderDetailBL>().ReverseMap();

            CreateMap<OrderPL, OrderBL>().ReverseMap();
        }
    }
}