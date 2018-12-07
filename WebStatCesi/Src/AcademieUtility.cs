using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using WebStatCesi.DTO;
using WebStatCesi.Models;

namespace WebStatCesi.Src
{
    public class AcademieUtility
    {
        StatCesiEntities _db;
        public AcademieUtility()
        {
            this._db = new StatCesiEntities();
        }

        public async Task<List<AcademyWrapper>> GetAcademies()
        {
            return await _db.Academy.Select(a => new AcademyWrapper()
            {
                id = a.Id,
                name = a.nom,
                area = a.area
            })
            .ToListAsync();
        }

        public void AddStatistique(Academy academy)
        {
            _db.Academy.Add(academy);
            _db.SaveChanges();
        }
    }
}