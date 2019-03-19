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
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();
            try
            {
                decimal i = decimal.Parse(input);
                half.Half(i, out i);
            }
            catch
            {
                decimal i = decimal.Parse(input);
                half.Half(i, out i);
            }
            Console.ReadLine();
            
        }
    }
}
