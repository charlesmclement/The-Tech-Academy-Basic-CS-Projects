using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class Program
    {
        static void Main()
        {
            string[] Numbers = new string[] { "Zero", "One", "Two", "Three" };
            int[] Hundreds = new int[] { 0, 100, 200, 300 };
            int i = 0;
            List<string> Colors = new List<string>();
            Colors.Add("Green");
            Colors.Add("Red");
            Colors.Add("Yellow");
            Colors.Add("Blue");
            Console.WriteLine("Select an index from the string array:");
            try
            {
                i = int.Parse(Console.ReadLine());
                Console.WriteLine(Numbers[i]);
            }
            catch
            {
                Console.WriteLine("That index does not exist.");
            }

            Console.WriteLine("Select an index from the int array:");
            try
            {
                i = int.Parse(Console.ReadLine());
                Console.WriteLine(Hundreds[i]);
            }
            catch
            {
                Console.WriteLine("That index does not exist.");
            }

            Console.WriteLine("Select an index from the string list:");
            try
            {
                i = int.Parse(Console.ReadLine());
                Console.WriteLine(Colors[i]);
            }
            catch
            {
                Console.WriteLine("That index does not exist.");
            }
            
            Console.ReadLine();
        }
    }
}
