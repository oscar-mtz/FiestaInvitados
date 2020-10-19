using Microsoft.AspNetCore.Mvc;
using FiestaInvitados.Models;
using System.Linq;

namespace FiestaInvitados.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet] //método o accion predeterminado al navegar desde el navegador
        public ViewResult RsvpForm()
        {
            // Como la accion se llama RsvpForm, se buscará una vista con ese nombre
            return View();
        }

        [HttpPost] //método comun al hacer submit en las formas
        public ViewResult RsvpForm(InvitadosRespuesta respuesta)
        {
            if (ModelState.IsValid)
            {
                Repositorio.AddRespuesta(respuesta);
                return View("Gracias", respuesta);
            }
            else
                return View();
        }

        public ViewResult VerInvitados()
        {
            return View(Repositorio.Respuestas.Where(r => r.Asistira == true));
        }
    }
}
