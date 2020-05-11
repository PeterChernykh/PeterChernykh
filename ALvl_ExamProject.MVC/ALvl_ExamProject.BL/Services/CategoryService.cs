using ALvl_ExamProject.BL.Interfaces;
using ALvl_ExamProject.BL.Models;
using ALvl_ExamProject.DAL.Interfaces;
using ALvl_ExamProject.DAL.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALvl_ExamProject.BL.Services
{
    public class CategoryService : ShopService<CategoryBL, Category>, ICategoryService
    {
        public readonly IMapper _mapper;

        public CategoryService(IShopRepository<Category> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public override CategoryBL Map(Category modelDL)
        {
            return _mapper.Map<CategoryBL>(modelDL);
        }

        public override Category Map(CategoryBL modelBL)
        {
            return _mapper.Map<Category>(modelBL);
        }

        public override IEnumerable<CategoryBL> Map(IList<Category> posts)
        {
            return _mapper.Map<IEnumerable<CategoryBL>>(posts);
        }
        public override IEnumerable<Category> Map(IList<CategoryBL> postsModel)
        {
            return _mapper.Map<IEnumerable<Category>>(postsModel);
        }
    }
}
