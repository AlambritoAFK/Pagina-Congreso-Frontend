using Microsoft.AspNetCore.Mvc;

namespace PaginaCongreso.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View("Login");
        }
        public IActionResult Registro()
        {
            return View("Registro");
        }
        public IActionResult Autenticacion()
        {
            return View("Autenticacion");
        }
    }
}
