using ALvl_ExamProject.MVC.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace ALvl_ExamProject.MVC.Controllers
{
    public class RolesController : Controller
    {
        [Authorize]
        public ActionResult GetRoles()
        {
            IList<string> roles = new List<string> { "Role wasn't defined" };
            ApplicationUserManager userManager = HttpContext.GetOwinContext()
                                                    .GetUserManager<ApplicationUserManager>();
            ApplicationUser user = userManager.FindByEmail(User.Identity.Name);
            if (user != null)
                roles = userManager.GetRoles(user.Id);
            return View(roles);
        }
    }
}