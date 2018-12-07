using System.Web.Mvc;
using System.Web.Routing;

namespace WebStatCesi
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

//            routes.MapRoute(
//    name: "Default",
//    url: "{controller}/{action}/{id}",
//    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
//);

            routes.MapRoute("Default",
                        "{language}-{culture}/{controller}/{action}/{id}",
                        new
                        {
                            controller = "Home",
                            action = "Index",
                            id = "",
                            language = "fr",
                            culture = "FR"
                        });
        }
    }
}
