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
            numTry:
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();
            try
            {
                decimal j = decimal.Parse(input);
                int i = int.Parse(input);
                if (i % 2 == 0)
                {
                    half.Half(i, out i);
                }
                else
                {
                    half.Half(j, out j);
                }
            }

            catch
            {
                goto numTry;
            }

            Console.ReadLine();
            
        }
    }
}
