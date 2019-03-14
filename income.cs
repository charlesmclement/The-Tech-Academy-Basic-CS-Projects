using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("Anonymous Income Comparison Program");
        Console.WriteLine("Person 1");
        Console.WriteLine("Hourly Rate?");
        decimal hourlyRate1 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Hours worked per week?");
        decimal hoursWorked1 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Person 2");
        Console.WriteLine("Hourly Rate?");
        decimal hourlyRate2 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Hours worked per week?");
        decimal hoursWorked2 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Does Person 1 make more money than Person 2?");
        decimal total1 = (hourlyRate1 * hoursWorked1);
        decimal total2 = (hourlyRate2 * hoursWorked2);
        if (total1 > total2)
        {
            Console.WriteLine("True.");
        }
        else
        {
            Console.WriteLine("False.");
        }
        Console.ReadLine();

    }
    }

