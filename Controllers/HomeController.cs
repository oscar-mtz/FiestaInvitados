using Microsoft.AspNetCore.Mvc;


namespace FiestaInvitados.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult RsvpForm() {
            // Como la accion se llama RsvpForm, se buscará una vista con ese nombre
            return View();
        }
    }
}
