using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myWebCore2.Models;

namespace myWebCore2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About(string vardas)
        {
            var sarasas = new List<Person>
            {
                new Person() { Vardas="tomas", Pavarde="trinkus"},
                new Person() { Vardas="Mantas", Pavarde="Jonaitis"},
                new Person() { Vardas="Jurgis", Pavarde="zigas"},
                new Person() { Vardas="Dominykas", Pavarde="Rentelis"},
                new Person() { Vardas="Dominykas", Pavarde="Rentelis"},
                new Person() { Vardas="Dominykas", Pavarde="Rentelis"},
            };

            return View(sarasas.Where(x=>x.Vardas == vardas).ToList());
        }

       

        
    }
}
