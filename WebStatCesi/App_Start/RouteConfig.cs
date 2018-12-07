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
            // Call to register your localized and default attribute routes        
            //routes.MapLocalizedMvcAttributeRoutes(urlPrefix: "{culture}/", constraints: new { culture = new CultureConstraint(defaultCulture: "nl", pattern: "[a-z]{2}") }); routes.MapRoute(name: "DefaultWithCulture", url: "{culture}/{controller}/{action}/{id}", defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }, constraints: new { culture = new CultureConstraint(defaultCulture: "nl", pattern: "[a-z]{2}") }); routes.MapRoute(name: "Default", url: "{controller}/{action}/{id}", defaults: new { culture = "nl", controller = "Home", action = "Index", id = UrlParameter.Optional });

        }
    }
}
