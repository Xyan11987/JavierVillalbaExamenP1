using System.ComponentModel.DataAnnotations;

namespace ExamenProgreso1.Models
{
    public class JVillalba
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public decimal Decimal { get; set; }

        [Range(4, 10)] 
        [Required]
        public string Palabra { get; set; }

        [Required]
        public bool Respuesta { get; set; }

        [Required]
        public DateTime Fecha { get; set; }
    }
}
