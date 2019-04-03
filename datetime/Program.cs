using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It is now: " + DateTime.Now + "\nEnter a number: ");
            double input;
            input:
            try
            {
                input = double.Parse(Console.ReadLine());
                Console.WriteLine("It will be " + DateTime.Now.AddHours(input) + " {0} hours from now", input);
                Console.ReadLine();
            }
            catch
            {
                goto input;
            }
        }
    }
}
