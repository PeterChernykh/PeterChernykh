using ALevel_InternetShop.BLL.Interfaces;
using ALevel_InternetShop.BLL.Models;
using ALevel_InternetShop.DAL.Interfaces;
using ALevel_InternetShop.DAL.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_InternetShop.BLL.Services
{
    public class CategoryService : ShopService<CategoryModel, Category>, ICategoryService
    {
        public readonly IMapper _mapper;

        public CategoryService(IShopRepository<Category> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public override CategoryModel Map(Category modelDL)
        {
            return _mapper.Map<CategoryModel>(modelDL);
        }

        public override Category Map(CategoryModel modelBL)
        {
            return _mapper.Map<Category>(modelBL);
        }

        public override IEnumerable<CategoryModel> Map(IList<Category> posts)
        {
            return _mapper.Map<IEnumerable<CategoryModel>>(posts);
        }
        public override IEnumerable<Category> Map(IList<CategoryModel> postsModel)
        {
            return _mapper.Map<IEnumerable<Category>>(postsModel);
        }
    }
}
