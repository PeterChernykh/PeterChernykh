using HomeworkBlog.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace HomeworkBlog.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            List<AuthorViewModel> authors = new List<AuthorViewModel>();

            authors.Add(new AuthorViewModel()
            {
                Id = 1,
                Name = "Rob Nilson"
            });
            authors.Add(new AuthorViewModel()
            {
                Id = 2,
                Name = "John Lucas"
            });
             


            return View(authors);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}