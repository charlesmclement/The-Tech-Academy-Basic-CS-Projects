using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a number to multiply by 50");
        int Multiply = int.Parse(Console.ReadLine());
        Console.WriteLine(Multiply * 50);
        Console.WriteLine("Please enter a number to add 25");
        int Addition = int.Parse(Console.ReadLine());
        Console.WriteLine(Addition + 25);
        Console.WriteLine("Please enter a number divide by 12.5");
        int Division = int.Parse(Console.ReadLine());
        Console.WriteLine(Division / 12.5);
        Console.WriteLine("Please enter a number to check if it is greater than 50");
        int over50 = int.Parse(Console.ReadLine());
        if (over50 > 50)
        {
            Console.WriteLine("True.");
        }
        else
        {
            Console.WriteLine("False.");
        }
        Console.WriteLine("Please enter a number to divide by 7 and print the remainder.");
        int Remainder = int.Parse(Console.ReadLine());
        Console.WriteLine(Remainder % 7);
        Console.Read();
    }
}
