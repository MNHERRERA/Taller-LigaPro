using System.Drawing.Text;
using Microsoft.AspNetCore.Mvc;
using Taller_LigaPro.Models;
using Taller_LigaPro.Repositories;

namespace Taller_LigaPro.Controllers
{
    public class EquipoController : Controller  
    {
        public EquiposRepository _repository;
        public EquipoController()
        {
            _repository = new EquiposRepository();
        }   

        public IActionResult List()
        {
            
            var equipos = _repository.DevuleveListEquipos();          
            return View(equipos);
        }
        public IActionResult EditarEquipo(int Id)
        {
            
            var equipos= _repository.DevuelveInformacionEquipo(Id); 
            return View(equipos);   
        }
        [HttpPost]
        public IActionResult EditarEquipo(Equipo equipo)
        {
            try
            {
                var actualziar = _repository.ActualziarEquipo(equipo);
                return View();
            }
            catch (Exception e)
            {
                throw;
            }
        }
        
    }
}
