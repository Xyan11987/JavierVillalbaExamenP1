using System.ComponentModel.DataAnnotations;

namespace ExamenProgreso1.Models
{
    public class JVillalba
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [Range(0.1,100000000)]
        public decimal Decimal { get; set; }

        [StringLength(50,MinimumLength =3)] 
        [Required]
        public string Palabra { get; set; }

        [Required]
        public bool Respuesta { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        public Celular celular { get; set; }
    }
}
