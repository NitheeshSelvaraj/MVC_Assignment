
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //  name: "Demo",
            //    url: "Sam/{action}",
            //    defaults: new { controller = "Maximum", action = "Index", id = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Employee",
                url: "Sample/Details",
                defaults: new { controller = "Sample", action = "ViewEmployee", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Sample", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}
