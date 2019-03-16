using System;

namespace numberpass
{
    class numberpass
    {

       public static int Mult(int num1,int num2 = 0)
            {
            
                Console.WriteLine("Method 1:\n");
                Console.WriteLine("Number 1: " + num1 + " Number 2: " + num2);
                num1 = num1 * 10;
                Console.WriteLine("(number 1 was multiplied by 10: " + num1 + ")");
                num2 = num2 * 50;
                Console.WriteLine("(number 2 was multiplied by 50: " + num2 + ")");
                return (num1);
        }

        public static decimal Mult(decimal num1, decimal num2 = 0m)
        {

            Console.WriteLine("Method 2:\n");
            Console.WriteLine("Number 1: " + num1 + " Number 2: " + num2);
            num1 = num1 - 10;
            Console.WriteLine("(number 1 had 10 subtracted: " + num1 + ")");
            Console.WriteLine("Writing number 2 to the screen: " + num2 + "\n");
            return (num1);
        }
        public static decimal Mult(string num1, string num2 = "0")
        {
            loop:
            try
            {
                int number1 = int.Parse(num1);
                int number2 = int.Parse(num2);
                Console.WriteLine("Method 3:\n");
                Console.WriteLine("Number 1: " + number1 + " Number 2: " + number2);
                number1 = number1 / 2;
                Console.WriteLine("(Half of number 1 is: " + number1 + ")");
                Console.WriteLine("Writing number 2 to the screen: " + number2 + "\n");
                return (number1);
            }
            catch
            {
                Console.WriteLine("Enter a number:");
                goto loop;
            }
        }

    }
}
