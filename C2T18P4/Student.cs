using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2T18P4
{
    class Student : Person
    {
        //Студент (имя, фамилия, дата рождения, факультет, курс)

        public int Course { get; set; }
        public Student(string name, string surname, DateTime dateTime, string fuculty,int course)
        {
            this.Name = name;
            this.Surname = surname;
            this.DateTime = dateTime;
            this.Fuculty = fuculty;
            this.Course = course;
        }
        public void StudentOutput()
        {
            Console.WriteLine($"name {Name}\nsurname {Surname}\ndatetime {DateTime}\nfuculty {Fuculty}\ncourse {Course}");
        }
    }
}
