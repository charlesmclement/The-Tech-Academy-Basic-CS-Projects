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
            Console.WriteLine("Create a person.\nEnter a name:");
            string username = Console.ReadLine();
            string userid = Guid.NewGuid().ToString();
            string guild = "";
            string quit = "no";
            while (quit == "no")
            {
                Console.WriteLine("Would you like to be a medic or soldier? \n(type soldier or medic, optional)");
                guild = Console.ReadLine().ToLower();
                switch (guild)
                {
                    case "medic":
                        Console.WriteLine("You chose Medic!\n");
                        userid = Guid.NewGuid().ToString();
                        Medic medic = new Medic(userid, username, Medic.MJob);
                        People.Add(medic);
                        break;
                    case "soldier":
                        Console.WriteLine("You chose Soldier!\n");
                        userid = Guid.NewGuid().ToString();
                        Soldier soldier = new Soldier(userid, username, Soldier.SJob);
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
                    Console.WriteLine("{0}: {1}", person.Id, person.Name);
                    person.Talk();
                }
                Console.WriteLine("\nMake another?");
                quit = Console.ReadLine();
                if (quit == "yes" || quit == "y")
                {
                    goto creation;
                }
                else
                {
                    Environment.Exit(0);
                }
            }

            Console.ReadLine();
        }
    }
}
