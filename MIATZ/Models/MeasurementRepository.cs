using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MIATZ.Models
{
    public class MeasurementRepository
    {
        public List<Measurement> GetMeasurements(int id)
        {
            List<Measurement> mes = new List<Measurement>();
            //string str = System.Configuration.ConfigurationManager.ConnectionStrings["myDataBase"].ConnectionString;
            string str = Repository.connectionString;
            using (SqlConnection con = new SqlConnection(str))
            {
                SqlCommand com = new SqlCommand("SELECT *FROM Measurement WHERE Patient_id= " + id, con);
                con.Open();
                SqlDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    Measurement p = new Measurement();
                    p.Id = (int)r["ID"];
                    p.IdPatient = (int)r["Patient_id"];
                    p.Date = (DateTime)r["Date"];
                    p.Status = r["Status"].ToString();
                    p.TopPressure = (int)r["TopPreassure"];
                    p.BottomPressure = (int)r["BottomPreassure"];
                    p.Pulse = (int)r["Pulse"];
                    mes.Add(p);
                }

            }
            return mes;
        }
    }
}
