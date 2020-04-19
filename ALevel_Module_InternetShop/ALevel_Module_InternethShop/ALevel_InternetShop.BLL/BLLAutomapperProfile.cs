using ALevel_InternetShop.BLL.Models;
using ALevel_InternetShop.DAL.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_InternetShop.BLL
{
    public class BLLAutomapperProfile:Profile
    {
        public BLLAutomapperProfile()
        {
            CreateMap<ProductModel, Product>()
                .ForMember(x => x.Category, y => y.MapFrom(x => x.CategoryModel))
                .ForMember(x => x.CategoryId, y => y.MapFrom(x => x.CategoryModelId))
                .ReverseMap();

            CreateMap<CategoryModel, Category>().ReverseMap();
        }
    }
}
