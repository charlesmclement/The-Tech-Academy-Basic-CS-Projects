using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumdays
{
    class Program
    {
        enum Days { sunday, monday, tuesday, wednesday, thursday, friday, saturday };

        static void Main(string[] args)
        {
        dayInput:
            System.Console.WriteLine("input a day");
            string input = System.Console.ReadLine().ToLower();
            Days myDays = new Days();

            if (Enum.TryParse(input, out myDays))
            {
                switch (myDays)
                {
                    case Days.sunday:
                        Console.WriteLine("It is Sunday");
                        break;
                    case Days.monday:
                        Console.WriteLine("It is Monday");
                        break;
                    case Days.tuesday:
                        Console.WriteLine("It is Tuesday");
                        break;
                    case Days.wednesday:
                        Console.WriteLine("It is Wednesday");
                        break;
                    case Days.thursday:
                        Console.WriteLine("It is Thursday");
                        break;
                    case Days.friday:
                        Console.WriteLine("It is Friday");
                        break;
                    case Days.saturday:
                        Console.WriteLine("It is Saturday");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Enter an actual day");
                goto dayInput;
            }

            Console.ReadLine();
        }



    }
}

