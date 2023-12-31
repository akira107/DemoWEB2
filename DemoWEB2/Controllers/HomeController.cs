﻿using DemoWEB2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoWEB2.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult About()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PrintMessage()
        {
            ViewBag.Name= Request.Form["Name"].ToString();
            ViewBag.Sex = Request.Form["Sex"].ToString();
            ViewBag.Address = Request.Form["Address"].ToString();
            return View("About");
        }
    }
}