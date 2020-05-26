
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ALvl_ExamProject.MVC.Startup))]

namespace ALvl_ExamProject.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
