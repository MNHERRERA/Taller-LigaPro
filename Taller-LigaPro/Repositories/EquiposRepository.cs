using Taller_LigaPro.Models;
using System.Linq;
using System;
using System.Collections.Generic;



namespace Taller_LigaPro.Repositories
{
    public class EquiposRepository
    {
        private static List<Equipo> equipos = new List<Equipo>
        {
            new Equipo { Id = 1, Nombre = "BSC", PartidosGanados = 3, PartidosEmpatados = 5, PartidosPerdidos = 3 },
            new Equipo { Id = 2, Nombre = "LDU", PartidosGanados = 3, PartidosEmpatados = 5, PartidosPerdidos = 3 },
            new Equipo { Id = 3, Nombre = "Emelec", PartidosGanados = 3, PartidosEmpatados = 5, PartidosPerdidos = 3 },
            new Equipo { Id = 4, Nombre = "Aucas", PartidosGanados = 3, PartidosEmpatados = 5, PartidosPerdidos = 3 }
        };
        public IEnumerable<Equipo> DevuleveListEquipos()
        {
            return equipos.OrderByDescending(x => x.TotalPuntos).ToList();
        }
        public Equipo DevuelveInformacionEquipo(int Id)
        {

            var equipos = DevuleveListEquipos();
            var equipo = equipos.First(item => item.Id == Id);
            return equipo;

        }

        public bool ActualziarEquipo(Equipo equipoActualizado)
        {
            // Buscar el equipo existente en la lista por Id
            var equipoExistente = equipos.FirstOrDefault(e => e.Id == equipoActualizado.Id);

            if (equipoExistente != null)
            {
                // Actualizar sus propiedades
                equipoExistente.Nombre = equipoActualizado.Nombre;
                equipoExistente.PartidosGanados = equipoActualizado.PartidosGanados;
                equipoExistente.PartidosEmpatados = equipoActualizado.PartidosEmpatados;
                equipoExistente.PartidosPerdidos = equipoActualizado.PartidosPerdidos;
           
                return true;
            }

            return false;
        }
    }
}
