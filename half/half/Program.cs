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
                int i = int.Parse(input);
                if (i % 2 == 1) {
                    decimal j = decimal.Parse(input);
                    half.Half(j, out j);
                }
                else {
                    half.Half(i, out i);
                }
                
                
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
