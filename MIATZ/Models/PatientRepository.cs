using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MIATZ.Models
{
    public class PatientRepository
    {

        public List<Patient> GetPatient(int snils)
        {
            List<Patient> patients = new List<Patient>();
            //string str = System.Configuration.ConfigurationManager.ConnectionStrings["myDataBase"].ConnectionString;
            string str = "заглушка";
            using (SqlConnection con = new SqlConnection(str))
            {
                SqlCommand com = new SqlCommand("SELECT *FROM Patient", con);
                con.Open();
                SqlDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    Patient p = new Patient();
                    p.Name = r["Name"].ToString();
                    p.Surname = r["Surname"].ToString();
                    p.Patronymic = r["Patronymic"].ToString();
                    p.Snils = (int)r["SNILS"];
                    p.DateOfBirthDay = (DateTime)r["DateOfBirth"];
                    p.Height = (int)r["Height"];
                    p.Weight = (int)r["Weight"];
                    patients.Add(p);
                }

            }
            ViewBag.item = guests;
            return View();
        }
    }
}
