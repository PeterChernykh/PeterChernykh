﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ALvl_ExamProject.MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
             name: "Roles",
             url: "Roles/{action}",
             defaults: new { controller = "Roles", action = "GetRoles" },
             namespaces: new[] { "ALvl_ExamProject.MVC.Controllers" });

            routes.MapRoute(
              name: "Login",
              url: "Account/{action}/{id}",
              defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional },
              namespaces: new[] { "ALvl_ExamProject.MVC.Controllers" });

            routes.MapRoute(
              name: "Account",
              url: "Account/{action}",
              defaults: new { controller = "Account", action = "Login" },
              namespaces: new[] { "ALvl_ExamProject.MVC.Controllers" });

            routes.MapRoute(
              name: "ShopCart",
              url: "ShopCart/{action}/{id}",
              defaults: new { controller = "ShopCart", action = "Index", id = UrlParameter.Optional },
              namespaces: new[] { "ALvl_ExamProject.MVC.Controllers" });

            routes.MapRoute(
              name: "SidebarPartial",
              url: "Pages/SidebarPartial",
              defaults: new { controller = "Pages", action = "SidebarPartial" },
              namespaces: new[] { "ALvl_ExamProject.MVC.Controllers" });

            routes.MapRoute(
               name: "Shop",
               url: "Shop/{action}/{name}",
               defaults: new { controller = "Shop", action = "Index", name=UrlParameter.Optional },
               namespaces: new[] { "ALvl_ExamProject.MVC.Controllers" });

            routes.MapRoute(
               name: "PartialPageMenu",
               url: "Pages/PartialPageMenu",
               defaults: new { controller = "Pages", action = "PartialPageMenu" },
               namespaces: new[] { "ALvl_ExamProject.MVC.Controllers" });

            routes.MapRoute(
                name: "Pages",
                url: "{page}",
                defaults: new { controller = "Pages", action = "Index" },
                namespaces: new[] { "ALvl_ExamProject.MVC.Controllers" });

            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new { controller = "Pages", action = "Index" },
                namespaces: new[] { "ALvl_ExamProject.MVC.Controllers" });
        }
    }
}
