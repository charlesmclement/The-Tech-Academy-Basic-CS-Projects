using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int i = int.Parse(Console.ReadLine());
            int addResults = calculator.Adding(i);
            int multResults = calculator.Multiplying(i);
            int subResults = calculator.Subtracting(i);
            Console.WriteLine(i + " + 50 = " + addResults);
            Console.WriteLine(i + " * 50 = " + multResults);
            Console.WriteLine(i + " - 50 = " + subResults);
            Console.ReadLine();
        }
    }
}
