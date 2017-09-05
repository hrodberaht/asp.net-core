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
        public string Users(string email)
        {
            
            return _userService.Get(email).Name;
            
        }
    }
}