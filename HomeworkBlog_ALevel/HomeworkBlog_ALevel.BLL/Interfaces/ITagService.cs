using HomeworkBlog_ALevel.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkBlog_ALevel.BLL.Interfaces
{
    public interface ITagService: IService<TagModel>
    {
        TagModel GetById(int id);
    }
}
