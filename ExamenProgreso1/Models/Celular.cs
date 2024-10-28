using System.ComponentModel.DataAnnotations;

namespace ExamenProgreso1.Models
{
    public class Celular
    {
        [Key]
        public int Id { get; set; }

        public string Modelo { get; set; }

        public int Año { get; set; }

        public float Precio { get; set; }
    }
}
id, modelo, año, precio