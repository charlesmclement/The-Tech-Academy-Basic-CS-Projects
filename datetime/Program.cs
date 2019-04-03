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
            double input;
            DateTime Now = DateTime.Now;
            input:
            Console.WriteLine("It is now: {0} \nEnter a number: ", Now);
            try
            {
                input = double.Parse(Console.ReadLine());
                Console.WriteLine("It will be {0} in {1} hours.", Now.AddHours(input), input);
                Console.ReadLine();
            }
            catch { goto input; }
        }
    }
}
