using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace half
{
    class Program
    {
        static void Main(string[] args)
        {
            decTry:
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();

            try
            {
                decimal i = decimal.Parse(input);
                half.Half(i, out i);
            }
            catch
            {
                goto decTry;
            }
            Console.ReadLine();
            
        }
    }
}
