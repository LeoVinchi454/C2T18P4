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
        public Enrollee(string name, string surname, DateTime date, string fuculty) : base(name, surname, date, fuculty)
        { }
        public override void Output()
        {
            Console.WriteLine($"\nИмя: {Name}\nФамилия: {Surname}\nДата рождения: {Date}\n" +
                $"Факультет: {Fuculty}");
        }
        public static Enrollee Input()
        {
            Console.WriteLine("\nАбитуриент\n");
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите дату рождения: ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Введите факультет: ");
            string fuculty = Console.ReadLine();
            return new Enrollee(name, surname, date, fuculty);
        }

    }
}
