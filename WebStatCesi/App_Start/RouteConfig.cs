using System.Web.Mvc;
using System.Web.Routing;

namespace WebStatCesi
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute("Default",
            //"{controller}/{action}/{id}",
            //new
            //{
            //    controller = "Home",
            //    id = "",
            //    action = "Index",
            //});

            routes.MapRoute("Default",
                        "{language}-{culture}/{controller}/{action}/{id}",
                        new
                        {
                            culture = "FR",
                            language = "fr",
                            controller = "Home",
                            action = "Index",
                            id = ""
                        });
        }
    }
}
