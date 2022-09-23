using System;
using System.ComponentModel.DataAnnotations;

namespace ClienteWebOData.Models
{
    public class Ejercito
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public float FuerzaCombate { get; set; }
        [Required]
        public string Ubicacion { get; set; }
    }
}
