using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

using WebStatCesi.Src;

namespace WebStatCesi.Controllers
{
    [Internationalization]
    public class AcademyController : Controller
    {
        // GET: Academy
        public async Task<ActionResult> Index()
        {
            return View(await new AcademieUtility().GetAcademies());
        }

        [AllowJsonGet]
        public async Task<JsonResult> Json()
        {
            return Json(await new AcademieUtility().GetAcademies());
        }
    }
}