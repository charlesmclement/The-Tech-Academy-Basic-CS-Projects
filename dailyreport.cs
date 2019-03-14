using System;


    class Program
    {
        static void Main()
        {
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");
        Console.WriteLine("");
        Console.WriteLine("What course are you on?");
        string currentCourse = Console.ReadLine();
        Console.WriteLine("What page number?");
        byte currentPage = byte.Parse(Console.ReadLine());
        Console.WriteLine("Do you need any help with anything? Please answer \"true\" or \"false.\"");
        bool needHelp = bool.Parse(Console.ReadLine());
        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        string Experience = Console.ReadLine();
        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        string Feedback = Console.ReadLine();
        Console.WriteLine("How many hours did you study today?");
        byte hoursWorked = byte.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        Console.Read();
        }
    }
