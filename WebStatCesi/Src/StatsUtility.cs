using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using WebStatCesi.DTO;
using WebStatCesi.Models;

namespace WebStatCesi.Src
{
    public class StatsUtility
    {
        StatCesiEntities _db;
        public StatsUtility()
        {
            this._db = new StatCesiEntities();
        }

        public async Task<List<StatisticsWrapper>> GetStatistiques()
        {
            return await _db.Statistics.Select(s=> new StatisticsWrapper()
            {
                id = s.Id,
                description = s.description,
                rate = s.rate,
                idAcademy = s.IdAcademy
            }).ToListAsync();
        }

        public void AddStatistique(Statistics stat)
        {
            _db.Statistics.Add(stat);
            _db.SaveChanges();
        }
    }
}