using System.Web;
using System.Web.Mvc;

namespace ALevel_Module_InternethShop
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
