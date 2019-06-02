using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicalLife.Models;

namespace MusicalLife.Controllers
{
    public class UsersController : Controller
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Users
        public IActionResult Login()
        {
            return View(new User());
        }

        private bool UserExists(string login, string password)
        {
            return _context.Users.Any(e => e.Login == login) && _context.Users.Any(e => e.Password == password);
        }

        public IActionResult GetUser(string login, string password)
        {
            User user = null;
            var userExist = UserExists(login, password);

            if (userExist)
            {
                user = _context.Users.First(usr => usr.Login == login && usr.Password == password);
                HttpHelper.HttpContext.Session.SetObjectAsJson("Role", user.Role);
                
            }

            if (user != null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View("Login");
        }

        public IActionResult Register()
        {
            return View("CreateUser");
        }

        public IActionResult CreateUser(string login, string password)
        {
            var newUser = new User();

            newUser.Role = Enums.UserRoles.User;
            newUser.Login = login;
            newUser.Password = password;

            _context.Users.Add(newUser);
            _context.SaveChanges();

            return View("Login");
        }
    }
}
