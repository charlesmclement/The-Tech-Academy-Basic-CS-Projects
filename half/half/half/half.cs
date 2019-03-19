using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace half
{
    class half
    {
        public static void Half(int input,out int number)
        {
            number = (input / 2);
            Console.WriteLine("Half of " + input + " is " + number);

        }

        public static void Half(decimal input, out decimal number)
        {
            number = (input / 2m);
            Console.WriteLine("Half of " + input + " is " + number);
        }

    }
}
