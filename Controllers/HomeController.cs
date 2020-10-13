using Microsoft.AspNetCore.Mvc;


namespace FiestaInvitados.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
