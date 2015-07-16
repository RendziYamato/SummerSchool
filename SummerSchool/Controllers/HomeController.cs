using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SummerSchool.Models;

namespace SummerSchool.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

        [HttpGet]
        public ViewResult RSVPForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RSVPForm(GuestResponce guestResponce)
        {
            //TODO: Email responce to party organizer
            return View("Thanks", guestResponce);
        }
    }
}
