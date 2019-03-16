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
            intTry:
            string input = Console.ReadLine();
            Console.WriteLine("Enter a number:");
            try
            {
                int i = int.Parse(input);
                half.Half(i, out i);
            }
            catch
            {
                goto decTry;
            }
            decTry:
            try
            {
                decimal i = decimal.Parse(Console.ReadLine());
                half.Half(i, out i);
            }
            catch (FormatException)
            {
                goto intTry;
            }
            finally {
                Console.ReadLine();
            }
        }
    }
}
