using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebStatCesi.Content;
using WebStatCesi.Models;
using WebStatCesi.Src;

namespace WebStatCesi.Controllers
{
    [Internationalization]
    public class StatisticsController : Controller
    {
        // GET: Statistics
        public async Task<ActionResult> Index() => View(await new StatsUtility().GetStatistiques());

        [AllowJsonGet]
        public async Task<ActionResult> Json() {
            return this.Json(await new StatsUtility().GetStatistiques());
        }

        [HttpPost]
        [ActionName("Save")]
        public JsonResult Save()
        {
            //var tets = "";
            return Json(new { result = true });
        }

        [HttpPost]
        public async Task<ActionResult> Delete()
        {
            return this.Json(await new StatsUtility().GetStatistiques());
        }

        public void PopulateStats(int nb)
        {
            for (int i = 0; i <= nb; i++)
            {
                var random = new Random();
                new StatsUtility().AddStatistique(new Statistics()
                {
                    rate = random.Next(0, 20),
                    description = StaticsData.statDescription[random.Next(0, StaticsData.statDescription.Length)],
                    IdAcademy = random.Next(1, 4)
                });
            }
        }
    }
}