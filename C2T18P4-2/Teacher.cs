using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2T18P4
{
    class Teacher : Person
    {
        public string Post { get; set; }
        public int Experience { get; set; }
        //Преподаватель (имя, фамилия, дата рождения, факультет, должность, стаж)
        public Teacher(string name, string surname, DateTime date, string fuculty, string post, int experience) : base(name, surname, date, fuculty)
        {
            this.Post = post;
            this.Experience = experience;
        }
        public override void Output()
        {
            Console.WriteLine($"\nИмя: {Name}\nФамилия: {Surname}\nДата рождения: {Date}\n" +
                $"Факультет: {Fuculty}\nДолжность: {Post}\nСтаж: {Experience}");
        }
        public static Teacher Input()
        {
            Console.WriteLine("\nУчитель\n");
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите дату рождения: ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Введите факультет: ");
            string fuculty = Console.ReadLine();
            Console.Write("Введите должность: ");
            string post = Console.ReadLine();
            Console.Write("Введите стаж: ");
            int experience = Convert.ToInt32(Console.ReadLine());
            return new Teacher(name, surname, date, fuculty, post, experience);
        }
    }
}
