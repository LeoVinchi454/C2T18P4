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
        public Student(string name, string surname, DateTime date, string fuculty,int course) : base(name, surname, date, fuculty)
        {
            this.Course = course;
        }
        public override void Output()
        {
            Console.WriteLine($"\nИмя: {Name}\nФамилия: {Surname}\nДата рождения: {Date}\n" +
                $"Факультет: {Fuculty}\nКурс: {Course}");
        }
        public static Student Input()
        {
            Console.WriteLine("\nСтудент\n");
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите дату рождения: ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Введите факультет: ");
            string fuculty = Console.ReadLine();
            Console.Write("Введите курс: ");
            int course = Convert.ToInt32(Console.ReadLine());

            return new Student(name, surname, date, fuculty,course);
        }
    }
}
