using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OpenIdConnect;

using System.Web;
using System.Web.Mvc;

using WebStatCesi.Src;

namespace WebStatCesi.Controllers
{
    [Internationalization]
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        public ActionResult Index()
        {
            return View();
        }

        public void SignIn()
        {
            if (!Request.IsAuthenticated)
            {
                HttpContext.GetOwinContext().Authentication.Challenge(
                    new AuthenticationProperties { RedirectUri = "/" },
                    OpenIdConnectAuthenticationDefaults.AuthenticationType);
            }
        }
        public void SignOut()
        {
            HttpContext.GetOwinContext().Authentication.SignOut(
                    OpenIdConnectAuthenticationDefaults.AuthenticationType,
                    CookieAuthenticationDefaults.AuthenticationType);
        }
    }
}