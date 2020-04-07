using AutoMapper;
using HomeworkBlog_ALevel.BLL.Interfaces;
using HomeworkBlog_ALevel.BLL.Models;
using HomeworkBlog_ALevel.DAL.Interfaces;
using HomeworkBlog_ALevel.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkBlog_ALevel.BLL.Services
{
    public class AuthorService : GeneralService<AuthorModel, Author>, IAuthorService
    {

        public readonly IMapper _mapper;

        public AuthorService(IBlogRepository<Author> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public AuthorModel GetById(int id)
        {
            var authorModel = GetAll().FirstOrDefault(x => x.Id == id);
            return authorModel;
        }

        public override AuthorModel Map(Author modelDL)
        {
            return _mapper.Map<AuthorModel>(modelDL);
        }

        public override Author Map(AuthorModel modelBL)
        {
            return _mapper.Map<Author>(modelBL);
        }

        public override IEnumerable<AuthorModel> Map(IList<Author> posts)
        {
            return _mapper.Map<IEnumerable<AuthorModel>>(posts);
        }
        public override IEnumerable<Author> Map(IList<AuthorModel> postsModel)
        {
            return _mapper.Map<IEnumerable<Author>>(postsModel);
        }
    }
}
