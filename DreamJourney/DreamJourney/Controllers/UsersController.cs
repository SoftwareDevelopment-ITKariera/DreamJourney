using DreamJourney.Data.Models;
using DreamJourney.Services.Contracts;
using DreamJourney.ViewModels.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DreamJourney.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersService userService;

        public UsersController(IUsersService userService)
        {
            this.userService = userService;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            User loggedUser = userService.GetByUsernameAndPassword(model.Username, model.Password);
            if (loggedUser == null)
            {
                ModelState.AddModelError("login error", "Wrong Username or Password");
                return View(model);
            }
            HttpContext.Session.SetInt32("loggedUserId", loggedUser.Id);
            AuthUser.LoggedUser = loggedUser;
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            User user = new User
            {
                Username = model.Username,
                Password = model.Password,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Role = model.Role,
                ImageUrl = model.ImageUrl

            };
            if (userService.GetByUsername(user.Username) != null)
            {
                ModelState.AddModelError("User error", "This username is taken");
                return View(model);
            }
            userService.Insert(user);
            return RedirectToAction("Login");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            AuthUser.LoggedUser = null;
            return RedirectToAction("Login");
        }
    }
}
