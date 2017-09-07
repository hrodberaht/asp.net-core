using Microsoft.AspNetCore.Mvc;
using src.Models;

namespace src.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Users(string email)
        {
            ViewData["Name"] = _userService.Get(email).Name;
            return View();
        }
    }
}