using AutoMapper;
using HomeworkBlog_ALevel.BLL.Interfaces;
using HomeworkBlog_ALevel.BLL.Models;
using HomeworkBlog_ALevel.DAL.Interfaces;
using HomeworkBlog_ALevel.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkBlog_ALevel.BLL.Services
{
    public class PostService : GeneralService<PostModel, Post>, IPostService
    {
        public readonly IMapper _mapper;

        public PostService(IBlogRepository<Post> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public PostModel GetById(int id)
        {
            var postModel = GetAll().FirstOrDefault(x => x.Id == id);
            return postModel;
        }

        public IEnumerable<PostModel> Posts(int pageNo, int pageSize)
        {
            var posts = _repository.GetAll()
                .OrderByDescending(x => x.PostedOn)
                .Skip(pageNo * pageSize)
                .Take(pageSize)
                .ToList();

            var postsModel = Map(posts);

            return postsModel;

        }

        public int TotalPosts()
        {
            var postsCount = GetAll().ToList().Count();

            return postsCount;
        }

        public override PostModel Map(Post modelDL)
        {
            return _mapper.Map<PostModel>(modelDL);
        }

        public override Post Map(PostModel modelBL)
        {
            return _mapper.Map<Post>(modelBL);
        }

        public override IEnumerable<PostModel> Map(IList<Post> posts)
        {
            return _mapper.Map<IEnumerable<PostModel>>(posts);
        }
        public override IEnumerable<Post> Map(IList<PostModel> postsModel)
        {
            return _mapper.Map<IEnumerable<Post>>(postsModel);
        }
    }
}
