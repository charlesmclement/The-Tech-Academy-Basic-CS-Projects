using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age
{
    class Program
    {
        static void Main(string[] args)
        {
            byte age = 0;
            age:
            Console.WriteLine("Enter your age:");
            try
            {
                age = byte.Parse(Console.ReadLine());
            }
            catch (OverflowException)
            {
                Console.WriteLine("Use whole numbers between 0 and 255");
                goto age;
            }
            catch (FormatException)
            {
                Console.WriteLine("Use whole numbers between 0 and 255");
                goto age;
            }
            catch
            {
                Console.WriteLine("Use whole numbers between 0 and 255");
                goto age;
            }
            int currentAge = Convert.ToInt32(age);
            int birthYear = (2019 - age);
            Console.Write("You were born in: ");
            Console.WriteLine(birthYear);
            Console.ReadLine();

        }
    }
}

