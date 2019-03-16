using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberpass
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("Number 1:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Number 2 (optional) :");
            string input2 = Console.ReadLine();
            num1 = Convert.ToInt32(input1);
            try {
                num2 = Convert.ToInt32(input2);
                numberpass.Mult(num1, num2);
            }
            catch (FormatException)
            {
                numberpass.Mult(num1);
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
