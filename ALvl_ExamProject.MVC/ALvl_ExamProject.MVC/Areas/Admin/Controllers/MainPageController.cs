using System.Web.Mvc;

namespace ALvl_ExamProject.MVC.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    public class MainPageController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}