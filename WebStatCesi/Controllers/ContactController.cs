using System.Web.Mvc;
using WebStatCesi.Src;

namespace WebStatCesi.Controllers
{
    [Internationalization]
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
    }
}