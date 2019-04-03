using System;
using System.IO;

namespace fileio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            File.WriteAllText(@"C:\logs\log.txt", input);
            string output = File.ReadAllText(@"C:\logs\log.txt");
            Console.WriteLine("You chose " + output);
            Console.ReadLine();

        }
    }
}
