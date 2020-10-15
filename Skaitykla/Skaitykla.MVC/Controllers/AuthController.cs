using Microsoft.AspNetCore.Mvc;
using Skaitykla.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skaitykla.MVC.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.AuthError = "blogi prisijungimo duomenys";
                return View("~/Views/Auth/Index.cshtml");
            }

            if (model.Email == "test@admin" && model.Password == "Pass")
            {
                return RedirectToAction("Admin");
            }

            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }
    }
}
