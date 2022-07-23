using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Open Employee page
            routes.MapRoute(
                name: "Employee",
                url: "employee",
                defaults: new { controller = "Employee", action = "Employee" }
            );

            // Open Registration form
            routes.MapRoute(
                name: "register",
                url: "employee/register",
                defaults: new { controller = "Employee", action = "register" }
            );

            // Save new Employee
            routes.MapRoute(
                name: "saveRegistraion",
                url: "employee/save",
                defaults: new { controller = "Employee", action = "save" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
