using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeworkBlog.Models
{
    public class PostsPaginationModel
    {
        public IEnumerable<PostViewModel> Posts { get; set; }
        public PaheInformation PageInfo { get; set; }
    }

    public class PaheInformation
    {
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages
        {
            get {return (int)Math.Ceiling((decimal) TotalItems/ PageSize); }
        }
    }
}