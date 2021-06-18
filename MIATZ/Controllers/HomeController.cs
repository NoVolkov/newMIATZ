﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MIATZ.Models;

namespace MIATZ.Controllers
{
    public class HomeController : Controller
    {
        private PatientRepository db = new PatientRepository();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int snils)
        {

            return View();
        }
        public IActionResult Patient()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}