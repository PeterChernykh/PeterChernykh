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
                //.ForMember(dest => dest.Posts, opt => opt.AllowNull())
                .ReverseMap();

            CreateMap<CategoryModel, Category>().ReverseMap();
            CreateMap<TagModel, Tag>().ReverseMap();
        }
    }
}
