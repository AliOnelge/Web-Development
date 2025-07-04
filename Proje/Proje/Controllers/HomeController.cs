﻿using Microsoft.AspNetCore.Mvc;
using Proje.Models;
using System.Diagnostics;

namespace Proje.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Players()
        {
            return View();
        }
        public IActionResult Achievements()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}