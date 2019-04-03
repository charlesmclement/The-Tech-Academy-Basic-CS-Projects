using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace constvariable
{
    class Program
    {
        static void Main(string[] args)
        {
            var People = new List<Person>();
            string output = File.ReadAllText(@"title.txt");
            Console.WriteLine(output);
            creation:
            Console.Write("Create a person.\nEnter a name:");
            string username = Console.ReadLine();
            string userid = Guid.NewGuid().ToString();
            string guild = "";
            string quit = "no";

            Console.WriteLine("Would you like to be a medic or soldier? \n(type soldier or medic, optional)");
            guild = Console.ReadLine().ToLower();
            switch (guild)
            {
                case "medic":
                    Console.WriteLine("You chose Medic!\n");
                    userid = Guid.NewGuid().ToString();
                    Medic medic = new Medic(userid, username, Medic.Job);
                    People.Add(medic);
                    break;
                case "soldier":
                    Console.WriteLine("You chose Soldier!\n");
                    userid = Guid.NewGuid().ToString();
                    Soldier soldier = new Soldier(userid, username, Soldier.Job);
                    People.Add(soldier);
                    break;
                default:
                    Console.WriteLine("You're just an average person.\n");
                    userid = Guid.NewGuid().ToString();
                    Person person = new Person(userid, username, "none");
                    People.Add(person);
                    break;
            }
            foreach (Person person in People)
            {
                Console.WriteLine("{0}: {1}", person.Name, person.Id);
                person.Talk();
            }
            anotherOne:
            Console.WriteLine("\nMake another? y/n");
            quit = Console.ReadLine().ToLower();
            if (quit == "yes" || quit == "y")
            {
                goto creation;
            }
            else if (quit == "no" || quit == "n")
            {
                Environment.Exit(0);
            }
            else
            {
                goto anotherOne;
            }


            Console.ReadLine();
        }
    }
}
