using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab_3.ViewModels;

namespace Lab_3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Life is good :)";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            var viewModel = new Address()
            {
                Name = "UTM",
                Street = "Studentilor",
                City = "Chisinau",
                PostalCode = "MD-0000"
            };
            return View(viewModel);//passing data to view
        }

        public IActionResult Support()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
