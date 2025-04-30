using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Taller_LigaPro.Models;

namespace DBSQLTaller_LigaPro.Data
{
    public class Taller_LigaProContext : DbContext
    {
        public Taller_LigaProContext (DbContextOptions<Taller_LigaProContext> options)
            : base(options)
        {
        }

        public DbSet<Taller_LigaPro.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<Taller_LigaPro.Models.Jugador> Jugador { get; set; } = default!;
        public DbSet<Taller_LigaPro.Models.EstadisticasEquipo> EstadisticasEquipo { get; set; } = default!;
    }
}
