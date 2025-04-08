using System.ComponentModel.DataAnnotations;

namespace Taller_LigaPro.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }
        [Range(0,20)]
        public int PartidosJugados { get; set; }
        [Range(0, 20)]
        public int PartidosGanadados { get; set; }
        [Range(0, 20)]
        public int PartidosEmpatados { get; set; }
        [Range(0, 20)]
        public int PartidosPerdidos { get; set; }
        public int TotalPuntos { get; set;}

    }
}
