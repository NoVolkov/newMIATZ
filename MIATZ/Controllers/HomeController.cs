using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MIATZ.Models;
using System.Data.SqlClient;
using System.Data;

namespace MIATZ.Controllers
{
    public class HomeController : Controller
    {
        private PatientRepository PatientDb = new PatientRepository();
        private MeasurementRepository MeasurementDb = new MeasurementRepository();
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
            patient = PatientDb.GetPatient(snils);
            return View("Patient", patient);
        }
        public IActionResult Patient()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PatientMeasurement(int Id)
        {
            List<Measurement> measurements = new List<Measurement>();
            measurements = MeasurementDb.GetMeasurements(Id);
            return View("ViewPatientMeasurements", measurements);
        }
        [HttpPost]
        public IActionResult SetDescription(int Id, string description)
        {
            string str = Repository.connectionString;
            using (SqlConnection con = new SqlConnection(str))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Description (Patient_id, Date, Comment) VALUES(@patId, @Date, @Comment)", con);
                cmd.Parameters.Add("@patId", SqlDbType.NVarChar).Value = Id;
                cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@Comment", SqlDbType.NVarChar).Value = description;
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    View("Ошибка");
                }
            }
            return View("ViewPatientMeasurements");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
