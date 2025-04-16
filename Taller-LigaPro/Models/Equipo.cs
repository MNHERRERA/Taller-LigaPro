using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Taller_LigaPro.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Ingrese el nombre")]
        public string Nombre { get; set; }
      
        [Range(0, 20)]
        public int PartidosGanados { get; set; }
        [Range(0, 20)]
        public int PartidosEmpatados { get; set; }
        [Range(0, 20)]
        public int PartidosPerdidos { get; set; }
        [Range(0, 20)]
        public int PartidosJugados => PartidosGanados + PartidosEmpatados + PartidosPerdidos; 
        public int TotalPuntos
        {
            get
            {
                return (PartidosGanados * 3) + (PartidosEmpatados * 1);
            }
        }
        public string LogoUrl { get; set; }

        internal object First(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
