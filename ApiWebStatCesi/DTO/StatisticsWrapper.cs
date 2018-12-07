using System.ComponentModel.DataAnnotations;

namespace ApiWebStatCesi.DTO
{
    public class StatisticsWrapper
    {
        [Required]
        public int id { get; set; }
        public string description { get; set; }
        [Required]
        public double rate { get; set; }
        [Required]
        public int idAcademy { get; set; }
    }
}