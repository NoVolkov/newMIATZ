using System;
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
        //вызов главной страницы
        public IActionResult Index()
        {
            return View();
        }
        //метод по пост, открываем представление Patient, куда передаем пациентов
        [HttpPost]
        public IActionResult Index(string snils)
        {
            Patient patient = new Patient();
            patient = db.GetPatient(snils);
            return View("Patient", patient);
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
