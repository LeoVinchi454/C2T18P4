using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2T18P4
{
    //своими методами вывода информации на экран, и определения возраста.
    //Абитуриент (имя, фамилия, дата рождения, факультет)
    //Класс Абитуриент
    class Enrollee : Person
    {
        public Enrollee(string name, string surname, DateTime dateTime, string fuculty)
        {
            this.Name = name;
            this.Surname = surname;
            this.DateTime = dateTime;
            this.Fuculty = fuculty;
        }
    }
}
