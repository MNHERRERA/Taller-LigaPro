using System.Drawing.Text;
using Microsoft.AspNetCore.Mvc;
using Taller_LigaPro.Models;

namespace Taller_LigaPro.Controllers
{
    public class EquipoController : Controller
    {
        
        public IActionResult List()
        {
            List<Equipo> equipos = new List<Equipo>();
           
            return View();
        }
    }
}
