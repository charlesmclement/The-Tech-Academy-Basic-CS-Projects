using System;


    class Program
    {
        static void Main()
        {
        Console.WriteLine("What is your age?");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("Have you ever had a DUI? Please answer true or false.");
        byte duiloop = 0;
        bool dui = false;
        while (duiloop == 0) {
            try
            {
                dui = bool.Parse(Console.ReadLine());
                duiloop = 1;
            }
            catch
            {
                Console.WriteLine("Please answer true or false.");
            }
        }
        Console.WriteLine("How many speeding tickets do you have?");
        byte tickets = byte.Parse(Console.ReadLine());
        Console.WriteLine("Qualified?");
        if (age >= 15 && dui == false && tickets < 3)
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

