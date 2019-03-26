using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    class Program
    {
        static void Main()
        {
            Employee<string> Stringz = new Employee<string>();
            Employee<int> Intz = new Employee<int>();
            List<string> Strings = new List<string> { "1", "2", "3", "4", "5" };
            List<int> Ints = new List<int> { 1, 2, 3, 4, 5 };
            Stringz.Things = Strings;
            Intz.Things = Ints;

            foreach (int thing in Intz.Things)
            {
                Console.WriteLine(thing);
            }

            foreach (string thing in Stringz.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
