using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace layoutassignment
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathinfo)");
            routes.MapRoute(
                "Checker",
                "/Fevercheck",
                new { controller = "home", action = "CheckTemp" }
                );
            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new { controller = "home", action = "index", id = "" }
                );
        }
        protected void Application_Start()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
