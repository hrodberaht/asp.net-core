using Microsoft.AspNetCore.Mvc;

namespace src.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Users()
        {
            return View();
        }
    }
}