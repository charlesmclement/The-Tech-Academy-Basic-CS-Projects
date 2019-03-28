using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> eList = new List<Employee>();
            eList.Add(new Employee { Id = 0, Fname = "Paul", Lname = "Denino" });
            eList.Add(new Employee { Id = 1, Fname = "Brent", Lname = "Kaskel" });
            eList.Add(new Employee { Id = 2, Fname = "Brandon", Lname = "Grosso" });
            eList.Add(new Employee { Id = 3, Fname = "Conrad", Lname = "Mason" });
            eList.Add(new Employee { Id = 4, Fname = "Gul", Lname = "Darhe'el" });
            eList.Add(new Employee { Id = 5, Fname = "Joe", Lname = "Blow" });
            eList.Add(new Employee { Id = 6, Fname = "Joe", Lname = "Bro" });
            eList.Add(new Employee { Id = 7, Fname = "Jorge", Lname = "Morte" });
            eList.Add(new Employee { Id = 8, Fname = "El", Lname = "Luchador" });
            eList.Add(new Employee { Id = 9, Fname = "Carlos", Lname = "Clemente" });

            Console.WriteLine("Joes list, foreach:");
            List<Employee> joesFE = new List<Employee>();
            foreach (Employee e in eList)
            {
                if (e.Fname == "Joe")
                {
                    Console.WriteLine(e.Id + " " + e.Fname + " " + e.Lname);
                    joesFE.Add(e);
                }
            }

            Console.WriteLine("\nJoes list, lamda:");
            List<Employee> joesLamda = eList.Where(x => x.Fname == "Joe").ToList();
            foreach (Employee e in joesLamda) { Console.WriteLine(e.Id + " " + e.Fname + " " + e.Lname); }

            Console.WriteLine("\nEmployees with an Id greater than 5:");
            List<Employee> list5 = eList.Where(x => x.Id >= 5).ToList();
            foreach (Employee e in list5) { Console.WriteLine(e.Id + " " + e.Fname + " " + e.Lname); }

            Console.ReadLine();
        }
    }
}
