using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MIATZ.Models
{
    public class PatientRepository
    {

        public Patient GetPatient(string snils)
        {
            Patient patient = new Patient();
            //string str = System.Configuration.ConfigurationManager.ConnectionStrings["myDataBase"].ConnectionString;
            //поменять имя пользователя, в дальнейшем перенесется в конфиг файла
            string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dim5d\source\repos\MIATZ\MIATZ\AppData\miazDB.mdf;Integrated Security=True;Connect Timeout=30";
            
            using (SqlConnection con = new SqlConnection(str))
            {
                SqlCommand com = new SqlCommand("SELECT *FROM Patient WHERE SNILS= "+snils, con);
                con.Open();
                SqlDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    Patient p = new Patient();
                    p.Id = (int)r["ID"];
                    p.Name = r["Name"].ToString();
                    p.Surname = r["Surname"].ToString();
                    p.Patronymic = r["Patronomic"].ToString();
                    p.Snils = r["SNILS"].ToString();
                    p.DateOfBirthDay = (DateTime)r["DateOfBirth"];
                    p.Height = (double)r["Height"];
                    p.Weight = (double)r["Weight"];
                    patient = p;
                }

            }
            return patient;
        }
    }
}
