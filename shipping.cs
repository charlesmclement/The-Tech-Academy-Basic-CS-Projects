using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        Console.WriteLine("Enter your package's weight:");
        decimal pkgHeight = 0;
        decimal pkgWidth = 0;
        decimal pkgLength = 0;
        decimal pkgDimensions = 0;
        decimal quote = 0;
        decimal finalquote = 0m;
        decimal pkgWeight = decimal.Parse(Console.ReadLine());
        if (pkgWeight > 50)
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Enter your package's width:");
            pkgWidth = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter your package's height:");
            pkgHeight = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter your package's length:");
            pkgLength = decimal.Parse(Console.ReadLine());
            pkgDimensions = (pkgWidth + pkgHeight + pkgLength);
            if (pkgDimensions > 50) 
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Environment.Exit(0);
            }
            else
            {
                quote = pkgDimensions * pkgWeight / 100;
                Console.WriteLine("Final Quote:");
                Console.WriteLine("$" + quote);
                Console.ReadLine();

            }
        }
        }
    }

