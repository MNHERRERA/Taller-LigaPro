using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Taller_LigaPro.Models
{
    public class EstadisticasEquipo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int EquipoId { get; set; }
        public Equipo? Equipo { get; set; }

        [Range(0, int.MaxValue)]
        public int PartidosJugados { get; set; }

        [Range(0, int.MaxValue)]
        public int PartidosGanados { get; set; }

        [Range(0, int.MaxValue)]
        public int PartidosEmpatados { get; set; }

        [Range(0, int.MaxValue)]
        public int PartidosPerdidos { get; set; }

        [NotMapped]
        public int PuntosTotales
        {
            get
            {
                return (PartidosGanados * 3) + (PartidosEmpatados * 1);
            }
        }
    }

}
