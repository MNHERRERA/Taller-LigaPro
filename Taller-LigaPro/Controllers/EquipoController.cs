using System.Drawing.Text;
using Microsoft.AspNetCore.Mvc;
using Taller_LigaPro.Models;
using Taller_LigaPro.Repositories;

namespace Taller_LigaPro.Controllers
{
    public class EquipoController : Controller  
    {
        
        public IActionResult List()
        {
            EquiposRepository repository = new EquiposRepository();
            var equipos = repository.DevuleveListEquipos();          
            return View(equipos);
        }
        public IActionResult EditarEquipo()
        {
            Equipo bsc = new Equipo{ Id = 1 };  
            return View(bsc);   
        }
        
    }
}
