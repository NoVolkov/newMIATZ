using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MIATZ.Models
{
    //измерения пациента
    public class Measurement
    {
        public int Id { get; set; }
        public int IdPatient { get; set; } //id клиента
        [DisplayName("Дата")]
        public DateTime Date { get; set; } //дата измерения давления
        [DisplayName("Статус")]
        public string Status { get; set; }
        [DisplayName("Верхнее артериальное давление")]
        public int TopPressure { get; set; } //верхнее давление
        [DisplayName("Нижнее артериальное давление")]
        public int BottomPressure { get; set; }//нижнее давление
        [DisplayName("Пульс")]

        public int Pulse { get; set; }
    }
}
