using HomeworkBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace HomeworkBlog.Helpers
{
    public static class PaginationHelper
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, PaheInformation pageInfo, Func<int, string> pageUrl)
        {
            StringBuilder link = new StringBuilder();
            for (int i =1; i<= pageInfo.TotalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(i));
                tag.InnerHtml = i.ToString();

                if (i == pageInfo.PageNo)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }
                tag.AddCssClass("btn btm-default");

                link.Append(tag.ToString());
            }
            return MvcHtmlString.Create(link.ToString());
        }
    }
}