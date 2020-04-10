using AutoMapper;
using HomeworkBlog_ALevel.BLL.Interfaces;
using HomeworkBlog_ALevel.BLL.Models;
using HomeworkBlog_ALevel.DAL.Interfaces;
using HomeworkBlog_ALevel.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkBlog_ALevel.BLL.Services
{
    public class CategoryService : GeneralService<CategoryModel, Category>, ICategoryService
    {
        public readonly IMapper _mapper;

        public CategoryService(IBlogRepository<Category> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public CategoryModel GetById(int id)
        {
            var categoryModel = GetAll().FirstOrDefault(x => x.Id == id);
            return categoryModel;
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
