using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2T18P4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            while (true)
            {
                Console.Write("\nВведите название (а/с/у): ");
                string est = Console.ReadLine();
                switch (est)
                {
                    case "а":
                        list.Add(Enrollee.Input());
                        break;
                    case "с":
                        list.Add(Student.Input());
                        break;
                    case "у":
                        list.Add(Teacher.Input());
                        break;
                    default:return;
                }
                foreach (var i in list)
                {
                    i.Output();
                    i.GetAge();
                }
            }
        }
    }
}
