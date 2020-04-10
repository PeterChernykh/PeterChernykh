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
    public class TagService: GeneralService<TagModel, Tag>, ITagService
    {
        public readonly IMapper _mapper;

        public TagService(IBlogRepository<Tag> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public TagModel GetById(int id)
        {
            var tagModel = GetAll().FirstOrDefault(x => x.Id == id);
            return tagModel;
        }

        public override TagModel Map(Tag modelDL)
        {
            return _mapper.Map<TagModel>(modelDL);
        }

        public override Tag Map(TagModel modelBL)
        {
            return _mapper.Map<Tag>(modelBL);
        }

        public override IEnumerable<TagModel> Map(IList<Tag> posts)
        {
            return _mapper.Map<IEnumerable<TagModel>>(posts);
        }
        public override IEnumerable<Tag> Map(IList<TagModel> postsModel)
        {
            return _mapper.Map<IEnumerable<Tag>>(postsModel);
        }
    }
}
