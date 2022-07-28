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

            // Close Details
            routes.MapRoute(
                name: "closeDetails",
                url: "Employee/details/close",
                defaults: new { controller = "Employee", action = "Close" }
            );

            // Open Edit from Details Page
            routes.MapRoute(
                name: "Edit",
                url: "Employee/details/Edit",
                defaults: new { controller = "Employee", action = "Edit" }
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

            // close on Employee
            routes.MapRoute(
                name: "closeRegistration",
                url: "employee/close",
                defaults: new { controller = "Employee", action = "close" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
