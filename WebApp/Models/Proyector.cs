using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace WebApp.Models
{
    public class Proyector
    {
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage ="Debe proporcionar un valor para el Marca")]
        [StringLength(24)]
        public string Marca { get; set; }

        [Required(ErrorMessage = "Debe proporcionar un valor para el Modelo")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Debe proporcionar un valor para el Numero de Serie")]
        public string NumeroDeSerie { get; set; }
        public SituacionProyector Situacion { get; set; } = SituacionProyector.Bueno;


        [DataType(DataType.Date)]
        public DateTime FechaDeAlta { get; set; } = DateTime.Now;
        
        [DataType(DataType.Date)]
        public DateTime? FechaDeBaja { get; set; }


    }

    public enum SituacionProyector 
    {
        Bueno=1,
        Regular,
        Malo
    }
}
