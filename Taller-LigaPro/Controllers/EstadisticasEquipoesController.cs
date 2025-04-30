using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DBSQLTaller_LigaPro.Data;
using Taller_LigaPro.Models;

namespace Taller_LigaPro.Controllers
{
    public class EstadisticasEquipoesController : Controller
    {
        private readonly Taller_LigaProContext _context;

        public EstadisticasEquipoesController(Taller_LigaProContext context)
        {
            _context = context;
        }

        // GET: EstadisticasEquipoes
        public async Task<IActionResult> Index()
        {
            var taller_LigaProContext = _context.EstadisticasEquipo.Include(e => e.Equipo);
            return View(await taller_LigaProContext.ToListAsync());
        }

        // GET: EstadisticasEquipoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadisticasEquipo = await _context.EstadisticasEquipo
                .Include(e => e.Equipo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estadisticasEquipo == null)
            {
                return NotFound();
            }

            return View(estadisticasEquipo);
        }

        // GET: EstadisticasEquipoes/Create
        public IActionResult Create()
        {
            ViewData["EquipoId"] = new SelectList(_context.Equipo, "Id", "Nombre");
            return View();
        }

        // POST: EstadisticasEquipoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EquipoId,PartidosJugados,PartidosGanados,PartidosEmpatados,PartidosPerdidos")] EstadisticasEquipo estadisticasEquipo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estadisticasEquipo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EquipoId"] = new SelectList(_context.Equipo, "Id", "Nombre", estadisticasEquipo.EquipoId);
            return View(estadisticasEquipo);
        }

        // GET: EstadisticasEquipoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadisticasEquipo = await _context.EstadisticasEquipo.FindAsync(id);
            if (estadisticasEquipo == null)
            {
                return NotFound();
            }
            ViewData["EquipoId"] = new SelectList(_context.Equipo, "Id", "Nombre", estadisticasEquipo.EquipoId);
            return View(estadisticasEquipo);
        }

        // POST: EstadisticasEquipoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EquipoId,PartidosJugados,PartidosGanados,PartidosEmpatados,PartidosPerdidos")] EstadisticasEquipo estadisticasEquipo)
        {
            if (id != estadisticasEquipo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estadisticasEquipo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstadisticasEquipoExists(estadisticasEquipo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["EquipoId"] = new SelectList(_context.Equipo, "Id", "Nombre", estadisticasEquipo.EquipoId);
            return View(estadisticasEquipo);
        }

        // GET: EstadisticasEquipoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadisticasEquipo = await _context.EstadisticasEquipo
                .Include(e => e.Equipo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estadisticasEquipo == null)
            {
                return NotFound();
            }

            return View(estadisticasEquipo);
        }

        // POST: EstadisticasEquipoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var estadisticasEquipo = await _context.EstadisticasEquipo.FindAsync(id);
            if (estadisticasEquipo != null)
            {
                _context.EstadisticasEquipo.Remove(estadisticasEquipo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstadisticasEquipoExists(int id)
        {
            return _context.EstadisticasEquipo.Any(e => e.Id == id);
        }
    }
}
