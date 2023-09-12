﻿using ForumDdd.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ForumDdd.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Recently()
        {
            return View("Recently");
        }

        public IActionResult Popular()
        {
            return View("Popular");
        }

        public IActionResult WithoutAnswer()
        {
            return View("WithoutAnswer");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}