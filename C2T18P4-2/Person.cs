using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2T18P4
{
    abstract class Person
    {
        //позволяющими вывести на экран информацию о персоне,
        //а также определить ее возраст (на момент текущей даты)
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Date { get; set; }
        public string Fuculty { get; set; }
        //метод вывода информации
        public Person() { }
        public Person(string name, string surname, DateTime date, string fuculty)
        {
            this.Name = name;
            this.Surname = surname;
            this.Date = date;
            this.Fuculty = fuculty;
        }

        public abstract void Output();

        public virtual void GetAge()
        {
            Console.WriteLine($"Возраст: {DateTime.Now.Year - Date.Year}\n");

        }
    }
}
