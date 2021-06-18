using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIATZ.Models
{
    public class Patient
    {
        //класс клиента
        public int Id { get; set; }
        public string Snils { get; set; } //снилс
        public string Name { get; set; } //имя
        public string Surname { get; set; } //фамилия
        public string Patronymic { get; set; } //отчество
        public DateTime DateOfBirthDay { get; set; } // возраст
        public double Height { get; set; }// рост
        public double Weight { get; set; }//вес

    }
}
