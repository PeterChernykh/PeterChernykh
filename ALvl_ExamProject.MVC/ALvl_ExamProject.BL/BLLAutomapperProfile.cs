using ALvl_ExamProject.BL.Models;
using ALvl_ExamProject.DAL.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALvl_ExamProject.BL
{
    public class BLLAutomapperProfile: Profile
    {
        public BLLAutomapperProfile()
        {
            CreateMap<ProductBL, Product>()
           .ForMember(x => x.Category, y => y.MapFrom(x => x.CategoryBL))
           .ForMember(x => x.CategoryId, y => y.MapFrom(x => x.CategoryId))
           .ReverseMap();

            CreateMap<CategoryBL, Category>().ReverseMap();

            CreateMap<PageBL, Page>().ReverseMap();

            CreateMap<SidebarBL, Sidebar>().ReverseMap();
        }
    }
}
