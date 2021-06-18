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
        public int Snils { get; set; } //снилс
        public string Name { get; set; } //имя
        public string Surname { get; set; } //фамилия
        public string Patronymic { get; set; } //отчество
        public DateTime DateOfBirthDay { get; set; } // возраст
        public int Height { get; set; }// рост
        public int Weight { get; set; }//вес

    }
}
