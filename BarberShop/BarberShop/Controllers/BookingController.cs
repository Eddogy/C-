using BarberShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberShop.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            Barber Aurimas = new Barber() { Name = "Aurimas", Surname = "Bajo" };
            Barber Tomas = new Barber() { Name = "Tomas", Surname = "Sinickis" };

            List<Booking> bookings = new List<Booking>()
            {
                new Booking(){Barber = Aurimas, BookingStatus = BookingStatus.available, AvailableTime = DateTime.Now},
                new Booking(){Barber = Tomas, BookingStatus = BookingStatus.available, AvailableTime = DateTime.Now},
                new Booking(){Barber = Aurimas, BookingStatus = BookingStatus.available, AvailableTime = DateTime.Now.AddDays(-1)},
            };


            return View(bookings);
        }
    }
}
