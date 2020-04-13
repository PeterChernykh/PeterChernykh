using AutoMapper;
using HomeworkBlog_ALevel.BLL.Models;
using HomeworkBlog_ALevel.DAL.Models;

namespace HomeworkBlog_ALevel.BLL
{
    public class BLAutomapperProfile: Profile
    {
        public BLAutomapperProfile()
        {
            CreateMap<PostModel, Post>().ReverseMap();

            CreateMap<AuthorModel, Author>()
                .ReverseMap();

            CreateMap<CategoryModel, Category>().ReverseMap();
            CreateMap<TagModel, Tag>().ReverseMap();
        }
    }
}
