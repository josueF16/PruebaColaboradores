using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Salario
    {
        [Key]
        public int IdSalario { get; set; }
        public string Salario { get; set; }
        public bool FechaInicio { get; set; }

    }
}