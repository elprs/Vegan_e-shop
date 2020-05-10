using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vegan.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "Product",
              url: "product/{action}/{id}",
              defaults: new { controller = "Product", action = "Index" , id= ""},
              namespaces: new[] { "Vegan.Web.Controllers.TestControllers" }
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Vegan.Web.Controllers" }
            );

        }
        //public static void RegisterRoutes(RouteCollection routes)
        //{
        //    routes.IgnoreRoute("{resource}.axd/{*pathInfo}"); // new routing 

        //    routes.MapRoute("Default", "{type}/{controller}/{action}/{id}",
        //        new { controller = "Home", action = "Index", id = UrlParameter.Optional },
        //        new RouteValueDictionary
        //        {
        //    { "type", "Home|User|Admin" }
        //        });
        //}
    }
}