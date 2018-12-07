using ApiWebStatCesi.Models;

using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace ApiWebStatCesi.Controllers
{
    [Authorize]
    public class AcademiesController : ApiController
    {
        private StatCesiEntities db = new StatCesiEntities();
        public AcademiesController()
        {
            db.Configuration.ProxyCreationEnabled = false;
        }
        // GET: api/Academies
        public IQueryable<Academy> GetAcademy()
        {
            return db.Academy;
        }

        // GET: api/Academies/5
        [ResponseType(typeof(Academy))]
        public async Task<IHttpActionResult> GetAcademy(int id)
        {
            Academy academy = await db.Academy.FindAsync(id);
            if (academy == null)
            {
                return NotFound();
            }

            return Ok(academy);
        }

        // PUT: api/Academies/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAcademy(int id, Academy academy)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != academy.Id)
            {
                return BadRequest();
            }

            db.Entry(academy).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AcademyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Academies
        [ResponseType(typeof(Academy))]
        public async Task<IHttpActionResult> PostAcademy(Academy academy)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Academy.Add(academy);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = academy.Id }, academy);
        }

        // DELETE: api/Academies/5
        [ResponseType(typeof(Academy))]
        public async Task<IHttpActionResult> DeleteAcademy(int id)
        {
            Academy academy = await db.Academy.FindAsync(id);
            if (academy == null)
            {
                return NotFound();
            }

            db.Academy.Remove(academy);
            await db.SaveChangesAsync();

            return Ok(academy);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AcademyExists(int id)
        {
            return db.Academy.Count(e => e.Id == id) > 0;
        }
    }
}