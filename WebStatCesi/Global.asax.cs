using System;
using System.Globalization;
using System.Threading;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebStatCesi.Src;

namespace WebStatCesi
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            new Startup();
        }

        protected void Application_AcquireRequestState(object sender, EventArgs e)
        {
            // Recupère la langue du navigateur

            //string culture = "fr-FR";
            //if (Request.UserLanguages != null)
            //{
            //    culture = Request.UserLanguages[0];
            //}
            //Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(culture);
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
        }
    }
}
