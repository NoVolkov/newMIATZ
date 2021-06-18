using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIATZ.Models
{
    //измерения пациента
    public class Measurement
    {
        public int Id { get; set; }
        public int IdPatient { get; set; } //id клиента
        public DateTime Date { get; set; } //дата измерения давления
        public int TopPressure { get; set; } //верхнее давление
        public int BottomPressure { get; set; }//нижнее давление
    }
}
