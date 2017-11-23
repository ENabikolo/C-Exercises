using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Mathematics
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "The",
                url: "Calc/{a}/{b}",
                defaults: new { controller = "Math", action = "Calculations", id = UrlParameter.Optional }
            );


            routes.MapRoute(
               name: "Best",
               url: "Sub/{a}/{b}",
               defaults: new { controller = "Math", action = "Subtraction", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "Subject",
               url: "Mul/{a}/{b}",
               defaults: new { controller = "Math", action = "Multiplication", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "Ever",
               url: "Div/{a}/{b}",
               defaults: new { controller = "Math", action = "Division", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );
        }
    }
}
