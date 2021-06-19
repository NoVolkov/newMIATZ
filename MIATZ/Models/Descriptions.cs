using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIATZ.Models
{ 
    //модель для комментариев
    public class Descriptions
    {
        public int Id { get; set; }
        public int IdPatient { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}
