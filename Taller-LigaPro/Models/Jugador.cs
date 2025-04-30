using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Taller_LigaPro.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El número de camiseta es obligatorio")]
        [Range(1, 99, ErrorMessage = "Debe estar entre 1 y 99")]
        public int NumeroCamiseta { get; set; }

        [Range(0, int.MaxValue)]
        public int Goles { get; set; }

        [Range(0, int.MaxValue)]
        public int Asistencias { get; set; }

        [Range(0, double.MaxValue)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Sueldo { get; set; }

        // Relación con Equipo
        [Required]
        public int EquipoId { get; set; }

        public Equipo? Equipo { get; set; }
    }
}
