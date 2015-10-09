using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TesteBD
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Index",
                url: "Index",
                defaults: new { controller = "Cidade", action = "Index" },
                namespaces: new[] { "TesteBD.Controllers.CidadeController" });

            routes.MapRoute(
                name: "",
                url: "",
                defaults: new { controller = "Cidade", action = "Index" },
                namespaces: new[] { "TesteBD.Controllers.CidadeController" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}