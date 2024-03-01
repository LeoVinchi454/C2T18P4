using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2T18P4
{
    class Teacher : Person
    {
        public int Post { get; set; }
        public string Experience { get; set; }
        //Преподаватель (имя, фамилия, дата рождения, факультет, должность, стаж)
        public Teacher(string name, string surname, DateTime dateTime, string fuculty, int post, string experience)
        {
            this.Name = name;
            this.Surname = surname;
            this.DateTime = dateTime;
            this.Fuculty = fuculty;
            this.Post = post;
            this.Experience = experience;
        }
        public void TeacherOutput()
        {
            Console.WriteLine($"name {Name}\nsurname {Surname}\ndatetime {DateTime}\nfuculty {Fuculty}\n" +
                $"post {Post}\nexperience {Experience}");
        }
    }
}
