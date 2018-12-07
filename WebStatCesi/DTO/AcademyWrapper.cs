using System.ComponentModel.DataAnnotations;

namespace WebStatCesi.DTO
{
    public class AcademyWrapper
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string area { get; set; }
    }
}