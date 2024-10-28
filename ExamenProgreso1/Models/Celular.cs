using System.ComponentModel.DataAnnotations;

namespace ExamenProgreso1.Models
{
    public class Celular
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Modelo { get; set; }

        [Required]
        [Range(2000,2100)]
        public int Año { get; set; }

        [DataType(DataType.Currency)]
        public float Precio { get; set; }

        public JVillalba JVillalba { get; set; }
    }
}
