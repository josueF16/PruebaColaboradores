using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Seguro
    {
        [Key]
        public int IdSeguro { get; set; }
        public string Tipo { get; set; }
        public bool Importa { get; set; }
        public int FechaImporte { get; set; }

    }
}