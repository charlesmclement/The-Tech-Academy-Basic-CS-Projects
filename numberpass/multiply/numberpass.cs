using System;

namespace numberpass
{
    class numberpass
    {

       public static void Mult(int num1,int num2)
            {

                Console.WriteLine("Number 1: " + num1 + " Number 2: " + num2);
                num1 = num1 * 10;
                Console.WriteLine("(number 1 was multiplied by 10: " + num1 + ")");
                Console.WriteLine("Writing number 2 to the screen: " + num2);
                Console.ReadLine();
            }

    }
}
