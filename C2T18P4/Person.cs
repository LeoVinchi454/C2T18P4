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
        public DateTime DateTime { get; set; }
        public string Fuculty { get; set; }
        //метод вывода информации
       
        public void Output()
        {
            Console.WriteLine($"name{Name}\nsurname{Surname}\ndata{DateTime}\n{Fuculty}");
        }
    }
}
